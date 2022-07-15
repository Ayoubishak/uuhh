using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothéque.Views;
using Bibliothéque.Data_Modal;
using System.Data.SqlClient;
using System.IO;
namespace Bibliothéque
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                
                //string u = ;
                //MessageBox.Show(u);
                SqlConnection con = new SqlConnection("Data Source = (local);Integrated Security = True");               
                con.Open();
                SqlCommand cmd = new SqlCommand("select name from Sys.databases where name like 'LIBRARY'", con);
                if (cmd.ExecuteScalar() != null)
                {
                    con.Close();
                    BibliothéqueEntities Bib = new BibliothéqueEntities();
                    if (Bib.Admins.Count() > 0)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form_Main(Bib));
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form_Sing_Up(Bib));
                    }
                }
                else
                {
                    //SqlCommand sqlCommand = new SqlCommand(@"create database LIBRARY on (filename= N'C:\Program Files (x86)\Bibliothéque\Bibliothéque\Database\LIBRARY.mdf'),(filename= N'C:\Program Files (x86)\Bibliothéque\Bibliothéque\Database\LIBRARY_log.ldf') for attach", con);
                    //string path = string.Format("{ 0}Bibliothéque\\Bibliothéque\\Database", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);
                    string path = string.Format("{0}\\Database", Application.StartupPath);
                    SqlCommand sqlCommand = new SqlCommand(@"create database LIBRARY on "
                                                            + "(filename= N'" + path + "\\LIBRARY.mdf'),"
                                                            + "(filename= N'" + path + "\\LIBRARY_log.ldf') for attach", con);
                    //C:\Program Files (x86)\Bibliothéque\Bibliothéque\Database
                    BibliothéqueEntities Bib = new BibliothéqueEntities();
                    sqlCommand.ExecuteNonQuery();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form_Sing_Up(Bib));
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
