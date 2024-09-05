using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05DS
{
    public partial class CalculadoraRadio : Form
    {
        public CalculadoraRadio()
        {
            InitializeComponent();
        }

        private void CalculadoraRadio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Button_Click(object sender, EventArgs e)
        {
            try { 
            if(somar_RadioButton.Checked)
            {
                double num1, num2, res;
                operador_Label.Text = "a+b";
                num1 = double.Parse(primeiroNum_TextBox.Text);
                num2 = double.Parse(segundoNum_TextBox.Text);
                res = num1 + num2;

                resultado_Label.Text = res.ToString();
            }
            else if (subtrair_RadioButton.Checked)
            {
                double num1, num2, res;

                num1 = double.Parse(primeiroNum_TextBox.Text);
                num2 = double.Parse(segundoNum_TextBox.Text);
                res = num1 - num2;
                operador_Label.Text = "a-b";
                resultado_Label.Text = res.ToString();
            }
            else if (multiplicar_RadioButton.Checked)
            {
                double num1, num2, res;

                num1 = double.Parse(primeiroNum_TextBox.Text);
                num2 = double.Parse(segundoNum_TextBox.Text);
                res = num1 * num2;
                operador_Label.Text = "a*b";
                resultado_Label.Text = res.ToString();
            }
            else if(dividir_RadioButton.Checked)
            {
                double num1, num2, res;

                num1 = double.Parse(primeiroNum_TextBox.Text);
                num2 = double.Parse(segundoNum_TextBox.Text);
                res = num1 / num2;
                operador_Label.Text = "a/b";
                resultado_Label.Text = res.ToString();
            }
            else if(potencia_RadioButton.Checked)
            {
                double num1, num2, res;

                num1 = double.Parse(primeiroNum_TextBox.Text);
                num2 = double.Parse(segundoNum_TextBox.Text);
                res = Math.Pow(num1,num2);
                operador_Label.Text = "a^b";
                resultado_Label.Text = res.ToString();
            }
            }
            catch (FormatException)
            {
                MessageBox.Show("Úm número não foi inserido!");
            }
        }

        private void limpar_Button_Click(object sender, EventArgs e)
        {
            primeiroNum_TextBox.Text = " ";
            segundoNum_TextBox.Text = " ";
            resultado_Label.Text = " ";
        }

        private void fechar_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
