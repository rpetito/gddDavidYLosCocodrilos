namespace UberFrba.Rendicion_Viajes
{
    partial class Rendicion
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
            this.fechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.busquedaChoferButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.turnoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viajesGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.rendirButton = new System.Windows.Forms.Button();
            this.choferTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viajesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // fechaTimePicker
            // 
            this.fechaTimePicker.Location = new System.Drawing.Point(58, 16);
            this.fechaTimePicker.Name = "fechaTimePicker";
            this.fechaTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chofer:";
            // 
            // busquedaChoferButton
            // 
            this.busquedaChoferButton.Location = new System.Drawing.Point(229, 41);
            this.busquedaChoferButton.Name = "busquedaChoferButton";
            this.busquedaChoferButton.Size = new System.Drawing.Size(29, 23);
            this.busquedaChoferButton.TabIndex = 3;
            this.busquedaChoferButton.Text = "...";
            this.busquedaChoferButton.UseVisualStyleBackColor = true;
            this.busquedaChoferButton.Click += new System.EventHandler(this.busquedaChoferButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno:";
            // 
            // turnoComboBox
            // 
            this.turnoComboBox.FormattingEnabled = true;
            this.turnoComboBox.Location = new System.Drawing.Point(59, 70);
            this.turnoComboBox.Name = "turnoComboBox";
            this.turnoComboBox.Size = new System.Drawing.Size(41, 21);
            this.turnoComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viajesGrid);
            this.groupBox1.Location = new System.Drawing.Point(15, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 173);
            this.groupBox1.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(158, 277);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 8;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(12, 316);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 9;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(105, 316);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 10;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // rendirButton
            // 
            this.rendirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendirButton.Location = new System.Drawing.Point(200, 316);
            this.rendirButton.Name = "rendirButton";
            this.rendirButton.Size = new System.Drawing.Size(75, 23);
            this.rendirButton.TabIndex = 11;
            this.rendirButton.Text = "Rendir";
            this.rendirButton.UseVisualStyleBackColor = true;
            // 
            // choferTextBox
            // 
            this.choferTextBox.Location = new System.Drawing.Point(59, 44);
            this.choferTextBox.Name = "choferTextBox";
            this.choferTextBox.Size = new System.Drawing.Size(164, 20);
            this.choferTextBox.TabIndex = 12;
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 351);
            this.Controls.Add(this.choferTextBox);
            this.Controls.Add(this.rendirButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.turnoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busquedaChoferButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "Rendicion";
            this.Text = "Rendición";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viajesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button busquedaChoferButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox turnoComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView viajesGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button rendirButton;
        private System.Windows.Forms.TextBox choferTextBox;
    }
}