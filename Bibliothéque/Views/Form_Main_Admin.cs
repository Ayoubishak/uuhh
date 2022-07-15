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
using Bibliothéque.Views.Views_Manages;
namespace Bibliothéque.Views
{
    public partial class Form_Main_Admin : Form
    {
        BibliothéqueEntities Bib;
        Admin ADM;
        public Form_Main_Admin(Admin admin, BibliothéqueEntities bib)
        {
            this.Bib = bib;
            this.ADM = admin;
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Close Form", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();                
                if (Application.OpenForms[0].Name == "Form_Sing_Up")
                {
                    Application.OpenForms[1].Show();
                }
                else
                {
                    Application.OpenForms[0].Show();
                }
            }
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.mini2.Visible = true;
            this.max.Visible = false;
        }

        private void mini1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mini2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.mini2.Visible = false;
            this.max.Visible = true;
        }
        int move, moveX, moveY;
        private void pnlmove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            this.pnlleft.Width = 180;
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.pnlleft.Width = 56;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FormSecteurs F = new FormSecteurs(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FormTheme F = new FormTheme(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form_Filieur F = new Form_Filieur(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form_Groupe F = new Form_Groupe(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form_Stagiaires F = new Form_Stagiaires(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form_Ouvrages F = new Form_Ouvrages(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form_Emprinte F = new Form_Emprinte(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FormChangePassword F = new FormChangePassword(this.ADM,this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (this.pnlmain.Visible != true)
            {
                this.pnlmain.Visible = true;
            }
           
        }

        private void Form_Main_Admin_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lblnomadmin.Text = this.ADM.Nom + " " + this.ADM.Prenom;
            if (this.ADM.Image != null)
            {
                try
                {
                    pcbximgadmin.Image = Image.FromFile(this.ADM.Image);
                }
                catch
                {

                    MessageBox.Show("The image Position is incorrect.\n Please re-select the appropriate image position", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
               
            }           
        }

        private void pcbximgadmin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "img png|*.png|img jpg|*.jpg";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                try
                {
                    pcbximgadmin.Image = Image.FromFile(openFile.FileName);
                    this.ADM.Image = openFile.FileName;
                    this.Bib.SaveChanges();
                }
                catch 
                {

                    MessageBox.Show("The image Position is incorrect.\n Please re-select the appropriate image position", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form_Livres F = new Form_Livres(this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void pnlmove_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pnlmove_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }
    }
}
