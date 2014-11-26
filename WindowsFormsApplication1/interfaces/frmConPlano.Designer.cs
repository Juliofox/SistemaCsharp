namespace WindowsFormsApplication1.interfaces
{
    partial class frmConPlano
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.banco_friedrichdesignDataSet = new WindowsFormsApplication1.banco_friedrichdesignDataSet();
            this.planoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoTableAdapter = new WindowsFormsApplication1.banco_friedrichdesignDataSetTableAdapters.planoTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valormensalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortrimestralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorsemestralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoranualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_atualizaGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 30;
            // 
            // grid
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.valormensalDataGridViewTextBoxColumn,
            this.valortrimestralDataGridViewTextBoxColumn,
            this.valorsemestralDataGridViewTextBoxColumn,
            this.valoranualDataGridViewTextBoxColumn});
            this.grid.DataSource = this.planoBindingSource;
            this.grid.Location = new System.Drawing.Point(12, 64);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(765, 301);
            this.grid.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(702, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(610, 385);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 26;
            this.btnApagar.Text = "Deletar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(518, 385);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(427, 385);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // banco_friedrichdesignDataSet
            // 
            this.banco_friedrichdesignDataSet.DataSetName = "banco_friedrichdesignDataSet";
            this.banco_friedrichdesignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planoBindingSource
            // 
            this.planoBindingSource.DataMember = "plano";
            this.planoBindingSource.DataSource = this.banco_friedrichdesignDataSet;
            // 
            // planoTableAdapter
            // 
            this.planoTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 270;
            // 
            // valormensalDataGridViewTextBoxColumn
            // 
            this.valormensalDataGridViewTextBoxColumn.DataPropertyName = "valor_mensal";
            this.valormensalDataGridViewTextBoxColumn.HeaderText = "Valor Mensal(R$)";
            this.valormensalDataGridViewTextBoxColumn.Name = "valormensalDataGridViewTextBoxColumn";
            // 
            // valortrimestralDataGridViewTextBoxColumn
            // 
            this.valortrimestralDataGridViewTextBoxColumn.DataPropertyName = "valor_trimestral";
            this.valortrimestralDataGridViewTextBoxColumn.HeaderText = "Valor Trimestral(R$)";
            this.valortrimestralDataGridViewTextBoxColumn.Name = "valortrimestralDataGridViewTextBoxColumn";
            // 
            // valorsemestralDataGridViewTextBoxColumn
            // 
            this.valorsemestralDataGridViewTextBoxColumn.DataPropertyName = "valor_semestral";
            this.valorsemestralDataGridViewTextBoxColumn.HeaderText = "Valor Semestral(R$)";
            this.valorsemestralDataGridViewTextBoxColumn.Name = "valorsemestralDataGridViewTextBoxColumn";
            // 
            // valoranualDataGridViewTextBoxColumn
            // 
            this.valoranualDataGridViewTextBoxColumn.DataPropertyName = "valor_anual";
            this.valoranualDataGridViewTextBoxColumn.HeaderText = "Valor Anual(R$)";
            this.valoranualDataGridViewTextBoxColumn.Name = "valoranualDataGridViewTextBoxColumn";
            // 
            // btn_atualizaGrid
            // 
            this.btn_atualizaGrid.Location = new System.Drawing.Point(12, 385);
            this.btn_atualizaGrid.Name = "btn_atualizaGrid";
            this.btn_atualizaGrid.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizaGrid.TabIndex = 32;
            this.btn_atualizaGrid.Text = "Atualizar";
            this.btn_atualizaGrid.UseVisualStyleBackColor = true;
            this.btn_atualizaGrid.Click += new System.EventHandler(this.btn_atualizaGrid_Click);
            // 
            // frmConPlano
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
            this.Name = "frmConPlano";
            this.Text = "Consulta de Planos";
            this.Load += new System.EventHandler(this.frmConPlano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnCadastrar;
        private banco_friedrichdesignDataSet banco_friedrichdesignDataSet;
        private System.Windows.Forms.BindingSource planoBindingSource;
        private banco_friedrichdesignDataSetTableAdapters.planoTableAdapter planoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valormensalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortrimestralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorsemestralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoranualDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btn_atualizaGrid;
    }
}