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
    public partial class frmCadEstado : Form
    {
        Estado umEstado;
        Pais umPais;
        DaoEstado umaDaoEstado;
        DaoPais umaDaoPais;
        frmConPais consultaPais;
        public frmCadEstado()
        {
            InitializeComponent();
            umEstado = new Estado();
            umaDaoEstado = new DaoEstado();
            umaDaoPais = new DaoPais();
        }
        public void CarregaObjForm(Estado obj)
        {
            txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            txtEstado.Text = obj.estado;
            txtCodPais.Text = Convert.ToString(obj.getumPais.GetCodigo);
            txtPais.Text = obj.getumPais.GetPais;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String msg;
            if (txtEstado.Text == "")
            {
                MessageBox.Show("O campo Estado é obrigatório!");
                txtEstado.Focus();
            }
            else if (txtCodPais.Text == "")
            {
                MessageBox.Show("O campo Pais é obrigatório!");
                txtCodPais.Focus();
            }
            else if (this.btnCadastrar.Text == "Cadastrar")
            {
                umEstado.getEstado = txtEstado.Text;
                umEstado.getumPais.GetCodigo = Convert.ToInt32(txtCodPais.Text);
                msg = umaDaoEstado.Salvar(umEstado);
                MessageBox.Show(msg);
                Close();
            }
            else if (this.btnCadastrar.Text == "Editar")
            {
                umEstado.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                umEstado.getEstado = txtEstado.Text;
                umEstado.getumPais.GetCodigo = Convert.ToInt32(txtCodPais.Text);
                msg = umaDaoEstado.Salvar(umEstado);
                MessageBox.Show(msg);
                Close();
            }
            else
            {
                umEstado.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                umEstado.getEstado = txtEstado.Text;
                umEstado.getumPais.GetCodigo = Convert.ToInt32(txtCodPais.Text);
                msg = umaDaoEstado.Excluir(umEstado);
                MessageBox.Show(msg);
                Close();
            }
        }

        private void frmCadEstado_Load(object sender, EventArgs e)
        {

        }

        private void txtCodPais_Leave(object sender, EventArgs e)
        {
            try
            {
                umPais = new Pais();
                umPais.GetCodigo = Convert.ToInt32(txtCodPais.Text);
                umaDaoPais.Carrega(umPais);
                txtPais.Text = umPais.GetPais;
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
                consultaPais = new frmConPais();
                //umPais = new Pais();
                consultaPais.ConhecaObj(umEstado.getumPais);
                consultaPais.btnSair.Text = "Selecionar";
                consultaPais.Show();
                txtCodPais.Text = Convert.ToString(umEstado.getumPais.GetCodigo);
                txtPais.Text = umEstado.getumPais.GetPais;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
