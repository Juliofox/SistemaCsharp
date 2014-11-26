using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.interfaces;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConPais consultaPais;
            consultaPais = new frmConPais();
            consultaPais.MdiParent = this;
            consultaPais.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConEstado consultaEstado;
            consultaEstado = new frmConEstado();
            consultaEstado.MdiParent = this;
            consultaEstado.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConCidade consultaCidade;
            consultaCidade = new frmConCidade();
            consultaCidade.MdiParent = this;
            consultaCidade.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConCliente consultaClientes;
            consultaClientes = new frmConCliente();
            consultaClientes.MdiParent = this;
            consultaClientes.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hospedagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hospedagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConHospedagem consultaHospedagem;
            consultaHospedagem = new frmConHospedagem();
            consultaHospedagem.MdiParent = this;
            consultaHospedagem.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConEmpresa consultaEmpresa;
            consultaEmpresa = new frmConEmpresa();
            consultaEmpresa.MdiParent = this;
            consultaEmpresa.Show();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConPlano consultaPlano;
            consultaPlano = new frmConPlano();
            consultaPlano.MdiParent = this;
            consultaPlano.Show();
        }

        private void boletosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmComBoleto consultaBoleto;
            consultaBoleto = new frmComBoleto();
            
            consultaBoleto.Show();
        }

        private void contasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConContasReceber consultaContasReceber;
            consultaContasReceber = new frmConContasReceber();
            consultaContasReceber.MdiParent = this;
            consultaContasReceber.Show();
        }
    }
}
