
namespace Aula05DS
{
    partial class Calculadora
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
            this.somarBotao = new System.Windows.Forms.Button();
            this.subtrairBotao = new System.Windows.Forms.Button();
            this.multiplicarBotao = new System.Windows.Forms.Button();
            this.dividirBotao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.primeiroAlgarismo = new System.Windows.Forms.TextBox();
            this.segundoAlgarismo = new System.Windows.Forms.TextBox();
            this.operadorLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.potenciaBotao = new System.Windows.Forms.Button();
            this.imparParBotao = new System.Windows.Forms.Button();
            this.compararBotao = new System.Windows.Forms.Button();
            this.limparBotao = new System.Windows.Forms.Button();
            this.cancelar_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // somarBotao
            // 
            this.somarBotao.Location = new System.Drawing.Point(225, 21);
            this.somarBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.somarBotao.Name = "somarBotao";
            this.somarBotao.Size = new System.Drawing.Size(102, 23);
            this.somarBotao.TabIndex = 0;
            this.somarBotao.Text = "&Somar";
            this.somarBotao.UseVisualStyleBackColor = true;
            this.somarBotao.Click += new System.EventHandler(this.somarBotao_Click);
            // 
            // subtrairBotao
            // 
            this.subtrairBotao.Location = new System.Drawing.Point(225, 48);
            this.subtrairBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subtrairBotao.Name = "subtrairBotao";
            this.subtrairBotao.Size = new System.Drawing.Size(102, 23);
            this.subtrairBotao.TabIndex = 1;
            this.subtrairBotao.Text = "S&ubtrair";
            this.subtrairBotao.UseVisualStyleBackColor = true;
            this.subtrairBotao.Click += new System.EventHandler(this.subtrairBotao_Click);
            // 
            // multiplicarBotao
            // 
            this.multiplicarBotao.Location = new System.Drawing.Point(225, 75);
            this.multiplicarBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiplicarBotao.Name = "multiplicarBotao";
            this.multiplicarBotao.Size = new System.Drawing.Size(102, 23);
            this.multiplicarBotao.TabIndex = 2;
            this.multiplicarBotao.Text = "&Multiplicar";
            this.multiplicarBotao.UseVisualStyleBackColor = true;
            this.multiplicarBotao.Click += new System.EventHandler(this.multiplicarBotao_Click);
            // 
            // dividirBotao
            // 
            this.dividirBotao.Location = new System.Drawing.Point(225, 103);
            this.dividirBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dividirBotao.Name = "dividirBotao";
            this.dividirBotao.Size = new System.Drawing.Size(102, 23);
            this.dividirBotao.TabIndex = 3;
            this.dividirBotao.Text = "&Dividir";
            this.dividirBotao.UseVisualStyleBackColor = true;
            this.dividirBotao.Click += new System.EventHandler(this.dividirBotao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________";
            // 
            // primeiroAlgarismo
            // 
            this.primeiroAlgarismo.Location = new System.Drawing.Point(55, 33);
            this.primeiroAlgarismo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.primeiroAlgarismo.Name = "primeiroAlgarismo";
            this.primeiroAlgarismo.Size = new System.Drawing.Size(119, 20);
            this.primeiroAlgarismo.TabIndex = 5;
            this.primeiroAlgarismo.TextChanged += new System.EventHandler(this.primeiroAlgarismo_TextChanged);
            // 
            // segundoAlgarismo
            // 
            this.segundoAlgarismo.Location = new System.Drawing.Point(55, 81);
            this.segundoAlgarismo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.segundoAlgarismo.Name = "segundoAlgarismo";
            this.segundoAlgarismo.Size = new System.Drawing.Size(119, 20);
            this.segundoAlgarismo.TabIndex = 6;
            // 
            // operadorLabel
            // 
            this.operadorLabel.Location = new System.Drawing.Point(39, 58);
            this.operadorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operadorLabel.Name = "operadorLabel";
            this.operadorLabel.Size = new System.Drawing.Size(145, 13);
            this.operadorLabel.TabIndex = 7;
            this.operadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.Location = new System.Drawing.Point(2, 140);
            this.resultadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(219, 21);
            this.resultadoLabel.TabIndex = 8;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potenciaBotao
            // 
            this.potenciaBotao.Location = new System.Drawing.Point(225, 130);
            this.potenciaBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.potenciaBotao.Name = "potenciaBotao";
            this.potenciaBotao.Size = new System.Drawing.Size(102, 23);
            this.potenciaBotao.TabIndex = 9;
            this.potenciaBotao.Text = "&Potência";
            this.potenciaBotao.UseVisualStyleBackColor = true;
            this.potenciaBotao.Click += new System.EventHandler(this.potenciaBotao_Click);
            // 
            // imparParBotao
            // 
            this.imparParBotao.Location = new System.Drawing.Point(331, 21);
            this.imparParBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imparParBotao.Name = "imparParBotao";
            this.imparParBotao.Size = new System.Drawing.Size(102, 23);
            this.imparParBotao.TabIndex = 10;
            this.imparParBotao.Text = "&Impar e Par";
            this.imparParBotao.UseVisualStyleBackColor = true;
            this.imparParBotao.Click += new System.EventHandler(this.imparParBotao_Click);
            // 
            // compararBotao
            // 
            this.compararBotao.Location = new System.Drawing.Point(331, 48);
            this.compararBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.compararBotao.Name = "compararBotao";
            this.compararBotao.Size = new System.Drawing.Size(102, 23);
            this.compararBotao.TabIndex = 11;
            this.compararBotao.Text = "&Comparar";
            this.compararBotao.UseVisualStyleBackColor = true;
            this.compararBotao.Click += new System.EventHandler(this.compararBotao_Click);
            // 
            // limparBotao
            // 
            this.limparBotao.Location = new System.Drawing.Point(331, 75);
            this.limparBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.limparBotao.Name = "limparBotao";
            this.limparBotao.Size = new System.Drawing.Size(102, 23);
            this.limparBotao.TabIndex = 12;
            this.limparBotao.Text = "&Limpar";
            this.limparBotao.UseVisualStyleBackColor = true;
            this.limparBotao.Click += new System.EventHandler(this.limparBotao_Click);
            // 
            // cancelar_Button
            // 
            this.cancelar_Button.Location = new System.Drawing.Point(331, 103);
            this.cancelar_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar_Button.Name = "cancelar_Button";
            this.cancelar_Button.Size = new System.Drawing.Size(102, 23);
            this.cancelar_Button.TabIndex = 13;
            this.cancelar_Button.Text = "Cancelar";
            this.cancelar_Button.UseVisualStyleBackColor = true;
            this.cancelar_Button.Click += new System.EventHandler(this.cancelar_Button_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(553, 196);
            this.Controls.Add(this.cancelar_Button);
            this.Controls.Add(this.limparBotao);
            this.Controls.Add(this.compararBotao);
            this.Controls.Add(this.imparParBotao);
            this.Controls.Add(this.potenciaBotao);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.operadorLabel);
            this.Controls.Add(this.segundoAlgarismo);
            this.Controls.Add(this.primeiroAlgarismo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dividirBotao);
            this.Controls.Add(this.multiplicarBotao);
            this.Controls.Add(this.subtrairBotao);
            this.Controls.Add(this.somarBotao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button somarBotao;
        private System.Windows.Forms.Button subtrairBotao;
        private System.Windows.Forms.Button multiplicarBotao;
        private System.Windows.Forms.Button dividirBotao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox primeiroAlgarismo;
        private System.Windows.Forms.TextBox segundoAlgarismo;
        private System.Windows.Forms.Label operadorLabel;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button potenciaBotao;
        private System.Windows.Forms.Button imparParBotao;
        private System.Windows.Forms.Button compararBotao;
        private System.Windows.Forms.Button limparBotao;
        private System.Windows.Forms.Button cancelar_Button;
    }
}

