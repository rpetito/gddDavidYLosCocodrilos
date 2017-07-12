namespace UberFrba.Abm_Cliente
{
    partial class FormularioModCliente
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
            this.fechaNacimientoSelDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.habilitadoCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailSelTextBox = new System.Windows.Forms.TextBox();
            this.dniSelTextBox = new System.Windows.Forms.TextBox();
            this.apellidoSelTextBox = new System.Windows.Forms.TextBox();
            this.nombreSelTextBox = new System.Windows.Forms.TextBox();
            this.pisoSelTextBox = new System.Windows.Forms.TextBox();
            this.codigoSelTextBox = new System.Windows.Forms.TextBox();
            this.localidadSelTextBox = new System.Windows.Forms.TextBox();
            this.departamentoSelTextBox = new System.Windows.Forms.TextBox();
            this.telefonoSelTextBox = new System.Windows.Forms.TextBox();
            this.direccionSelTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.modificarSelButton = new System.Windows.Forms.Button();
            this.limpiarSelButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechaNacimientoSelDatePicker);
            this.groupBox2.Controls.Add(this.cancelarButton);
            this.groupBox2.Controls.Add(this.habilitadoCheckBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mailSelTextBox);
            this.groupBox2.Controls.Add(this.dniSelTextBox);
            this.groupBox2.Controls.Add(this.apellidoSelTextBox);
            this.groupBox2.Controls.Add(this.nombreSelTextBox);
            this.groupBox2.Controls.Add(this.pisoSelTextBox);
            this.groupBox2.Controls.Add(this.codigoSelTextBox);
            this.groupBox2.Controls.Add(this.localidadSelTextBox);
            this.groupBox2.Controls.Add(this.departamentoSelTextBox);
            this.groupBox2.Controls.Add(this.telefonoSelTextBox);
            this.groupBox2.Controls.Add(this.direccionSelTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.modificarSelButton);
            this.groupBox2.Controls.Add(this.limpiarSelButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 386);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente seleccionado";
            // 
            // fechaNacimientoSelDatePicker
            // 
            this.fechaNacimientoSelDatePicker.Location = new System.Drawing.Point(124, 115);
            this.fechaNacimientoSelDatePicker.Name = "fechaNacimientoSelDatePicker";
            this.fechaNacimientoSelDatePicker.Size = new System.Drawing.Size(128, 20);
            this.fechaNacimientoSelDatePicker.TabIndex = 147;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(6, 351);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 83;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // habilitadoCheckBox
            // 
            this.habilitadoCheckBox.AutoSize = true;
            this.habilitadoCheckBox.Location = new System.Drawing.Point(66, 326);
            this.habilitadoCheckBox.Name = "habilitadoCheckBox";
            this.habilitadoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.habilitadoCheckBox.Size = new System.Drawing.Size(73, 17);
            this.habilitadoCheckBox.TabIndex = 146;
            this.habilitadoCheckBox.Text = "Habilitado";
            this.habilitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 145;
            this.label6.Text = "Mail:";
            // 
            // mailSelTextBox
            // 
            this.mailSelTextBox.Location = new System.Drawing.Point(124, 295);
            this.mailSelTextBox.Name = "mailSelTextBox";
            this.mailSelTextBox.Size = new System.Drawing.Size(128, 20);
            this.mailSelTextBox.TabIndex = 144;
            // 
            // dniSelTextBox
            // 
            this.dniSelTextBox.Enabled = false;
            this.dniSelTextBox.Location = new System.Drawing.Point(124, 85);
            this.dniSelTextBox.Name = "dniSelTextBox";
            this.dniSelTextBox.Size = new System.Drawing.Size(128, 20);
            this.dniSelTextBox.TabIndex = 143;
            // 
            // apellidoSelTextBox
            // 
            this.apellidoSelTextBox.Location = new System.Drawing.Point(124, 55);
            this.apellidoSelTextBox.Name = "apellidoSelTextBox";
            this.apellidoSelTextBox.Size = new System.Drawing.Size(128, 20);
            this.apellidoSelTextBox.TabIndex = 142;
            // 
            // nombreSelTextBox
            // 
            this.nombreSelTextBox.Location = new System.Drawing.Point(124, 25);
            this.nombreSelTextBox.Name = "nombreSelTextBox";
            this.nombreSelTextBox.Size = new System.Drawing.Size(128, 20);
            this.nombreSelTextBox.TabIndex = 141;
            // 
            // pisoSelTextBox
            // 
            this.pisoSelTextBox.Location = new System.Drawing.Point(152, 235);
            this.pisoSelTextBox.Name = "pisoSelTextBox";
            this.pisoSelTextBox.Size = new System.Drawing.Size(25, 20);
            this.pisoSelTextBox.TabIndex = 139;
            // 
            // codigoSelTextBox
            // 
            this.codigoSelTextBox.Location = new System.Drawing.Point(152, 265);
            this.codigoSelTextBox.Name = "codigoSelTextBox";
            this.codigoSelTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoSelTextBox.TabIndex = 138;
            // 
            // localidadSelTextBox
            // 
            this.localidadSelTextBox.Location = new System.Drawing.Point(152, 205);
            this.localidadSelTextBox.Name = "localidadSelTextBox";
            this.localidadSelTextBox.Size = new System.Drawing.Size(100, 20);
            this.localidadSelTextBox.TabIndex = 137;
            // 
            // departamentoSelTextBox
            // 
            this.departamentoSelTextBox.Location = new System.Drawing.Point(231, 235);
            this.departamentoSelTextBox.Name = "departamentoSelTextBox";
            this.departamentoSelTextBox.Size = new System.Drawing.Size(21, 20);
            this.departamentoSelTextBox.TabIndex = 136;
            // 
            // telefonoSelTextBox
            // 
            this.telefonoSelTextBox.Location = new System.Drawing.Point(124, 145);
            this.telefonoSelTextBox.Name = "telefonoSelTextBox";
            this.telefonoSelTextBox.Size = new System.Drawing.Size(128, 20);
            this.telefonoSelTextBox.TabIndex = 135;
            // 
            // direccionSelTextBox
            // 
            this.direccionSelTextBox.Location = new System.Drawing.Point(124, 175);
            this.direccionSelTextBox.Name = "direccionSelTextBox";
            this.direccionSelTextBox.Size = new System.Drawing.Size(128, 20);
            this.direccionSelTextBox.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 133;
            this.label11.Text = "Fecha de Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 132;
            this.label10.Text = "Depto.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 131;
            this.label9.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Piso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 129;
            this.label7.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "DNI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 126;
            this.label12.Text = "Cód. Postal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 125;
            this.label13.Text = "Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 124;
            this.label14.Text = "Nombre:";
            // 
            // modificarSelButton
            // 
            this.modificarSelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarSelButton.Location = new System.Drawing.Point(209, 350);
            this.modificarSelButton.Name = "modificarSelButton";
            this.modificarSelButton.Size = new System.Drawing.Size(75, 23);
            this.modificarSelButton.TabIndex = 79;
            this.modificarSelButton.Text = "Modificar";
            this.modificarSelButton.UseVisualStyleBackColor = true;
            this.modificarSelButton.Click += new System.EventHandler(this.modificarSelButton_Click);
            // 
            // limpiarSelButton
            // 
            this.limpiarSelButton.Location = new System.Drawing.Point(106, 351);
            this.limpiarSelButton.Name = "limpiarSelButton";
            this.limpiarSelButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarSelButton.TabIndex = 78;
            this.limpiarSelButton.Text = "Limpiar";
            this.limpiarSelButton.UseVisualStyleBackColor = true;
            this.limpiarSelButton.Click += new System.EventHandler(this.limpiarSelButton_Click);
            // 
            // FormularioModCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 409);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormularioModCliente";
            this.Text = "FormularioModCliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.CheckBox habilitadoCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailSelTextBox;
        private System.Windows.Forms.TextBox dniSelTextBox;
        private System.Windows.Forms.TextBox apellidoSelTextBox;
        private System.Windows.Forms.TextBox nombreSelTextBox;
        private System.Windows.Forms.TextBox pisoSelTextBox;
        private System.Windows.Forms.TextBox codigoSelTextBox;
        private System.Windows.Forms.TextBox localidadSelTextBox;
        private System.Windows.Forms.TextBox departamentoSelTextBox;
        private System.Windows.Forms.TextBox telefonoSelTextBox;
        private System.Windows.Forms.TextBox direccionSelTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button modificarSelButton;
        private System.Windows.Forms.Button limpiarSelButton;
        private System.Windows.Forms.DateTimePicker fechaNacimientoSelDatePicker;
    }
}