namespace UberFrba.Listado_Estadistico
{
    partial class Listado
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
            this.numericUpDown_Mes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Anio = new System.Windows.Forms.NumericUpDown();
            this.label_Trimestre = new System.Windows.Forms.Label();
            this.label_TipoListado = new System.Windows.Forms.Label();
            this.label_Anio = new System.Windows.Forms.Label();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_HacerConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_TipoListado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_Mes
            // 
            this.numericUpDown_Mes.Location = new System.Drawing.Point(317, 31);
            this.numericUpDown_Mes.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_Mes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Mes.Name = "numericUpDown_Mes";
            this.numericUpDown_Mes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Mes.TabIndex = 29;
            this.numericUpDown_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Mes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Mes.ValueChanged += new System.EventHandler(this.numericUpDown_Mes_ValueChanged);
            // 
            // numericUpDown_Anio
            // 
            this.numericUpDown_Anio.Location = new System.Drawing.Point(77, 31);
            this.numericUpDown_Anio.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown_Anio.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDown_Anio.Name = "numericUpDown_Anio";
            this.numericUpDown_Anio.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Anio.TabIndex = 26;
            this.numericUpDown_Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Anio.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numericUpDown_Anio.ValueChanged += new System.EventHandler(this.numericUpDown_Anio_ValueChanged);
            // 
            // label_Trimestre
            // 
            this.label_Trimestre.AutoSize = true;
            this.label_Trimestre.Location = new System.Drawing.Point(261, 33);
            this.label_Trimestre.Name = "label_Trimestre";
            this.label_Trimestre.Size = new System.Drawing.Size(50, 13);
            this.label_Trimestre.TabIndex = 22;
            this.label_Trimestre.Text = "Trimestre";
            // 
            // label_TipoListado
            // 
            this.label_TipoListado.AutoSize = true;
            this.label_TipoListado.Location = new System.Drawing.Point(45, 63);
            this.label_TipoListado.Name = "label_TipoListado";
            this.label_TipoListado.Size = new System.Drawing.Size(76, 13);
            this.label_TipoListado.TabIndex = 24;
            this.label_TipoListado.Text = "Tipo de listado";
            // 
            // label_Anio
            // 
            this.label_Anio.AutoSize = true;
            this.label_Anio.Location = new System.Drawing.Point(45, 33);
            this.label_Anio.Name = "label_Anio";
            this.label_Anio.Size = new System.Drawing.Size(26, 13);
            this.label_Anio.TabIndex = 21;
            this.label_Anio.Text = "Año";
            // 
            // button_Volver
            // 
            this.button_Volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Volver.Location = new System.Drawing.Point(470, 92);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 20;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(470, 63);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 19;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_HacerConsulta
            // 
            this.button_HacerConsulta.Location = new System.Drawing.Point(470, 22);
            this.button_HacerConsulta.Name = "button_HacerConsulta";
            this.button_HacerConsulta.Size = new System.Drawing.Size(75, 35);
            this.button_HacerConsulta.TabIndex = 18;
            this.button_HacerConsulta.Text = "Hacer consulta";
            this.button_HacerConsulta.UseVisualStyleBackColor = true;
            this.button_HacerConsulta.Click += new System.EventHandler(this.button_HacerConsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // comboBox_TipoListado
            // 
            this.comboBox_TipoListado.FormattingEnabled = true;
            this.comboBox_TipoListado.Location = new System.Drawing.Point(127, 60);
            this.comboBox_TipoListado.Name = "comboBox_TipoListado";
            this.comboBox_TipoListado.Size = new System.Drawing.Size(309, 21);
            this.comboBox_TipoListado.TabIndex = 17;
            this.comboBox_TipoListado.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoListado_SelectedIndexChanged);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 273);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown_Mes);
            this.Controls.Add(this.numericUpDown_Anio);
            this.Controls.Add(this.label_Trimestre);
            this.Controls.Add(this.comboBox_TipoListado);
            this.Controls.Add(this.label_TipoListado);
            this.Controls.Add(this.label_Anio);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_HacerConsulta);
            this.Name = "Listado";
            this.Text = "Listados Estadisticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Mes;
        private System.Windows.Forms.NumericUpDown numericUpDown_Anio;
        private System.Windows.Forms.Label label_Trimestre;
        private System.Windows.Forms.Label label_TipoListado;
        private System.Windows.Forms.Label label_Anio;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_HacerConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_TipoListado;
    }
}