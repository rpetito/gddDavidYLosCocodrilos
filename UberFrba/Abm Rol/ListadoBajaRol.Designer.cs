namespace UberFrba.Abm_Rol
{
    partial class ListadoBajaRol
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.limpiarButton = new System.Windows.Forms.Button();
			this.eliminarButton = new System.Windows.Forms.Button();
			this.buscarButton = new System.Windows.Forms.Button();
			this.cancelarButton = new System.Windows.Forms.Button();
			this.rolesGrid = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rolesGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nombreTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox1.Location = new System.Drawing.Point(20, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(205, 64);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros de Búsqueda";
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.Location = new System.Drawing.Point(57, 27);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
			this.nombreTextBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label1.Location = new System.Drawing.Point(11, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// limpiarButton
			// 
			this.limpiarButton.Location = new System.Drawing.Point(20, 89);
			this.limpiarButton.Name = "limpiarButton";
			this.limpiarButton.Size = new System.Drawing.Size(75, 23);
			this.limpiarButton.TabIndex = 13;
			this.limpiarButton.Text = "Limpiar";
			this.limpiarButton.UseVisualStyleBackColor = true;
			this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
			// 
			// eliminarButton
			// 
			this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eliminarButton.Location = new System.Drawing.Point(150, 314);
			this.eliminarButton.Name = "eliminarButton";
			this.eliminarButton.Size = new System.Drawing.Size(75, 23);
			this.eliminarButton.TabIndex = 17;
			this.eliminarButton.Text = "Eliminar";
			this.eliminarButton.UseVisualStyleBackColor = true;
			this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
			// 
			// buscarButton
			// 
			this.buscarButton.Location = new System.Drawing.Point(150, 89);
			this.buscarButton.Name = "buscarButton";
			this.buscarButton.Size = new System.Drawing.Size(75, 23);
			this.buscarButton.TabIndex = 14;
			this.buscarButton.Text = "Buscar";
			this.buscarButton.UseVisualStyleBackColor = true;
			this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
			// 
			// cancelarButton
			// 
			this.cancelarButton.Location = new System.Drawing.Point(20, 314);
			this.cancelarButton.Name = "cancelarButton";
			this.cancelarButton.Size = new System.Drawing.Size(75, 23);
			this.cancelarButton.TabIndex = 16;
			this.cancelarButton.Text = "Cancelar";
			this.cancelarButton.UseVisualStyleBackColor = true;
			this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
			// 
			// rolesGrid
			// 
			this.rolesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rolesGrid.Location = new System.Drawing.Point(20, 131);
			this.rolesGrid.Name = "rolesGrid";
			this.rolesGrid.Size = new System.Drawing.Size(205, 162);
			this.rolesGrid.TabIndex = 15;
			// 
			// ListadoBajaRol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 356);
			this.Controls.Add(this.limpiarButton);
			this.Controls.Add(this.eliminarButton);
			this.Controls.Add(this.buscarButton);
			this.Controls.Add(this.cancelarButton);
			this.Controls.Add(this.rolesGrid);
			this.Controls.Add(this.groupBox1);
			this.Name = "ListadoBajaRol";
			this.Text = "Baja de Rol";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rolesGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView rolesGrid;
    }
}