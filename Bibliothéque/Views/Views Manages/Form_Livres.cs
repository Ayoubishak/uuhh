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
    public partial class Form_Livres : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceLivres;
        BindingSource bindingSourceOuvrages;
        Thème THM;
        Ouvrage OVG;
        Livre LVR;
        public Form_Livres(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        private void UpdateDataGridLivres()
        {
            try
            {

                bindingSourceLivres.DataSource = this.OVG.Livres.Select(i => new { i.Id, i.Ispan,i.DateEntrye}).ToList();
                bindingNVGlivrs.BindingSource = bindingSourceLivres;
                dtgvlivres.DataSource = bindingSourceLivres;
                dtgvlivres.Columns[0].Visible = false;
                dtgvlivres.Columns[2].HeaderText = "Date Entrye";
                if (dtgvlivres.Rows.Count > 0)
                {
                    foreach (DataGridViewRow i in dtgvlivres.Rows)
                    {
                        i.Selected = false;
                    }
                    dtgvlivres.Rows[0].Selected = true;
                }
                txtispan.Text = "";
            }
            catch
            {
            }
        }
        private void UpdateDataGridOuvrage()
        {
            try
            {
                bindingSourceOuvrages.DataSource = THM.Ouvrages.Select(i => new { i.Id, i.Titre,i.Auteur, i.Editor,}).ToList();
                bindingNVGouvrage.BindingSource = bindingSourceOuvrages;
                dtgvouvrage.DataSource = bindingSourceOuvrages;
                dtgvouvrage.Columns[0].Visible = false;
                if (dtgvouvrage.Rows.Count > 0)
                {
                    foreach (DataGridViewRow i in dtgvouvrage.Rows)
                    {
                        i.Selected = false;
                    }
                    dtgvouvrage.Rows[0].Selected = true;
                }
                txtispan.Text = "";
            }
            catch
            {
            }
        }

        private void Form_Livres_Load(object sender, EventArgs e)
        {
            bindingSourceLivres = new BindingSource();
            bindingSourceOuvrages = new BindingSource();
            cmbthemes.DataSource = this.Bib.Thème.Select(i => new { i.Id, i.Nom }).ToList();
            cmbthemes.DisplayMember = "Nom";
            cmbthemes.ValueMember = "Id";
        }

        private void cmbthemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idthm = int.Parse(cmbthemes.SelectedValue.ToString());
                THM = this.Bib.Thème.Find(idthm);
                this.UpdateDataGridOuvrage();
            }
            catch 
            {
            }
        }

        private void dtgvouvrage_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idovr = int.Parse(dtgvouvrage.Rows[bindingSourceOuvrages.Position].Cells[0].Value.ToString());
                OVG = this.THM.Ouvrages.Where(i => i.Id == idovr).Single();
                UpdateDataGridLivres();
            }
            catch 
            {


            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtispan.Text != "" && OVG != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure To Add Livre", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        LVR = null;
                        LVR = new Livre();
                        LVR.Id_OVR = OVG.Id;
                        LVR.Ispan = txtispan.Text;
                        LVR.Etat = "Non Disponible";
                        LVR.DateEntrye = DateTime.Now;
                        this.Bib.Livres.Add(LVR);
                        this.Bib.SaveChanges();
                        this.UpdateDataGridLivres();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtispan.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Update Livre", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        this.LVR.Ispan = txtispan.Text;
                        this.Bib.SaveChanges();
                        this.UpdateDataGridLivres();
                        btnupdate.Enabled = false;
                        btnadd.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    btnupdate.Enabled = false;
                    btnadd.Enabled = true;
                    txtispan.Text = "";
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete Livre", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvlivres.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Livres.Remove(LVR);
                        this.Bib.SaveChanges();
                        this.UpdateDataGridLivres();
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvlivres.Rows.Count > 0)
            {
                try
                {
                    txtispan.Text = LVR.Ispan.ToString();
                    btnupdate.Enabled = true;
                    btnadd.Enabled = false;
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

        private void dtgvlivres_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idlvr = int.Parse(dtgvlivres.Rows[bindingSourceLivres.Position].Cells[0].Value.ToString());
                LVR = this.OVG.Livres.Where(i => i.Id == idlvr).Single();
                txtispan.Text = "";
            }
            catch
            {

            }
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVR != null)
            {
                Form_Details_Book F = new Form_Details_Book(LVR, this.Bib);
                F.ShowDialog();
                //ANMCH.ShowSync(F);
            }
        }
    }
}
