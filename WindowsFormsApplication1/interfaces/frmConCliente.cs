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
    public partial class frmConCliente : Form
    {
        DataTable lista;
        Cliente umCliente;
        DaoCliente umaDaoCliente;
        public frmConCliente()
        {
            InitializeComponent();
            umaDaoCliente = new DaoCliente();
            lista = umaDaoCliente.CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (this.btnSair.Text == "Selecionar")
            {
                umCliente.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                umCliente.GetNome = grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadCliente CadCliente;
            CadCliente = new frmCadCliente();
            CadCliente.Show();
        }

        private void frmConCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_friedrichdesignDataSet.cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.banco_friedrichdesignDataSet.cliente);
            this.grid.DataSource = lista;
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoCliente = new DaoCliente();
            lista = umaDaoCliente.CarregaGrid();
            grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            umCliente = new Cliente();
            umCliente.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoCliente.Carrega(umCliente);
            frmCadCliente cadCliente = new frmCadCliente();
            cadCliente.CarregaObjForm(umCliente);
            cadCliente.btnCadastrar.Text = "Editar";
            cadCliente.Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            umCliente = new Cliente();
            umCliente.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoCliente.Carrega(umCliente);
            frmCadCliente cadCliente = new frmCadCliente();
            cadCliente.CarregaObjForm(umCliente);
            cadCliente.btnCadastrar.Text = "Excluir";
            cadCliente.txtBairro.Enabled = false;
            cadCliente.txtCep.Enabled = false;
            cadCliente.txtcodCidade.Enabled = false;
            cadCliente.txtComplemento.Enabled = false;
            cadCliente.txtCpf.Enabled = false;
            cadCliente.txtDataNascimento.Enabled = false;
            cadCliente.txtEmail.Enabled = false;
            cadCliente.txtLogradouro.Enabled = false;
            cadCliente.txtNome.Enabled = false;
            cadCliente.txtNumero.Enabled = false;
            cadCliente.txtRG.Enabled = false;
            cadCliente.txtTelefone.Enabled = false;
            cadCliente.Show();
        }
        public void ConhecaObj(Cliente obj)
        {
            umCliente = obj;
        }
    }
}
