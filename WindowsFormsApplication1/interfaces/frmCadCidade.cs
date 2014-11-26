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
    public partial class frmCadCidade : Form
    {
        Cidade umaCidade;
        Estado umEstado;
        String msg;
        DaoCidade umaDaoCidade;
        DaoEstado umaDaoEstado;
        frmConEstado consultaEstado;
        public frmCadCidade()
        {
            InitializeComponent();
            umaCidade = new Cidade();
            umaDaoCidade = new DaoCidade();
            umaDaoEstado = new DaoEstado();
        }
        public void CarregaObjForm(Cidade obj)
        {
            this.txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            this.txtCidade.Text = obj.GetCidade;
            this.txtCodEstado.Text = Convert.ToString(obj.getumEstado.GetCodigo);
            this.txtEstado.Text = obj.getumEstado.getEstado;
            this.txtPais.Text = obj.getumEstado.getumPais.GetPais;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório!");
                txtCidade.Focus();
            }
            else if (txtCodEstado.Text == "")
            {
                MessageBox.Show("O campo Estado é obrigatório!");
                txtCodEstado.Focus();
            }
            else if (this.btnCadastrar.Text == "Cadastrar")
            {
                umaCidade.GetCidade = txtCidade.Text;
                umaCidade.getumEstado.GetCodigo = Convert.ToInt32(txtCodEstado.Text);
                msg = umaDaoCidade.Salvar(umaCidade);
                MessageBox.Show(msg);
                Close();
            }
            else if (this.btnCadastrar.Text == "Editar")
            {
                umaCidade.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                umaCidade.GetCidade = txtCidade.Text;
                umaCidade.getumEstado.GetCodigo = Convert.ToInt32(txtCodEstado.Text);
                msg = umaDaoCidade.Salvar(umaCidade);
                MessageBox.Show(msg);
                Close();
            }
            else 
            {
                umaCidade.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                umaCidade.GetCidade = txtCidade.Text;
                umaCidade.getumEstado.GetCodigo = Convert.ToInt32(txtCodEstado.Text);
                msg = umaDaoCidade.Excluir(umaCidade);
                MessageBox.Show(msg);
            }
        }

        private void txtCodEstado_Leave(object sender, EventArgs e)
        {
            try
            {
                umEstado = new Estado();
                umEstado.GetCodigo = Convert.ToInt32(txtCodEstado.Text);
                umaDaoEstado.Carrega(umEstado);
                txtEstado.Text = umEstado.getEstado;
                txtPais.Text = umEstado.getumPais.GetPais;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                consultaEstado = new frmConEstado();
                //umPais = new Pais();
                consultaEstado.ConhecaObj(umaCidade.getumEstado);
                consultaEstado.btnSair.Text = "Selecionar";
                consultaEstado.Show();
                txtCodEstado.Text = Convert.ToString(umaCidade.getumEstado.GetCodigo);
                txtEstado.Text = umaCidade.getumEstado.getEstado;
                txtPais.Text = umaCidade.getumEstado.getumPais.GetPais;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCadCidade_Load(object sender, EventArgs e)
        {

        }
    }
}
