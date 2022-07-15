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
    public partial class Form_Ouvrages : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceouvrages;
        Thème THM;
        Secteur SCT;
        Ouvrage OVG;
        public Form_Ouvrages(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (THM != null && SCT != null && cmbsecteurs.Enabled && cmbthemes.Enabled)
            {
                pnladdorupdate.Visible = true;
                dtgvouvrages.Width = 770;
                dtgvouvrages.ColumnHeadersHeight = 30;
            }
            else
            {
                MessageBox.Show("Please select Thème and Secteure", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dtgvouvrages.Rows.Count > 0)
            {
                try
                {
                    pnladdorupdate.Visible = true;
                    dtgvouvrages.Width = 770;
                    dtgvouvrages.ColumnHeadersHeight = 30;
                    btnaddovg.ButtonText = "Update Ouvrage";

                    txttiter.Text = OVG.Titre;
                    txtlieu.Text = OVG.Lieu;
                    txtauteur.Text = OVG.Auteur;
                    txtediteur.Text = OVG.Editor;
                    txtprix.Text = OVG.Prix.ToString();

                    
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to delete Ouvrage ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvouvrages.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Ouvrages.Remove(OVG);
                        this.Bib.SaveChanges();
                        UpdateDataGridOuvrage();
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

        private void Form_Ouvrages_Load(object sender, EventArgs e)
        {
            bindingSourceouvrages = new BindingSource();
            UpdateDataGridOuvrage();
            try
            {
                //SCTR
                cmbsecteurs.DataSource = this.Bib.Secteurs.Select(i => new { i.Id, i.Nom }).ToList();
                cmbsecteurs.DisplayMember = "Nom";
                cmbsecteurs.ValueMember = "Id";

                //THM
                cmbthemes.DataSource = this.Bib.Thème.Select(i => new { i.Id, i.Nom }).ToList();
                cmbthemes.DisplayMember = "Nom";
                cmbthemes.ValueMember = "Id";
                //UpdateDataGridOuvrage();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClearBox()
        {
            txttiter.Text = "";
            txtediteur.Text = "";
            txtauteur.Text = "";
            txtlieu.Clear();
            txtprix.Text = "";
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearBox();
            pnladdorupdate.Visible = false;
            dtgvouvrages.Width = 1105;
            dtgvouvrages.ColumnHeadersHeight = 30;
            btnaddovg.ButtonText = "Add Ouvrage";
        }

        //update
        private void UpdateDataGridOuvrage()
        {
            bindingSourceouvrages.DataSource = null;
            dtgvouvrages.DataSource = null;
            this.bindingSourceouvrages.DataSource = this.Bib.Ouvrages.Select(i => new { i.Id, i.Titre, i.Auteur, i.Editor, i.Prix, i.Lieu, Secteur = i.Secteur.Nom, Thème = i.Thème.Nom }).ToList();
            this.bindingNVGOuvrage.BindingSource = bindingSourceouvrages;
            this.dtgvouvrages.DataSource = bindingSourceouvrages;
            this.dtgvouvrages.Columns[0].Visible = false;
            if (dtgvouvrages.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtgvouvrages.Rows)
                {
                    item.Selected = false;
                }
                this.dtgvouvrages.Rows[0].Selected = true;
            }
        }
        //sort
        private void SorteOVG()
        {
            try
            {
                bindingSourceouvrages.DataSource = null;
                dtgvouvrages.DataSource = null;
                this.bindingSourceouvrages.DataSource = this.Bib.Ouvrages.Where(j => j.Id_Thm == THM.Id || j.Id_SCT == SCT.Id).Select(i => new { i.Id, i.Titre, i.Auteur, i.Editor, i.Prix, i.Lieu, Secteur = i.Secteur.Nom, Thème = i.Thème.Nom }).ToList();
                this.bindingNVGOuvrage.BindingSource = bindingSourceouvrages;
                this.dtgvouvrages.DataSource = bindingSourceouvrages;
                this.dtgvouvrages.Columns[0].Visible = false;
                if (dtgvouvrages.Rows.Count > 0)
                {
                    this.dtgvouvrages.Rows[0].Selected = true;
                }
            }
            catch
            {
            }
        }
       
        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (switchsecteurs.Value == true)
            {
                cmbsecteurs.Enabled = false;
                cmbthemes.Enabled = false;
                this.UpdateDataGridOuvrage();
            }
            else
            {
                cmbsecteurs.Enabled = true;
                cmbthemes.Enabled = true;
                this.SorteOVG();
            }
        }

        private void cmbsecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idsct = int.Parse(cmbsecteurs.SelectedValue.ToString());
                SCT = this.Bib.Secteurs.Find(idsct);
                SorteOVG();
            }
            catch 
            {
            }
           
        }

        private void cmbthemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idthm = int.Parse(cmbthemes.SelectedValue.ToString());
                THM = this.Bib.Thème.Find(idthm);
                SorteOVG();
            }
            catch 
            {
            }
          
        }

        private void btnaddovg_Click(object sender, EventArgs e)
        {
            if (btnaddovg.ButtonText == "Add Ouvrage")
            {
                if (txttiter.Text != "" && txtediteur.Text != "" && txtauteur.Text != "" && txtlieu.Text != "" && txtprix.Text != "" && THM != null && SCT != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure to Add Ouvrage", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        try
                        {
                            OVG = null;
                            OVG = new Ouvrage();
                            OVG.Id_SCT = SCT.Id;
                            OVG.Id_Thm = THM.Id;
                            OVG.Titre = txttiter.Text.ToUpper();
                            OVG.Lieu = txtlieu.Text.ToUpper();
                            OVG.Auteur = txtauteur.Text.ToUpper();
                            OVG.Editor = txtediteur.Text.ToUpper();
                            OVG.Prix = double.Parse(txtprix.Text);
                            this.Bib.Ouvrages.Add(OVG);
                            this.Bib.SaveChanges();
                            UpdateDataGridOuvrage();
                            btncancel_Click(sender,e);
                            if (switchsecteurs.Value != true)
                            {
                                switchsecteurs.Value = true;
                                bunifuSwitch1_Click(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            else
            {
                if (txttiter.Text != "" && txtediteur.Text != "" && txtauteur.Text != "" && txtlieu.Text != "" && txtprix.Text != "" )
                {
                    if (DialogResult.Yes == MessageBox.Show("Aare you sure to Update Ouvrage", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        try
                        {
                            OVG.Titre = txttiter.Text.ToUpper();
                            OVG.Lieu = txtlieu.Text.ToUpper();
                            OVG.Auteur = txtauteur.Text.ToUpper();
                            OVG.Editor = txtediteur.Text.ToUpper();
                            OVG.Prix = double.Parse(txtprix.Text);
                            this.Bib.SaveChanges();
                            UpdateDataGridOuvrage();
                            btncancel_Click(sender, e);
                            if (switchsecteurs.Value != true)
                            {
                                switchsecteurs.Value = true;
                                bunifuSwitch1_Click(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void dtgvouvrages_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idovr = int.Parse(dtgvouvrages.Rows[bindingSourceouvrages.Position].Cells[0].Value.ToString());
                OVG = this.Bib.Ouvrages.Where(i => i.Id == idovr).Single();
                btncancel_Click(sender, e);
            }
            catch 
            {
            }
        }
    }  
}
