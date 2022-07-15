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
namespace Bibliothéque.Views
{
    public partial class FormChangePassword : Form
    {
        BibliothéqueEntities Bib;
        string Type = "";
        Admin Admin;
        public FormChangePassword(Admin admin, BibliothéqueEntities bib)
        {
            Type = "ADM";
            this.Admin = admin;
            this.Bib = bib;
            InitializeComponent();
        }
        Stagiaire Stagiaire;
        public FormChangePassword(Stagiaire stagiaire, BibliothéqueEntities bib)
        {
            Type = "STG";
            this.Stagiaire = stagiaire;
            this.Bib = bib;
            InitializeComponent();
        }

        private void checkBox1_OnChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtConfirmPassword.isPassword = false;
                txtNewPassword.isPassword = false;
                txtCurrentPassword.isPassword = false;
            }
            else
            {
                txtConfirmPassword.isPassword = true;
                txtNewPassword.isPassword = true;
                txtCurrentPassword.isPassword = true;
            }
        }

        private void txtcurrentpassword_OnValueChanged(object sender, EventArgs e)
        {
            txtCurrentPassword.isPassword = true;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtNewPassword.isPassword = true;
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }

        private void btnsingup_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case "ADM":
                    if (txtCurrentPassword.Text != "" && txtConfirmPassword.Text != "" && txtNewPassword.Text != "")
                    {
                        if (txtCurrentPassword.Text == this.Admin.Password)
                        {
                            if (txtConfirmPassword.Text == txtNewPassword.Text)
                            {
                                try
                                {
                                    if (DialogResult.Yes == MessageBox.Show("Are you sure to change the password [You mist re-login]", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    {
                                        Admin ADM = Bib.Admins.Attach(this.Admin);
                                        ADM.Password = txtNewPassword.Text;
                                        Bib.SaveChanges();
                                        MessageBox.Show("Password changed succesfully", "Good");
                                        this.MdiParent.Close();
                                        this.Close();
                                        Application.OpenForms[0].Show();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The old password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Make sure to fill in all the information", "Asterisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    break;
                case "STG":
                    if (txtCurrentPassword.Text != "" && txtConfirmPassword.Text != "" && txtNewPassword.Text != "")
                    {
                        if (txtCurrentPassword.Text == this.Stagiaire.Password)
                        {
                            if (txtConfirmPassword.Text == txtNewPassword.Text)
                            {
                                try
                                {
                                    if (DialogResult.Yes == MessageBox.Show("Are you sure to change the password [You mist re-login]", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    {
                                        Stagiaire STG = Bib.Stagiaires.Attach(this.Stagiaire);
                                        STG.Password = txtNewPassword.Text;
                                        Bib.SaveChanges();
                                        MessageBox.Show("Password changed succesfully", "Good");
                                        this.MdiParent.Close();
                                        this.Close();
                                        Application.OpenForms[0].Show();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The old password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Make sure to fill in all the information", "Asterisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    break;
            }
        }
    }
}
