namespace WindowsFormsApplication1.interfaces
{
    partial class frmCadContasReceber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtDataDocumento = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNossoNumero = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btn_Boleto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rPendente = new System.Windows.Forms.RadioButton();
            this.rPago = new System.Windows.Forms.RadioButton();
            this.rCancelado = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDemonstrativo1 = new System.Windows.Forms.TextBox();
            this.txtDemonstrativo2 = new System.Windows.Forms.TextBox();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCod_empresa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gridServico = new System.Windows.Forms.DataGridView();
            this.dominioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_friedrichdesignDataSet1 = new WindowsFormsApplication1.banco_friedrichdesignDataSet1();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hostsTableAdapter = new WindowsFormsApplication1.banco_friedrichdesignDataSet1TableAdapters.hostsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(362, 513);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(148, 513);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor (R$)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data Documento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data Vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nosso Número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Número Documento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(26, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 26;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(26, 72);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(55, 20);
            this.txtCodCliente.TabIndex = 27;
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(110, 72);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(321, 20);
            this.txtCliente.TabIndex = 28;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(28, 298);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 29;
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVencimento.Location = new System.Drawing.Point(371, 298);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(105, 20);
            this.txtDataVencimento.TabIndex = 30;
            // 
            // txtDataDocumento
            // 
            this.txtDataDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataDocumento.Location = new System.Drawing.Point(179, 298);
            this.txtDataDocumento.Name = "txtDataDocumento";
            this.txtDataDocumento.Size = new System.Drawing.Size(97, 20);
            this.txtDataDocumento.TabIndex = 31;
            this.txtDataDocumento.Value = new System.DateTime(2014, 4, 8, 16, 8, 37, 0);
            this.txtDataDocumento.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Enabled = false;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(218, 349);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 32;
            // 
            // txtNossoNumero
            // 
            this.txtNossoNumero.Enabled = false;
            this.txtNossoNumero.Location = new System.Drawing.Point(29, 349);
            this.txtNossoNumero.Name = "txtNossoNumero";
            this.txtNossoNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNossoNumero.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(453, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btn_Boleto
            // 
            this.btn_Boleto.Enabled = false;
            this.btn_Boleto.Location = new System.Drawing.Point(255, 513);
            this.btn_Boleto.Name = "btn_Boleto";
            this.btn_Boleto.Size = new System.Drawing.Size(75, 23);
            this.btn_Boleto.TabIndex = 35;
            this.btn_Boleto.Text = "Gerar Boleto";
            this.btn_Boleto.UseVisualStyleBackColor = true;
            this.btn_Boleto.Click += new System.EventHandler(this.btn_Boleto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(243, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Situação:";
            // 
            // rPendente
            // 
            this.rPendente.AutoSize = true;
            this.rPendente.Location = new System.Drawing.Point(345, 8);
            this.rPendente.Name = "rPendente";
            this.rPendente.Size = new System.Drawing.Size(71, 17);
            this.rPendente.TabIndex = 37;
            this.rPendente.Text = "Pendente";
            this.rPendente.UseVisualStyleBackColor = true;
            this.rPendente.CheckedChanged += new System.EventHandler(this.rPendente_CheckedChanged);
            // 
            // rPago
            // 
            this.rPago.AutoSize = true;
            this.rPago.Location = new System.Drawing.Point(422, 8);
            this.rPago.Name = "rPago";
            this.rPago.Size = new System.Drawing.Size(50, 17);
            this.rPago.TabIndex = 38;
            this.rPago.TabStop = true;
            this.rPago.Text = "Pago";
            this.rPago.UseVisualStyleBackColor = true;
            this.rPago.CheckedChanged += new System.EventHandler(this.rPago_CheckedChanged);
            // 
            // rCancelado
            // 
            this.rCancelado.AutoSize = true;
            this.rCancelado.Location = new System.Drawing.Point(478, 8);
            this.rCancelado.Name = "rCancelado";
            this.rCancelado.Size = new System.Drawing.Size(76, 17);
            this.rCancelado.TabIndex = 39;
            this.rCancelado.TabStop = true;
            this.rCancelado.Text = "Cancelado";
            this.rCancelado.UseVisualStyleBackColor = true;
            this.rCancelado.CheckedChanged += new System.EventHandler(this.rCancelado_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Demonstrativo1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Demonstrativo2";
            // 
            // txtDemonstrativo1
            // 
            this.txtDemonstrativo1.Enabled = false;
            this.txtDemonstrativo1.Location = new System.Drawing.Point(31, 397);
            this.txtDemonstrativo1.Multiline = true;
            this.txtDemonstrativo1.Name = "txtDemonstrativo1";
            this.txtDemonstrativo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDemonstrativo1.Size = new System.Drawing.Size(497, 27);
            this.txtDemonstrativo1.TabIndex = 42;
            // 
            // txtDemonstrativo2
            // 
            this.txtDemonstrativo2.Enabled = false;
            this.txtDemonstrativo2.Location = new System.Drawing.Point(31, 457);
            this.txtDemonstrativo2.Multiline = true;
            this.txtDemonstrativo2.Name = "txtDemonstrativo2";
            this.txtDemonstrativo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDemonstrativo2.Size = new System.Drawing.Size(497, 36);
            this.txtDemonstrativo2.TabIndex = 43;
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Enabled = false;
            this.btn_buscar2.Location = new System.Drawing.Point(454, 250);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar2.TabIndex = 47;
            this.btn_buscar2.Text = "Buscar";
            this.btn_buscar2.UseVisualStyleBackColor = true;
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(111, 251);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(321, 20);
            this.txtEmpresa.TabIndex = 46;
            // 
            // txtCod_empresa
            // 
            this.txtCod_empresa.Enabled = false;
            this.txtCod_empresa.Location = new System.Drawing.Point(27, 251);
            this.txtCod_empresa.Name = "txtCod_empresa";
            this.txtCod_empresa.Size = new System.Drawing.Size(55, 20);
            this.txtCod_empresa.TabIndex = 45;
            this.txtCod_empresa.Leave += new System.EventHandler(this.txtCod_empresa_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Empresa";
            // 
            // gridServico
            // 
            this.gridServico.AutoGenerateColumns = false;
            this.gridServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dominioDataGridViewTextBoxColumn});
            this.gridServico.DataSource = this.hostsBindingSource;
            this.gridServico.Location = new System.Drawing.Point(27, 104);
            this.gridServico.Name = "gridServico";
            this.gridServico.Size = new System.Drawing.Size(501, 75);
            this.gridServico.TabIndex = 48;
            this.gridServico.Click += new System.EventHandler(this.gridServico_Click);
            // 
            // dominioDataGridViewTextBoxColumn
            // 
            this.dominioDataGridViewTextBoxColumn.DataPropertyName = "dominio";
            this.dominioDataGridViewTextBoxColumn.HeaderText = "Domínio/Serviço";
            this.dominioDataGridViewTextBoxColumn.Name = "dominioDataGridViewTextBoxColumn";
            this.dominioDataGridViewTextBoxColumn.Width = 430;
            // 
            // hostsBindingSource
            // 
            this.hostsBindingSource.DataMember = "hosts";
            this.hostsBindingSource.DataSource = this.banco_friedrichdesignDataSet1;
            // 
            // banco_friedrichdesignDataSet1
            // 
            this.banco_friedrichdesignDataSet1.DataSetName = "banco_friedrichdesignDataSet1";
            this.banco_friedrichdesignDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(26, 203);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(502, 20);
            this.txtServico.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Serviço (Hospedagem/Registro dominio)";
            // 
            // hostsTableAdapter
            // 
            this.hostsTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 571);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridServico);
            this.Controls.Add(this.btn_buscar2);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtCod_empresa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDemonstrativo2);
            this.Controls.Add(this.txtDemonstrativo1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rCancelado);
            this.Controls.Add(this.rPago);
            this.Controls.Add(this.rPendente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Boleto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNossoNumero);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtDataDocumento);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCadContasReceber";
            this.Text = "Cadastro Contas à Receber";
            this.Load += new System.EventHandler(this.frmCadContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtCodCliente;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.DateTimePicker txtDataVencimento;
        public System.Windows.Forms.DateTimePicker txtDataDocumento;
        public System.Windows.Forms.TextBox txtNumeroDocumento;
        public System.Windows.Forms.TextBox txtNossoNumero;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btn_Boleto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rPendente;
        public System.Windows.Forms.RadioButton rPago;
        public System.Windows.Forms.RadioButton rCancelado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtDemonstrativo1;
        public System.Windows.Forms.TextBox txtDemonstrativo2;
        public System.Windows.Forms.Button btn_buscar2;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txtCod_empresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gridServico;
        public System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label label12;
        private banco_friedrichdesignDataSet1 banco_friedrichdesignDataSet1;
        private System.Windows.Forms.BindingSource hostsBindingSource;
        private banco_friedrichdesignDataSet1TableAdapters.hostsTableAdapter hostsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dominioDataGridViewTextBoxColumn;
    }
}