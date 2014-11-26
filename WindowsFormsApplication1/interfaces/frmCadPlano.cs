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
    public partial class frmCadPlano : Form
    {
        DaoPlano umaDaoPlano;
        Plano umPlano;
        public frmCadPlano()
        {
            InitializeComponent();
            umaDaoPlano = new DaoPlano();
            umPlano = new Plano();
        }

        public void CarregaObjForm(Plano obj)
        {
            txtCodigo.Text = Convert.ToString(obj.GetCodigo);
            txtNome.Text = obj.GetNome;
            txtValorAnual.Text = Convert.ToString(obj.GetValorAnual);
            txtValorMensal.Text = Convert.ToString(obj.GetValorMensal);
            txtValorSemestral.Text = Convert.ToString(obj.GetValorSemestral);
            txtValorTrimestral.Text = Convert.ToString(obj.GetValorTrimestral);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String msg;
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório!");
                txtNome.Focus();
            }
            else if (txtValorMensal.Text == "")
            {
                MessageBox.Show("O campo Valor Mensal é obrigatório!");
                txtValorMensal.Focus();
            }
            else if (txtValorTrimestral.Text == "")
            {
                MessageBox.Show("O campo Valor Trimestral é obrigatório!");
                txtValorTrimestral.Focus();
            }
            else if (txtValorSemestral.Text == "")
            {
                MessageBox.Show("O campo Valor Semestral é obrigatório!");
                txtValorSemestral.Focus();
            }
            else if (txtValorAnual.Text == "")
            {
                MessageBox.Show("O campo Valor Anual é obrigatório!");
                txtValorAnual.Focus();
            }
            else if (this.btnCadastrar.Text == "Cadastrar")
            {
                try
                {
                    umPlano.GetNome = this.txtNome.Text;
                    umPlano.GetValorAnual = Convert.ToDecimal(this.txtValorAnual.Text);
                    umPlano.GetValorMensal = Convert.ToDecimal(this.txtValorMensal.Text);
                    umPlano.GetValorSemestral = Convert.ToDecimal(this.txtValorSemestral.Text);
                    umPlano.GetValorTrimestral = Convert.ToDecimal(this.txtValorTrimestral.Text);
                    msg = umaDaoPlano.Salvar(umPlano);
                    MessageBox.Show(msg);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (this.btnCadastrar.Text == "Editar")
            {
                try
                {
                    umPlano.GetCodigo = Convert.ToInt32(this.txtCodigo.Text);
                    umPlano.GetNome = this.txtNome.Text;
                    umPlano.GetValorAnual = Convert.ToDecimal(this.txtValorAnual.Text);
                    umPlano.GetValorMensal = Convert.ToDecimal(this.txtValorMensal.Text);
                    umPlano.GetValorSemestral = Convert.ToDecimal(this.txtValorSemestral.Text);
                    umPlano.GetValorTrimestral = Convert.ToDecimal(this.txtValorTrimestral.Text);
                    msg = umaDaoPlano.Salvar(umPlano);
                    MessageBox.Show(msg);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                umPlano.GetCodigo = Convert.ToInt32(this.txtCodigo.Text);
                umPlano.GetNome = this.txtNome.Text;
                umPlano.GetValorAnual = Convert.ToDecimal(this.txtValorAnual.Text);
                umPlano.GetValorMensal = Convert.ToDecimal(this.txtValorMensal.Text);
                umPlano.GetValorSemestral = Convert.ToDecimal(this.txtValorSemestral.Text);
                umPlano.GetValorTrimestral = Convert.ToDecimal(this.txtValorTrimestral.Text);
                msg = umaDaoPlano.Excluir(umPlano);
                MessageBox.Show(msg);
                Close();
            }
            
        }
    }
}
