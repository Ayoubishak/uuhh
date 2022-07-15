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
    public partial class Form_Main : Form
    {
        BibliothéqueEntities Bib;
        public Form_Main(BibliothéqueEntities bib)
        {
            this.Bib = bib;
            InitializeComponent();
        }

        int move, moveX, moveY;
        
        private void pnlmove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Close Application", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            
        }

        private void txtpassword_OnValueChanged(object sender, EventArgs e)
        {
            this.txtpassword.isPassword = true;
            if (txtpassword.Text != "")
            {
                this.Show.Visible = true;
            }
            else
            {
                this.Show.Visible = false;
                this.notShow.Visible = false;
            }
        }

        private void notshow_Click(object sender, EventArgs e)
        {
            this.txtpassword.isPassword = false;
            notShow.Visible = true;
            this.Show.Visible = false;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            this.txtpassword.isPassword = true;
            notShow.Visible = false;
            this.Show.Visible = true;
        }

        private void bntlogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "" && txtpassword.Text != "")
            {
                try
                {
                    //Admin admin = Bib.Admins.Where(i => i.Email == txtemail.Text && i.Password == txtpassword.Text).Single();
                    Admin admin = Bib.Admins.Where(i => i.Email == txtemail.Text && i.Password == txtpassword.Text && i.Type == "ADM").Single();
                    this.Hide();
                    new Form_Main_Admin(admin, this.Bib).ShowDialog();
                    txtemail.Text = "";
                    txtpassword.Text = "";
                   
                }
                catch
                {
                    try
                    {
                        Stagiaire stagiaire = Bib.Stagiaires.Where(i => i.Email == txtemail.Text && i.Password == txtpassword.Text && i.Type == "STG").Single();
                        this.Hide();
                        new Form_MAin_Stagiaire(stagiaire, this.Bib).ShowDialog(); 
                        txtemail.Text = "";
                        txtpassword.Text = "";
                        
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect Password or Email ", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill in all the information", "Asterisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void pnlmove_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pnlmove_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX,MousePosition.Y - moveY);
            }
        }
    }
}
