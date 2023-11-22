using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.ContaExeção
{
    public partial class Form1 : Form
    {

        ContaBancaria conta;
        private Double saldo;
        private Double valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new ContaBancaria();

            saldo = conta.Saldo();

            txtSaldo.Text = saldo.ToString();

        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDeposito.Checked)
                {
                    valor = Double.Parse(txtValor.Text);
                    conta.Deposito(valor);

                    txtSaldo.Text = valor.ToString();

                    MessageBox.Show("Operação realizada com sucesso!!!");

                    txtValor.Clear();
                }

                if (radioButtonSaque.Checked)
                {
                    valor = Double.Parse(txtValor.Text);
                    conta.Saque(valor);

                    valor = conta.Saldo();

                    txtSaldo.Text = valor.ToString();

                    MessageBox.Show("Operação realizada com sucesso!!!");

                    txtValor.Clear();
                }

            }

            catch (FormatException erro)
            {
                MessageBox.Show("Digite um valor valido!!!");
                txtValor.Clear();
            }

            catch(ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
                txtValor.Clear();
            }

            catch(SaldoInsuficienteException erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Saldo insuficiente!!");
                sb.AppendLine();
            }

        }
    }
}
