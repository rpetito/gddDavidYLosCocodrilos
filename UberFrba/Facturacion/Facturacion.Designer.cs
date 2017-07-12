namespace UberFrba.Facturacion
{
    partial class Facturacion
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
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.facturarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viajesGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.busquedaClienteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anioLabel = new System.Windows.Forms.Label();
            this.mesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viajesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Enabled = false;
            this.clienteTextBox.Location = new System.Drawing.Point(86, 66);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.clienteTextBox.TabIndex = 25;
            // 
            // facturarButton
            // 
            this.facturarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturarButton.Location = new System.Drawing.Point(201, 314);
            this.facturarButton.Name = "facturarButton";
            this.facturarButton.Size = new System.Drawing.Size(75, 23);
            this.facturarButton.TabIndex = 24;
            this.facturarButton.Text = "Facturar";
            this.facturarButton.UseVisualStyleBackColor = true;
            this.facturarButton.Click += new System.EventHandler(this.facturarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(106, 314);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 23;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(13, 314);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 22;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(159, 275);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viajesGrid);
            this.groupBox1.Location = new System.Drawing.Point(16, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 173);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viajes";
            // 
            // viajesGrid
            // 
            this.viajesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesGrid.Location = new System.Drawing.Point(6, 19);
            this.viajesGrid.Name = "viajesGrid";
            this.viajesGrid.Size = new System.Drawing.Size(231, 148);
            this.viajesGrid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mes:";
            // 
            // busquedaClienteButton
            // 
            this.busquedaClienteButton.Location = new System.Drawing.Point(213, 63);
            this.busquedaClienteButton.Name = "busquedaClienteButton";
            this.busquedaClienteButton.Size = new System.Drawing.Size(29, 23);
            this.busquedaClienteButton.TabIndex = 16;
            this.busquedaClienteButton.Text = "...";
            this.busquedaClienteButton.UseVisualStyleBackColor = true;
            this.busquedaClienteButton.Click += new System.EventHandler(this.busquedaCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Año:";
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(134, 18);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(70, 13);
            this.anioLabel.TabIndex = 26;
            this.anioLabel.Text = "Año corriente";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(134, 44);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(72, 13);
            this.mesLabel.TabIndex = 27;
            this.mesLabel.Text = "Mes Corriente";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 351);
            this.Controls.Add(this.mesLabel);
            this.Controls.Add(this.anioLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.facturarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busquedaClienteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturacion";
            this.Text = "Facturación";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viajesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Button facturarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView viajesGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button busquedaClienteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Label mesLabel;
    }
}