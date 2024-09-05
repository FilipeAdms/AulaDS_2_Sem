
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
            this.somarBotao.Location = new System.Drawing.Point(338, 32);
            this.somarBotao.Name = "somarBotao";
            this.somarBotao.Size = new System.Drawing.Size(153, 36);
            this.somarBotao.TabIndex = 0;
            this.somarBotao.Text = "&Somar";
            this.somarBotao.UseVisualStyleBackColor = true;
            this.somarBotao.Click += new System.EventHandler(this.somarBotao_Click);
            // 
            // subtrairBotao
            // 
            this.subtrairBotao.Location = new System.Drawing.Point(338, 74);
            this.subtrairBotao.Name = "subtrairBotao";
            this.subtrairBotao.Size = new System.Drawing.Size(153, 36);
            this.subtrairBotao.TabIndex = 1;
            this.subtrairBotao.Text = "S&ubtrair";
            this.subtrairBotao.UseVisualStyleBackColor = true;
            this.subtrairBotao.Click += new System.EventHandler(this.subtrairBotao_Click);
            // 
            // multiplicarBotao
            // 
            this.multiplicarBotao.Location = new System.Drawing.Point(338, 116);
            this.multiplicarBotao.Name = "multiplicarBotao";
            this.multiplicarBotao.Size = new System.Drawing.Size(153, 36);
            this.multiplicarBotao.TabIndex = 2;
            this.multiplicarBotao.Text = "&Multiplicar";
            this.multiplicarBotao.UseVisualStyleBackColor = true;
            this.multiplicarBotao.Click += new System.EventHandler(this.multiplicarBotao_Click);
            // 
            // dividirBotao
            // 
            this.dividirBotao.Location = new System.Drawing.Point(338, 158);
            this.dividirBotao.Name = "dividirBotao";
            this.dividirBotao.Size = new System.Drawing.Size(153, 36);
            this.dividirBotao.TabIndex = 3;
            this.dividirBotao.Text = "&Dividir";
            this.dividirBotao.UseVisualStyleBackColor = true;
            this.dividirBotao.Click += new System.EventHandler(this.dividirBotao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________";
            // 
            // primeiroAlgarismo
            // 
            this.primeiroAlgarismo.Location = new System.Drawing.Point(82, 51);
            this.primeiroAlgarismo.Name = "primeiroAlgarismo";
            this.primeiroAlgarismo.Size = new System.Drawing.Size(176, 26);
            this.primeiroAlgarismo.TabIndex = 5;
            this.primeiroAlgarismo.TextChanged += new System.EventHandler(this.primeiroAlgarismo_TextChanged);
            // 
            // segundoAlgarismo
            // 
            this.segundoAlgarismo.Location = new System.Drawing.Point(82, 124);
            this.segundoAlgarismo.Name = "segundoAlgarismo";
            this.segundoAlgarismo.Size = new System.Drawing.Size(176, 26);
            this.segundoAlgarismo.TabIndex = 6;
            // 
            // operadorLabel
            // 
            this.operadorLabel.Location = new System.Drawing.Point(58, 90);
            this.operadorLabel.Name = "operadorLabel";
            this.operadorLabel.Size = new System.Drawing.Size(217, 20);
            this.operadorLabel.TabIndex = 7;
            this.operadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.Location = new System.Drawing.Point(3, 216);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(329, 32);
            this.resultadoLabel.TabIndex = 8;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potenciaBotao
            // 
            this.potenciaBotao.Location = new System.Drawing.Point(338, 200);
            this.potenciaBotao.Name = "potenciaBotao";
            this.potenciaBotao.Size = new System.Drawing.Size(153, 36);
            this.potenciaBotao.TabIndex = 9;
            this.potenciaBotao.Text = "&Potência";
            this.potenciaBotao.UseVisualStyleBackColor = true;
            this.potenciaBotao.Click += new System.EventHandler(this.potenciaBotao_Click);
            // 
            // imparParBotao
            // 
            this.imparParBotao.Location = new System.Drawing.Point(497, 32);
            this.imparParBotao.Name = "imparParBotao";
            this.imparParBotao.Size = new System.Drawing.Size(153, 36);
            this.imparParBotao.TabIndex = 10;
            this.imparParBotao.Text = "&Impar e Par";
            this.imparParBotao.UseVisualStyleBackColor = true;
            this.imparParBotao.Click += new System.EventHandler(this.imparParBotao_Click);
            // 
            // compararBotao
            // 
            this.compararBotao.Location = new System.Drawing.Point(497, 74);
            this.compararBotao.Name = "compararBotao";
            this.compararBotao.Size = new System.Drawing.Size(153, 36);
            this.compararBotao.TabIndex = 11;
            this.compararBotao.Text = "&Comparar";
            this.compararBotao.UseVisualStyleBackColor = true;
            this.compararBotao.Click += new System.EventHandler(this.compararBotao_Click);
            // 
            // limparBotao
            // 
            this.limparBotao.Location = new System.Drawing.Point(497, 116);
            this.limparBotao.Name = "limparBotao";
            this.limparBotao.Size = new System.Drawing.Size(153, 36);
            this.limparBotao.TabIndex = 12;
            this.limparBotao.Text = "&Limpar";
            this.limparBotao.UseVisualStyleBackColor = true;
            this.limparBotao.Click += new System.EventHandler(this.limparBotao_Click);
            // 
            // cancelar_Button
            // 
            this.cancelar_Button.Location = new System.Drawing.Point(497, 158);
            this.cancelar_Button.Name = "cancelar_Button";
            this.cancelar_Button.Size = new System.Drawing.Size(153, 36);
            this.cancelar_Button.TabIndex = 13;
            this.cancelar_Button.Text = "Cancelar";
            this.cancelar_Button.UseVisualStyleBackColor = true;
            this.cancelar_Button.Click += new System.EventHandler(this.cancelar_Button_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 301);
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
            this.Name = "Calculadora";
            this.Text = "Form1";
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

