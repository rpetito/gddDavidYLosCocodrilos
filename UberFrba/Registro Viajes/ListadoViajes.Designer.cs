namespace UberFrba.Registro_Viajes
{
    partial class ListadoViajes
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
            this.viajesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viajesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viajesGrid
            // 
            this.viajesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesGrid.Location = new System.Drawing.Point(12, 12);
            this.viajesGrid.Name = "viajesGrid";
            this.viajesGrid.Size = new System.Drawing.Size(366, 237);
            this.viajesGrid.TabIndex = 0;
            // 
            // ListadoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.viajesGrid);
            this.Name = "ListadoViajes";
            this.Text = "Listado de Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.viajesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viajesGrid;

    }
}