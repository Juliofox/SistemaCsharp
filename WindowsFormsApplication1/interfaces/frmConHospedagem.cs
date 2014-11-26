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
    public partial class frmConHospedagem : Form
    {
        DataTable lista;
        Hosts umHost;
        DaoHosts umaDaoHost;
        public frmConHospedagem()
        {
            InitializeComponent();
            umaDaoHost = new DaoHosts();
            lista = umaDaoHost.CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadHospedagem cadHospedagem;
            cadHospedagem = new frmCadHospedagem();
            cadHospedagem.rAtivo.Checked = true;
            cadHospedagem.Show();
        }

        private void frmConHospedagem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_friedrichdesignDataSet.hosts'. Você pode movê-la ou removê-la conforme necessário.
            //this.hostsTableAdapter.Fill(this.banco_friedrichdesignDataSet.hosts);
            this.grid.DataSource = lista;
        }

        private void btn_atualizaGrid_Click(object sender, EventArgs e)
        {
            umaDaoHost = new DaoHosts();
            lista = umaDaoHost.CarregaGrid();
            grid.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                umHost = new Hosts();
                umHost.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                umaDaoHost.Carrega(umHost);
                frmCadHospedagem cadHospedagem = new frmCadHospedagem();
                cadHospedagem.CarregaObjForm(umHost);
                cadHospedagem.btnCadastrar.Text = "Editar";
                cadHospedagem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
