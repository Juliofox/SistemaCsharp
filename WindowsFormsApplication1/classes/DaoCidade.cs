using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Hospedagem.classes
{
    public class DaoCidade : DAO
    {
        Estado umEstado;
        Cidade umaCidade;
        
        public DaoCidade()
        {
            umEstado = new Estado();
            umaCidade = new Cidade();
            this.Conecta();
        }
        public String Salvar(Cidade obj)
        {
            string strSQL, msg;
            umaCidade = obj;
            try
            {
                if (umaCidade.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO cidade (cidade, cod_estado) VALUES ('" + umaCidade.GetCidade + "','" + umaCidade.getumEstado.GetCodigo + "')";
                }
                else
                {
                    strSQL = "UPDATE cidade SET cidade='" + umaCidade.GetCidade + "' ,cod_estado = '" + umaCidade.getumEstado.GetCodigo + "'where codigo =" + Convert.ToString(umaCidade.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Cidade salva com sucesso!";
                //return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Cidade Carrega(Cidade obj)
        {
            umaCidade = obj;
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            OleDbDataAdapter adapter, adapter2, adapter3;
            adapter = new OleDbDataAdapter("SELECT * from cidade where codigo = " + umaCidade.GetCodigo, objConnection);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            umaCidade.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
            umaCidade.GetCidade = dt.Rows[0]["cidade"].ToString();
            umaCidade.getumEstado.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_estado"].ToString());

            adapter2 = new OleDbDataAdapter("SELECT * from estado where codigo = " + umaCidade.getumEstado.GetCodigo, objConnection);
            adapter2.Fill(ds2);
            DataTable dt2 = ds2.Tables[0];
            umaCidade.getumEstado.getEstado = dt2.Rows[0]["estado"].ToString();

            adapter3 = new OleDbDataAdapter("SELECT * from pais where codigo = " + dt2.Rows[0]["cod_pais"].ToString(), objConnection);
            adapter3.Fill(ds3);
            DataTable dt3 = ds3.Tables[0];
            umaCidade.getumEstado.getumPais.GetPais = dt3.Rows[0]["pais"].ToString();
            
            return umaCidade;
        }
        public String Excluir(Cidade obj)
        {
            String strSQL, msg;
            umaCidade = obj;
            try
            {
                strSQL = "delete from cidade where codigo = " + umaCidade.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Cidade excluida com sucesso!";
                return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public DataTable CarregaGrid()
        {
            String strSelect = "SELECT * from cidade ORDER BY codigo";
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
