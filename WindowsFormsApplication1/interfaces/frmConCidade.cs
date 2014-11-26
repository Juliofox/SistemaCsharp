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
    public partial class frmConCidade : Form
    {
        DataTable lista;
        DaoCidade umaDaoCidade;
        Cidade umaCidade;
        public frmConCidade()
        {
            InitializeComponent();
            umaDaoCidade = new DaoCidade();
            lista = umaDaoCidade.CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (this.btnSair.Text == "Selecionar")
            {
                umaCidade.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                Cidade auxCidade = umaDaoCidade.Carrega(umaCidade);
                umaCidade.GetCidade = auxCidade.GetCidade;
                umaCidade.getumEstado.getEstado = auxCidade.getumEstado.getEstado;
            }

            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadCidade cadCidade;
            cadCidade = new frmCadCidade();
            cadCidade.Show();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void frmConCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_friedrichdesignDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            //this.cidadeTableAdapter.Fill(this.banco_friedrichdesignDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'banco_friedrichdesignDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.

            this.grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            umaCidade = new Cidade();
            umaCidade.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoCidade.Carrega(umaCidade);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadCidade cadastroCidade;
            cadastroCidade = new frmCadCidade();
            cadastroCidade.CarregaObjForm(umaCidade);
            cadastroCidade.btnCadastrar.Text = "Editar";
            cadastroCidade.Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            umaCidade = new Cidade();
            umaCidade.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoCidade.Carrega(umaCidade);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadCidade cadastroCidade;
            cadastroCidade = new frmCadCidade();
            cadastroCidade.CarregaObjForm(umaCidade);
            cadastroCidade.btnCadastrar.Text = "Excluir";
            cadastroCidade.txtCidade.Enabled = false;
            cadastroCidade.txtCodEstado.Enabled = false;
            cadastroCidade.Show();
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoCidade = new DaoCidade();
            lista = umaDaoCidade.CarregaGrid();
            grid.DataSource = lista;
        }
        public void ConhecaObj(Cidade obj)
        {
            umaCidade = obj;
        }
    }
}
