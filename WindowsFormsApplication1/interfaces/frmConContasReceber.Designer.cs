namespace WindowsFormsApplication1.interfaces
{
    partial class frmConContasReceber
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
            this.btn_atualizaGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contasreceberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banco_friedrichdesignDataSet1 = new WindowsFormsApplication1.banco_friedrichdesignDataSet1();
            this.contasreceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.contas_receberTableAdapter = new WindowsFormsApplication1.banco_friedrichdesignDataSet1TableAdapters.contas_receberTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atualizaGrid
            // 
            this.btn_atualizaGrid.Location = new System.Drawing.Point(12, 385);
            this.btn_atualizaGrid.Name = "btn_atualizaGrid";
            this.btn_atualizaGrid.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizaGrid.TabIndex = 41;
            this.btn_atualizaGrid.Text = "Atualizar";
            this.btn_atualizaGrid.UseVisualStyleBackColor = true;
            this.btn_atualizaGrid.Click += new System.EventHandler(this.btn_atualizaGrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 39;
            // 
            // grid
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.codclienteDataGridViewTextBoxColumn,
            this.servico,
            this.valorDataGridViewTextBoxColumn,
            this.datadocumentoDataGridViewTextBoxColumn,
            this.datavencimentoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn});
            this.grid.DataSource = this.contasreceberBindingSource1;
            this.grid.Location = new System.Drawing.Point(12, 64);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(765, 301);
            this.grid.TabIndex = 38;
            // 
            // contasreceberBindingSource1
            // 
            this.contasreceberBindingSource1.DataMember = "contas_receber";
            this.contasreceberBindingSource1.DataSource = this.banco_friedrichdesignDataSet1;
            // 
            // banco_friedrichdesignDataSet1
            // 
            this.banco_friedrichdesignDataSet1.DataSetName = "banco_friedrichdesignDataSet1";
            this.banco_friedrichdesignDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasreceberBindingSource
            // 
            this.contasreceberBindingSource.DataMember = "contas_receber";
            this.contasreceberBindingSource.DataSource = this.banco_friedrichdesignDataSet1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(702, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 36;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(610, 385);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 35;
            this.btnApagar.Text = "Deletar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(518, 385);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(427, 385);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // contas_receberTableAdapter
            // 
            this.contas_receberTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // codclienteDataGridViewTextBoxColumn
            // 
            this.codclienteDataGridViewTextBoxColumn.DataPropertyName = "cod_cliente";
            this.codclienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.codclienteDataGridViewTextBoxColumn.Name = "codclienteDataGridViewTextBoxColumn";
            this.codclienteDataGridViewTextBoxColumn.Width = 180;
            // 
            // servico
            // 
            this.servico.DataPropertyName = "servico";
            this.servico.HeaderText = "Serviço";
            this.servico.Name = "servico";
            this.servico.Width = 115;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor(R$)";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // datadocumentoDataGridViewTextBoxColumn
            // 
            this.datadocumentoDataGridViewTextBoxColumn.DataPropertyName = "data_documento";
            this.datadocumentoDataGridViewTextBoxColumn.HeaderText = "Data Documento";
            this.datadocumentoDataGridViewTextBoxColumn.Name = "datadocumentoDataGridViewTextBoxColumn";
            this.datadocumentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // datavencimentoDataGridViewTextBoxColumn
            // 
            this.datavencimentoDataGridViewTextBoxColumn.DataPropertyName = "data_vencimento";
            this.datavencimentoDataGridViewTextBoxColumn.HeaderText = "Data Vencimento";
            this.datavencimentoDataGridViewTextBoxColumn.Name = "datavencimentoDataGridViewTextBoxColumn";
            this.datavencimentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            // 
            // frmConContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 427);
            this.Controls.Add(this.btn_atualizaGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmConContasReceber";
            this.Text = "Consulta Contas à Receber";
            this.Load += new System.EventHandler(this.frmConContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasreceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_atualizaGrid;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnCadastrar;
        private banco_friedrichdesignDataSet1 banco_friedrichdesignDataSet1;
        private System.Windows.Forms.BindingSource contasreceberBindingSource;
        private banco_friedrichdesignDataSet1TableAdapters.contas_receberTableAdapter contas_receberTableAdapter;
        private System.Windows.Forms.BindingSource contasreceberBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
    }
}