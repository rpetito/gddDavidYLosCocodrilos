﻿namespace UberFrba.Registro_Viajes
{
    partial class Registro
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
            this.nuevoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nuevoButton
            // 
            this.nuevoButton.Location = new System.Drawing.Point(30, 77);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(131, 23);
            this.nuevoButton.TabIndex = 1;
            this.nuevoButton.Text = "Nuevo Viaje";
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 189);
            this.Controls.Add(this.nuevoButton);
            this.Name = "Registro";
            this.Text = "Registro de viaje";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nuevoButton;
    }
}