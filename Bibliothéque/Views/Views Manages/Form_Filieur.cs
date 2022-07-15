using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothéque.Data_Modal;
using System.Windows.Forms;

namespace Bibliothéque.Views.Views_Manages
{
    public partial class Form_Filieur : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourcefiliere;
        Secteur SCT;
        Filière FLR;
        public Form_Filieur(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();

        }

        private void Form_Filieur_Load(object sender, EventArgs e)
        {
            bindingSourcefiliere = new BindingSource();
            cmbsecteurs.DataSource = this.Bib.Secteurs.ToList();
            cmbsecteurs.DisplayMember = "Nom";
            cmbsecteurs.ValueMember = "Id";

        }

        private void UpdateDataGridFiliers()
        {
            try
            {
                bindingSourcefiliere.DataSource = SCT.Filière.Select(i => new { i.Id, i.Nom }).ToList();
                bindingNVGFiliers.BindingSource = bindingSourcefiliere;
                dtgvFilieurs.DataSource = bindingSourcefiliere;
                dtgvFilieurs.Columns[0].Visible = false;
                dtgvFilieurs.Columns[1].HeaderText = "Nom Filiérer";
                if (dtgvFilieurs.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in dtgvFilieurs.Rows)
                    {
                        item.Selected = false;
                    }
                    dtgvFilieurs.Rows[0].Selected = true;
                }
                txtnomFilière.Text = "";
                
            }
            catch
            {
            }
            
        }

        private void cmbsecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idsct = int.Parse(cmbsecteurs.SelectedValue.ToString());
                SCT = this.Bib.Secteurs.Find(idsct);
                UpdateDataGridFiliers();
            }
            catch 
            {
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnomFilière.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure To Add Filière", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        FLR = null;
                        FLR = new Filière();
                        FLR.Nom = txtnomFilière.Text.ToUpper();
                        FLR.Id_SCT = SCT.Id;
                        this.Bib.Filière.Add(FLR);
                        this.Bib.SaveChanges();
                        UpdateDataGridFiliers();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    txtnomFilière.Text = "";
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtnomFilière.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Update Filière", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        FLR.Nom = txtnomFilière.Text.ToUpper();
                        this.Bib.SaveChanges();
                        this.UpdateDataGridFiliers();
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
                    txtnomFilière.Text = "";
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete Filière", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvFilieurs.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Filière.Remove(FLR);
                        this.Bib.SaveChanges();
                        this.UpdateDataGridFiliers();
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvFilieurs.Rows.Count > 0)
            {
                txtnomFilière.ForeColor = Color.DarkOrange;
                txtnomFilière.Text = this.FLR.Nom;
                btnupdate.Enabled = true;
                btnadd.Enabled = false;
            }
            else
            {
                MessageBox.Show("There are no data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvFilieurs_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dtgvFilieurs.Rows[bindingSourcefiliere.Position].Cells[0].Value.ToString());
                FLR = this.Bib.Filière.Find(id);
                txtnomFilière.Text = "";
                btnupdate.Enabled = false;
                btnadd.Enabled = true;
            }
            catch
            {
            }
        }

    }
}
