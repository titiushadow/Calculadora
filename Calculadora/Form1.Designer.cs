namespace Calculadora
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
            this.calculadora = new System.Windows.Forms.Label();
            this.n1Box = new System.Windows.Forms.TextBox();
            this.n2Box = new System.Windows.Forms.TextBox();
            this.Btn_soma = new System.Windows.Forms.Button();
            this.n1Text = new System.Windows.Forms.Label();
            this.n2Text = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.Label();
            this.Btn_subtracao = new System.Windows.Forms.Button();
            this.Btn_divisao = new System.Windows.Forms.Button();
            this.Btn_multiplicacao = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculadora
            // 
            this.calculadora.AutoSize = true;
            this.calculadora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadora.Location = new System.Drawing.Point(91, 9);
            this.calculadora.Name = "calculadora";
            this.calculadora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculadora.Size = new System.Drawing.Size(216, 29);
            this.calculadora.TabIndex = 1;
            this.calculadora.Text = "Calculadora 2022";
            // 
            // n1Box
            // 
            this.n1Box.Location = new System.Drawing.Point(100, 70);
            this.n1Box.Multiline = true;
            this.n1Box.Name = "n1Box";
            this.n1Box.Size = new System.Drawing.Size(213, 26);
            this.n1Box.TabIndex = 2;
            this.n1Box.TextChanged += new System.EventHandler(this.n1Box_TextChanged);
            // 
            // n2Box
            // 
            this.n2Box.Location = new System.Drawing.Point(100, 122);
            this.n2Box.Multiline = true;
            this.n2Box.Name = "n2Box";
            this.n2Box.Size = new System.Drawing.Size(213, 26);
            this.n2Box.TabIndex = 3;
            this.n2Box.TextChanged += new System.EventHandler(this.n2Box_TextChanged);
            // 
            // Btn_soma
            // 
            this.Btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_soma.Location = new System.Drawing.Point(6, 19);
            this.Btn_soma.Name = "Btn_soma";
            this.Btn_soma.Size = new System.Drawing.Size(45, 33);
            this.Btn_soma.TabIndex = 4;
            this.Btn_soma.Text = "+";
            this.Btn_soma.UseVisualStyleBackColor = true;
            this.Btn_soma.Click += new System.EventHandler(this.Btn_soma_Click);
            // 
            // n1Text
            // 
            this.n1Text.AutoSize = true;
            this.n1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1Text.Location = new System.Drawing.Point(96, 47);
            this.n1Text.Name = "n1Text";
            this.n1Text.Size = new System.Drawing.Size(130, 20);
            this.n1Text.TabIndex = 8;
            this.n1Text.Text = "Primeiro Numero:";
            this.n1Text.Click += new System.EventHandler(this.n1Text_Click);
            // 
            // n2Text
            // 
            this.n2Text.AutoSize = true;
            this.n2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2Text.Location = new System.Drawing.Point(96, 99);
            this.n2Text.Name = "n2Text";
            this.n2Text.Size = new System.Drawing.Size(138, 20);
            this.n2Text.TabIndex = 9;
            this.n2Text.Text = "Segundo Numero:";
            this.n2Text.Click += new System.EventHandler(this.n2Text_Click);
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.Location = new System.Drawing.Point(170, 160);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(86, 20);
            this.ResultText.TabIndex = 10;
            this.ResultText.Text = "Resultado:";
            this.ResultText.Click += new System.EventHandler(this.n3Text_Click);
            // 
            // Btn_subtracao
            // 
            this.Btn_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_subtracao.Location = new System.Drawing.Point(57, 19);
            this.Btn_subtracao.Name = "Btn_subtracao";
            this.Btn_subtracao.Size = new System.Drawing.Size(45, 33);
            this.Btn_subtracao.TabIndex = 11;
            this.Btn_subtracao.Text = "-";
            this.Btn_subtracao.UseVisualStyleBackColor = true;
            this.Btn_subtracao.Click += new System.EventHandler(this.Btn_subtracao_Click);
            // 
            // Btn_divisao
            // 
            this.Btn_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_divisao.Location = new System.Drawing.Point(108, 19);
            this.Btn_divisao.Name = "Btn_divisao";
            this.Btn_divisao.Size = new System.Drawing.Size(45, 33);
            this.Btn_divisao.TabIndex = 12;
            this.Btn_divisao.Text = "/";
            this.Btn_divisao.UseVisualStyleBackColor = true;
            this.Btn_divisao.Click += new System.EventHandler(this.Btn_divisao_Click);
            // 
            // Btn_multiplicacao
            // 
            this.Btn_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_multiplicacao.Location = new System.Drawing.Point(162, 19);
            this.Btn_multiplicacao.Name = "Btn_multiplicacao";
            this.Btn_multiplicacao.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Btn_multiplicacao.Size = new System.Drawing.Size(45, 33);
            this.Btn_multiplicacao.TabIndex = 13;
            this.Btn_multiplicacao.Text = "*";
            this.Btn_multiplicacao.UseVisualStyleBackColor = true;
            this.Btn_multiplicacao.Click += new System.EventHandler(this.Btn_multiplicacao_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(201, 180);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(25, 25);
            this.Result.TabIndex = 14;
            this.Result.Text = "0";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Btn_soma);
            this.GroupBox.Controls.Add(this.Btn_subtracao);
            this.GroupBox.Controls.Add(this.Btn_multiplicacao);
            this.GroupBox.Controls.Add(this.Btn_divisao);
            this.GroupBox.Location = new System.Drawing.Point(100, 208);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(213, 65);
            this.GroupBox.TabIndex = 15;
            this.GroupBox.TabStop = false;
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 465);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.n2Text);
            this.Controls.Add(this.n1Text);
            this.Controls.Add(this.n2Box);
            this.Controls.Add(this.n1Box);
            this.Controls.Add(this.calculadora);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora - Fatec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label calculadora;
        private System.Windows.Forms.TextBox n1Box;
        private System.Windows.Forms.TextBox n2Box;
        private System.Windows.Forms.Button Btn_soma;
        private System.Windows.Forms.Label n1Text;
        private System.Windows.Forms.Label n2Text;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Button Btn_subtracao;
        private System.Windows.Forms.Button Btn_divisao;
        private System.Windows.Forms.Button Btn_multiplicacao;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.GroupBox GroupBox;
    }
}

