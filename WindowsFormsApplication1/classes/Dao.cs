using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospedagem.classes
{
    public class DAO
    {
        public OleDbConnection objConnection = null;
        public OleDbCommand objCommand = null;
        public string strConnection;

        public DAO()
        {
            
        }
        public void Conecta()
        {
            try
            {
                //strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Julio\\Dropbox\\Sistema Julio\\banco_friedrichdesign.mdb";
                strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\banco_friedrichdesign.mdb";
                objConnection = new OleDbConnection(strConnection);
                objConnection.Close();
                objConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
