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
    public partial class frmConEstado : Form
    {
        DataTable lista;
        DaoEstado umaDaoEstado;
        Estado umEstado;
        public frmConEstado()
        {
            InitializeComponent();
            umaDaoEstado = new DaoEstado();
            lista = umaDaoEstado.CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (this.btnSair.Text == "Selecionar")
            {
                umEstado.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                Estado auxEstado = umaDaoEstado.Carrega(umEstado);
                umEstado.getEstado = auxEstado.getEstado;
                umEstado.getumPais.GetCodigo = auxEstado.getumPais.GetCodigo;
                umEstado.getumPais.GetPais = auxEstado.getumPais.GetPais;
                //umEstado.getEstado = grid.CurrentRow.Cells[1].Value.ToString();
                //umEstado.getumPais.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
                Close();
            }
            else
                Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadEstado cadEstado;
            cadEstado = new frmCadEstado();
            cadEstado.Show();
        }

        private void frmConEstado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_friedrichdesignDataSet.estado' table. You can move, or remove it, as needed.
            //this.estadoTableAdapter.Fill(this.banco_friedrichdesignDataSet.estado);
            this.grid.DataSource = lista;
        }

        private void estadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            umEstado = new Estado();
            frmCadEstado cadEstado;
            umEstado.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoEstado.Carrega(umEstado);
            cadEstado = new frmCadEstado();
            cadEstado.CarregaObjForm(umEstado);
            cadEstado.btnCadastrar.Text = "Editar";
            cadEstado.Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            umEstado = new Estado();
            frmCadEstado cadEstado;
            umEstado.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoEstado.Carrega(umEstado);
            cadEstado = new frmCadEstado();
            cadEstado.CarregaObjForm(umEstado);
            cadEstado.btnCadastrar.Text = "Excluir";
            cadEstado.txtCodPais.Enabled = false;
            cadEstado.txtEstado.Enabled = false;
            cadEstado.Show();
        }
        public void ConhecaObj(Estado obj)
        {
            umEstado = obj;
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoEstado = new DaoEstado();
            lista = umaDaoEstado.CarregaGrid();
            grid.DataSource = lista;
        }
    }
}
