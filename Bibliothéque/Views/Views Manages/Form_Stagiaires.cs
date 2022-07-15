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
    public partial class Form_Stagiaires : Form
    {
        BibliothéqueEntities Bib;
        BindingSource bindingSourceStagiaires;
        Secteur SCT;
        Filière FLR;
        Groupe GRP;
        Stagiaire STG;
        public Form_Stagiaires(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        //update
        private void UpdateDataGridStagiaires()
        {
            try
            {
                bindingSourceStagiaires.DataSource = this.GRP.Stagiaires.Select(i => new { i.Id, i.Nom, i.Prenom, Email = i.Email.ToUpper(), i.Reserves.Count }).ToList();
                bindingNVGStagiaires.BindingSource = bindingSourceStagiaires;
                dtgvStagiairs.DataSource = bindingSourceStagiaires;
                dtgvStagiairs.Columns[0].Visible = false;
                dtgvStagiairs.Columns[1].HeaderText = "Nom Stagiaire";
                dtgvStagiairs.Columns[2].HeaderText = "Prénom Stagiaire";
                dtgvStagiairs.Columns[3].HeaderText = "Email Stagiaire";
                dtgvStagiairs.Columns[3].Width = 320;
                dtgvStagiairs.Columns[4].HeaderText = "Number Reserves";
                if (dtgvStagiairs.Rows.Count > 0)
                {
                    foreach (DataGridViewRow i in dtgvStagiairs.Rows)
                    {
                        i.Selected = false;
                    }
                    dtgvStagiairs.Rows[0].Selected = true;
                }
            }
            catch 
            {

            }
        }


        //search
        private void SearchSTG()
        {
            if (txtsearch.text.Length > 0)
            {
                try
                {
                    this.bindingSourceStagiaires.DataSource = GRP.Stagiaires.Where(i => i.Nom.Contains(txtsearch.text.ToUpper()) || i.Prenom.Contains(txtsearch.text.ToUpper()) || i.Email.Contains(txtsearch.text) || i.Reserves.Count.ToString().Contains(txtsearch.text)).Select(j => new { j.Id, Nom = j.Nom, Prenom = j.Prenom, Email = j.Email.ToUpper(), j.Reserves.Count }).ToList();
                    this.dtgvStagiairs.DataSource = bindingSourceStagiaires;
                    this.bindingNVGStagiaires.BindingSource = bindingSourceStagiaires;
                    this.dtgvStagiairs.Columns[0].Visible = false;
                    dtgvStagiairs.Columns[1].HeaderText = "Nom Stagiaire";
                    dtgvStagiairs.Columns[2].HeaderText = "Prénom Stagiaire";
                    dtgvStagiairs.Columns[3].HeaderText = "Email Stagiaire";
                    dtgvStagiairs.Columns[3].Width = 320;
                    dtgvStagiairs.Columns[4].HeaderText = "Number Reserves";
                    if (this.dtgvStagiairs.Rows.Count > 0)
                    {
                        this.dtgvStagiairs.Rows[0].Selected = true;
                    }
                }
                catch 
                {
                }
            }
            else
            {
                this.UpdateDataGridStagiaires();
            }
        }
        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                SearchSTG();
            }
            catch 
            {
            }
           
        }

        private void Form_Stagiaires_Load(object sender, EventArgs e)
        {

            try
            {
                bindingSourceStagiaires = new BindingSource();
                cmbsecteurs.DataSource = this.Bib.Secteurs.Select(i => new { i.Id, i.Nom }).ToList();
                cmbsecteurs.DisplayMember = "Nom";
                cmbsecteurs.ValueMember = "Id";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

                //Groups
                cmbgroupes.DataSource = this.FLR.Groupes.Select(i => new { i.Id, i.Nom }).ToList();
                cmbgroupes.DisplayMember = "Nom";
                cmbgroupes.ValueMember = "Id";

                cmbgroupes.Visible = true;
                lblgroup.Visible = true;
            }
            catch
            {
            }
        }

        private void cmbgroupes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idgrp = int.Parse(cmbgroupes.SelectedValue.ToString());
                this.GRP = this.FLR.Groupes.Where(i => i.Id == idgrp).Single();
                this.UpdateDataGridStagiaires();
                //this.SearchSTG();
                this.btnadd.Enabled = true;
                this.btnupdate.Enabled = true;
                txtsearch.Visible = true;
                SearchSTG();
            }
            catch
            {
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            pnladdorupdate.Visible = true;
            dtgvStagiairs.Width = 770;
            dtgvStagiairs.ColumnHeadersHeight = 70;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dtgvStagiairs.Rows.Count > 0)
            {
                try
                {
                    btnadd_Click(sender, e);
                    btnaddstg.ButtonText = "Update Stagiaire";
                    txtnom.Text = STG.Nom;
                    txtprenom.Text = STG.Prenom;
                    txtemail.Text = STG.Email;
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearBox();
            pnladdorupdate.Visible = false;
            dtgvStagiairs.Width = 1105;
            dtgvStagiairs.ColumnHeadersHeight = 30;
            btnaddstg.ButtonText = "Add Stagiaire";
        }

        private void ClearBox()
        {
            txtnom.Text = "";
            txtprenom.Text = "";
            txtemail.Text = "";
        }
        private void btnaddstg_Click(object sender, EventArgs e)
        {
            if (btnaddstg.ButtonText == "Add Stagiaire")
            {
                if (txtnom.Text != "" && txtprenom.Text != "" && txtemail.Text != "")
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure to Add Stagiaaire", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        try
                        {
                            STG = null;
                            STG = new Stagiaire();
                            STG.Id_GRP = this.GRP.Id;
                            STG.Nom = txtnom.Text.ToUpper();
                            STG.Prenom = txtprenom.Text.ToUpper();
                            STG.Email = txtemail.Text + "@Gmail.com";
                            STG.Password = "123";
                            STG.Type = "STG";
                            this.Bib.Stagiaires.Add(STG);
                            this.Bib.SaveChanges();
                            this.UpdateDataGridStagiaires();
                            btncancel_Click(sender, e);
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
                if (txtnom.Text != "" || txtprenom.Text != "" || txtemail.Text != "")
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure to Update Stagiaire", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        try
                        {
                            STG.Nom = txtnom.Text.ToUpper();
                            STG.Prenom = txtprenom.Text.ToUpper();
                            STG.Email = txtemail.Text;
                            this.Bib.SaveChanges();
                            this.UpdateDataGridStagiaires();
                            btncancel_Click(sender, e);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void dtgvStagiairs_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idstg = int.Parse(dtgvStagiairs.Rows[bindingSourceStagiaires.Position].Cells[0].Value.ToString());
                STG = this.GRP.Stagiaires.Where(i => i.Id == idstg).Single();
                btncancel_Click(sender, e);
            }
            catch
            {

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to delete stagiaire ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgvStagiairs.Rows.Count > 0)
                {
                    try
                    {
                        this.Bib.Stagiaires.Remove(STG);
                        this.Bib.SaveChanges();
                        this.UpdateDataGridStagiaires();
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
}
