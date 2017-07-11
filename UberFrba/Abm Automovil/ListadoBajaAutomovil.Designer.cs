namespace UberFrba.Abm_Automovil
{
    partial class ListadoBajaAutomovil
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.automovilesGrid = new System.Windows.Forms.DataGridView();
            this.buscarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.choferTextBox = new System.Windows.Forms.TextBox();
            this.patenteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.aUTOMOVILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOMOVILTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.AUTOMOVILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOMOVILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(12, 339);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 10;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // automovilesGrid
            // 
            this.automovilesGrid.AllowUserToAddRows = false;
            this.automovilesGrid.AllowUserToDeleteRows = false;
            this.automovilesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.automovilesGrid.Location = new System.Drawing.Point(12, 163);
            this.automovilesGrid.MultiSelect = false;
            this.automovilesGrid.Name = "automovilesGrid";
            this.automovilesGrid.ReadOnly = true;
            this.automovilesGrid.Size = new System.Drawing.Size(345, 162);
            this.automovilesGrid.TabIndex = 9;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(282, 128);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 8;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(12, 128);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 7;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modeloComboBox);
            this.groupBox1.Controls.Add(this.marcaComboBox);
            this.groupBox1.Controls.Add(this.choferTextBox);
            this.groupBox1.Controls.Add(this.patenteTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(57, 66);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(100, 21);
            this.modeloComboBox.TabIndex = 7;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(57, 27);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(100, 21);
            this.marcaComboBox.TabIndex = 1;
            // 
            // choferTextBox
            // 
            this.choferTextBox.Location = new System.Drawing.Point(231, 66);
            this.choferTextBox.Name = "choferTextBox";
            this.choferTextBox.Size = new System.Drawing.Size(100, 20);
            this.choferTextBox.TabIndex = 6;
            // 
            // patenteTextBox
            // 
            this.patenteTextBox.Location = new System.Drawing.Point(231, 27);
            this.patenteTextBox.Name = "patenteTextBox";
            this.patenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.patenteTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(184, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chofer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(178, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTOMOVILBindingSource
            // 
            this.aUTOMOVILBindingSource.DataMember = "AUTOMOVIL";
            this.aUTOMOVILBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // aUTOMOVILTableAdapter
            // 
            this.aUTOMOVILTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoBajaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 371);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.automovilesGrid);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoBajaAutomovil";
            this.Text = "Baja de Automóvil";
            ((System.ComponentModel.ISupportInitialize)(this.automovilesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOMOVILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView automovilesGrid;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.TextBox choferTextBox;
        private System.Windows.Forms.TextBox patenteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource aUTOMOVILBindingSource;
        private GD1C2017DataSetTableAdapters.AUTOMOVILTableAdapter aUTOMOVILTableAdapter;
    }
}