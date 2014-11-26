using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospedagem.classes
{
    public class DaoCliente : DAO
    {
        Cliente umCliente;
        Cidade umaCidade;

        public DaoCliente()
        {
            umaCidade = new Cidade();
            umCliente = new Cliente();
            this.Conecta();
        }
        public String Salvar(Cliente obj)
        {
            string strSQL, msg;
            umCliente = obj;
            try
            {
                if (umCliente.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO cliente (nome, logradouro, numero, complemento, bairro, cep, telefone, celular, email, data_nascimento, rg, cpf, cod_cidade, data_cad, data_alt) VALUES ('" + umCliente.GetNome + "','" + umCliente.GetLogradouro + "','" + umCliente.GetNumero + "','" + umCliente.GetComplemento + "','" + umCliente.GetBairro + "','" + umCliente.GetCep + "','" + umCliente.GetTelefone + "','" + umCliente.GetCelular + "','" + umCliente.GetEmail + "','" + Convert.ToString(umCliente.GetData_nascimento) + "','" + umCliente.GetRg + "','" + umCliente.GetCpf + "','" + Convert.ToString(umCliente.getumaCidade.GetCodigo) + "','" + Convert.ToString(umCliente.GetData_cad) + "','" + Convert.ToString(umCliente.GetData_alt) + "')";
                }
                else
                {
                    strSQL = "UPDATE cliente SET nome='" + umCliente.GetNome + "' ,logradouro = '" + umCliente.GetLogradouro + "', numero='" + umCliente.GetNumero + "',complemento='" + umCliente.GetComplemento + "',bairro='" + umCliente.GetBairro + "',cep='" + umCliente.GetCep + "',telefone='" + umCliente.GetTelefone + "',celular='" + umCliente.GetCelular + "',email='" + umCliente.GetEmail + "',data_nascimento='" + Convert.ToString(umCliente.GetData_nascimento) + "',rg='" + umCliente.GetRg + "',cpf='" + umCliente.GetCpf + "',cod_cidade='" + Convert.ToString(umCliente.getumaCidade.GetCodigo) + "',data_cad='" + Convert.ToString(umCliente.GetData_cad) + "', data_alt='" + Convert.ToString(umCliente.GetData_alt) + "'where codigo =" + Convert.ToString(umCliente.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Cliente salvo com sucesso!";
                //return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Cliente Carrega(Cliente obj)
        {
            umCliente = obj;
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                OleDbDataAdapter adapter, adapter2, adapter3;
                adapter = new OleDbDataAdapter("SELECT * from cliente where codigo = " + umCliente.GetCodigo, objConnection);
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                umCliente.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                umCliente.GetBairro = dt.Rows[0]["bairro"].ToString();
                umCliente.GetCelular = dt.Rows[0]["celular"].ToString();
                umCliente.GetCep = dt.Rows[0]["cep"].ToString();
                umCliente.GetComplemento = dt.Rows[0]["complemento"].ToString();
                umCliente.GetCpf = dt.Rows[0]["cpf"].ToString();
                umCliente.GetData_alt = Convert.ToDateTime(dt.Rows[0]["data_alt"].ToString());
                umCliente.GetData_cad = Convert.ToDateTime(dt.Rows[0]["data_cad"].ToString());
                umCliente.GetData_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"].ToString());
                umCliente.GetEmail = dt.Rows[0]["email"].ToString();
                umCliente.GetLogradouro = dt.Rows[0]["logradouro"].ToString();
                umCliente.GetNome = dt.Rows[0]["nome"].ToString();
                umCliente.GetNumero = dt.Rows[0]["numero"].ToString();
                umCliente.GetRg = dt.Rows[0]["rg"].ToString();
                umCliente.GetTelefone = dt.Rows[0]["telefone"].ToString();
                umCliente.getumaCidade.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_cidade"].ToString());

                adapter2 = new OleDbDataAdapter("SELECT * from cidade where codigo = " + umCliente.getumaCidade.GetCodigo, objConnection);
                adapter2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                umCliente.getumaCidade.GetCidade = dt2.Rows[0]["cidade"].ToString();

                adapter3 = new OleDbDataAdapter("SELECT * from estado where codigo = " + dt2.Rows[0]["cod_estado"].ToString(), objConnection);
                adapter3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                umCliente.getumaCidade.getumEstado.getEstado = dt3.Rows[0]["estado"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return umCliente;
        }
        public String Excluir(Cliente obj)
        {
            String strSQL, msg;
            umCliente = obj;
            try
            {
                strSQL = "delete from cliente where codigo = " + umCliente.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Cliente excluido com sucesso!";
                
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
                String strSelect = "SELECT * from cliente ORDER BY codigo";
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
