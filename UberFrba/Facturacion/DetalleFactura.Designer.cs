namespace UberFrba.Facturacion
{
    partial class DetalleFactura
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.detallesGrid = new System.Windows.Forms.DataGridView();
            this.salirButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(12, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(58, 17);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre";
            // 
            // detallesGrid
            // 
            this.detallesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesGrid.Location = new System.Drawing.Point(12, 35);
            this.detallesGrid.Name = "detallesGrid";
            this.detallesGrid.ReadOnly = true;
            this.detallesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detallesGrid.Size = new System.Drawing.Size(407, 287);
            this.detallesGrid.TabIndex = 1;
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(12, 367);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(75, 23);
            this.salirButton.TabIndex = 2;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(344, 367);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 402);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.detallesGrid);
            this.Controls.Add(this.nombreLabel);
            this.Name = "DetalleFactura";
            this.Text = "Detalle Factura";
            ((System.ComponentModel.ISupportInitialize)(this.detallesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.DataGridView detallesGrid;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button okButton;
    }
}