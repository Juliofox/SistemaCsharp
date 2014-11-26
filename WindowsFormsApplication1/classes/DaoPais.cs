using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Hospedagem.classes
{
    public class DaoPais : DAO
    {
        Pais umPais;
        public DaoPais()
        {
            umPais = new Pais();
            this.Conecta();
        }

        public String Salvar(Pais obj)
        {
            string strSQL, msg;
            umPais = obj;
            try
            {
                if (umPais.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO pais (pais) VALUES ('" + umPais.GetPais + "')";
                }
                else
                {
                    strSQL = "UPDATE pais SET pais='" + umPais.GetPais + "' where codigo =" + Convert.ToString(umPais.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                this.CarregaGrid();
                msg = "Pais salvo com sucesso!";
                return msg;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Pais Carrega(Pais obj)
        {
            Pais umPais;
            umPais = obj;
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter;
            adapter = new OleDbDataAdapter("SELECT * from pais where codigo = "+ umPais.GetCodigo, objConnection);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            
            umPais.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
            umPais.GetPais = dt.Rows[0]["pais"].ToString();
            return umPais;

        }
        public String Excluir(Pais obj)
        {
            String strSQL, msg;
            umPais = obj;
            try
            {
                strSQL = "delete from pais where codigo = "+ umPais.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                this.CarregaGrid();
                msg = "Pais excluido com sucesso!";
                return msg;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
            
        }
        public DataTable CarregaGrid()
        {
            string strSelect = "SELECT * from pais ORDER BY codigo";
            objCommand = new OleDbCommand(strSelect, objConnection);
            OleDbDataAdapter objAdp = new OleDbDataAdapter(objCommand);
            DataTable dtLista = new DataTable();
            objAdp.Fill(dtLista);
            return dtLista;
            //dataGridView1.DataSource = dtLista;
            objConnection.Close();
        }
        
    }
}
