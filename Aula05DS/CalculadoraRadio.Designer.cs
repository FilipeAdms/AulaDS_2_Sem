
namespace Aula05DS
{
    partial class CalculadoraRadio
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
            this.operacoes_GroupBox = new System.Windows.Forms.GroupBox();
            this.potencia_RadioButton = new System.Windows.Forms.RadioButton();
            this.dividir_RadioButton = new System.Windows.Forms.RadioButton();
            this.multiplicar_RadioButton = new System.Windows.Forms.RadioButton();
            this.subtrair_RadioButton = new System.Windows.Forms.RadioButton();
            this.somar_RadioButton = new System.Windows.Forms.RadioButton();
            this.calcular_Button = new System.Windows.Forms.Button();
            this.limpar_Button = new System.Windows.Forms.Button();
            this.fechar_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.operador_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado_Label = new System.Windows.Forms.Label();
            this.primeiroNum_TextBox = new System.Windows.Forms.TextBox();
            this.segundoNum_TextBox = new System.Windows.Forms.TextBox();
            this.operacoes_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // operacoes_GroupBox
            // 
            this.operacoes_GroupBox.Controls.Add(this.potencia_RadioButton);
            this.operacoes_GroupBox.Controls.Add(this.dividir_RadioButton);
            this.operacoes_GroupBox.Controls.Add(this.multiplicar_RadioButton);
            this.operacoes_GroupBox.Controls.Add(this.subtrair_RadioButton);
            this.operacoes_GroupBox.Controls.Add(this.somar_RadioButton);
            this.operacoes_GroupBox.Location = new System.Drawing.Point(45, 33);
            this.operacoes_GroupBox.Name = "operacoes_GroupBox";
            this.operacoes_GroupBox.Size = new System.Drawing.Size(184, 192);
            this.operacoes_GroupBox.TabIndex = 0;
            this.operacoes_GroupBox.TabStop = false;
            this.operacoes_GroupBox.Text = "Operações";
            // 
            // potencia_RadioButton
            // 
            this.potencia_RadioButton.AutoSize = true;
            this.potencia_RadioButton.Location = new System.Drawing.Point(23, 150);
            this.potencia_RadioButton.Name = "potencia_RadioButton";
            this.potencia_RadioButton.Size = new System.Drawing.Size(96, 24);
            this.potencia_RadioButton.TabIndex = 4;
            this.potencia_RadioButton.TabStop = true;
            this.potencia_RadioButton.Text = "Potência";
            this.potencia_RadioButton.UseVisualStyleBackColor = true;
            // 
            // dividir_RadioButton
            // 
            this.dividir_RadioButton.AutoSize = true;
            this.dividir_RadioButton.Location = new System.Drawing.Point(23, 119);
            this.dividir_RadioButton.Name = "dividir_RadioButton";
            this.dividir_RadioButton.Size = new System.Drawing.Size(76, 24);
            this.dividir_RadioButton.TabIndex = 3;
            this.dividir_RadioButton.TabStop = true;
            this.dividir_RadioButton.Text = "Dividir";
            this.dividir_RadioButton.UseVisualStyleBackColor = true;
            // 
            // multiplicar_RadioButton
            // 
            this.multiplicar_RadioButton.AutoSize = true;
            this.multiplicar_RadioButton.Location = new System.Drawing.Point(23, 88);
            this.multiplicar_RadioButton.Name = "multiplicar_RadioButton";
            this.multiplicar_RadioButton.Size = new System.Drawing.Size(104, 24);
            this.multiplicar_RadioButton.TabIndex = 2;
            this.multiplicar_RadioButton.TabStop = true;
            this.multiplicar_RadioButton.Text = "Multiplicar";
            this.multiplicar_RadioButton.UseVisualStyleBackColor = true;
            // 
            // subtrair_RadioButton
            // 
            this.subtrair_RadioButton.AutoSize = true;
            this.subtrair_RadioButton.Location = new System.Drawing.Point(23, 57);
            this.subtrair_RadioButton.Name = "subtrair_RadioButton";
            this.subtrair_RadioButton.Size = new System.Drawing.Size(90, 24);
            this.subtrair_RadioButton.TabIndex = 1;
            this.subtrair_RadioButton.TabStop = true;
            this.subtrair_RadioButton.Text = "Subtrair";
            this.subtrair_RadioButton.UseVisualStyleBackColor = true;
            // 
            // somar_RadioButton
            // 
            this.somar_RadioButton.AutoSize = true;
            this.somar_RadioButton.Location = new System.Drawing.Point(23, 26);
            this.somar_RadioButton.Name = "somar_RadioButton";
            this.somar_RadioButton.Size = new System.Drawing.Size(81, 24);
            this.somar_RadioButton.TabIndex = 0;
            this.somar_RadioButton.TabStop = true;
            this.somar_RadioButton.Text = "Somar";
            this.somar_RadioButton.UseVisualStyleBackColor = true;
            // 
            // calcular_Button
            // 
            this.calcular_Button.Location = new System.Drawing.Point(45, 259);
            this.calcular_Button.Name = "calcular_Button";
            this.calcular_Button.Size = new System.Drawing.Size(133, 33);
            this.calcular_Button.TabIndex = 1;
            this.calcular_Button.Text = "&Calcular";
            this.calcular_Button.UseVisualStyleBackColor = true;
            this.calcular_Button.Click += new System.EventHandler(this.calcular_Button_Click);
            // 
            // limpar_Button
            // 
            this.limpar_Button.Location = new System.Drawing.Point(207, 259);
            this.limpar_Button.Name = "limpar_Button";
            this.limpar_Button.Size = new System.Drawing.Size(133, 33);
            this.limpar_Button.TabIndex = 2;
            this.limpar_Button.Text = "Limpar";
            this.limpar_Button.UseVisualStyleBackColor = true;
            this.limpar_Button.Click += new System.EventHandler(this.limpar_Button_Click);
            // 
            // fechar_Button
            // 
            this.fechar_Button.Location = new System.Drawing.Point(375, 259);
            this.fechar_Button.Name = "fechar_Button";
            this.fechar_Button.Size = new System.Drawing.Size(133, 33);
            this.fechar_Button.TabIndex = 3;
            this.fechar_Button.Text = "Fechar";
            this.fechar_Button.UseVisualStyleBackColor = true;
            this.fechar_Button.Click += new System.EventHandler(this.fechar_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // operador_Label
            // 
            this.operador_Label.AutoSize = true;
            this.operador_Label.Location = new System.Drawing.Point(446, 90);
            this.operador_Label.Name = "operador_Label";
            this.operador_Label.Size = new System.Drawing.Size(0, 20);
            this.operador_Label.TabIndex = 5;
            this.operador_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            // 
            // resultado_Label
            // 
            this.resultado_Label.AutoSize = true;
            this.resultado_Label.Location = new System.Drawing.Point(555, 185);
            this.resultado_Label.Name = "resultado_Label";
            this.resultado_Label.Size = new System.Drawing.Size(0, 20);
            this.resultado_Label.TabIndex = 7;
            // 
            // primeiroNum_TextBox
            // 
            this.primeiroNum_TextBox.Location = new System.Drawing.Point(514, 63);
            this.primeiroNum_TextBox.Name = "primeiroNum_TextBox";
            this.primeiroNum_TextBox.Size = new System.Drawing.Size(130, 26);
            this.primeiroNum_TextBox.TabIndex = 8;
            // 
            // segundoNum_TextBox
            // 
            this.segundoNum_TextBox.Location = new System.Drawing.Point(514, 109);
            this.segundoNum_TextBox.Name = "segundoNum_TextBox";
            this.segundoNum_TextBox.Size = new System.Drawing.Size(130, 26);
            this.segundoNum_TextBox.TabIndex = 9;
            // 
            // CalculadoraRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.segundoNum_TextBox);
            this.Controls.Add(this.primeiroNum_TextBox);
            this.Controls.Add(this.resultado_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operador_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechar_Button);
            this.Controls.Add(this.limpar_Button);
            this.Controls.Add(this.calcular_Button);
            this.Controls.Add(this.operacoes_GroupBox);
            this.Name = "CalculadoraRadio";
            this.Text = "CalculadoraV2";
            this.Load += new System.EventHandler(this.CalculadoraRadio_Load);
            this.operacoes_GroupBox.ResumeLayout(false);
            this.operacoes_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox operacoes_GroupBox;
        private System.Windows.Forms.RadioButton somar_RadioButton;
        private System.Windows.Forms.RadioButton potencia_RadioButton;
        private System.Windows.Forms.RadioButton dividir_RadioButton;
        private System.Windows.Forms.RadioButton multiplicar_RadioButton;
        private System.Windows.Forms.RadioButton subtrair_RadioButton;
        private System.Windows.Forms.Button calcular_Button;
        private System.Windows.Forms.Button limpar_Button;
        private System.Windows.Forms.Button fechar_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label operador_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultado_Label;
        private System.Windows.Forms.TextBox primeiroNum_TextBox;
        private System.Windows.Forms.TextBox segundoNum_TextBox;
    }
}