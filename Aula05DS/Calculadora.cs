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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void somarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2, res;
                operadorLabel.Text = "a+b";
                num1 = double.Parse(primeiroAlgarismo.Text); 
                num2 = double.Parse(segundoAlgarismo.Text);
                res = num1 + num2; 

                resultadoLabel.Text = res.ToString();
            }catch(FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
        }

        private void subtrairBotao_Click(object sender, EventArgs e)
        {
            try { 
            double num1, num2, res;

            num1 = double.Parse(primeiroAlgarismo.Text);
            num2 = double.Parse(segundoAlgarismo.Text);
            res = num1 - num2;
            operadorLabel.Text = "a-b";
            resultadoLabel.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
        }

        private void multiplicarBotao_Click(object sender, EventArgs e)
        {
            try { 
            double num1, num2, res;

            num1 = double.Parse(primeiroAlgarismo.Text);
            num2 = double.Parse(segundoAlgarismo.Text);
            operadorLabel.Text = "a*b";
            res = num1 * num2;

            resultadoLabel.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
        }

        private void dividirBotao_Click(object sender, EventArgs e)
        {
            try
            {
            double num1, num2, res;

            num1 = double.Parse(primeiroAlgarismo.Text);
            num2 = double.Parse(segundoAlgarismo.Text);
            res = num1 / num2;
                operadorLabel.Text = "a/b";
                resultadoLabel.Text = res.ToString();
            }
            catch (DivideByZeroException)
            {
                primeiroAlgarismo.Text = "";
                segundoAlgarismo.Text = "";
                resultadoLabel.Text = "Tentou dividir por 0.";
            }
        catch(FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
}

        private void potenciaBotao_Click(object sender, EventArgs e)
        {
            try { 
            double num1, num2, res;

            num1 = double.Parse(primeiroAlgarismo.Text);
            num2 = double.Parse(segundoAlgarismo.Text);
            res = Math.Pow(num1, num2);
            operadorLabel.Text = "a^b";
            resultadoLabel.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
        }

        private void imparParBotao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2, teste1, teste2;

                num1 = double.Parse(primeiroAlgarismo.Text);
                num2 = double.Parse(segundoAlgarismo.Text);
                teste1 = num1 % 2;
                teste2 = num2 % 2;
                if (teste1 != 0 && teste2 != 0)
                {
                    resultadoLabel.Text = "Ambos são ímpar.";
                }
                else if (teste1 != 0 && teste2 == 0)
                {
                    resultadoLabel.Text = "O primeiro é ímpar e o segundo é par.";
                }
                else if (teste1 == 0 && teste2 != 0)
                {
                    resultadoLabel.Text = "O primeiro é par e o segundo é ímpar.";
                }
                else if (teste1 == 0 && teste2 == 0)
                {
                    resultadoLabel.Text = "Ambos são par.";
                }

                operadorLabel.Text = "Impar ou Par?";
            }
            catch (FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
        }

        private void compararBotao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;

                num1 = double.Parse(primeiroAlgarismo.Text);
                num2 = double.Parse(segundoAlgarismo.Text);

                if (num1 > num2)
                {
                resultadoLabel.Text = num1 + " > " + num2;
                }
                else if (num1 < num2)
                {
                resultadoLabel.Text = num1 + " < " + num2;
                }
                else
                {
                resultadoLabel.Text = num1 + " = " + num2;
                }
                operadorLabel.Text = "Comparando";
            }
            catch (FormatException)
            {
                MessageBox.Show("Um número não foi inserido!");
            }
        }

        private void limparBotao_Click(object sender, EventArgs e)
        {
            primeiroAlgarismo.Text = "";
            segundoAlgarismo.Text = "";
            operadorLabel.Text = "...";
        }

        private void primeiroAlgarismo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelar_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
