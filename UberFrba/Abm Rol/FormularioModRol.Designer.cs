namespace UberFrba.Abm_Rol
{
    partial class FormularioModRol
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cancelarButton = new System.Windows.Forms.Button();
			this.habilitadoCheckBox = new System.Windows.Forms.CheckBox();
			this.nombreSelTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.modificarSelButton = new System.Windows.Forms.Button();
			this.functionalityText = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.functionalityText);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.cancelarButton);
			this.groupBox2.Controls.Add(this.habilitadoCheckBox);
			this.groupBox2.Controls.Add(this.nombreSelTextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.modificarSelButton);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(353, 328);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rol seleccionado";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(34, 127);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(287, 23);
			this.button2.TabIndex = 57;
			this.button2.Text = "Remover Funcionalidad";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.removerButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(287, 23);
			this.button1.TabIndex = 56;
			this.button1.Text = "Agregar Funcionalidad";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.agregarButton_Click);
			// 
			// cancelarButton
			// 
			this.cancelarButton.Location = new System.Drawing.Point(6, 299);
			this.cancelarButton.Name = "cancelarButton";
			this.cancelarButton.Size = new System.Drawing.Size(75, 23);
			this.cancelarButton.TabIndex = 55;
			this.cancelarButton.Text = "Cancelar";
			this.cancelarButton.UseVisualStyleBackColor = true;
			this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
			// 
			// habilitadoCheckBox
			// 
			this.habilitadoCheckBox.AutoSize = true;
			this.habilitadoCheckBox.Location = new System.Drawing.Point(248, 29);
			this.habilitadoCheckBox.Name = "habilitadoCheckBox";
			this.habilitadoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.habilitadoCheckBox.Size = new System.Drawing.Size(73, 17);
			this.habilitadoCheckBox.TabIndex = 12;
			this.habilitadoCheckBox.Text = "Habilitado";
			this.habilitadoCheckBox.UseVisualStyleBackColor = true;
			// 
			// nombreSelTextBox
			// 
			this.nombreSelTextBox.Location = new System.Drawing.Point(84, 27);
			this.nombreSelTextBox.Name = "nombreSelTextBox";
			this.nombreSelTextBox.Size = new System.Drawing.Size(100, 20);
			this.nombreSelTextBox.TabIndex = 47;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(31, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 42;
			this.label9.Text = "Nombre:";
			// 
			// modificarSelButton
			// 
			this.modificarSelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modificarSelButton.Location = new System.Drawing.Point(272, 299);
			this.modificarSelButton.Name = "modificarSelButton";
			this.modificarSelButton.Size = new System.Drawing.Size(75, 23);
			this.modificarSelButton.TabIndex = 51;
			this.modificarSelButton.Text = "Modificar";
			this.modificarSelButton.UseVisualStyleBackColor = true;
			this.modificarSelButton.Click += new System.EventHandler(this.modificarSelButton_Click);
			// 
			// functionalityText
			// 
			this.functionalityText.AutoSize = true;
			this.functionalityText.Location = new System.Drawing.Point(31, 185);
			this.functionalityText.Name = "functionalityText";
			this.functionalityText.Size = new System.Drawing.Size(35, 13);
			this.functionalityText.TabIndex = 58;
			this.functionalityText.Text = "label1";
			// 
			// FormularioModRol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 352);
			this.Controls.Add(this.groupBox2);
			this.Name = "FormularioModRol";
			this.Text = "FormularioModRol";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelarButton;
		private System.Windows.Forms.CheckBox habilitadoCheckBox;
        private System.Windows.Forms.TextBox nombreSelTextBox;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button modificarSelButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label functionalityText;
    }
}