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
    public partial class frmConPais : Form
    {
        Pais umPais;
        DaoPais umaDaoPais;
        DataTable lista;
        public frmConPais()
        {
            InitializeComponent();
            umaDaoPais = new DaoPais();
            lista = umaDaoPais.CarregaGrid();
        }
        public void ConhecaObj(Pais obj)
        {
            umPais = obj;
        }

        public void btnSair_Click(object sender, EventArgs e)
        {
            if (this.btnSair.Text == "Selecionar")
            {
                umPais.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                umPais.GetPais = grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
            else
            {
                Close();
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadPais cadPais;
            cadPais = new frmCadPais();
            cadPais.Show();
        }

        private void frmConPais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_friedrichdesignDataSet.pais' table. You can move, or remove it, as needed.
            //this.paisTableAdapter.Fill(this.banco_friedrichdesignDataSet1.pais);
        
        
            this.grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            umPais = new Pais();
            umPais.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoPais.Carrega(umPais);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadPais cadastroPais;
            cadastroPais = new frmCadPais();
            cadastroPais.carregaObjForm(umPais);
            cadastroPais.btnCadastrar.Text = "Editar";
            cadastroPais.Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            umPais = new Pais();
            umPais.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoPais.Carrega(umPais);
            //MessageBox.Show("País selecionado: "+umPais.GetPais);
            frmCadPais cadastroPais;
            cadastroPais = new frmCadPais();
            cadastroPais.carregaObjForm(umPais);
            cadastroPais.btnCadastrar.Text = "Excluir";
            cadastroPais.txtPais.Enabled = false;
            cadastroPais.Show();
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoPais = new DaoPais();
            lista = umaDaoPais.CarregaGrid();
            grid.DataSource = lista;
        }
    }
}
