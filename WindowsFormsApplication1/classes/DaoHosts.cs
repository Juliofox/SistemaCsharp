using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospedagem.classes
{
    public class DaoHosts : DAO
    {
        Hosts umHost;
        Plano umPlano;
        Cliente umCliente;

        public DaoHosts()
        {
            umHost = new Hosts();
            umCliente = new Cliente();
            umPlano = new Plano();
            this.Conecta();
        }
        public String Salvar(Hosts obj)
        {
            string strSQL, msg;
            umHost = obj;
            try
            {
                if (umHost.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO hosts (dominio, cod_plano, cod_cliente, data_inicio, data_fim, situacao) VALUES ('" + umHost.GetDominio + "','" + Convert.ToInt32(umHost.Getumplano.GetCodigo) + "','" + Convert.ToInt32(umHost.Getumcliente.GetCodigo) + "','" + Convert.ToDateTime(umHost.GetDatainicio) + "','" + Convert.ToDateTime(umHost.GetDatafim) + "','" + umHost.GetSituacao + "')";
                }
                else
                {
                    strSQL = "UPDATE hosts SET dominio='" + umHost.GetDominio + "' ,cod_plano = '" + Convert.ToInt32(umHost.Getumplano.GetCodigo) + "', cod_cliente='" + Convert.ToInt32(umHost.Getumcliente.GetCodigo) + "',data_inicio='" + Convert.ToDateTime(umHost.GetDatainicio) + "',data_fim='" + Convert.ToDateTime(umHost.GetDatafim) +"',situacao='"+umHost.GetSituacao+ "'where codigo =" + Convert.ToString(umHost.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Hospedagem salva com sucesso!";
                //return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Hosts Carrega(Hosts obj)
        {
            umHost = obj;
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                OleDbDataAdapter adapter, adapter2, adapter3;
                adapter = new OleDbDataAdapter("SELECT * from hosts where codigo = " + umHost.GetCodigo, objConnection);
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                umHost.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                umHost.GetDominio = dt.Rows[0]["dominio"].ToString();
                umHost.Getumplano.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_plano"].ToString());
                umHost.Getumcliente.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_cliente"].ToString());
                umHost.GetDatainicio = Convert.ToDateTime(dt.Rows[0]["data_inicio"].ToString());
                umHost.GetDatafim = Convert.ToDateTime(dt.Rows[0]["data_fim"].ToString());
                umHost.GetSituacao = dt.Rows[0]["situacao"].ToString();

                adapter2 = new OleDbDataAdapter("SELECT * from plano where codigo = " + umHost.Getumplano.GetCodigo, objConnection);
                adapter2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                umHost.Getumplano.GetNome = dt2.Rows[0]["nome"].ToString();

                adapter3 = new OleDbDataAdapter("SELECT * from cliente where codigo = " + umHost.Getumcliente.GetCodigo, objConnection);
                adapter3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                umHost.Getumcliente.GetNome = dt3.Rows[0]["nome"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return umHost;
        }
        public String Excluir(Hosts obj)
        {
            String strSQL, msg;
            umHost = obj;
            try
            {
                strSQL = "delete from hosts where codigo = " + umHost.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Hospedagem excluida com sucesso!";

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public DataTable CarregaGrid()
        {
            DataTable dtLista = new DataTable();
            try
            {
                String strSelect = "SELECT * from hosts ORDER BY codigo";
                objCommand = new OleDbCommand(strSelect, objConnection);
                OleDbDataAdapter objAdp = new OleDbDataAdapter(objCommand);
                objAdp.Fill(dtLista);
                //dataGridView1.DataSource = dtLista;
                objConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtLista;
        }
        public DataTable CarregaServico(int codigo)
        {
            DataTable dtLista = new DataTable();
            try
            {
                String strSelect = "SELECT * from hosts where cod_cliente = " + codigo;
                objCommand = new OleDbCommand(strSelect, objConnection);
                OleDbDataAdapter objAdp = new OleDbDataAdapter(objCommand);
                objAdp.Fill(dtLista);
                //dataGridView1.DataSource = dtLista;
                objConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtLista;
        }
    }
}
