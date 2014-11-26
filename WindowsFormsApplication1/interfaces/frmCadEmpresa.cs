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
    public partial class frmCadEmpresa : Form
    {
        public Empresa umaEmpresa;
        Cidade umaCidade;
        DaoEmpresa umaDaoEmpresa;
        DaoCidade umaDaoCidade;
        frmConCidade consultaCidade;
        public frmCadEmpresa()
        {
            InitializeComponent();
            umaEmpresa = new Empresa();
            umaCidade = new Cidade();
            umaDaoEmpresa = new DaoEmpresa();
            umaDaoCidade = new DaoCidade();
        }
        public void CarregaObjForm(Empresa obj)
        {
            this.txtBairro.Text = obj.GetBairro;
            this.txtCep.Text = obj.GetCep;
            this.txtCidade.Text = obj.getumaCidade.GetCidade;
            this.txtcodCidade.Text = Convert.ToString(obj.getumaCidade.GetCodigo);
            this.txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            this.txtComplemento.Text = obj.GetComplemento;
            this.txtCpf.Text = obj.GetCnpj;
            this.txtDataAlt.Value = obj.GetData_alt;
            this.txtDataCad.Value = obj.GetData_cad;
            this.txtDataFundacao.Value = obj.GetData_nascimento;
            this.txtEmail.Text = obj.GetEmail;
            this.txtEstado.Text = obj.getumaCidade.getumEstado.getEstado;
            this.txtLogradouro.Text = obj.GetLogradouro;
            this.txtNome.Text = obj.GetNome;
            this.txtNumero.Text = obj.GetNumero;
            this.txtRG.Text = obj.GetIe;
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
                MessageBox.Show("O campo Nome/Razão social é obrigatório!");
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
                umaEmpresa.GetBairro = txtBairro.Text;
                umaEmpresa.GetCelular = txtTelefone.Text;
                umaEmpresa.GetCep = txtCep.Text;
                umaEmpresa.GetCnpj = txtCpf.Text;
                umaEmpresa.GetComplemento = txtComplemento.Text;
                umaEmpresa.GetData_alt = txtDataAlt.Value;
                umaEmpresa.GetData_cad = txtDataCad.Value;
                umaEmpresa.GetData_nascimento = txtDataFundacao.Value;
                umaEmpresa.GetEmail = txtEmail.Text;
                umaEmpresa.GetIe = txtRG.Text;
                umaEmpresa.GetLogradouro = txtLogradouro.Text;
                umaEmpresa.GetNome = txtNome.Text;
                umaEmpresa.GetNumero = txtNumero.Text;
                umaEmpresa.GetTelefone = txtTelefone.Text;
                umaEmpresa.getumaCidade.GetCodigo = Convert.ToInt32(txtcodCidade.Text);
                if (this.btnCadastrar.Text == "Cadastrar")
                {
                    msg = umaDaoEmpresa.Salvar(umaEmpresa);
                    MessageBox.Show(msg);
                }
                else if (this.btnCadastrar.Text == "Editar")
                {
                    umaEmpresa.GetCodigo = Convert.ToInt32(this.txtCodigo.Text);
                    msg = umaDaoEmpresa.Salvar(umaEmpresa);
                    MessageBox.Show(msg);
                }
                else
                {
                    umaEmpresa.GetCodigo = Convert.ToInt32(this.txtCodigo.Text);
                    msg = umaDaoEmpresa.Excluir(umaEmpresa);
                    MessageBox.Show(msg);
                }
                Close();
            }

            
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
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
                consultaCidade.ConhecaObj(umaEmpresa.getumaCidade);
                consultaCidade.btnSair.Text = "Selecionar";
                consultaCidade.Show();
                txtcodCidade.Text = Convert.ToString(umaEmpresa.getumaCidade.GetCodigo);
                txtCidade.Text = umaEmpresa.getumaCidade.GetCidade;
                txtEstado.Text = umaEmpresa.getumaCidade.getumEstado.getEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
