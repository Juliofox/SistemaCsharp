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
    public partial class frmComBoleto : Form
    {
        DataTable lista;
        Boleto umBoleto;
        DaoContaReceber umaDaoContaReceber;
        public frmComBoleto()
        {
            InitializeComponent();
            umaDaoContaReceber = new DaoContaReceber();
            lista = umaDaoContaReceber.CarregaGridBoleto();
        }

        private void frmComBoleto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_friedrichdesignDataSet1.Boleto' table. You can move, or remove it, as needed.
            //this.boletoTableAdapter.Fill(this.banco_friedrichdesignDataSet1.Boleto);
            this.grid.DataSource = lista;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nosso_numero, numero_documento, data_vencimento, data_documento, valor, demo1, demo2, cliente_nome, cliente_logradouro, cliente_numero, cliente_cidade, empresa_nome, empresa_logradouro, empresa_numero, empresa_cidade, empresa_cnpj;

            umBoleto = new Boleto();
            umBoleto.GetCodigo = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            umaDaoContaReceber.CarregaBoleto(umBoleto);

            nosso_numero = umBoleto.GetNossoNumero.ToString();
            numero_documento = umBoleto.GetNumeroDocumento.ToString();

            data_documento = umBoleto.GetDataDocumento.ToString("dd/MM/yyyy");
            data_vencimento = umBoleto.GetDataVencimento.ToString("dd/MM/yyyy");
            valor = umBoleto.GetValor.ToString();
            demo1 = umBoleto.GetDemonstrativo1;
            demo2 = umBoleto.GetDemonstrativo2;
            cliente_nome = umBoleto.GetumCliente.GetNome+"  "+umBoleto.GetumCliente.GetCpf;
            cliente_logradouro = umBoleto.GetumCliente.GetLogradouro;
            cliente_numero = umBoleto.GetumCliente.GetNumero;
            cliente_cidade = umBoleto.GetumCliente.getumaCidade.GetCidade;
            empresa_nome = umBoleto.GetumEmpresa.GetNome;
            empresa_logradouro = umBoleto.GetumEmpresa.GetLogradouro;
            empresa_numero = umBoleto.GetumEmpresa.GetNumero;
            empresa_cidade = umBoleto.GetumEmpresa.getumaCidade.GetCidade;
            empresa_cnpj = umBoleto.GetumEmpresa.GetCnpj;

            string url = "http://www.friedrichdesign.com/boleto/bol.php?nosso_numero="+nosso_numero+"&numero_documento="+numero_documento+"&data_vencimento="+data_vencimento+"&data_documento="+data_documento+
                "&valor="+valor+"&demo1="+demo1+"&demo2="+demo2+"&cliente_nome="+cliente_nome+"&cliente_logradouro="+cliente_logradouro+"&cliente_numero="+cliente_numero+"&cliente_cidade="+cliente_cidade+"&empresa_nome="+empresa_nome+
                "&empresa_logradouro="+empresa_logradouro+"&empresa_numero="+empresa_numero+"&empresa_cidade="+empresa_cidade+"&empresa_cnpj="+empresa_cnpj;
            
            frmBoleto printBoleto = new frmBoleto();
            printBoleto.webBrowser.Navigate(url);
            printBoleto.Show();
 
        }
    }
}
