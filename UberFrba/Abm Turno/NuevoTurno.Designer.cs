namespace UberFrba.Abm_Turno
{
    partial class NuevoTurno
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.kilometroTextBox = new System.Windows.Forms.TextBox();
			this.baseTextBox = new System.Windows.Forms.TextBox();
			this.cancelarButton = new System.Windows.Forms.Button();
			this.limpiarButton = new System.Windows.Forms.Button();
			this.crearButton = new System.Windows.Forms.Button();
			this.horaInicioTextBox = new System.Windows.Forms.TextBox();
			this.horaFin = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hora de inicio:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hora de finalización:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Descripción:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Valor del kilometro ($):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Precio base del turno ($):";
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.Location = new System.Drawing.Point(149, 105);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(121, 20);
			this.descripcionTextBox.TabIndex = 7;
			// 
			// kilometroTextBox
			// 
			this.kilometroTextBox.Location = new System.Drawing.Point(149, 145);
			this.kilometroTextBox.Name = "kilometroTextBox";
			this.kilometroTextBox.Size = new System.Drawing.Size(123, 20);
			this.kilometroTextBox.TabIndex = 8;
			// 
			// baseTextBox
			// 
			this.baseTextBox.Location = new System.Drawing.Point(149, 185);
			this.baseTextBox.Name = "baseTextBox";
			this.baseTextBox.Size = new System.Drawing.Size(123, 20);
			this.baseTextBox.TabIndex = 9;
			// 
			// cancelarButton
			// 
			this.cancelarButton.Location = new System.Drawing.Point(7, 234);
			this.cancelarButton.Name = "cancelarButton";
			this.cancelarButton.Size = new System.Drawing.Size(75, 23);
			this.cancelarButton.TabIndex = 10;
			this.cancelarButton.Text = "Cancelar";
			this.cancelarButton.UseVisualStyleBackColor = true;
			this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
			// 
			// limpiarButton
			// 
			this.limpiarButton.Location = new System.Drawing.Point(102, 234);
			this.limpiarButton.Name = "limpiarButton";
			this.limpiarButton.Size = new System.Drawing.Size(75, 23);
			this.limpiarButton.TabIndex = 11;
			this.limpiarButton.Text = "Limpiar";
			this.limpiarButton.UseVisualStyleBackColor = true;
			this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
			// 
			// crearButton
			// 
			this.crearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.crearButton.Location = new System.Drawing.Point(197, 234);
			this.crearButton.Name = "crearButton";
			this.crearButton.Size = new System.Drawing.Size(75, 23);
			this.crearButton.TabIndex = 12;
			this.crearButton.Text = "Crear";
			this.crearButton.UseVisualStyleBackColor = true;
			this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
			// 
			// horaInicioTextBox
			// 
			this.horaInicioTextBox.Location = new System.Drawing.Point(149, 25);
			this.horaInicioTextBox.Name = "horaInicioTextBox";
			this.horaInicioTextBox.Size = new System.Drawing.Size(121, 20);
			this.horaInicioTextBox.TabIndex = 13;
			// 
			// horaFin
			// 
			this.horaFin.Location = new System.Drawing.Point(149, 65);
			this.horaFin.Name = "horaFin";
			this.horaFin.Size = new System.Drawing.Size(121, 20);
			this.horaFin.TabIndex = 14;
			// 
			// NuevoTurno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 269);
			this.Controls.Add(this.horaFin);
			this.Controls.Add(this.horaInicioTextBox);
			this.Controls.Add(this.crearButton);
			this.Controls.Add(this.limpiarButton);
			this.Controls.Add(this.cancelarButton);
			this.Controls.Add(this.baseTextBox);
			this.Controls.Add(this.kilometroTextBox);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NuevoTurno";
			this.Text = "Nuevo Turno";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox kilometroTextBox;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button crearButton;
		private System.Windows.Forms.TextBox horaInicioTextBox;
		private System.Windows.Forms.TextBox horaFin;
    }
}