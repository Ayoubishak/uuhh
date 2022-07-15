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
    public partial class Form_Groupe : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceGroupes;
        Secteur SCT;
        Filière FLR;
        Groupe GRP;
        public Form_Groupe(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        // update 
        private void UpdateDataGridGroupes()
        {
            this.bindingSourceGroupes.DataSource = FLR.Groupes.Select(i => new { i.Id, i.Nom }).ToList();
            this.bindingNVGGroups.BindingSource = bindingSourceGroupes;
            dtgvgroupes.DataSource = bindingSourceGroupes;
            dtgvgroupes.Columns[0].Visible = false;
            dtgvgroupes.Columns[1].HeaderText = "Nom Groupe";
            if (dtgvgroupes.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtgvgroupes.Rows)
                {
                    item.Selected = false;
                }
                dtgvgroupes.Rows[0].Selected = true;
            }
            txtnomGroupe.Text = "";
        }


        private void cmbsecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idsct = int.Parse(cmbsecteurs.SelectedValue.ToString());
                SCT = this.Bib.Secteurs.Find(idsct);

                //filier
                cmbfilieres.DataSource = this.SCT.Filière.Select(i => new { i.Id, i.Nom }).ToList();
                cmbfilieres.DisplayMember = "Nom";
                cmbfilieres.ValueMember = "Id";

                cmbfilieres.Visible = true;
                lblfilieres.Visible = true;
            }
            catch 
            {

            }
        }



        private void cmbfilieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idflr = int.Parse(cmbfilieres.SelectedValue.ToString());
                FLR = this.SCT.Filière.Where(i => i.Id == idflr).Single();
                UpdateDataGridGroupes();
            }
            catch 
            {
            }
        }

        private void Form_Groupe_Load(object sender, EventArgs e)
        {
            bindingSourceGroupes = new BindingSource();
            cmbsecteurs.DataSource = this.Bib.Secteurs.ToList();
            cmbsecteurs.DisplayMember = "Nom";
            cmbsecteurs.ValueMember = "Id";
        }

        private void dtgvgroupes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idgrp = int.Parse(dtgvgroupes.Rows[bindingSourceGroupes.Position].Cells[0].Value.ToString());
                this.GRP = this.FLR.Groupes.Where(i => i.Id == idgrp).Single();
                btnupdate.Enabled = false;
                btnadd.Enabled = true;
                txtnomGroupe.Text = "";
            }
            catch 
            {
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvgroupes.Rows.Count > 0)
            {
                try
                {
                    txtnomGroupe.Text = GRP.Nom;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnomGroupe.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to add Groupe", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        GRP = null;
                        GRP = new Groupe();
                        GRP.Id_FLR = FLR.Id;
                        GRP.Nom = txtnomGroupe.Text.ToUpper();
                        this.Bib.Groupes.Add(GRP);
                        this.Bib.SaveChanges();
                        UpdateDataGridGroupes();
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
            if (txtnomGroupe.Text != "" )
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to Update Groupe", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        GRP.Nom = txtnomGroupe.Text.ToUpper();
                        this.Bib.SaveChanges();
                        UpdateDataGridGroupes();
                        btnupdate.Enabled = false;
                        btnadd.Enabled = true;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            else
            {
                btnupdate.Enabled = false;
                btnadd.Enabled = true;
                txtnomGroupe.Text = "";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Delete Groupe", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvgroupes.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Groupes.Remove(GRP);
                        this.Bib.SaveChanges();
                        UpdateDataGridGroupes();
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
    }
}
