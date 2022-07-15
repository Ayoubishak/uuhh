using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bibliothéque.Crystal
{
    public partial class Form_Crystal1 : Form
    {
        string Qury;
        string TYP;
        public Form_Crystal1(string qury,string typ)
        {
            this.TYP = typ;
            this.Qury = qury;
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter dataAdapter;
        DataSetLibrary DS;
        CrystalReportAll_RSV cr;
        CrystalReport_EMP cre;
        private void Form_Crystal1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=LIBRARY;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            DS = new DataSetLibrary();
            if (TYP == "RSV")
            {               
                SqlCommand cmd = new SqlCommand(Qury, con);
                dataAdapter = new SqlDataAdapter(cmd);                
                dataAdapter.Fill(DS.Tables[0]);
                cr = new CrystalReportAll_RSV();
                cr.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(Qury, con);
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(DS.Tables[1]);
                cre = new CrystalReport_EMP();
                cre.SetDataSource(DS.Tables[1]);
                crystalReportViewer1.ReportSource = cre;
                crystalReportViewer1.Refresh();
            }
           
        }
    }
}
