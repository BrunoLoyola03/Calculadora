
namespace Calculadora
{
    partial class Exercicio13
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
            this.btnHomem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnMulher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomem
            // 
            this.btnHomem.Location = new System.Drawing.Point(15, 51);
            this.btnHomem.Name = "btnHomem";
            this.btnHomem.Size = new System.Drawing.Size(75, 23);
            this.btnHomem.TabIndex = 9;
            this.btnHomem.Text = "Homem";
            this.btnHomem.UseVisualStyleBackColor = true;
            this.btnHomem.Click += new System.EventHandler(this.btnHomem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Peso Ideal";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(45, 93);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(45, 25);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // btnMulher
            // 
            this.btnMulher.Location = new System.Drawing.Point(96, 51);
            this.btnMulher.Name = "btnMulher";
            this.btnMulher.Size = new System.Drawing.Size(75, 23);
            this.btnMulher.TabIndex = 10;
            this.btnMulher.Text = "Mulher";
            this.btnMulher.UseVisualStyleBackColor = true;
            this.btnMulher.Click += new System.EventHandler(this.btnMulher_Click);
            // 
            // Exercicio13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 131);
            this.Controls.Add(this.btnMulher);
            this.Controls.Add(this.btnHomem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Name = "Exercicio13";
            this.Text = "Exercicio13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnMulher;
    }
}