namespace UberFrba
{
    partial class Menu
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
            this.automovilesButton = new System.Windows.Forms.Button();
            this.clientesButton = new System.Windows.Forms.Button();
            this.rolesButton = new System.Windows.Forms.Button();
            this.choferesButton = new System.Windows.Forms.Button();
            this.turnosButton = new System.Windows.Forms.Button();
            this.registroButton = new System.Windows.Forms.Button();
            this.rendicionButton = new System.Windows.Forms.Button();
            this.facturacionButton = new System.Windows.Forms.Button();
            this.administradoresButton = new System.Windows.Forms.Button();
            this.estadisticosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // automovilesButton
            // 
            this.automovilesButton.Location = new System.Drawing.Point(42, 26);
            this.automovilesButton.Name = "automovilesButton";
            this.automovilesButton.Size = new System.Drawing.Size(75, 23);
            this.automovilesButton.TabIndex = 0;
            this.automovilesButton.Text = "Automoviles";
            this.automovilesButton.UseVisualStyleBackColor = true;
            this.automovilesButton.Click += new System.EventHandler(this.automovilesButton_Click);
            // 
            // clientesButton
            // 
            this.clientesButton.Location = new System.Drawing.Point(245, 242);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Size = new System.Drawing.Size(75, 23);
            this.clientesButton.TabIndex = 1;
            this.clientesButton.Text = "Clientes";
            this.clientesButton.UseVisualStyleBackColor = true;
            this.clientesButton.Click += new System.EventHandler(this.clientesButton_Click);
            // 
            // rolesButton
            // 
            this.rolesButton.Location = new System.Drawing.Point(42, 118);
            this.rolesButton.Name = "rolesButton";
            this.rolesButton.Size = new System.Drawing.Size(75, 23);
            this.rolesButton.TabIndex = 2;
            this.rolesButton.Text = "Roles";
            this.rolesButton.UseVisualStyleBackColor = true;
            this.rolesButton.Click += new System.EventHandler(this.rolesButton_Click);
            // 
            // choferesButton
            // 
            this.choferesButton.Location = new System.Drawing.Point(164, 242);
            this.choferesButton.Name = "choferesButton";
            this.choferesButton.Size = new System.Drawing.Size(75, 23);
            this.choferesButton.TabIndex = 3;
            this.choferesButton.Text = "Choferes";
            this.choferesButton.UseVisualStyleBackColor = true;
            this.choferesButton.Click += new System.EventHandler(this.choferesButton_Click);
            // 
            // turnosButton
            // 
            this.turnosButton.Location = new System.Drawing.Point(42, 75);
            this.turnosButton.Name = "turnosButton";
            this.turnosButton.Size = new System.Drawing.Size(75, 23);
            this.turnosButton.TabIndex = 4;
            this.turnosButton.Text = "Turnos";
            this.turnosButton.UseVisualStyleBackColor = true;
            this.turnosButton.Click += new System.EventHandler(this.turnosButton_Click);
            // 
            // registroButton
            // 
            this.registroButton.Location = new System.Drawing.Point(175, 26);
            this.registroButton.Name = "registroButton";
            this.registroButton.Size = new System.Drawing.Size(117, 23);
            this.registroButton.TabIndex = 5;
            this.registroButton.Text = "Registro de Viajes";
            this.registroButton.UseVisualStyleBackColor = true;
            this.registroButton.Click += new System.EventHandler(this.registroButton_Click);
            // 
            // rendicionButton
            // 
            this.rendicionButton.Location = new System.Drawing.Point(175, 75);
            this.rendicionButton.Name = "rendicionButton";
            this.rendicionButton.Size = new System.Drawing.Size(117, 23);
            this.rendicionButton.TabIndex = 6;
            this.rendicionButton.Text = "Rendición de Viajes";
            this.rendicionButton.UseVisualStyleBackColor = true;
            this.rendicionButton.Click += new System.EventHandler(this.rendicionButton_Click);
            // 
            // facturacionButton
            // 
            this.facturacionButton.Location = new System.Drawing.Point(175, 118);
            this.facturacionButton.Name = "facturacionButton";
            this.facturacionButton.Size = new System.Drawing.Size(117, 23);
            this.facturacionButton.TabIndex = 7;
            this.facturacionButton.Text = "Facturación";
            this.facturacionButton.UseVisualStyleBackColor = true;
            this.facturacionButton.Click += new System.EventHandler(this.facturacionButton_Click);
            // 
            // administradoresButton
            // 
            this.administradoresButton.Location = new System.Drawing.Point(66, 242);
            this.administradoresButton.Name = "administradoresButton";
            this.administradoresButton.Size = new System.Drawing.Size(92, 23);
            this.administradoresButton.TabIndex = 8;
            this.administradoresButton.Text = "Administradores";
            this.administradoresButton.UseVisualStyleBackColor = true;
            this.administradoresButton.Click += new System.EventHandler(this.administradoresButton_Click);
            // 
            // estadisticosButton
            // 
            this.estadisticosButton.Location = new System.Drawing.Point(175, 163);
            this.estadisticosButton.Name = "estadisticosButton";
            this.estadisticosButton.Size = new System.Drawing.Size(117, 23);
            this.estadisticosButton.TabIndex = 9;
            this.estadisticosButton.Text = "Estadísticos";
            this.estadisticosButton.UseVisualStyleBackColor = true;
            this.estadisticosButton.Click += new System.EventHandler(this.estadisticosButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 277);
            this.Controls.Add(this.estadisticosButton);
            this.Controls.Add(this.administradoresButton);
            this.Controls.Add(this.facturacionButton);
            this.Controls.Add(this.rendicionButton);
            this.Controls.Add(this.registroButton);
            this.Controls.Add(this.turnosButton);
            this.Controls.Add(this.choferesButton);
            this.Controls.Add(this.rolesButton);
            this.Controls.Add(this.clientesButton);
            this.Controls.Add(this.automovilesButton);
            this.Name = "Menu";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button automovilesButton;
        private System.Windows.Forms.Button clientesButton;
        private System.Windows.Forms.Button rolesButton;
        private System.Windows.Forms.Button choferesButton;
        private System.Windows.Forms.Button turnosButton;
        private System.Windows.Forms.Button registroButton;
        private System.Windows.Forms.Button rendicionButton;
        private System.Windows.Forms.Button facturacionButton;
        private System.Windows.Forms.Button administradoresButton;
        private System.Windows.Forms.Button estadisticosButton;
    }
}