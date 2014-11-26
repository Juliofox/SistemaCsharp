namespace WindowsFormsApplication1.interfaces
{
    partial class frmComBoleto
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nossonumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demonstrativo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demonstrativo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_friedrichdesignDataSet1 = new WindowsFormsApplication1.banco_friedrichdesignDataSet1();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.boletoTableAdapter = new WindowsFormsApplication1.banco_friedrichdesignDataSet1TableAdapters.BoletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.datavencimentoDataGridViewTextBoxColumn,
            this.datadocumentoDataGridViewTextBoxColumn,
            this.nossonumeroDataGridViewTextBoxColumn,
            this.numerodocumentoDataGridViewTextBoxColumn,
            this.demonstrativo1DataGridViewTextBoxColumn,
            this.demonstrativo2DataGridViewTextBoxColumn,
            this.codempresaDataGridViewTextBoxColumn,
            this.codclienteDataGridViewTextBoxColumn});
            this.grid.DataSource = this.boletoBindingSource;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(765, 329);
            this.grid.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // datavencimentoDataGridViewTextBoxColumn
            // 
            this.datavencimentoDataGridViewTextBoxColumn.DataPropertyName = "data_vencimento";
            this.datavencimentoDataGridViewTextBoxColumn.HeaderText = "data_vencimento";
            this.datavencimentoDataGridViewTextBoxColumn.Name = "datavencimentoDataGridViewTextBoxColumn";
            // 
            // datadocumentoDataGridViewTextBoxColumn
            // 
            this.datadocumentoDataGridViewTextBoxColumn.DataPropertyName = "data_documento";
            this.datadocumentoDataGridViewTextBoxColumn.HeaderText = "data_documento";
            this.datadocumentoDataGridViewTextBoxColumn.Name = "datadocumentoDataGridViewTextBoxColumn";
            // 
            // nossonumeroDataGridViewTextBoxColumn
            // 
            this.nossonumeroDataGridViewTextBoxColumn.DataPropertyName = "nosso_numero";
            this.nossonumeroDataGridViewTextBoxColumn.HeaderText = "nosso_numero";
            this.nossonumeroDataGridViewTextBoxColumn.Name = "nossonumeroDataGridViewTextBoxColumn";
            // 
            // numerodocumentoDataGridViewTextBoxColumn
            // 
            this.numerodocumentoDataGridViewTextBoxColumn.DataPropertyName = "numero_documento";
            this.numerodocumentoDataGridViewTextBoxColumn.HeaderText = "numero_documento";
            this.numerodocumentoDataGridViewTextBoxColumn.Name = "numerodocumentoDataGridViewTextBoxColumn";
            // 
            // demonstrativo1DataGridViewTextBoxColumn
            // 
            this.demonstrativo1DataGridViewTextBoxColumn.DataPropertyName = "demonstrativo1";
            this.demonstrativo1DataGridViewTextBoxColumn.HeaderText = "demonstrativo1";
            this.demonstrativo1DataGridViewTextBoxColumn.Name = "demonstrativo1DataGridViewTextBoxColumn";
            // 
            // demonstrativo2DataGridViewTextBoxColumn
            // 
            this.demonstrativo2DataGridViewTextBoxColumn.DataPropertyName = "demonstrativo2";
            this.demonstrativo2DataGridViewTextBoxColumn.HeaderText = "demonstrativo2";
            this.demonstrativo2DataGridViewTextBoxColumn.Name = "demonstrativo2DataGridViewTextBoxColumn";
            // 
            // codempresaDataGridViewTextBoxColumn
            // 
            this.codempresaDataGridViewTextBoxColumn.DataPropertyName = "cod_empresa";
            this.codempresaDataGridViewTextBoxColumn.HeaderText = "cod_empresa";
            this.codempresaDataGridViewTextBoxColumn.Name = "codempresaDataGridViewTextBoxColumn";
            // 
            // codclienteDataGridViewTextBoxColumn
            // 
            this.codclienteDataGridViewTextBoxColumn.DataPropertyName = "cod_cliente";
            this.codclienteDataGridViewTextBoxColumn.HeaderText = "cod_cliente";
            this.codclienteDataGridViewTextBoxColumn.Name = "codclienteDataGridViewTextBoxColumn";
            // 
            // boletoBindingSource
            // 
            this.boletoBindingSource.DataMember = "Boleto";
            this.boletoBindingSource.DataSource = this.banco_friedrichdesignDataSet1;
            // 
            // banco_friedrichdesignDataSet1
            // 
            this.banco_friedrichdesignDataSet1.DataSetName = "banco_friedrichdesignDataSet1";
            this.banco_friedrichdesignDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(12, 358);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(139, 57);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir Boleto";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(702, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // boletoTableAdapter
            // 
            this.boletoTableAdapter.ClearBeforeFill = true;
            // 
            // frmComBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 427);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grid);
            this.Name = "frmComBoleto";
            this.Text = "Consulta de Boletos";
            this.Load += new System.EventHandler(this.frmComBoleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_friedrichdesignDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private banco_friedrichdesignDataSet1 banco_friedrichdesignDataSet1;
        private System.Windows.Forms.BindingSource boletoBindingSource;
        private banco_friedrichdesignDataSet1TableAdapters.BoletoTableAdapter boletoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nossonumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demonstrativo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demonstrativo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codclienteDataGridViewTextBoxColumn;
    }
}