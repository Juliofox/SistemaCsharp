using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospedagem.classes;

namespace WindowsFormsApplication1.interfaces
{
    public partial class frmCadCliente : Form
    {
        Cliente umCliente;
        Cidade umaCidade;
        DaoCliente umaDaoCliente;
        DaoCidade umaDaoCidade;
        frmConCidade consultaCidade;

        public frmCadCliente()
        {
            InitializeComponent();
            umCliente = new Cliente();
            umaCidade = new Cidade();
            umaDaoCliente = new DaoCliente();
            umaDaoCidade = new DaoCidade();
        }
        public void CarregaObjForm(Cliente obj)
        {
            this.txtBairro.Text = obj.GetBairro;
            this.txtCep.Text = obj.GetCep;
            this.txtCidade.Text = obj.getumaCidade.GetCidade;
            this.txtcodCidade.Text = Convert.ToString(obj.getumaCidade.GetCodigo);
            this.txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            this.txtComplemento.Text = obj.GetComplemento;
            this.txtCpf.Text = obj.GetCpf;
            this.txtDataAlt.Value = obj.GetData_alt;
            this.txtDataCad.Value = obj.GetData_cad;
            this.txtDataNascimento.Value = obj.GetData_nascimento;
            this.txtEmail.Text = obj.GetEmail;
            this.txtEstado.Text = obj.getumaCidade.getumEstado.getEstado;
            this.txtLogradouro.Text = obj.GetLogradouro;
            this.txtNome.Text = obj.GetNome;
            this.txtNumero.Text = obj.GetNumero;
            this.txtRG.Text = obj.GetRg;
            this.txtTelefone.Text = obj.GetTelefone;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String msg;
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório!");
                txtNome.Focus();
            }
            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("O campo Logradouro é obrigatório!");
                txtLogradouro.Focus();
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("O campo Número é obrigatório!");
                txtNumero.Focus();
            }
            else if (txtcodCidade.Text == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório!");
                txtcodCidade.Focus();
            }
            else
            {
                umCliente.GetBairro = txtBairro.Text;
                umCliente.GetCelular = txtTelefone.Text;
                umCliente.GetCep = txtCep.Text;
                umCliente.GetComplemento = txtComplemento.Text;
                umCliente.GetCpf = txtCpf.Text;
                umCliente.GetData_nascimento = txtDataNascimento.Value;
                umCliente.GetData_alt = txtDataAlt.Value;
                umCliente.GetData_cad = txtDataCad.Value;
                umCliente.GetEmail = txtEmail.Text;
                umCliente.GetLogradouro = txtLogradouro.Text;
                umCliente.GetNome = txtNome.Text;
                umCliente.GetNumero = txtNumero.Text;
                umCliente.GetRg = txtRG.Text;
                umCliente.GetTelefone = txtTelefone.Text;
                umCliente.getumaCidade.GetCodigo = Convert.ToInt32(txtcodCidade.Text);
                if (this.btnCadastrar.Text == "Cadastrar")
                {
                    msg = umaDaoCliente.Salvar(umCliente);
                    MessageBox.Show(msg);
                }
                else if (this.btnCadastrar.Text == "Editar")
                {
                    umCliente.GetCodigo = Convert.ToInt32(this.txtCodigo.Text);
                    msg = umaDaoCliente.Salvar(umCliente);
                    MessageBox.Show(msg);
                }
                else
                {
                    umCliente.GetCodigo = Convert.ToInt32(this.txtCodigo.Text);
                    msg = umaDaoCliente.Excluir(umCliente);
                    MessageBox.Show(msg);
                }
                Close();

            }
                       
            
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtcodCidade_Leave(object sender, EventArgs e)
        {
            try
            {
                umaCidade = new Cidade();
                umaCidade.GetCodigo = Convert.ToInt32(txtcodCidade.Text);
                umaDaoCidade.Carrega(umaCidade);
                txtCidade.Text = umaCidade.GetCidade;
                txtEstado.Text = umaCidade.getumEstado.getEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                consultaCidade = new frmConCidade();
                //umPais = new Pais();
                consultaCidade.ConhecaObj(umCliente.getumaCidade);
                consultaCidade.btnSair.Text = "Selecionar";
                consultaCidade.Show();
                txtcodCidade.Text = Convert.ToString(umCliente.getumaCidade.GetCodigo);
                txtCidade.Text = umCliente.getumaCidade.GetCidade;
                txtEstado.Text = umCliente.getumaCidade.getumEstado.getEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
