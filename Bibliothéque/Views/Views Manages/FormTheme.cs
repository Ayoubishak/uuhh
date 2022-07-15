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
    public partial class FormTheme : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceThemes;
        Thème THM;
        public FormTheme(BibliothéqueEntities bib)
        {
            Bib = bib;
            InitializeComponent();
        }

        private void UpdateDataGridThème()
        {
            bindingSourceThemes.DataSource = this.Bib.Thème.Select(i => new { i.Id, i.Nom }).ToList();
            bindingNVGTheme.BindingSource = bindingSourceThemes;
            dtgvTheme.DataSource = bindingSourceThemes;
            dtgvTheme.Columns[0].Visible = false;
            dtgvTheme.Columns[1].HeaderText = "Nom Thème";
            if (dtgvTheme.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtgvTheme.Rows)
                {
                    item.Selected = false;
                }
                dtgvTheme.Rows[0].Selected = true;
            }
        }

        private void FormTheme_Load(object sender, EventArgs e)
        {
            bindingSourceThemes = new BindingSource();
            UpdateDataGridThème();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvTheme.Rows.Count > 0)
            {
                txtnomtheme.ForeColor = Color.DarkOrange;
                txtnomtheme.Text = this.THM.Nom;
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
            if (txtnomtheme.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Update Thème", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        THM.Nom = txtnomtheme.Text.ToUpper();
                        this.Bib.SaveChanges();
                        this.UpdateDataGridThème();
                        btnupdate.Enabled = false;
                        btnadd.Enabled = true;
                        txtnomtheme.Text = "";
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
                    txtnomtheme.Text = "";
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete Thème", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvTheme.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Thème.Remove(THM);
                        this.Bib.SaveChanges();
                        this.UpdateDataGridThème();
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnomtheme.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure To Add Thème", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        THM = null;
                        THM = new Thème();
                        THM.Nom = txtnomtheme.Text.ToUpper();
                        this.Bib.Thème.Add(THM);
                        this.Bib.SaveChanges();
                        UpdateDataGridThème();
                        txtnomtheme.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    txtnomtheme.Text = "";
                }
            }
        }

        private void dtgvTheme_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dtgvTheme.Rows[bindingSourceThemes.Position].Cells[0].Value.ToString());
                THM = this.Bib.Thème.Find(id);
                btnupdate.Enabled = false;
                btnadd.Enabled = true;
                txtnomtheme.Text = "";
            }
            catch 
            {
            }
        }
    }
}
