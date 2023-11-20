using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Form1 : Form
    {
        //campo/atributo do tipo referência para um objeto do tipo "ContaBancaria"
        //cria a referência "conta" (ainda não criou o objeto "ContaBancária")
        ContaBancaria conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cria um objeto conta bancária !!!
            //esse objeto será acessado por meio da referência "conta";
            conta = new ContaBancaria();

            //recupera o saldo da conta (nesse caso R$100,00)
            double saldo = conta.saldo();

            //Atualiza o textbox responsável por mostrar o saldo da conta!
            txbSaldo.Text = saldo.ToString();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //variavel auxiliar usada para guardar o valor depositado,sacado, ou o saldo
            double valor;

            //Caso o usuário tenha selecionado a opção de depósito
            if (rdbDeposito.Checked)
            {
                //recupera o valor a ser depositado
                valor = double.Parse(txbValor.Text);

                //tenta efetuar um deposito;
                //o método depósito retorna false e não efetua o depósito
                //caso ocorra algum erro!
                if (conta.deposito(valor) == false)
                {
                    //Utiliza a classe StringBuilder para construir
                    //a mensagem de erro
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Não foi possível efetuar o depósito!");
                    sb.AppendLine();
                    sb.Append("Verifique se o valor do depósito é Valido. ");
                    sb.Append("São permitidos depósitos de no mínimo R$ 50,00. ");
                    sb.AppendLine();
                    sb.Append("Verifique se a conta possui saldo o suficiente para efetuar o saque. ");

                    //exibe uma mensagem informando o tipo de erro
                    MessageBox.Show(sb.ToString());

                    //limpa o texbox com o valor inválido!
                    txbValor.Clear();
                }
            }
            //Caso o usuário tenha selecionado a opção de depósito
            else if (rdbSaque.Checked)
            {
                //recupera o valor a ser sacado.
                valor = double.Parse(txbValor.Text);

                //tenta efetuar um saque;
                //o método depósito retorna false e não efetua o depósito
                //caso ocorra algum erro!
                if (conta.saque(valor) == false)
                {
                    //Utiliza a classe StringBuilder para construir
                    //a mensagem de erro
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Não foi possível efetuar o saque!");
                    sb.AppendLine();
                    sb.Append("Verifique se o valor do saque é Valido. ");
                    sb.Append("São permitidos saques com o valor mínimo de R$ 10,00. ");

                    //exibe uma mensagem informando o tipo de erro
                    MessageBox.Show(sb.ToString());

                    //limpa o texbox com o valor inválido!
                    txbValor.Clear();
                }
            }

            //mostra na janela o novo valor do saldo após a operação de saque ou depósito.
            //recupera o valor do saldo
            valor = conta.saldo();
            //exibe o valor do saldo corrente
            txbSaldo.Text = valor.ToString();
        }
    }
}
