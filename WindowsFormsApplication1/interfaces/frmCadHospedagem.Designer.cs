namespace WindowsFormsApplication1.interfaces
{
    partial class frmCadHospedagem
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
            this.btnBuscarPlano = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtcodPlano = new System.Windows.Forms.TextBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtcodCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.rAtivo = new System.Windows.Forms.RadioButton();
            this.rCongelado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBuscarPlano
            // 
            this.btnBuscarPlano.Location = new System.Drawing.Point(300, 158);
            this.btnBuscarPlano.Name = "btnBuscarPlano";
            this.btnBuscarPlano.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPlano.TabIndex = 24;
            this.btnBuscarPlano.Text = "Buscar";
            this.btnBuscarPlano.UseVisualStyleBackColor = true;
            this.btnBuscarPlano.Click += new System.EventHandler(this.btnBuscarPlano_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(226, 405);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(135, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Domínio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Plano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data Início";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Data Fim";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(25, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // txtDominio
            // 
            this.txtDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDominio.Location = new System.Drawing.Point(25, 101);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(350, 20);
            this.txtDominio.TabIndex = 32;
            // 
            // txtcodPlano
            // 
            this.txtcodPlano.Location = new System.Drawing.Point(25, 160);
            this.txtcodPlano.Name = "txtcodPlano";
            this.txtcodPlano.Size = new System.Drawing.Size(55, 20);
            this.txtcodPlano.TabIndex = 33;
            this.txtcodPlano.Leave += new System.EventHandler(this.txtcodPlano_Leave);
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(98, 160);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.ReadOnly = true;
            this.txtPlano.Size = new System.Drawing.Size(187, 20);
            this.txtPlano.TabIndex = 34;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(98, 214);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(187, 20);
            this.txtCliente.TabIndex = 36;
            // 
            // txtcodCliente
            // 
            this.txtcodCliente.Location = new System.Drawing.Point(25, 214);
            this.txtcodCliente.Name = "txtcodCliente";
            this.txtcodCliente.Size = new System.Drawing.Size(55, 20);
            this.txtcodCliente.TabIndex = 35;
            this.txtcodCliente.Leave += new System.EventHandler(this.txtcodCliente_Leave);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(300, 212);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 37;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Situação";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(25, 270);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(98, 20);
            this.txtDataInicio.TabIndex = 42;
            // 
            // txtDataFim
            // 
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFim.Location = new System.Drawing.Point(182, 270);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(98, 20);
            this.txtDataFim.TabIndex = 43;
            // 
            // rAtivo
            // 
            this.rAtivo.AutoSize = true;
            this.rAtivo.Location = new System.Drawing.Point(25, 345);
            this.rAtivo.Name = "rAtivo";
            this.rAtivo.Size = new System.Drawing.Size(49, 17);
            this.rAtivo.TabIndex = 44;
            this.rAtivo.TabStop = true;
            this.rAtivo.Text = "Ativo";
            this.rAtivo.UseVisualStyleBackColor = true;
            this.rAtivo.CheckedChanged += new System.EventHandler(this.rAtivo_CheckedChanged);
            // 
            // rCongelado
            // 
            this.rCongelado.AutoSize = true;
            this.rCongelado.Location = new System.Drawing.Point(98, 345);
            this.rCongelado.Name = "rCongelado";
            this.rCongelado.Size = new System.Drawing.Size(76, 17);
            this.rCongelado.TabIndex = 45;
            this.rCongelado.TabStop = true;
            this.rCongelado.Text = "Congelado";
            this.rCongelado.UseVisualStyleBackColor = true;
            this.rCongelado.CheckedChanged += new System.EventHandler(this.rCongelado_CheckedChanged);
            // 
            // frmCadHospedagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 451);
            this.Controls.Add(this.rCongelado);
            this.Controls.Add(this.rAtivo);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtcodCliente);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.txtcodPlano);
            this.Controls.Add(this.txtDominio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarPlano);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCadHospedagem";
            this.Text = "Cadastro HospedagemDomínio";
            this.Load += new System.EventHandler(this.frmCadHospedagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnBuscarPlano;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDominio;
        public System.Windows.Forms.TextBox txtcodPlano;
        public System.Windows.Forms.TextBox txtPlano;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtcodCliente;
        public System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker txtDataInicio;
        public System.Windows.Forms.DateTimePicker txtDataFim;
        public System.Windows.Forms.RadioButton rAtivo;
        public System.Windows.Forms.RadioButton rCongelado;
    }
}