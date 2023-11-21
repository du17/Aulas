using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.ContaBancaria
{
    public partial class CaixaDeBanco : Form
    {

        ContaBancariaClass conta;
        private Double saldo, valor;

        public CaixaDeBanco()
        {
            InitializeComponent();
        }

        private void CaixaDeBanco_Load(object sender, EventArgs e)
        {
            conta = new GIT.ContaBancariaClass();
            saldo = conta.Saldo();
            txtSaldo.Text = saldo.ToString();
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            if (radioButtonDeposito.Checked)
            {
                valor = Double.Parse(txtValor.Text);

                if (conta.Deposito(valor) == false)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Não foi possível fazer o depósito");
                    sb.AppendLine();
                    sb.Append("São permitidos valores de no minimo R$50,00.");
                    sb.Append("Verifique o valor do deposito");
                    sb.AppendLine();
                    sb.Append("Verifque se sua conta tem saldo suficiemte");

                    MessageBox.Show(sb.ToString());
                    txtValor.Clear();
                }

            }

            else if (radioButtonSaque.Checked)
            {
                valor = Double.Parse(txtValor.Text);

                if (conta.Saque(valor) == false)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Não foi possivel fazer o saque");
                    sb.AppendLine();
                    sb.Append("São permitidos valores de no minimo R$10,00.");
                    sb.Append("Verifique o valor do deposito");
                    sb.AppendLine();

                    MessageBox.Show(sb.ToString());
                    txtSaldo.Clear();
                }
            }

            valor = conta.Saldo();
            txtSaldo.Text = valor.ToString();
        }
    }
}
