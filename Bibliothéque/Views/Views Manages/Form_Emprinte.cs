using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothéque.Data_Modal;
namespace Bibliothéque.Views.Views_Manages
{
    public partial class Form_Emprinte : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceAll;
        BindingSource bindingSourceEmp;
        Stagiaire STG;
        Livre LVR;
        Reserve RSV;
        Emprinte EMP;
        public Form_Emprinte(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }
        // update all
        private void UpdateDataGridReserves()
        {
            bindingSourceAll.DataSource = this.Bib.Reserves.Select(i => new { i.Id,i.Stagiaire.Nom,i.Stagiaire.Prenom,i.Stagiaire.Email,i.Date_Reserve,i.Livre.Ispan,i.Etat}).ToList();
            bindingNVGL.BindingSource = bindingSourceAll;
            dtgvreserves.DataSource = bindingSourceAll;
            this.dtgvreserves.Columns[0].Visible = false;
            this.dtgvreserves.Columns[4].HeaderText = "Date Reserve";
            if (dtgvreserves.Rows.Count > 0)
            {
                this.dtgvreserves.Rows[0].Selected = true;
            }
        }
        // update valdet
        private void UpdateDataGridReservesValidate()
        {
            bindingSourceAll.DataSource = this.Bib.Reserves.Select(i => new { i.Id, i.Stagiaire.Nom, i.Stagiaire.Prenom, i.Stagiaire.Email, i.Date_Reserve, i.Livre.Ispan, i.Etat }).Where(j =>j.Etat == "Validate").ToList();
            bindingNVGL.BindingSource = bindingSourceAll;
            dtgvreserves.DataSource = bindingSourceAll;
            this.dtgvreserves.Columns[0].Visible = false;
            this.dtgvreserves.Columns[4].HeaderText = "Date Reserve";
            if (dtgvreserves.Rows.Count > 0)
            {
                this.dtgvreserves.Rows[0].Selected = true;
            }
        }
        // update not rexserv
        private void UpdateDataGridReservesNotValidate()
        {
            bindingSourceAll.DataSource = this.Bib.Reserves.Select(i => new { i.Id, i.Stagiaire.Nom, i.Stagiaire.Prenom, i.Stagiaire.Email, i.Date_Reserve, i.Livre.Ispan, i.Etat }).Where(j => j.Etat == "Not Validate").ToList();
            bindingNVGL.BindingSource = bindingSourceAll;
            dtgvreserves.DataSource = bindingSourceAll;
            this.dtgvreserves.Columns[0].Visible = false;
            this.dtgvreserves.Columns[4].HeaderText = "Date Reserve";
            if (dtgvreserves.Rows.Count > 0)
            {
                this.dtgvreserves.Rows[0].Selected = true;
            }
        }
        string slc = "";
        private void cmnchoiser_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                slc = cmnchoiser.selectedValue;
                switch (slc)
                {
                    case "All Reserved":
                        UpdateDataGridReserves();
                        panmain.Visible = true;
                        txtsearch.Visible = true;
                        break;
                    case "Reserved Validate":
                        UpdateDataGridReservesValidate();
                        panmain.Visible = true;
                        txtsearch.Visible = true;
                        break;
                    case "Reserved Not Validate":
                        UpdateDataGridReservesNotValidate();
                        panmain.Visible = true;
                        txtsearch.Visible = true;
                        break;
                }
            }
            catch 
            {
            }
        }

        private void Form_Emprinte_Load(object sender, EventArgs e)
        {
            bindingSourceAll = new BindingSource();
            bindingSourceEmp = new BindingSource();
        }

        private void dtgvreserves_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idrsv = int.Parse(dtgvreserves.Rows[bindingSourceAll.Position].Cells[0].Value.ToString());
                RSV = this.Bib.Reserves.Find(idrsv);
                STG = this.Bib.Stagiaires.Find(RSV.Id_STG);
                LVR = this.Bib.Livres.Find(RSV.Id_LVR);
                if (RSV.Etat == "Not Validate")
                {
                    btnvld.Visible = true;
                    pnldays.Visible = false;
                }
                else
                {
                    btnvld.Visible = false;
                    pnldays.Visible = false;
                }
            }
            catch 
            {

            }
        }

        private void detailsLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (dtgvreserves.Rows.Count > 0 || dtgvEmp.Rows.Count > 0)
            {
                try
                {
                    new Form_Details_Book(this.LVR, this.Bib).ShowDialog();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to delete Reserve ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvreserves.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Reserves.Remove(RSV);
                        this.Bib.SaveChanges();
                        this.cmnchoiser_onItemSelected(sender,e);
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Validate Reserve ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvreserves.Rows.Count > 0)
                {
                    try
                    {
                        Emprinte EMP = new Emprinte();
                        EMP.Id_RSV = RSV.Id;
                        EMP.Nbr_Days = int.Parse(nbrdays.Value.ToString());
                        EMP.Date_Emprinte = DateTime.Now;
                        this.Bib.Emprintes.Add(EMP);
                        this.RSV.Etat = "Validate";
                        this.Bib.SaveChanges();
                        this.cmnchoiser_onItemSelected(sender,e);
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnvld_Click(object sender, EventArgs e)
        {
            if (dtgvreserves.Rows.Count > 0)
            {
                try
                {
                    pnldays.Visible = true;
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // serce
        private void SearchRSV()
        {
            if (txtsearch.text!= "")
            {
                try
                {                                                           // i.Id, i.Stagiaire.Nom, i.Stagiaire.Prenom, i.Stagiaire.Email, i.Date_Reserve, i.Livre.Ispan, i.Etat
                    this.bindingSourceAll.DataSource = this.Bib.Reserves.Where(i => i.Stagiaire.Nom.Contains(txtsearch.text.ToUpper()) || i.Stagiaire.Prenom.Contains(txtsearch.text.ToUpper()) || i.Stagiaire.Email.Contains(txtsearch.text) || i.Etat.Contains(txtsearch.text) || i.Livre.Ispan.Contains(txtsearch.text) || (i.Date_Reserve).ToString().Contains(txtsearch.text)).Select(i => new { i.Id, i.Stagiaire.Nom, i.Stagiaire.Prenom, i.Stagiaire.Email, i.Date_Reserve, i.Livre.Ispan, i.Etat }).ToList();
                    this.dtgvreserves.DataSource = bindingSourceAll;
                    this.bindingNVGL.BindingSource = bindingSourceAll;
                    dtgvreserves.Columns[0].Visible = false;
                    this.dtgvreserves.Columns[4].HeaderText = "Date Reserve";
                    if (dtgvreserves.Rows.Count > 0)
                    {                  
                        dtgvreserves.Rows[0].Selected = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
            if (txtsearch.text != "")
            {
                SearchRSV();
            }
            else
            {
                this.cmnchoiser_onItemSelected(sender,e);
            }
                
        }

        private void detailsStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvreserves.Rows.Count > 0 || dtgvEmp.Rows.Count > 0)
            {
                try
                {
                    new Form__Details_stagiaire(this.Bib,this.STG).ShowDialog();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        ///Emprint

        private void UpdateDataGridEmp()
        {
            bindingSourceEmp.DataSource = this.Bib.Emprintes.Select(i => new { i.Id, i.Reserve.Stagiaire.Nom, i.Reserve.Stagiaire.Prenom, i.Reserve.Stagiaire.Email, i.Reserve.Livre.Ispan,i.Nbr_Days,i.Date_Emprinte, i.Date_Retourne }).ToList();
            bindingNVGEmp.BindingSource = bindingSourceEmp;
            dtgvEmp.DataSource = bindingSourceEmp;
            this.dtgvEmp.Columns[0].Visible = false;
            this.dtgvEmp.Columns[5].HeaderText = "Number Dayes";
            this.dtgvEmp.Columns[6].HeaderText = "Date Emprint";
            this.dtgvEmp.Columns[7].HeaderText = "Date Retourne";
            if (dtgvEmp.Rows.Count > 0)
            {
                this.dtgvEmp.Rows[0].Selected = true;
            }
        }
        private void UpdateDataGridEmpRtn()
        {
            bindingSourceEmp.DataSource = this.Bib.Emprintes.Select(i => new { i.Id, i.Reserve.Stagiaire.Nom, i.Reserve.Stagiaire.Prenom, i.Reserve.Stagiaire.Email, i.Reserve.Livre.Ispan, i.Nbr_Days, i.Date_Emprinte, i.Date_Retourne }).Where(j => j.Date_Retourne != null).ToList();
            bindingNVGEmp.BindingSource = bindingSourceEmp;
            dtgvEmp.DataSource = bindingSourceEmp;
            this.dtgvEmp.Columns[0].Visible = false;
            this.dtgvEmp.Columns[5].HeaderText = "Number Dayes";
            this.dtgvEmp.Columns[6].HeaderText = "Date Emprint";
            this.dtgvEmp.Columns[7].HeaderText = "Date Retourne";
            if (dtgvEmp.Rows.Count > 0)
            {
                this.dtgvEmp.Rows[0].Selected = true;
            }
        }
        private void UpdateDataGridEmpNotRtn()
        {
            bindingSourceEmp.DataSource = this.Bib.Emprintes.Select(i => new { i.Id, i.Reserve.Stagiaire.Nom, i.Reserve.Stagiaire.Prenom, i.Reserve.Stagiaire.Email, i.Reserve.Livre.Ispan, i.Nbr_Days, i.Date_Emprinte, i.Date_Retourne }).Where(j => j.Date_Retourne == null).ToList();
            bindingNVGEmp.BindingSource = bindingSourceEmp;
            dtgvEmp.DataSource = bindingSourceEmp;
            this.dtgvEmp.Columns[0].Visible = false;
            this.dtgvEmp.Columns[5].HeaderText = "Number Dayes";
            this.dtgvEmp.Columns[6].HeaderText = "Date Emprint";
            this.dtgvEmp.Columns[7].HeaderText = "Date Retourne";
            if (dtgvEmp.Rows.Count > 0)
            {
                this.dtgvEmp.Rows[0].Selected = true;
            }
        }
        string slcm = "";
        private void cmbEMP_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                slcm = cmbEMP.selectedValue;
                switch (slcm)
                {
                    case "All Emprinte":
                        UpdateDataGridEmp();
                        pnl2.Visible = true;
                        txtsearchEmp.Visible = true;
                        break;
                    case "Emprinte Retourne":
                        UpdateDataGridEmpRtn();
                        pnl2.Visible = true;
                        txtsearchEmp.Visible = true;
                        break;
                    case "Emprinte Not Return":
                        UpdateDataGridEmpNotRtn();
                        pnl2.Visible = true;
                        txtsearchEmp.Visible = true;
                        break;
                }
            }
            catch 
            {
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (dtgvEmp.Rows.Count > 0)
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure to return Book ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        this.EMP.Date_Retourne = DateTime.Now;
                        this.Bib.SaveChanges();
                        this.cmbEMP_onItemSelected(sender, e);
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //search
        private void SearchEMP()
        {
            if (txtsearchEmp.text != "")
            {
                try
                {                                                           // i.Id, i.Stagiaire.Nom, i.Stagiaire.Prenom, i.Stagiaire.Email, i.Date_Reserve, i.Livre.Ispan, i.Etat
                    this.bindingSourceEmp.DataSource = this.Bib.Emprintes.Where(i => i.Reserve.Stagiaire.Nom.Contains(txtsearchEmp.text.ToUpper()) || i.Reserve.Stagiaire.Prenom.Contains(txtsearchEmp.text.ToUpper()) || i.Reserve.Stagiaire.Email.Contains(txtsearchEmp.text) || i.Reserve.Livre.Ispan.Contains(txtsearchEmp.text) || i.Date_Emprinte.ToString().Contains(txtsearchEmp.text) || i.Date_Retourne.ToString().Contains(txtsearchEmp.text)).Select(i => new { i.Id, i.Reserve.Stagiaire.Nom, i.Reserve.Stagiaire.Prenom, i.Reserve.Stagiaire.Email, i.Reserve.Livre.Ispan, i.Nbr_Days, i.Date_Emprinte, i.Date_Retourne }).ToList();
                    this.dtgvEmp.DataSource = bindingSourceEmp;
                    this.bindingNVGEmp.BindingSource = bindingSourceEmp;
                    this.dtgvEmp.Columns[0].Visible = false;
                    this.dtgvEmp.Columns[5].HeaderText = "Number Dayes";
                    this.dtgvEmp.Columns[6].HeaderText = "Date Emprint";
                    this.dtgvEmp.Columns[7].HeaderText = "Date Retourne";
                    if (dtgvEmp.Rows.Count > 0)
                    {
                        this.dtgvEmp.Rows[0].Selected = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtsearchEmp_OnTextChange(object sender, EventArgs e)
        {
            if (txtsearchEmp.text != "")
            {
                SearchEMP();
            }
            else
            {
                this.cmbEMP_onItemSelected(sender,e);
            }
        }

        private void dtgvEmp_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idemp = int.Parse(dtgvEmp.Rows[bindingSourceEmp.Position].Cells[0].Value.ToString());
                EMP = this.Bib.Emprintes.Find(idemp);
                STG = this.Bib.Stagiaires.Find(EMP.Reserve.Stagiaire.Id);
                LVR = this.Bib.Livres.Find(EMP.Reserve.Livre.Id);
                if (EMP.Date_Retourne == null)
                {
                    btnreturn.Visible = true;
                }
                else
                {
                    btnreturn.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (dtgvreserves.Rows.Count > 0)
            {
                try
                {
                    
                    switch (slc)
                    {
                        case "All Reserved":
                            new Crystal.Form_Crystal1("select * from List_All_Reserves", "RSV").ShowDialog();
                            break;
                        case "Reserved Validate":
                            new Crystal.Form_Crystal1("select * from List_All_Reserves where List_All_Reserves.Etat like 'Validate'", "RSV").ShowDialog();
                            break;
                        case "Reserved Not Validate":
                            new Crystal.Form_Crystal1("select * from List_All_Reserves where List_All_Reserves.Etat like 'Not Validate'", "RSV").ShowDialog();
                            break;
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (dtgvEmp.Rows.Count > 0)
            {
                try
                {

                    switch (slcm)
                    {
                        case "All Emprinte":
                            new Crystal.Form_Crystal1("select * from List_All_Emprint", "EMP").ShowDialog();
                            break;
                        case "Emprinte Retourne":
                            new Crystal.Form_Crystal1("select * from List_All_Emprint where List_All_Emprint.Date_Retourne is not null", "EMP").ShowDialog();
                            break;
                        case "Emprinte Not Return":
                            new Crystal.Form_Crystal1("select * from List_All_Emprint where List_All_Emprint.Date_Retourne is null", "EMP").ShowDialog();
                            break;
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
