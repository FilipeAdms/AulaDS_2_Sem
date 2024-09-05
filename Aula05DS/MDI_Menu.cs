using System;
using System.Linq;
using System.Windows.Forms;

namespace Aula05DS
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void comBotoesToolStrip_Click(object sender, EventArgs e)
        {
            // Verifica se o formulário Calculadora já está aberto
            Form calculadora = Application.OpenForms.OfType<Calculadora>().FirstOrDefault();

            if (calculadora == null)
            {
                // Se não estiver aberto, cria e abre o formulário
                calculadora = new Calculadora();

                calculadora.Show();
            }
            else
            {
                // Se já estiver aberto, traz o formulário para frente
                calculadora.BringToFront();
            }
        }

        private void comRadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica se o formulário CalculadoraRadio já está aberto
            Form calculadoraRadio = Application.OpenForms.OfType<CalculadoraRadio>().FirstOrDefault();

            if (calculadoraRadio == null)
            {
                // Se não estiver aberto, cria e abre o formulário
                calculadoraRadio = new CalculadoraRadio();
                calculadoraRadio.MdiParent = this;
                calculadoraRadio.Show();
            }
            else
            {
                // Se já estiver aberto, traz o formulário para frente
                calculadoraRadio.BringToFront();
            }
        }

        private void calculadoraSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica se o formulário CalculadoraRadio já está aberto
            Form superCalculadora = Application.OpenForms.OfType<SuperCalculadora>().FirstOrDefault();

            if (superCalculadora == null)
            {
                // Se não estiver aberto, cria e abre o formulário
                superCalculadora = new SuperCalculadora();
                superCalculadora.MdiParent = this;
                superCalculadora.Show();
            }
            else
            {
                // Se já estiver aberto, traz o formulário para frente
                superCalculadora.BringToFront();
            }
        }
    }
}
