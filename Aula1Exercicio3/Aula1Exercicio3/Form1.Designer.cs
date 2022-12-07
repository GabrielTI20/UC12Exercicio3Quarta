namespace Aula1Exercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.mensagem1 = new System.Windows.Forms.Label();
            this.mensagem2 = new System.Windows.Forms.Label();
            this.mensagem3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Black;
            this.botao1.ForeColor = System.Drawing.Color.White;
            this.botao1.Location = new System.Drawing.Point(24, 189);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(174, 73);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Traduzir";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Black;
            this.botao2.ForeColor = System.Drawing.Color.White;
            this.botao2.Location = new System.Drawing.Point(373, 189);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(179, 73);
            this.botao2.TabIndex = 1;
            this.botao2.Text = "Traduzir";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // botao3
            // 
            this.botao3.BackColor = System.Drawing.Color.Black;
            this.botao3.ForeColor = System.Drawing.Color.White;
            this.botao3.Location = new System.Drawing.Point(801, 189);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(158, 73);
            this.botao3.TabIndex = 2;
            this.botao3.Text = "Traduzir";
            this.botao3.UseVisualStyleBackColor = false;
            this.botao3.Click += new System.EventHandler(this.botao3_Click);
            // 
            // mensagem1
            // 
            this.mensagem1.AutoSize = true;
            this.mensagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem1.Location = new System.Drawing.Point(51, 134);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.Size = new System.Drawing.Size(81, 25);
            this.mensagem1.TabIndex = 3;
            this.mensagem1.Text = "school";
            this.mensagem1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mensagem2
            // 
            this.mensagem2.AutoSize = true;
            this.mensagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem2.Location = new System.Drawing.Point(394, 134);
            this.mensagem2.Name = "mensagem2";
            this.mensagem2.Size = new System.Drawing.Size(141, 25);
            this.mensagem2.TabIndex = 4;
            this.mensagem2.Text = "Marketplace";
            this.mensagem2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mensagem3
            // 
            this.mensagem3.AutoSize = true;
            this.mensagem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem3.Location = new System.Drawing.Point(823, 134);
            this.mensagem3.Name = "mensagem3";
            this.mensagem3.Size = new System.Drawing.Size(106, 25);
            this.mensagem3.TabIndex = 5;
            this.mensagem3.Text = "town hall";
            this.mensagem3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.mensagem3);
            this.Controls.Add(this.mensagem2);
            this.Controls.Add(this.mensagem1);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Label mensagem1;
        private System.Windows.Forms.Label mensagem2;
        private System.Windows.Forms.Label mensagem3;
    }
}

