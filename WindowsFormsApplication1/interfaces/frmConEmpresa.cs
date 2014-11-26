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
    public partial class frmConEmpresa : Form
    {
        DataTable lista;
        Empresa umaEmpresa;
        DaoEmpresa umaDaoEmpresa;
        public frmConEmpresa()
        {
            InitializeComponent();
            umaDaoEmpresa = new DaoEmpresa();
            lista = umaDaoEmpresa.CarregaGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadEmpresa cadEmpresa;
            cadEmpresa = new frmCadEmpresa();
            cadEmpresa.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (this.btnSair.Text == "Selecionar")
            {
                umaEmpresa.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                Empresa auxEmpresa = umaDaoEmpresa.Carrega(umaEmpresa);
                umaEmpresa.GetNome = auxEmpresa.GetNome;
                umaEmpresa.GetLogradouro = auxEmpresa.GetLogradouro;
                umaEmpresa.GetNumero = auxEmpresa.GetNumero;
                umaEmpresa.getumaCidade.GetCidade = auxEmpresa.getumaCidade.GetCidade;
                umaEmpresa.getumaCidade.getumEstado.getEstado = auxEmpresa.getumaCidade.getumEstado.getEstado;
                Close();
            }
            else
            {
                Close();
            }
        }

        private void frmConEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_friedrichdesignDataSet.empresa'. Você pode movê-la ou removê-la conforme necessário.
            //this.empresaTableAdapter.Fill(this.banco_friedrichdesignDataSet.empresa);
            this.grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                umaEmpresa = new Empresa();
                umaEmpresa.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                umaDaoEmpresa.Carrega(umaEmpresa);
                frmCadEmpresa cadEmpresa = new frmCadEmpresa();
                cadEmpresa.CarregaObjForm(umaEmpresa);
                cadEmpresa.btnCadastrar.Text = "Editar";
                cadEmpresa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                umaEmpresa = new Empresa();
                umaEmpresa.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                umaDaoEmpresa.Carrega(umaEmpresa);
                frmCadEmpresa cadEmpresa = new frmCadEmpresa();
                cadEmpresa.CarregaObjForm(umaEmpresa);
                cadEmpresa.btnCadastrar.Text = "Excluir";
                cadEmpresa.txtBairro.Enabled = false;
                cadEmpresa.txtCep.Enabled = false;
                cadEmpresa.txtcodCidade.Enabled = false;
                cadEmpresa.txtComplemento.Enabled = false;
                cadEmpresa.txtCpf.Enabled = false;
                cadEmpresa.txtDataFundacao.Enabled = false;
                cadEmpresa.txtEmail.Enabled = false;
                cadEmpresa.txtLogradouro.Enabled = false;
                cadEmpresa.txtNome.Enabled = false;
                cadEmpresa.txtNumero.Enabled = false;
                cadEmpresa.txtRG.Enabled = false;
                cadEmpresa.txtTelefone.Enabled = false;
                cadEmpresa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoEmpresa = new DaoEmpresa();
            lista = umaDaoEmpresa.CarregaGrid();
            grid.DataSource = lista;
        }
        public void ConhecaObj(Empresa obj)
        {
            umaEmpresa = obj;
            
        }
    }
}
