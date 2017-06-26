namespace UberFrba.Abm_Turno
{
    partial class Turno
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
            this.modificacionButton = new System.Windows.Forms.Button();
            this.bajaButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modificacionButton
            // 
            this.modificacionButton.Location = new System.Drawing.Point(52, 139);
            this.modificacionButton.Name = "modificacionButton";
            this.modificacionButton.Size = new System.Drawing.Size(75, 23);
            this.modificacionButton.TabIndex = 5;
            this.modificacionButton.Text = "Modificación";
            this.modificacionButton.UseVisualStyleBackColor = true;
            this.modificacionButton.Click += new System.EventHandler(this.modificacionButton_Click);
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(52, 89);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(75, 23);
            this.bajaButton.TabIndex = 4;
            this.bajaButton.Text = "Baja";
            this.bajaButton.UseVisualStyleBackColor = true;
            this.bajaButton.Click += new System.EventHandler(this.bajaButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Location = new System.Drawing.Point(52, 39);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 23);
            this.nuevoButton.TabIndex = 3;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 201);
            this.Controls.Add(this.modificacionButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.nuevoButton);
            this.Name = "Turno";
            this.Text = "Turnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modificacionButton;
        private System.Windows.Forms.Button bajaButton;
        private System.Windows.Forms.Button nuevoButton;
    }
}