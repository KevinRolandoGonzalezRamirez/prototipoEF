﻿
namespace capaVista
{
    partial class eliminarProducto
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
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(396, 34);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.RowHeadersWidth = 51;
            this.dvgConsulta.RowTemplate.Height = 24;
            this.dvgConsulta.Size = new System.Drawing.Size(619, 293);
            this.dvgConsulta.TabIndex = 35;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(103, 156);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(235, 80);
            this.btn.TabIndex = 34;
            this.btn.Text = "Dar de Baja";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID Producto: ";
            this.label1.UseMnemonic = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(103, 89);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(247, 22);
            this.txt1.TabIndex = 32;
            // 
            // eliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 366);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Name = "eliminarProducto";
            this.Text = "eliminarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
    }
}