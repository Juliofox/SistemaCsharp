using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospedagem.classes
{
    public class DaoEmpresa : DAO
    {
        Empresa umaEmpresa;
        Cidade umaCidade;

        public DaoEmpresa()
        {
            umaCidade = new Cidade();
            umaEmpresa = new Empresa();
            this.Conecta();
        }
        public String Salvar(Empresa obj)
        {
            string strSQL, msg;
            umaEmpresa = obj;
            try
            {
                if (umaEmpresa.GetCodigo == 0)
                {
                    strSQL = "INSERT INTO empresa (nome, logradouro, numero, complemento, bairro, cep, telefone, celular, email, data_nascimento, rg, cpf, cod_cidade, data_cad, data_alt) VALUES ('" + umaEmpresa.GetNome + "','" + umaEmpresa.GetLogradouro + "','" + umaEmpresa.GetNumero + "','" + umaEmpresa.GetComplemento + "','" + umaEmpresa.GetBairro + "','" + umaEmpresa.GetCep + "','" + umaEmpresa.GetTelefone + "','" + umaEmpresa.GetCelular + "','" + umaEmpresa.GetEmail + "','" + Convert.ToString(umaEmpresa.GetData_nascimento) + "','" + umaEmpresa.GetIe + "','" + umaEmpresa.GetCnpj + "','" + Convert.ToString(umaEmpresa.getumaCidade.GetCodigo) + "','" + Convert.ToString(umaEmpresa.GetData_cad) + "','" + Convert.ToString(umaEmpresa.GetData_alt) + "')";
                }
                else
                {
                    strSQL = "UPDATE empresa SET nome='" + umaEmpresa.GetNome + "' ,logradouro = '" + umaEmpresa.GetLogradouro + "', numero='" + umaEmpresa.GetNumero + "',complemento='" + umaEmpresa.GetComplemento + "',bairro='" + umaEmpresa.GetBairro + "',cep='" + umaEmpresa.GetCep + "',telefone='" + umaEmpresa.GetTelefone + "',celular='" + umaEmpresa.GetCelular + "',email='" + umaEmpresa.GetEmail + "',data_nascimento='" + Convert.ToString(umaEmpresa.GetData_nascimento) + "',rg='" + umaEmpresa.GetIe + "',cpf='" + umaEmpresa.GetCnpj + "',cod_cidade='" + Convert.ToString(umaEmpresa.getumaCidade.GetCodigo) + "',data_cad='" + Convert.ToString(umaEmpresa.GetData_cad) + "', data_alt='" + Convert.ToString(umaEmpresa.GetData_alt) + "'where codigo =" + Convert.ToString(umaEmpresa.GetCodigo);
                }

                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Empresa salva com sucesso!";
                //return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        public Empresa Carrega(Empresa obj)
        {
            umaEmpresa = obj;
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                OleDbDataAdapter adapter, adapter2, adapter3;
                adapter = new OleDbDataAdapter("SELECT * from empresa where codigo = " + umaEmpresa.GetCodigo, objConnection);
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                umaEmpresa.GetCodigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                umaEmpresa.GetBairro = dt.Rows[0]["bairro"].ToString();
                umaEmpresa.GetCelular = dt.Rows[0]["celular"].ToString();
                umaEmpresa.GetCep = dt.Rows[0]["cep"].ToString();
                umaEmpresa.GetComplemento = dt.Rows[0]["complemento"].ToString();
                umaEmpresa.GetCnpj = dt.Rows[0]["cpf"].ToString();
                umaEmpresa.GetData_alt = Convert.ToDateTime(dt.Rows[0]["data_alt"].ToString());
                umaEmpresa.GetData_cad = Convert.ToDateTime(dt.Rows[0]["data_cad"].ToString());
                umaEmpresa.GetData_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"].ToString());
                umaEmpresa.GetEmail = dt.Rows[0]["email"].ToString();
                umaEmpresa.GetLogradouro = dt.Rows[0]["logradouro"].ToString();
                umaEmpresa.GetNome = dt.Rows[0]["nome"].ToString();
                umaEmpresa.GetNumero = dt.Rows[0]["numero"].ToString();
                umaEmpresa.GetIe = dt.Rows[0]["rg"].ToString();
                umaEmpresa.GetTelefone = dt.Rows[0]["telefone"].ToString();
                umaEmpresa.getumaCidade.GetCodigo = Convert.ToInt32(dt.Rows[0]["cod_cidade"].ToString());

                adapter2 = new OleDbDataAdapter("SELECT * from cidade where codigo = " + umaEmpresa.getumaCidade.GetCodigo, objConnection);
                adapter2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                umaEmpresa.getumaCidade.GetCidade = dt2.Rows[0]["cidade"].ToString();

                adapter3 = new OleDbDataAdapter("SELECT * from estado where codigo = " + dt2.Rows[0]["cod_estado"].ToString(), objConnection);
                adapter3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                umaEmpresa.getumaCidade.getumEstado.getEstado = dt3.Rows[0]["estado"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return umaEmpresa;
        }
        public String Excluir(Empresa obj)
        {
            String strSQL, msg;
            umaEmpresa = obj;
            try
            {
                strSQL = "delete from empresa where codigo = " + umaEmpresa.GetCodigo;
                objCommand = new OleDbCommand(strSQL, objConnection);
                objCommand.ExecuteNonQuery();
                msg = "Empresa excluida com sucesso!";

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
                String strSelect = "SELECT * from empresa ORDER BY codigo";
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
