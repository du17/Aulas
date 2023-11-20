using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaSemExcecao
{
    public partial class Form1 : Form
    {
        //campo/atributo do tipo referência para um objeto do tipo "ContaBancaria"
        // cria a referência "conta" (ainda não criou o objeto "ContaBancária")
        private ContaBancaria conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cria um objeto conta bancária !!!
            //esse objeto será acessado por meio da referência "Conta";
            conta = new ContaBancaria();

            //recupera o saldo da conta (nesse caso R$100,00)
            double saldo = conta.saldo();

            //Atualiza o textbox responsável por mostrar o saldo da conta!
            txbSaldo.Text = saldo.ToString();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Caso o usuário tenha marcado a opção de depósito
            if (rdbDeposito.Checked)
            {
                //recupera o valor (contido em txbValor.Text) a ser ser depositado
                double valor = double.Parse(txbValor.Text);

                //tenta efetuar um deposito (o depósito mínimo permitido é de "R$50,00")
                conta.deposito(valor);

                //recupera o valor do saldo
                valor = conta.saldo();

                //exibe o valor do saldo corrente
                txbSaldo.Text = valor.ToString();

                //limpa o texbox com o valor
                txbValor.Clear();
            }

            //caso o usuário tenha marcada a opção de saque
            if (rdbSaque.Checked)
            {
                //recupera o valor (contido em txbValor.Text) a ser ser sacado/retirado
                double valor = double.Parse(txbValor.Text);

                //tenta efetuar um saque;
                conta.saque(valor);

                //recupera o valor do saldo
                valor = conta.saldo();

                //exibe o valor do saldo corrente
                txbSaldo.Text = valor.ToString();

                //limpa o texbox com o valor
                txbValor.Clear();
            }
        }
    }
}
