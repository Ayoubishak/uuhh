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
    public partial class Form_Stagiaire_Reserve : Form
    {
        BibliothéqueEntities Bib;
        Stagiaire STG;
        BindingSource bindingSourceLivres;
        BindingSource bindingSourceOuvrages;
        Thème THM;
        Ouvrage OVG;
        Livre LVR;
        public Form_Stagiaire_Reserve(BibliothéqueEntities bib,Stagiaire stg)
        {
            this.Bib = bib;
            this.STG = stg;
            InitializeComponent();
        }

        private void Form_Stagiaire_Reserve_Load(object sender, EventArgs e)
        {
            bindingSourceLivres = new BindingSource();
            bindingSourceOuvrages = new BindingSource();
            cmbthemes.DataSource = this.Bib.Thème.Select(i => new { i.Id, i.Nom }).ToList();
            cmbthemes.DisplayMember = "Nom";
            cmbthemes.ValueMember = "Id";
        }

        private void UpdateDataGridOuvrage()
        {
            try
            {
                bindingSourceOuvrages.DataSource = THM.Ouvrages.Select(i => new { i.Id, i.Titre, i.Auteur, i.Editor, }).ToList();
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
                this.UpdateDataGridOuvrage();
            }
            catch
            {
            }
        }

        private void UpdateDataGridLivres()
        {
            try
            {

                bindingSourceLivres.DataSource = this.OVG.Livres.Select(i => new { i.Id, i.Ispan, i.DateEntrye }).ToList();
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

        private void dtgvlivres_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idlvr = int.Parse(dtgvlivres.Rows[bindingSourceLivres.Position].Cells[0].Value.ToString());
                LVR = this.OVG.Livres.Where(i => i.Id == idlvr).Single();
            }
            catch
            {

            }
        }

        private void detailsLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dtgvlivres.Rows.Count > 0)
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

        private void btnvld_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Reserve Book ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvlivres.Rows.Count > 0)
                {
                    try
                    {
                        Reserve RSV = new Reserve();
                        RSV.Id_STG = STG.Id;
                        RSV.Id_LVR = LVR.Id;
                        RSV.Date_Reserve = DateTime.Now;
                        RSV.Etat = "Not Validate";
                        this.Bib.Reserves.Add(RSV);
                        this.Bib.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
              
        }
    }
}
