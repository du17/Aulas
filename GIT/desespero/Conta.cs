using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.desespero
{
    public partial class Conta : Form
    {
        private ContaBancaria conta;

        public Conta()
        {
            InitializeComponent();
        }

        private void Conta_Load(object sender, EventArgs e)
        {
            conta = new ContaBancaria();
            double saldo = conta.saldo();
            txtSaque.Text = saldo.ToString(); 
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDeposito.Checked)
                {
                    double valor = double.Parse(txtValor.Text);

                    conta.deposito(valor);

                    valor = conta.saldo();

                    txtSaque.Text = valor.ToString();

                    MessageBox.Show("Operacao feita com sucesso !!");

                    txtValor.Clear();
                }

                if (rbSaque.Checked)
                {
                    double valor = double.Parse(txtValor.Text);

                    conta.saque(valor);

                    valor = conta.saldo();

                    txtSaque.Text = valor.ToString();

                    MessageBox.Show("Operacao feita com sucesso !!");

                    txtValor.Clear();
                }
            }
            catch(FormatException erro)
            {
                MessageBox.Show("digite um valor numerico valido !!");
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
                sb.Append("Saldo insuficiente");
                sb.AppendLine();
                sb.AppendFormat("O saldo atual ({0:C}) é insuficiente ", erro.getSaldoAtual());
                sb.AppendFormat("para esse saque ({0:C)}", erro.getValorSaque());

                MessageBox.Show(sb.ToString());
                txtValor.Clear();
            }
            catch(Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Tipo da excecao" + GetType());
                sb.AppendLine();
                sb.Append(erro.Message);

                MessageBox.Show(sb.ToString());
            }
        }
    }
}
