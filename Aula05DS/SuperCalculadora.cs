using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Aula05DS
{
    public partial class SuperCalculadora : Form
    {
        private List<double> listaDeNumeros = new List<double>();
        private List<string> listaDeOperadores = new List<string>();

        private bool temVirgula = false;
        private bool mostreiResultado = false;
        private string Operador = "";

        public SuperCalculadora()
        {
            InitializeComponent();
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                Resposta.Text = "";
                RespTemp.Text = "";
                mostreiResultado = false;
                temVirgula = false;
            }
            if (temVirgula == false)
            {
                if (Resposta.Text == "")
                {
                    Resposta.Text += "0.";
                    temVirgula = true;
                }
                else
                {
                    Resposta.Text += ".";
                    temVirgula = true;
                }
            }
        }

        private void OperadorSoma_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                RespTemp.Text = Resposta.Text + "+";
                Resposta.Text = "";
                mostreiResultado = false;
            }
            if (Resposta.Text != "")
            {
                RespTemp.Text += Resposta.Text + "+";
                Operador = "+";
                GuardarNumeroAtual();
                Resposta.Text = "";
                temVirgula = false;
            }
        }

        private void OperadorSubtracao_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                RespTemp.Text = Resposta.Text + "-";
                Resposta.Text = "";
                mostreiResultado = false;
            }
            if (Resposta.Text != "")
            {
                RespTemp.Text += Resposta.Text + "-";
                Operador = "-";
                GuardarNumeroAtual();
                Resposta.Text = "";
                temVirgula = false;
            }
        }

        private void OperadorMultiplicacao_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                RespTemp.Text = Resposta.Text + "*";
                Resposta.Text = "";
                mostreiResultado = false;
            }
            if (Resposta.Text != "")
            {
                RespTemp.Text += Resposta.Text + "*";
                Operador = "*";
                GuardarNumeroAtual();
                Resposta.Text = "";
                temVirgula = false;
            }
        }

        private void OperadorDivisao_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                RespTemp.Text = Resposta.Text + "/";
                Resposta.Text = "";
                mostreiResultado = false;
            }
            if (Resposta.Text != "")
            {
                RespTemp.Text += Resposta.Text + "/";
                Operador = "/";
                GuardarNumeroAtual();
                Resposta.Text = "";
                temVirgula = false;
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            if (Resposta.Text != "" && mostreiResultado)
            {
                if (listaDeOperadores.Count == 0)
                {
                    RespTemp.Text = Resposta.Text + " = ";
                    mostreiResultado = true;
                    Historico.Text += RespTemp.Text + Resposta.Text + Environment.NewLine;
                }
                else if (listaDeOperadores.Count > 0)
                {
                    try
                    {
                        int ultimoNumero = listaDeNumeros.Count - 1;
                        int ultimoOperador = listaDeOperadores.Count - 1;
                        DataTable calculo = new DataTable();
                        string expressao = Resposta.Text + listaDeOperadores[ultimoOperador].ToString() + listaDeNumeros[ultimoNumero].ToString();
                        object resultado = calculo.Compute(expressao.Replace(",","."), null);
                        RespTemp.Text = Resposta.Text + listaDeOperadores[ultimoOperador].ToString() + listaDeNumeros[ultimoNumero].ToString();
                        Resposta.Text = resultado.ToString();
                        Historico.Text += RespTemp.Text + "=" + Resposta.Text + Environment.NewLine;
                    }
                    catch (DivideByZeroException)
                    {
                        Resposta.Text = "Dividiu por 0 (se isso aparecer, parabéns)";
                    }
                    catch (SyntaxErrorException)
                    {
                        MessageBox.Show("Me perdi :/");
                    }
                }
            }
            else if (Resposta.Text != "" && !mostreiResultado)
            {
                Operador = "";
                if (Resposta.Text != "")
                {
                    RespTemp.Text += Resposta.Text;
                    GuardarNumeroAtual();
                    mostreiResultado = true;
                    Calcular();
                }
            }

        }

        private void OperadorPotencia_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                Resposta.Text = Math.Pow(Double.Parse(Resposta.Text), 2).ToString();
                RespTemp.Text = "";
                mostreiResultado = false;
            }
            else if (Resposta.Text != "")
            {
                Resposta.Text = Math.Pow(Double.Parse(Resposta.Text), 2).ToString();
            }
        }

        private void OperadorRaiz_Click(object sender, EventArgs e)
        {
            if (mostreiResultado)
            {
                Resposta.Text = Math.Sqrt(Double.Parse(Resposta.Text)).ToString();
                RespTemp.Text = "";
                mostreiResultado = false;
            }
            if (Resposta.Text != "")
            {
                Resposta.Text = Math.Sqrt(Double.Parse(Resposta.Text)).ToString();
            }
        }

        private void GuardarNumeroAtual()
        {
            listaDeNumeros.Add(double.Parse(Resposta.Text));
            if (Operador != "")
            {
                listaDeOperadores.Add(Operador);
            }
        }

        private void Calcular()
        {
            if (listaDeNumeros.Count > listaDeOperadores.Count)
            {
                try
                {
                    DataTable calculo = new DataTable();
                    string expressao = RespTemp.Text.Trim();
                    object resultado = calculo.Compute(expressao.Replace(",", "."), null);
                    Resposta.Text = resultado.ToString();
                    Historico.Text += RespTemp.Text + "=" + Resposta.Text + Environment.NewLine;
                }
                catch (DivideByZeroException)
                {
                    Resposta.Text = "Dividiu por 0";
                }
                catch (SyntaxErrorException)
                {
                    MessageBox.Show("vo me mata");
                }
            }
            else
            {
                MessageBox.Show("Insira mais um número");
            }
        }

        private void Inversor_Click(object sender, EventArgs e)
        {
            Resposta.Text = ((-1) * double.Parse(Resposta.Text)).ToString();
        }

        private void CancelarEntrada_Click(object sender, EventArgs e)
        {
            Resposta.Text = "";
            Historico.Text = "";

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Resposta.Text = "";
            RespTemp.Text = "";
            Historico.Text = "";
            temVirgula = false;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClicarBotaoNumero(object sender, EventArgs e)
        {

            if (mostreiResultado)
            {
                Resposta.Text = "";
                RespTemp.Text = "";
                mostreiResultado = false;
            }
            Button botao = (Button)sender;
            Resposta.Text += botao.Text;
        }

        private void SuperCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            TeclaPressionada.Text = e.KeyCode.ToString();

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }

            Button Botao = new Button();
            string tecla = e.KeyCode.ToString();
        }
    }
}
