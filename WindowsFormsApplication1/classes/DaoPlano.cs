using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospedagem.classes
{
    public class DaoPlano : DAO
    {
        Plano umPlano;
        public DaoPlano()
        {
            umPlano = new Plano();
            this.Conecta();
        }
        public String Salvar(Plano obj)
        {
            string strSQL, msg;
            umPlano = obj;
            try
            {
                if (umPlano.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO plano (nome, valor_mensal, valor_trimestral, valor_semestral, valor_anual) VALUES ('" + umPlano.GetNome + "','"+umPlano.GetValorMensal+"','"+umPlano.GetValorTrimestral+"','"+umPlano.GetValorSemestral+"','"+umPlano.GetValorAnual+"')";
                }
                else
                {
                    strSQL = "UPDATE plano SET nome='" + umPlano.GetNome + "',valor_mensal='"+umPlano.GetValorMensal+"',valor_trimestral='"+umPlano.GetValorTrimestral+"',valor_semestral='"+umPlano.GetValorSemestral+"',valor_anual='"+umPlano.GetValorAnual+"' where codigo =" + Convert.ToString(umPlano.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                
                msg = "Plano salvo com sucesso!";
                return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Plano Carrega(Plano obj)
        {
            Plano umPlano;
            umPlano = obj;
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter;
            adapter = new OleDbDataAdapter("SELECT * from plano where codigo = " + umPlano.GetCodigo, objConnection);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            umPlano.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
            umPlano.GetNome = dt.Rows[0]["nome"].ToString();
            umPlano.GetValorAnual = Convert.ToDecimal(dt.Rows[0]["valor_anual"].ToString());
            umPlano.GetValorMensal = Convert.ToDecimal(dt.Rows[0]["valor_mensal"].ToString());
            umPlano.GetValorSemestral = Convert.ToDecimal(dt.Rows[0]["valor_semestral"].ToString());
            umPlano.GetValorTrimestral = Convert.ToDecimal(dt.Rows[0]["valor_trimestral"].ToString());
            return umPlano;
        }
        public String Excluir(Plano obj)
        {
            String strSQL, msg;
            umPlano = obj;
            try
            {
                strSQL = "delete from plano where codigo = " + umPlano.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Plano excluido com sucesso!";
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
            String strSelect = "SELECT * from plano ORDER BY codigo";
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
