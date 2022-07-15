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
    public partial class Form__Details_stagiaire : Form
    {
        BibliothéqueEntities Bib;
        Stagiaire STG;
        public Form__Details_stagiaire(BibliothéqueEntities bib,Stagiaire stg)
        {
            this.Bib = bib;
            this.STG = stg;
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form__Details_stagiaire_Load(object sender, EventArgs e)
        {
            txtnom.Text = STG.Nom;
            txtprenom.Text = STG.Prenom;
            txtemail.Text = STG.Email;
            txtgroupe.Text = STG.Groupe.Nom;
            txtfiliere.Text = STG.Groupe.Filière.Nom;
            txtsec.Text = STG.Groupe.Filière.Secteur.Nom;
            lblnbr.Text = STG.Reserves.Count().ToString();
            if (this.STG.Image != null)
            {
                try
                {
                    pcbxphoto.Image = Image.FromFile(this.STG.Image);
                }
                catch
                {
                }

            }
        }
    }
}
