
namespace Calculadora
{
    partial class Exercicio17
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
            this.btnLatas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.btnGaloes = new System.Windows.Forms.Button();
            this.btnLatasGaloes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLatas = new System.Windows.Forms.TextBox();
            this.txtGaloes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLatas
            // 
            this.btnLatas.Location = new System.Drawing.Point(15, 51);
            this.btnLatas.Name = "btnLatas";
            this.btnLatas.Size = new System.Drawing.Size(75, 23);
            this.btnLatas.TabIndex = 13;
            this.btnLatas.Text = "Só Latas";
            this.btnLatas.UseVisualStyleBackColor = true;
            this.btnLatas.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "M³";
            // 
            // txtPreço
            // 
            this.txtPreço.Location = new System.Drawing.Point(15, 200);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(100, 20);
            this.txtPreço.TabIndex = 9;
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(15, 25);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 20);
            this.txtMetros.TabIndex = 7;
            // 
            // btnGaloes
            // 
            this.btnGaloes.Location = new System.Drawing.Point(96, 51);
            this.btnGaloes.Name = "btnGaloes";
            this.btnGaloes.Size = new System.Drawing.Size(75, 23);
            this.btnGaloes.TabIndex = 14;
            this.btnGaloes.Text = "Só Galões";
            this.btnGaloes.UseVisualStyleBackColor = true;
            this.btnGaloes.Click += new System.EventHandler(this.btnGaloes_Click);
            // 
            // btnLatasGaloes
            // 
            this.btnLatasGaloes.Location = new System.Drawing.Point(15, 80);
            this.btnLatasGaloes.Name = "btnLatasGaloes";
            this.btnLatasGaloes.Size = new System.Drawing.Size(156, 23);
            this.btnLatasGaloes.TabIndex = 15;
            this.btnLatasGaloes.Text = "Latas e Galoes";
            this.btnLatasGaloes.UseVisualStyleBackColor = true;
            this.btnLatasGaloes.Click += new System.EventHandler(this.btnLatasGaloes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Qntd Latas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Qntd Galões";
            // 
            // txtLatas
            // 
            this.txtLatas.Location = new System.Drawing.Point(15, 122);
            this.txtLatas.Name = "txtLatas";
            this.txtLatas.Size = new System.Drawing.Size(100, 20);
            this.txtLatas.TabIndex = 18;
            // 
            // txtGaloes
            // 
            this.txtGaloes.Location = new System.Drawing.Point(15, 161);
            this.txtGaloes.Name = "txtGaloes";
            this.txtGaloes.Size = new System.Drawing.Size(100, 20);
            this.txtGaloes.TabIndex = 19;
            // 
            // Exercicio17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 233);
            this.Controls.Add(this.txtGaloes);
            this.Controls.Add(this.txtLatas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLatasGaloes);
            this.Controls.Add(this.btnGaloes);
            this.Controls.Add(this.btnLatas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreço);
            this.Controls.Add(this.txtMetros);
            this.Name = "Exercicio17";
            this.Text = "Exercicio17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLatas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Button btnGaloes;
        private System.Windows.Forms.Button btnLatasGaloes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLatas;
        private System.Windows.Forms.TextBox txtGaloes;
    }
}