using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospedagem.classes
{
    public class DaoContaReceber : DAO
    {
        Cliente umCliente;
        ContasReceber umaContaReceber;
        Boleto umBoleto;

        public DaoContaReceber()
        {
            umaContaReceber = new ContasReceber();
            umCliente = new Cliente();
            this.Conecta();
        }
        public String Salvar(ContasReceber obj)
        {
            string strSQL, msg;
            umaContaReceber = obj;
            try
            {
                if (umaContaReceber.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO contas_receber (cod_cliente, valor, data_documento, data_vencimento, nosso_numero, numero_documento, situacao, servico) VALUES ('" + Convert.ToString(umaContaReceber.GetumCliente.GetCodigo) + "','" + Convert.ToString(umaContaReceber.GetValor) + "','" + Convert.ToString(umaContaReceber.GetData_documento) + "','" + Convert.ToString(umaContaReceber.GetData_vencimento) + "','" + Convert.ToString(umaContaReceber.GetNossoNumero) + "','" + Convert.ToString(umaContaReceber.GetNumeroDocumento) + "','" + umaContaReceber.GetSituacao + "','"+umaContaReceber.GetServico+"')";
                }
                else
                {
                    strSQL = "UPDATE contas_receber SET valor = '" + Convert.ToString(umaContaReceber.GetValor) + "',data_documento='" + Convert.ToString(umaContaReceber.GetData_documento) + "',data_vencimento='" + umaContaReceber.GetData_vencimento + "',situacao='" + umaContaReceber.GetSituacao + "',servico='"+umaContaReceber.GetServico+"'where codigo =" + Convert.ToString(umaContaReceber.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Conta à Receber salva com sucesso!";
                //return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public ContasReceber Carrega(ContasReceber obj)
        {
            umaContaReceber = obj;
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                DataSet ds4 = new DataSet();
                OleDbDataAdapter adapter, adapter2, adapter3, adapter4;
                adapter = new OleDbDataAdapter("SELECT * from contas_receber where codigo = " + umaContaReceber.GetCodigo, objConnection);
                adapter.Fill(ds);
                
                
                DataTable dt = ds.Tables[0];

                umaContaReceber.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                umaContaReceber.GetData_documento = Convert.ToDateTime(dt.Rows[0]["data_documento"].ToString());
                umaContaReceber.GetData_vencimento = Convert.ToDateTime(dt.Rows[0]["data_vencimento"].ToString());
                umaContaReceber.GetNossoNumero = Convert.ToInt32(dt.Rows[0]["nosso_numero"].ToString());
                umaContaReceber.GetNumeroDocumento = Convert.ToInt32(dt.Rows[0]["numero_documento"].ToString());
                umaContaReceber.GetSituacao = dt.Rows[0]["situacao"].ToString();
                umaContaReceber.GetServico = dt.Rows[0]["servico"].ToString();
                umaContaReceber.GetumCliente.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_cliente"].ToString());
                umaContaReceber.GetValor = Convert.ToDecimal(dt.Rows[0]["valor"].ToString());

                adapter2 = new OleDbDataAdapter("SELECT * from cliente where codigo = " + umaContaReceber.GetumCliente.GetCodigo, objConnection);
                adapter2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                umaContaReceber.GetumCliente.GetNome = dt2.Rows[0]["nome"].ToString();
                umaContaReceber.GetumCliente.GetLogradouro = dt2.Rows[0]["logradouro"].ToString();
                umaContaReceber.GetumCliente.GetNumero = dt2.Rows[0]["numero"].ToString();
                umaContaReceber.GetumCliente.getumaCidade.GetCodigo = Convert.ToInt32(dt2.Rows[0]["cod_cidade"].ToString());

                adapter3 = new OleDbDataAdapter("SELECT * from cidade where codigo = " + umaContaReceber.GetumCliente.getumaCidade.GetCodigo, objConnection);
                adapter3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                umaContaReceber.GetumCliente.getumaCidade.GetCidade = dt3.Rows[0]["cidade"].ToString();
                umaContaReceber.GetumCliente.getumaCidade.getumEstado.GetCodigo = Convert.ToInt32(dt3.Rows[0]["cod_estado"].ToString());
                
                adapter4 = new OleDbDataAdapter("SELECT * from estado where codigo = " + umaContaReceber.GetumCliente.getumaCidade.getumEstado.GetCodigo, objConnection);
                adapter4.Fill(ds4);
                DataTable dt4 = ds4.Tables[0];
                umaContaReceber.GetumCliente.getumaCidade.getumEstado.getEstado = dt4.Rows[0]["estado"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return umaContaReceber;
        }
        public DataTable CarregaGrid()
        {
            DataTable dtLista = new DataTable();
            try
            {
                String strSelect = "SELECT * from contas_receber ORDER BY codigo DESC";
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
        public int LastNossonumero()
        {
            int total;
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter;
            adapter = new OleDbDataAdapter("SELECT MAX (nosso_numero) from contas_receber ", objConnection);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            total = dt.Rows.Count + 1;
           return total;
        }
        public int LastDocumento()
        {
            int total;
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter;
            adapter = new OleDbDataAdapter("SELECT numero_documento from contas_receber order by numero_documento DESC", objConnection);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            total = Convert.ToInt32(dt.Rows[0]["numero_documento"].ToString()) + 1;
            return total;
        }
        public String SalvarBoleto(Boleto obj)
        {
            umBoleto = new Boleto();
            string strSQL, msg;
            umBoleto = obj;
            try
            {
                strSQL = "INSERT INTO boleto(valor, data_vencimento, data_documento, nosso_numero, numero_documento, demonstrativo1, demonstrativo2, cod_empresa, cod_cliente) VALUES ('" + Convert.ToString(umBoleto.GetValor) + "','" + Convert.ToString(umBoleto.GetDataVencimento) + "','" + Convert.ToString(umBoleto.GetDataDocumento) + "','" + Convert.ToString(umBoleto.GetNossoNumero) + "','" + Convert.ToString(umBoleto.GetNumeroDocumento) + "','" + umBoleto.GetDemonstrativo1 + "','" + umBoleto.GetDemonstrativo2 + "','" + Convert.ToString(umBoleto.GetumEmpresa.GetCodigo) + "','"+Convert.ToString(umBoleto.GetumCliente.GetCodigo)+"')";
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Boleto gerado com sucesso!";
                //return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Boleto CarregaBoleto(Boleto obj)
        {
            umBoleto = obj;
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                DataSet ds4 = new DataSet();
                DataSet ds5 = new DataSet();
                
                OleDbDataAdapter adapter, adapter2, adapter3, adapter4, adapter5;
                adapter = new OleDbDataAdapter("SELECT * from boleto where codigo = " + umBoleto.GetCodigo, objConnection);
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                umBoleto.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                umBoleto.GetDataDocumento = Convert.ToDateTime(dt.Rows[0]["data_documento"].ToString());
                umBoleto.GetDataVencimento = Convert.ToDateTime(dt.Rows[0]["data_vencimento"].ToString());
                umBoleto.GetNossoNumero = Convert.ToInt32(dt.Rows[0]["nosso_numero"].ToString());
                umBoleto.GetNumeroDocumento = Convert.ToInt32(dt.Rows[0]["numero_documento"].ToString());
                umBoleto.GetSituacao = dt.Rows[0]["situacao"].ToString();
                umBoleto.GetDemonstrativo1 = dt.Rows[0]["demonstrativo1"].ToString();
                umBoleto.GetDemonstrativo2 = dt.Rows[0]["demonstrativo2"].ToString();
                umBoleto.GetumCliente.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_cliente"].ToString());
                umBoleto.GetumEmpresa.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_empresa"].ToString());
                umBoleto.GetValor = Convert.ToDecimal(dt.Rows[0]["valor"].ToString());

                adapter2 = new OleDbDataAdapter("SELECT * from cliente where codigo = " + umBoleto.GetumCliente.GetCodigo, objConnection);
                adapter2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                umBoleto.GetumCliente.GetNome = dt2.Rows[0]["nome"].ToString();
                umBoleto.GetumCliente.GetLogradouro = dt2.Rows[0]["logradouro"].ToString();
                umBoleto.GetumCliente.GetNumero = dt2.Rows[0]["numero"].ToString();
                umBoleto.GetumCliente.GetCpf = dt2.Rows[0]["cpf"].ToString();
                umBoleto.GetumCliente.getumaCidade.GetCodigo = Convert.ToInt32(dt2.Rows[0]["cod_cidade"].ToString());

                adapter3 = new OleDbDataAdapter("SELECT * from cidade where codigo = " + umBoleto.GetumCliente.getumaCidade.GetCodigo, objConnection);
                adapter3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                umBoleto.GetumCliente.getumaCidade.GetCidade = dt3.Rows[0]["cidade"].ToString();

                adapter4 = new OleDbDataAdapter("SELECT * from empresa where codigo = " + umBoleto.GetumEmpresa.GetCodigo, objConnection);
                adapter4.Fill(ds4);
                DataTable dt4 = ds4.Tables[0];
                umBoleto.GetumEmpresa.GetNome = dt4.Rows[0]["nome"].ToString();
                umBoleto.GetumEmpresa.GetLogradouro = dt4.Rows[0]["logradouro"].ToString();
                umBoleto.GetumEmpresa.GetNumero = dt4.Rows[0]["numero"].ToString();
                umBoleto.GetumEmpresa.GetCnpj = dt4.Rows[0]["cpf"].ToString();
                umBoleto.GetumEmpresa.getumaCidade.GetCodigo = Convert.ToInt32(dt4.Rows[0]["cod_cidade"].ToString());

                adapter5 = new OleDbDataAdapter("SELECT * from cidade where codigo = " + umBoleto.GetumEmpresa.getumaCidade.GetCodigo, objConnection);
                adapter5.Fill(ds5);
                DataTable dt5 = ds5.Tables[0];
                umBoleto.GetumEmpresa.getumaCidade.GetCidade = dt5.Rows[0]["cidade"].ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return umBoleto;
        }
        public DataTable CarregaGridBoleto()
        {
            DataTable dtLista = new DataTable();
            try
            {
                String strSelect = "SELECT * from boleto ORDER BY codigo DESC";
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
