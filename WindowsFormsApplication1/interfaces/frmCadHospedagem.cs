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
    public partial class frmCadHospedagem : Form
    {
        Hosts umHost;
        Plano umPlano;
        Cliente umCliente;
        String situacao;
        DaoHosts umaDaoHosts;
        DaoPlano umaDaoPlano;
        DaoCliente umaDaocliente;
        frmConCliente consultaCliente;
        frmConPlano consultaPlano;
        public frmCadHospedagem()
        {
            InitializeComponent();
            umHost = new Hosts();
            umaDaoHosts = new DaoHosts();
            umaDaoPlano = new DaoPlano();
            umaDaocliente = new DaoCliente();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String msg;
            if (txtDominio.Text == "")
            {
                MessageBox.Show("O campo Domínio é obrigatório!");
                txtDominio.Focus();
            }
            else if (txtcodCliente.Text == "")
            {
                MessageBox.Show("O campo Cliente é obrigatório");
                txtcodCliente.Focus();
            }
            else if (txtcodPlano.Text == "")
            {
                MessageBox.Show("O campo Plano é obrigatório");
                txtcodPlano.Focus();
            }
            else
            {
                if (btnCadastrar.Text == "Cadastrar")
                {
                    umHost.GetDatafim = txtDataFim.Value;
                    umHost.GetDatainicio = txtDataInicio.Value;
                    umHost.GetDominio = txtDominio.Text;
                    umHost.GetSituacao = situacao;
                    umHost.Getumcliente.GetCodigo = Convert.ToInt32(txtcodCliente.Text);
                    umHost.Getumplano.GetCodigo = Convert.ToInt32(txtcodPlano.Text);
                    msg = umaDaoHosts.Salvar(umHost);
                    MessageBox.Show(msg);
                    Close();
                }
                else if (btnCadastrar.Text == "Editar")
                {
                    umHost.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                    umHost.GetDatafim = txtDataFim.Value;
                    umHost.GetDatainicio = txtDataInicio.Value;
                    umHost.GetDominio = txtDominio.Text;
                    umHost.GetSituacao = situacao;
                    umHost.Getumcliente.GetCodigo = Convert.ToInt32(txtcodCliente.Text);
                    umHost.Getumplano.GetCodigo = Convert.ToInt32(txtcodPlano.Text);
                    msg = umaDaoHosts.Salvar(umHost);
                    MessageBox.Show(msg);
                    Close();
                }
                

            }
        }

        private void rAtivo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Ativo";
        }

        private void rCongelado_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Congelado";
        }

        private void txtcodPlano_Leave(object sender, EventArgs e)
        {
            try
            {
                umPlano = new Plano();
                umPlano.GetCodigo = Convert.ToInt32(txtcodPlano.Text);
                umaDaoPlano.Carrega(umPlano);
                txtPlano.Text = umPlano.GetNome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtcodCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                umCliente = new Cliente();
                umCliente.GetCodigo = Convert.ToInt32(txtcodCliente.Text);
                umaDaocliente.Carrega(umCliente);
                txtCliente.Text = umCliente.GetNome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarPlano_Click(object sender, EventArgs e)
        {
            try
            {
                consultaPlano = new frmConPlano();
                //umPais = new Pais();
                consultaPlano.ConhecaObj(umHost.Getumplano);
                consultaPlano.btnSair.Text = "Selecionar";
                consultaPlano.Show();
                txtcodPlano.Text = Convert.ToString(umHost.Getumplano.GetCodigo);
                txtPlano.Text = umHost.Getumplano.GetNome;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                consultaCliente = new frmConCliente();
                //umPais = new Pais();
                consultaCliente.ConhecaObj(umHost.Getumcliente);
                consultaCliente.btnSair.Text = "Selecionar";
                consultaCliente.Show();
                txtcodCliente.Text = Convert.ToString(umHost.Getumcliente.GetCodigo);
                txtCliente.Text = umHost.Getumcliente.GetNome;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CarregaObjForm(Hosts obj)
        {
            String situacao;
            txtCliente.Text = obj.Getumcliente.GetNome;
            txtcodCliente.Text = Convert.ToString(obj.Getumcliente.GetCodigo);
            txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            txtcodPlano.Text = Convert.ToString(obj.Getumplano.GetCodigo);
            txtDataFim.Value = obj.GetDatafim;
            txtDataInicio.Value = obj.GetDatainicio;
            txtDominio.Text = obj.GetDominio;
            txtPlano.Text = obj.Getumplano.GetNome;
            situacao = obj.GetSituacao;
            if (situacao == "Ativo")
                this.rAtivo.Checked = true;
            else
                this.rCongelado.Checked = true;
        }

        private void frmCadHospedagem_Load(object sender, EventArgs e)
        {

        }
    }
}
