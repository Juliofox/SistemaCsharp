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
    public partial class frmCadContasReceber : Form
    {
        ContasReceber umaContaReceber;
        Cliente umCliente;
        Empresa umaEmpresa;
        Boleto umBoleto;
        DaoCliente umaDaoCliente;
        DaoEmpresa umaDaoEmpresa;
        DaoHosts umaDaohost;
        DaoContaReceber umaDaoContaReceber;
        frmConCliente consultaCliente;
        frmConEmpresa consultaEmpresa;
        int NossoNumero, NumeroDocumento;
        String Situacao;
        public frmCadContasReceber()
        {
            InitializeComponent();
            umaContaReceber = new ContasReceber();
            umCliente = new Cliente();
            umaEmpresa = new Empresa();
            umaDaoCliente = new DaoCliente();
            umaDaoEmpresa = new DaoEmpresa();
            umaDaoContaReceber = new DaoContaReceber();
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string msg;
            if (this.txtCodCliente.Text == "")
            {
                MessageBox.Show("Campo Cliente é obrigatório!");
                txtCodCliente.Focus();
            }
            else if (txtServico.Text == "")
            {
                MessageBox.Show("Campo Serviço é obrigatório!");
                txtServico.Focus();
            }
            else if (txtValor.Text == "")
            {
                MessageBox.Show("Campo Valor é obrigatório!");
                txtValor.Focus();
            }
            else if (Situacao == null)
            {
                MessageBox.Show("Escolha a situação da Conta!");
            }
            else
            {
                if (this.btnCadastrar.Text == "Cadastrar")
                {
                    umaContaReceber.GetData_documento = txtDataDocumento.Value.Date;
                    umaContaReceber.GetData_vencimento = txtDataVencimento.Value.Date;
                    umaContaReceber.GetNossoNumero = Convert.ToInt32(txtNossoNumero.Text);
                    umaContaReceber.GetNumeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                    umaContaReceber.GetSituacao = Situacao;
                    umaContaReceber.GetServico = txtServico.Text;
                    umaContaReceber.GetumCliente.GetCodigo = Convert.ToInt32(txtCodCliente.Text);
                    umaContaReceber.GetValor = Convert.ToDecimal(txtValor.Text);
                    msg = umaDaoContaReceber.Salvar(umaContaReceber);
                    MessageBox.Show(msg);
                    Close();
                }
                else
                {
                    umaContaReceber.GetCodigo = Convert.ToInt32(txtCodigo.Text);
                    umaContaReceber.GetValor = Convert.ToDecimal(txtValor.Text);
                    umaContaReceber.GetData_documento = txtDataDocumento.Value;
                    umaContaReceber.GetData_vencimento = txtDataVencimento.Value;
                    umaContaReceber.GetSituacao = Situacao;
                    umaContaReceber.GetServico = txtServico.Text;
                    msg = umaDaoContaReceber.Salvar(umaContaReceber);
                    MessageBox.Show(msg);
                    Close();
                }

            }

        }

        private void frmCadContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_friedrichdesignDataSet1.hosts'. Você pode movê-la ou removê-la conforme necessário.
            //this.hostsTableAdapter.Fill(this.banco_friedrichdesignDataSet1.hosts);
            
        }
        public void GetNossonumero()
        {
            NumeroDocumento = umaDaoContaReceber.LastDocumento();
            NossoNumero = 10100000 + NumeroDocumento;
            txtNossoNumero.Text = Convert.ToString(NossoNumero);
            txtNumeroDocumento.Text = Convert.ToString(NumeroDocumento);
        }

        private void rPendente_CheckedChanged(object sender, EventArgs e)
        {
            Situacao = "Pendente";
        }

        private void rPago_CheckedChanged(object sender, EventArgs e)
        {
            Situacao = "Pago";
        }

        private void rCancelado_CheckedChanged(object sender, EventArgs e)
        {
            Situacao = "Cancelado";
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable lista;
                umCliente = new Cliente();
                umCliente.GetCodigo = Convert.ToInt32(txtCodCliente.Text);
                umaDaoCliente.Carrega(umCliente);
                txtCliente.Text = umCliente.GetNome;

                umaDaohost = new DaoHosts();
                lista = umaDaohost.CarregaServico(Convert.ToInt32(txtCodCliente.Text));
                this.gridServico.DataSource = lista;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCod_empresa_Leave(object sender, EventArgs e)
        {
            try
            {
                umaEmpresa = new Empresa();
                umaEmpresa.GetCodigo = Convert.ToInt32(txtCod_empresa.Text);
                umaDaoEmpresa.Carrega(umaEmpresa);
                txtEmpresa.Text = umaEmpresa.GetNome;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                consultaCliente = new frmConCliente();
                //umPais = new Pais();
                consultaCliente.ConhecaObj(umaContaReceber.GetumCliente);
                consultaCliente.btnSair.Text = "Selecionar";
                consultaCliente.Show();
                txtCodCliente.Text = Convert.ToString(umaContaReceber.GetumCliente.GetCodigo);
                txtCliente.Text = umaContaReceber.GetumCliente.GetNome;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            try
            {
                
                consultaEmpresa = new frmConEmpresa();
                //umPais = new Pais();
                consultaEmpresa.ConhecaObj(umaEmpresa);
                consultaEmpresa.btnSair.Text = "Selecionar";
                consultaEmpresa.Show();
                txtCod_empresa.Text = Convert.ToString(umaEmpresa.GetCodigo);
                txtEmpresa.Text = umaEmpresa.GetNome;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CarregaObjForm(ContasReceber obj)
        {
            txtCliente.Text = obj.GetumCliente.GetNome;
            txtCodCliente.Text = Convert.ToString(obj.GetumCliente.GetCodigo);
            txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            txtDataDocumento.Value = obj.GetData_documento;
            txtDataVencimento.Value = obj.GetData_vencimento;
            txtNossoNumero.Text = Convert.ToString(obj.GetNossoNumero);
            txtNumeroDocumento.Text = Convert.ToString(obj.GetNumeroDocumento);
            txtValor.Text = Convert.ToString(obj.GetValor);
            txtServico.Text = obj.GetServico;
            Situacao = obj.GetSituacao;

            if (Situacao == "Pago")
                rPago.Checked = true;
            else if (Situacao == "Cancelado")
                rCancelado.Checked = true;
            else
                rPendente.Checked = true;

            DataTable lista;
            umaDaohost = new DaoHosts();
            lista = umaDaohost.CarregaServico(obj.GetumCliente.GetCodigo);
            this.gridServico.DataSource = lista;

            //carrega demonstrativo boleto
            String demonstrativo1, demonstrativo2;
            demonstrativo1 = "Renovação pelo período 1 (um) ano a partir da data de pagamento";
            demonstrativo2 = "Pagamento referente a renovação por 12 meses da hospedagem do domínio "+obj.GetServico+"<br>Taxa bancária - R$3,95";
            this.txtDemonstrativo1.Text = demonstrativo1;
            this.txtDemonstrativo2.Text = demonstrativo2;
        }

        private void gridServico_Click(object sender, EventArgs e)
        {
            this.txtServico.Text = gridServico.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Boleto_Click(object sender, EventArgs e)
        {
            if (txtCod_empresa.Text == "")
            {
                MessageBox.Show("Você deve escolher uma empresa!");
                txtCod_empresa.Focus();
            }
            else
            {
                string msg;
                umBoleto = new Boleto();
                umBoleto.GetDataDocumento = txtDataDocumento.Value;
                umBoleto.GetDataVencimento = txtDataVencimento.Value;
                umBoleto.GetDemonstrativo1 = txtDemonstrativo1.Text;
                umBoleto.GetDemonstrativo2 = txtDemonstrativo2.Text;
                umBoleto.GetNossoNumero = Convert.ToInt32(txtNossoNumero.Text);
                umBoleto.GetNumeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                umBoleto.GetSituacao = Situacao;
                umBoleto.GetumCliente.GetCodigo = Convert.ToInt32(txtCodCliente.Text);
                umBoleto.GetumEmpresa.GetCodigo = Convert.ToInt32(txtCod_empresa.Text);
                umBoleto.GetValor = Convert.ToDecimal(txtValor.Text);
                msg = umaDaoContaReceber.SalvarBoleto(umBoleto);
                MessageBox.Show(msg);
                Close();
            }

        }
    }
}
