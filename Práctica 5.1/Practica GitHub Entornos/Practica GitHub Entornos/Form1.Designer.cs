﻿namespace Practica_GitHub_Entornos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(36, 45);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(216, 20);
            this.aluNombre.TabIndex = 0;
            this.aluNombre.TextChanged += new System.EventHandler(this.aluNombre_TextChanged);
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(387, 45);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(117, 20);
            this.aluNota.TabIndex = 1;
            this.aluNota.TextChanged += new System.EventHandler(this.aluNota_TextChanged);
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(36, 145);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(709, 245);
            this.listaAlumnos.TabIndex = 2;
            this.listaAlumnos.TextChanged += new System.EventHandler(this.listaAlumnos_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar Alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota del Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de Alumnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.aluNombre);
            this.Name = "Form1";
            this.Text = "Practica GitHub Entornos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.TextBox listaAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

