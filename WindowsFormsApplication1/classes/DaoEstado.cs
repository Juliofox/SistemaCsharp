using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Hospedagem.classes
{
    public class DaoEstado : DAO
    {
        Pais umPais;
        Estado umEstado;
        public DaoEstado()
        {
            umPais = new Pais();
            umEstado = new Estado();
            this.Conecta();
        }
        public String Salvar(Estado obj)
        {
            string strSQL, msg;
            umEstado = obj;
            try
            {
                if (umEstado.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO estado (estado, cod_pais) VALUES ('" + umEstado.getEstado + "','"+umEstado.getumPais.GetCodigo +"')";
                }
                else
                {
                    strSQL = "UPDATE estado SET estado='" + umEstado.getEstado + "' ,cod_pais = '"+ umEstado.getumPais.GetCodigo + "'where codigo =" + Convert.ToString(umEstado.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Estado salvo com sucesso!";
                return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Estado Carrega(Estado obj)
        {
            Estado umEstado;
            umEstado = obj;
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            OleDbDataAdapter adapter, adapter2;
            adapter = new OleDbDataAdapter("SELECT * from estado where codigo = " + umEstado.GetCodigo, objConnection);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            umEstado.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
            umEstado.getEstado = dt.Rows[0]["estado"].ToString();
            umEstado.getumPais.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_pais"].ToString());

            adapter2 = new OleDbDataAdapter("SELECT * from pais where codigo = " + umEstado.getumPais.GetCodigo, objConnection);
            adapter2.Fill(ds2);
            DataTable dt2 = ds2.Tables[0];
            umEstado.getumPais.GetPais = dt2.Rows[0]["pais"].ToString();

            return umEstado;
        }
        public String Excluir(Estado obj)
        {
            String strSQL, msg;
            umEstado = obj;
            try
            {
                strSQL = "delete from estado where codigo = " + umEstado.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Estado excluido com sucesso!";
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
            string strSelect = "SELECT * from estado ORDER BY codigo";
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
