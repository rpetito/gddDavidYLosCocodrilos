namespace UberFrba.Abm_Turno
{
    partial class ListadoModTurno
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
            this.baseSelTextBox = new System.Windows.Forms.TextBox();
            this.kilometroSelTextBox = new System.Windows.Forms.TextBox();
            this.descripcionSelTextBox = new System.Windows.Forms.TextBox();
            this.horaFinSelComboBox = new System.Windows.Forms.ComboBox();
            this.horaInicioSelComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.habilitadoCheckBox = new System.Windows.Forms.CheckBox();
            this.limpiarSelButton = new System.Windows.Forms.Button();
            this.modificarSelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.selecionarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.turnosGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baseSelTextBox);
            this.groupBox2.Controls.Add(this.kilometroSelTextBox);
            this.groupBox2.Controls.Add(this.descripcionSelTextBox);
            this.groupBox2.Controls.Add(this.horaFinSelComboBox);
            this.groupBox2.Controls.Add(this.horaInicioSelComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.habilitadoCheckBox);
            this.groupBox2.Controls.Add(this.limpiarSelButton);
            this.groupBox2.Controls.Add(this.modificarSelButton);
            this.groupBox2.Location = new System.Drawing.Point(391, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 311);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno seleccionado";
            // 
            // baseSelTextBox
            // 
            this.baseSelTextBox.Enabled = false;
            this.baseSelTextBox.Location = new System.Drawing.Point(140, 198);
            this.baseSelTextBox.Name = "baseSelTextBox";
            this.baseSelTextBox.Size = new System.Drawing.Size(123, 20);
            this.baseSelTextBox.TabIndex = 62;
            // 
            // kilometroSelTextBox
            // 
            this.kilometroSelTextBox.Enabled = false;
            this.kilometroSelTextBox.Location = new System.Drawing.Point(140, 158);
            this.kilometroSelTextBox.Name = "kilometroSelTextBox";
            this.kilometroSelTextBox.Size = new System.Drawing.Size(123, 20);
            this.kilometroSelTextBox.TabIndex = 61;
            // 
            // descripcionSelTextBox
            // 
            this.descripcionSelTextBox.Enabled = false;
            this.descripcionSelTextBox.Location = new System.Drawing.Point(140, 118);
            this.descripcionSelTextBox.Name = "descripcionSelTextBox";
            this.descripcionSelTextBox.Size = new System.Drawing.Size(121, 20);
            this.descripcionSelTextBox.TabIndex = 60;
            // 
            // horaFinSelComboBox
            // 
            this.horaFinSelComboBox.Enabled = false;
            this.horaFinSelComboBox.FormattingEnabled = true;
            this.horaFinSelComboBox.Location = new System.Drawing.Point(140, 78);
            this.horaFinSelComboBox.Name = "horaFinSelComboBox";
            this.horaFinSelComboBox.Size = new System.Drawing.Size(121, 21);
            this.horaFinSelComboBox.TabIndex = 59;
            // 
            // horaInicioSelComboBox
            // 
            this.horaInicioSelComboBox.Enabled = false;
            this.horaInicioSelComboBox.FormattingEnabled = true;
            this.horaInicioSelComboBox.Location = new System.Drawing.Point(140, 38);
            this.horaInicioSelComboBox.Name = "horaInicioSelComboBox";
            this.horaInicioSelComboBox.Size = new System.Drawing.Size(121, 21);
            this.horaInicioSelComboBox.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Precio base del turno ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Valor del kilometro ($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Hora de finalización:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Hora de inicio:";
            // 
            // habilitadoCheckBox
            // 
            this.habilitadoCheckBox.AutoSize = true;
            this.habilitadoCheckBox.Enabled = false;
            this.habilitadoCheckBox.Location = new System.Drawing.Point(81, 236);
            this.habilitadoCheckBox.Name = "habilitadoCheckBox";
            this.habilitadoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.habilitadoCheckBox.Size = new System.Drawing.Size(73, 17);
            this.habilitadoCheckBox.TabIndex = 10;
            this.habilitadoCheckBox.Text = "Habilitado";
            this.habilitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // limpiarSelButton
            // 
            this.limpiarSelButton.Enabled = false;
            this.limpiarSelButton.Location = new System.Drawing.Point(79, 276);
            this.limpiarSelButton.Name = "limpiarSelButton";
            this.limpiarSelButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarSelButton.TabIndex = 52;
            this.limpiarSelButton.Text = "Limpiar";
            this.limpiarSelButton.UseVisualStyleBackColor = true;
            this.limpiarSelButton.Click += new System.EventHandler(this.limpiarSelButton_Click);
            // 
            // modificarSelButton
            // 
            this.modificarSelButton.Enabled = false;
            this.modificarSelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarSelButton.Location = new System.Drawing.Point(195, 276);
            this.modificarSelButton.Name = "modificarSelButton";
            this.modificarSelButton.Size = new System.Drawing.Size(75, 23);
            this.modificarSelButton.TabIndex = 51;
            this.modificarSelButton.Text = "Modificar";
            this.modificarSelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 66);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(83, 27);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(248, 20);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(12, 87);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 10;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // selecionarButton
            // 
            this.selecionarButton.Location = new System.Drawing.Point(282, 303);
            this.selecionarButton.Name = "selecionarButton";
            this.selecionarButton.Size = new System.Drawing.Size(75, 23);
            this.selecionarButton.TabIndex = 14;
            this.selecionarButton.Text = "Seleccionar";
            this.selecionarButton.UseVisualStyleBackColor = true;
            this.selecionarButton.Click += new System.EventHandler(this.selecionarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(282, 87);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(12, 303);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 13;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // turnosGrid
            // 
            this.turnosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnosGrid.Location = new System.Drawing.Point(12, 120);
            this.turnosGrid.Name = "turnosGrid";
            this.turnosGrid.Size = new System.Drawing.Size(345, 162);
            this.turnosGrid.TabIndex = 12;
            // 
            // ListadoModTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.selecionarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.turnosGrid);
            this.Controls.Add(this.groupBox2);
            this.Name = "ListadoModTurno";
            this.Text = "Modificación de Turno";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button limpiarSelButton;
        private System.Windows.Forms.Button modificarSelButton;
        private System.Windows.Forms.CheckBox habilitadoCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button selecionarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView turnosGrid;
        private System.Windows.Forms.TextBox baseSelTextBox;
        private System.Windows.Forms.TextBox kilometroSelTextBox;
        private System.Windows.Forms.TextBox descripcionSelTextBox;
        private System.Windows.Forms.ComboBox horaFinSelComboBox;
        private System.Windows.Forms.ComboBox horaInicioSelComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}