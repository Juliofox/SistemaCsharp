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
    public partial class frmCadPais : Form
    {
        Pais umPais;
        DaoPais umaDaoPais;
        public frmCadPais()
        {
            InitializeComponent();
            umPais = new Pais();
            umaDaoPais = new DaoPais();
        }
        public void carregaObjForm(Pais obj)
        {
            umPais = new Pais();
            umPais = obj;
            this.txtCodigo.Text = Convert.ToString(umPais.GetCodigo);
            this.txtPais.Text = umPais.GetPais;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String msg;
            if (txtPais.Text == "")
            {
                MessageBox.Show("O campo País é obrigatório!");
                txtPais.Focus();
            }
            else
            {
                if (this.btnCadastrar.Text == "Cadastrar")
                {
                    umPais.GetPais = txtPais.Text;
                    msg = umaDaoPais.Salvar(umPais);
                    MessageBox.Show(msg);
                    Close();
                }
                else if (this.btnCadastrar.Text == "Editar")
                {
                    umPais.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                    umPais.GetPais = txtPais.Text;
                    msg = umaDaoPais.Salvar(umPais);
                    MessageBox.Show(msg);
                    Close();
                }
                else
                {
                    umPais.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                    umPais.GetPais = txtPais.Text;
                    msg = umaDaoPais.Excluir(umPais);
                    MessageBox.Show(msg);
                    Close();
                }
                

            }
        }

        private void frmCadPais_Load(object sender, EventArgs e)
        {

        }
    }
}
