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
    public partial class frmConContasReceber : Form
    {
        DataTable lista;
        DaoContaReceber umaDaoContasReceber;
        ContasReceber umaContareceber;

        public frmConContasReceber()
        {
            InitializeComponent();
            umaDaoContasReceber = new DaoContaReceber();
            lista = umaDaoContasReceber.CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadContasReceber cadastroContasReceber;
            cadastroContasReceber = new frmCadContasReceber();
            cadastroContasReceber.GetNossonumero();
            cadastroContasReceber.Show();
        }

        private void frmConContasReceber_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'banco_friedrichdesignDataSet1.contas_receber' table. You can move, or remove it, as needed.
            //this.contas_receberTableAdapter.Fill(this.banco_friedrichdesignDataSet1.contas_receber);
            this.grid.DataSource = lista;
            
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            //umaDaoContasReceber = new DaoContaReceber();
            lista = umaDaoContasReceber.CarregaGrid();
            grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            umaContareceber = new ContasReceber();
            umaContareceber.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoContasReceber.Carrega(umaContareceber);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadContasReceber cadContaReceber;
            cadContaReceber = new frmCadContasReceber();
            cadContaReceber.CarregaObjForm(umaContareceber);
            cadContaReceber.btnCadastrar.Text = "Editar";
            cadContaReceber.txtCod_empresa.Enabled = true;
            cadContaReceber.txtDemonstrativo1.Enabled = true;
            cadContaReceber.txtDemonstrativo2.Enabled = true;
            cadContaReceber.btn_buscar2.Enabled = true;
            cadContaReceber.btn_Boleto.Enabled = true;
            cadContaReceber.Show();
        }
    }
}
