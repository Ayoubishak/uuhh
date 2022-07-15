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
    public partial class Form_MAin_Stagiaire : Form
    {
        BibliothéqueEntities Bib;
        Stagiaire STG;
        public Form_MAin_Stagiaire(Stagiaire stagiaire, BibliothéqueEntities bib)
        {
            this.Bib = bib;
            this.STG = stagiaire;
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to Close Form", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
                Application.OpenForms[0].Show();
            }
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.mini2.Visible = true;
            this.max.Visible = false;
        }

        private void mini2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.mini2.Visible = false;
            this.max.Visible = true;
        }

        private void mini1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            this.pnlleft.Width = 180;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.pnlleft.Width = 56;
        }

        private void Form_MAin_Stagiaire_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lblnomstagiaire.Text = this.STG.Nom + " " + this.STG.Prenom;
            if (this.STG.Image != null)
            {
                try
                {
                    pcbximgadmin.Image = Image.FromFile(this.STG.Image);
                }
                catch
                {

                    MessageBox.Show("The image Position is incorrect.\n Please re-select the appropriate image position", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
              
            }
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            Form_Stagiaire_Reserve F = new Form_Stagiaire_Reserve(this.Bib, this.STG);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (this.pnlmain.Visible != false)
            {
                this.pnlmain.Visible = false;
            }
            FormChangePassword F = new FormChangePassword(this.STG, this.Bib);
            F.MdiParent = this;
            F.Dock = DockStyle.Fill;
            F.Show();
        }

        int move, moveX, moveY;
        private void pnlmove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
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
                    this.STG.Image = openFile.FileName;
                    this.Bib.SaveChanges();
                }
                catch
                {

                    MessageBox.Show("The image Position is incorrect.\n Please re-select the appropriate image position", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
               
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
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }
    }
}
