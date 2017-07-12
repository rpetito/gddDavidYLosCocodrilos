namespace UberFrba
{
    partial class ListadoTurnos
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
            this.turnosGrid = new System.Windows.Forms.DataGridView();
            this.agregarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turnosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // turnosGrid
            // 
            this.turnosGrid.AllowUserToAddRows = false;
            this.turnosGrid.AllowUserToDeleteRows = false;
            this.turnosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnosGrid.Location = new System.Drawing.Point(12, 12);
            this.turnosGrid.Name = "turnosGrid";
            this.turnosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.turnosGrid.Size = new System.Drawing.Size(338, 238);
            this.turnosGrid.TabIndex = 0;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(235, 260);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(115, 23);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.Text = "Agregar Turnos";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // ListadoTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 295);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.turnosGrid);
            this.Name = "ListadoTurnos";
            this.Text = "ListadoTurnos";
            ((System.ComponentModel.ISupportInitialize)(this.turnosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView turnosGrid;
        private System.Windows.Forms.Button agregarButton;
    }
}