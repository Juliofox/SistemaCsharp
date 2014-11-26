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
    public partial class frmConPlano : Form
    {
        Plano umPlano;
        DaoPlano umaDaoPlano;
        DataTable lista;
        public frmConPlano()
        {
            InitializeComponent();
            umaDaoPlano = new DaoPlano();
            lista = umaDaoPlano.CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (this.btnSair.Text == "Selecionar")
            {
                umPlano.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                umPlano.GetNome = grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadPlano cadastroPlano;
            cadastroPlano = new frmCadPlano();
            cadastroPlano.Show();
        }

        private void frmConPlano_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_friedrichdesignDataSet.plano'. Você pode movê-la ou removê-la conforme necessário.
            //this.planoTableAdapter.Fill(this.banco_friedrichdesignDataSet.plano);
            this.grid.DataSource = lista;
            
        }
        public void ConhecaObj(Plano obj)
        {
            umPlano = obj;
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoPlano = new DaoPlano();
            lista = umaDaoPlano.CarregaGrid();
            grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            umPlano = new Plano();
            umPlano.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoPlano.Carrega(umPlano);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadPlano cadastroPlano;
            cadastroPlano = new frmCadPlano();
            cadastroPlano.CarregaObjForm(umPlano);
            cadastroPlano.btnCadastrar.Text = "Editar";
            cadastroPlano.Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            umPlano = new Plano();
            umPlano.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoPlano.Carrega(umPlano);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadPlano cadastroPlano;
            cadastroPlano = new frmCadPlano();
            cadastroPlano.CarregaObjForm(umPlano);
            cadastroPlano.btnCadastrar.Text = "Excluir";
            cadastroPlano.txtNome.Enabled = false;
            cadastroPlano.txtValorAnual.Enabled = false;
            cadastroPlano.txtValorMensal.Enabled = false;
            cadastroPlano.txtValorSemestral.Enabled = false;
            cadastroPlano.txtValorTrimestral.Enabled = false;
            cadastroPlano.Show();
        }
    }
}
