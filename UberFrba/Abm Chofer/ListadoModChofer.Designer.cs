namespace UberFrba.Abm_Chofer
{
    partial class ListadoModChofer
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
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.choferesGrid = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intentosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choferesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.dniTextBox);
            this.groupBox1.Controls.Add(this.apellidoTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 106);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(57, 27);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(233, 27);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 5;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(57, 67);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(198, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(12, 129);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 104;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Location = new System.Drawing.Point(282, 345);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.seleccionarButton.TabIndex = 108;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.seleccionarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(282, 129);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 105;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(12, 345);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 107;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // choferesGrid
            // 
            this.choferesGrid.AllowUserToAddRows = false;
            this.choferesGrid.AllowUserToDeleteRows = false;
            this.choferesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.choferesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.apellidoColumn,
            this.dniColumn,
            this.mailColumn,
            this.telefonoColumn,
            this.direccionColumn,
            this.pisoColumn,
            this.departamentoColumn,
            this.localidadColumn,
            this.fechaNacColumn,
            this.usernameColumn,
            this.contraseniaColumn,
            this.intentosColumn,
            this.habilitadoColumn});
            this.choferesGrid.Location = new System.Drawing.Point(12, 164);
            this.choferesGrid.MultiSelect = false;
            this.choferesGrid.Name = "choferesGrid";
            this.choferesGrid.ReadOnly = true;
            this.choferesGrid.Size = new System.Drawing.Size(345, 162);
            this.choferesGrid.TabIndex = 19;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            // 
            // apellidoColumn
            // 
            this.apellidoColumn.HeaderText = "Apellido";
            this.apellidoColumn.Name = "apellidoColumn";
            this.apellidoColumn.ReadOnly = true;
            // 
            // dniColumn
            // 
            this.dniColumn.HeaderText = "DNI";
            this.dniColumn.Name = "dniColumn";
            this.dniColumn.ReadOnly = true;
            // 
            // mailColumn
            // 
            this.mailColumn.HeaderText = "Mail";
            this.mailColumn.Name = "mailColumn";
            this.mailColumn.ReadOnly = true;
            // 
            // telefonoColumn
            // 
            this.telefonoColumn.HeaderText = "Teléfono";
            this.telefonoColumn.Name = "telefonoColumn";
            this.telefonoColumn.ReadOnly = true;
            // 
            // direccionColumn
            // 
            this.direccionColumn.HeaderText = "Dirección";
            this.direccionColumn.Name = "direccionColumn";
            this.direccionColumn.ReadOnly = true;
            // 
            // pisoColumn
            // 
            this.pisoColumn.HeaderText = "Piso";
            this.pisoColumn.Name = "pisoColumn";
            this.pisoColumn.ReadOnly = true;
            // 
            // departamentoColumn
            // 
            this.departamentoColumn.HeaderText = "Departamento";
            this.departamentoColumn.Name = "departamentoColumn";
            this.departamentoColumn.ReadOnly = true;
            // 
            // localidadColumn
            // 
            this.localidadColumn.HeaderText = "Localidad";
            this.localidadColumn.Name = "localidadColumn";
            this.localidadColumn.ReadOnly = true;
            // 
            // fechaNacColumn
            // 
            this.fechaNacColumn.HeaderText = "Fecha de Nacimiento";
            this.fechaNacColumn.Name = "fechaNacColumn";
            this.fechaNacColumn.ReadOnly = true;
            // 
            // usernameColumn
            // 
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            // 
            // contraseniaColumn
            // 
            this.contraseniaColumn.HeaderText = "Contraseña";
            this.contraseniaColumn.Name = "contraseniaColumn";
            this.contraseniaColumn.ReadOnly = true;
            // 
            // intentosColumn
            // 
            this.intentosColumn.HeaderText = "Intentos de Logeo";
            this.intentosColumn.Name = "intentosColumn";
            this.intentosColumn.ReadOnly = true;
            // 
            // habilitadoColumn
            // 
            this.habilitadoColumn.HeaderText = "Habilitado";
            this.habilitadoColumn.Name = "habilitadoColumn";
            this.habilitadoColumn.ReadOnly = true;
            // 
            // ListadoModChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 381);
            this.Controls.Add(this.choferesGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.seleccionarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.cancelarButton);
            this.Name = "ListadoModChofer";
            this.Text = "Modificación de Chofer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choferesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button seleccionarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView choferesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseniaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intentosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilitadoColumn;
    }
}