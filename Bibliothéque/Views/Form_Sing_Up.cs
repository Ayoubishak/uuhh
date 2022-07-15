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
    public partial class Form_Sing_Up : Form
    {
        BibliothéqueEntities Bib;
        public Form_Sing_Up(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtConfirmPassword.isPassword = false;
                txtPassword.isPassword = false;
            }
            else
            {
                txtConfirmPassword.isPassword = true;
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            this.txtPassword.isPassword = true;
            if (txtPassword.Text != "")
            {
                this.checkBox1.Visible = true;
                this.lblshow.Visible = true;
            }
            else
            {
                this.checkBox1.Visible = false;
                this.lblshow.Visible = false;
            }
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }

        private void btnsingup_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != "" && txtPassword.Text != "" && txtnom.Text != "" && txtemail.Text != "" && txtemail.Text != "")
            {
                if (txtConfirmPassword.Text == txtPassword.Text)
                {
                        if (txtConfirmPassword.Text == txtPassword.Text)
                        {
                            Admin admin = new Admin();
                            admin.Nom = txtnom.Text.ToUpper();
                            admin.Prenom = txtprenom.Text.ToUpper();
                            admin.Email = txtemail.Text;
                            admin.Password = txtPassword.Text;
                            admin.Type = "ADM";
                            if (openFile != null && openFile.FileName != null)
                            {
                                admin.Image = openFile.FileName;
                            }
                            else
                            {
                                admin.Image = null;
                            }
                            
                            this.Bib.Admins.Add(admin);                            
                            this.Bib.SaveChanges();                    
                            this.Hide();
                            new Form_Main(this.Bib).Show();
                    }
                        else
                        {
                            MessageBox.Show("Password not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }  
                }
                else
                {
                    MessageBox.Show("Password not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
            else
            {
                MessageBox.Show("Make sure to fill in all the information", "Asterisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        OpenFileDialog openFile;
        private void pcbxphoto_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            if (DialogResult.OK == openFile.ShowDialog())
            {
                pcbxphoto.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void Form_Sing_Up_Load(object sender, EventArgs e)
        {

        }
    }
}
