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
    public partial class Form_Details_Book : Form
    {
        Livre LVR;
        BibliothéqueEntities Bib;
        public Form_Details_Book(Livre lvr,BibliothéqueEntities bib)
        {
            this.LVR = lvr;
            this.Bib = bib;
            InitializeComponent();
        }

        private void pcbxphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "img png|*.png|img jpg|*.jpg";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                pcbxphoto.Image = Image.FromFile(openFile.FileName);
                LVR.Image = openFile.FileName;
                this.Bib.SaveChanges();
            }
        }

        private void Form_Details_Book_Load(object sender, EventArgs e)
        {
            txttiter.Text = LVR.Ouvrage.Titre;
            txtauteur.Text = LVR.Ouvrage.Auteur;
            txteditor.Text = LVR.Ouvrage.Editor;
            txttheme.Text = LVR.Ouvrage.Thème.Nom;
            txtdateentry.Text = LVR.DateEntrye.ToString();
            txtisp.Text = LVR.Ispan;
            txtprix.Text = LVR.Ouvrage.Prix.ToString()+"  DH";
            lblnbr.Text = LVR.Reserves.Count().ToString();
            txtlieu.Text = LVR.Ouvrage.Lieu;
            if (this.LVR.Image != null)
            {
                try
                {
                    pcbxphoto.Image = Image.FromFile(this.LVR.Image);
                }
                catch
                { 
                }

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
