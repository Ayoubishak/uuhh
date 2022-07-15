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
    public partial class FormSecteurs : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceSecteurs;
        Secteur SCT;
        public FormSecteurs(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvSecteurs.Rows.Count > 0)
            {
                txtnomsecteur.ForeColor = Color.DarkOrange;
                txtnomsecteur.Text = this.SCT.Nom;
                btnupdate.Enabled = true;
                btnadd.Enabled = false;
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtnomsecteur.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Update Secteur", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        SCT.Nom = txtnomsecteur.Text.ToUpper();
                        this.Bib.SaveChanges();
                        this.UpdateDataGridSecteurs();
                        btnupdate.Enabled = false;
                        btnadd.Enabled = true;
                        txtnomsecteur.Text = "";
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
                    txtnomsecteur.Text = "";
                }
            }
        }

        private void UpdateDataGridSecteurs()
        {
            bindingSourceSecteurs.DataSource = this.Bib.Secteurs.Select(i => new { i.Id, i.Nom }).ToList();
            bindingNVGSecteurs.BindingSource = bindingSourceSecteurs;
            dtgvSecteurs.DataSource = bindingSourceSecteurs;
            dtgvSecteurs.Columns[0].Visible = false;
            dtgvSecteurs.Columns[1].HeaderText = "Nom Secteur";
            if (dtgvSecteurs.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtgvSecteurs.Rows)
                {
                    item.Selected = false;
                }
                dtgvSecteurs.Rows[0].Selected = true;
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete Secteur", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvSecteurs.Rows.Count > 0)
                {
                   try
                    {
                        this.Bib.Secteurs.Remove(SCT);
                        this.Bib.SaveChanges();
                        this.UpdateDataGridSecteurs();
                    }
                    catch (Exception ex)
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

        private void FormSecteurs_Load(object sender, EventArgs e)
        {
            bindingSourceSecteurs = new BindingSource();
            UpdateDataGridSecteurs();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnomsecteur.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure To Add Secteur", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        SCT = null;
                        SCT = new Secteur();
                        SCT.Nom = txtnomsecteur.Text.ToUpper();
                        this.Bib.Secteurs.Add(SCT);
                        this.Bib.SaveChanges();
                        UpdateDataGridSecteurs();
                        txtnomsecteur.Text = "";                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    txtnomsecteur.Text = "";
                }
            }
        }

        private void dtgvSecteurs_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dtgvSecteurs.Rows[bindingSourceSecteurs.Position].Cells[0].Value.ToString());
                SCT = this.Bib.Secteurs.Find(id);
                btnupdate.Enabled = false;
                btnadd.Enabled = true;
                txtnomsecteur.Text = "";
            }
            catch 
            {

            }
        }
    }
}
