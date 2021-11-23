
namespace capaVista
{
    partial class modificacionClientes
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
            this.txt4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txt4
            // 
            this.txt4.FormattingEnabled = true;
            this.txt4.Items.AddRange(new object[] {
            "A",
            "I"});
            this.txt4.Location = new System.Drawing.Point(146, 244);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(48, 24);
            this.txt4.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Estado:";
            this.label5.UseMnemonic = false;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(602, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(310, 81);
            this.btn2.TabIndex = 34;
            this.btn2.Text = "Buscar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(458, 120);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.RowHeadersWidth = 51;
            this.dvgConsulta.RowTemplate.Height = 24;
            this.dvgConsulta.Size = new System.Drawing.Size(619, 288);
            this.dvgConsulta.TabIndex = 33;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(146, 316);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(235, 80);
            this.btn.TabIndex = 30;
            this.btn.Text = "Actualizar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "DPI:";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            this.label2.UseMnemonic = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(146, 137);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(247, 22);
            this.txt2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Cliente: ";
            this.label1.UseMnemonic = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(142, 35);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(247, 22);
            this.txt1.TabIndex = 24;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(146, 187);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(247, 22);
            this.txt3.TabIndex = 37;
            // 
            // modificacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 454);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Name = "modificacionClientes";
            this.Text = "modificacionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
    }
}