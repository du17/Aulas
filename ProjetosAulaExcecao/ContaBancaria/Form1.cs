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
            // Bloco de execução protegida !!!
            // O bloco try tenta executar todas as instruções
            // Se ocorrer algum erro, a execução é pulada/desviada para os blocos catch
            try
            {
                //Caso o usuário tenha
                if (rdbDeposito.Checked)
                {

                    //recupera o valor (contido em txbValor.Text) a ser ser depositado
                    //caso double.Parse não consiga converter o conteúdo do 
                    //texbox para double, ele irá gerar a exceção: "FormatException"
                    double valor = double.Parse(txbValor.Text);

                    //tenta efetuar um deposito (o depósito mínimo permitido é de "R$50,00")
                    //caso tente depositar um valor menor que R$50.00 
                    //gera a exeção "ArgumentException"
                    conta.deposito(valor);

                    //recupera o valor do saldo
                    valor = conta.saldo();

                    //exibe o valor do saldo corrente
                    txbSaldo.Text = valor.ToString();

                    //Exibe uma janela informando o sucesso da operação!!!
                    MessageBox.Show("Operação bancaria executada com sucesso !");

                    //limpa o texbox com o valor
                    txbValor.Clear();
                }

                if (rdbSaque.Checked)
                {
                    //recupera o valor (contido em txbValor.Text) a ser ser sacado/retirado
                    //caso double.Parse não consiga converter o conteúdo do 
                    //texbox para double, ele irá gerar a exceção: "FormatException"
                    double valor = double.Parse(txbValor.Text);


                    //tenta efetuar um saque;
                    //caso tente sacar um valor memor que R$10.00 gera a exeção "ArgumentException"
                    //caso não possua saldo o suficiente para executar o saque
                    //gera a exceção: "SaldoInsuficienteException"
                    conta.saque(valor);

                    //recupera o valor do saldo
                    valor = conta.saldo();

                    //exibe o valor do saldo corrente
                    txbSaldo.Text = valor.ToString();

                    //Exibe uma janela informando o sucesso da operação!!!
                    MessageBox.Show("Operação bancaria executada com sucesso !");

                    //limpa o texbox com o valor
                    txbValor.Clear();
                }

            }

            //trata a exceção gerada pelo método "Parse" quando a string
            //passada não representa um valor numérico
            catch (FormatException erro)
            {
                //Exibe a janela de erro!
                MessageBox.Show("Digite um valor numérico válido!!");

                //limpa o texbox com o valor inválido
                txbValor.Clear();
            }

            //trata a exceção gerada pelos métodos "saque" ou "depósito" quando é passado
            //valores númericos inválidos (que não façam sentido para a aplicação)
            //método saque --> caso tente sacar um valor memor que R$10.00
            //método depósito --> caso tente depositar um valor menor que R$50.00
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
                txbValor.Clear();

            }

            //trata a exceção gerada pelo método "saque" quando a conta
            //não possui saldo suficiente para efetuar o saque
            catch (SaldoInsuficienteException erro)
            {
                //classe utilizada para auxiliar a construção de strings
                StringBuilder sb = new StringBuilder();
                sb.Append("Saldo Insuficiente");
                sb.AppendLine();
                sb.AppendFormat("O saldo atual ({0:C}) é insuficiente ",erro.getSaldoAtual());
                sb.AppendFormat("para o valor sacado ({0:C})!", erro.getValorSaque());

                //Exibe a janela de erro!
                MessageBox.Show(sb.ToString());

                //limpa o texbox com o valor inválido
                txbValor.Clear();
            }

            //trata qualquer outra exceção não prevista durante o desenvolvimento
            //da aplicação
            catch (Exception erro)
            {
                //cria uma string com as informações do erro
                StringBuilder sb = new StringBuilder();
                sb.Append("Tipo da Exceção: " + erro.GetType()); //Classe da Exceção
                sb.AppendLine();
                sb.AppendLine(erro.Message); //Mensagem de Erro

                //exibe uma janela de mensagem com as informções do erro ocorrido
                MessageBox.Show(sb.ToString());
            }

        }
    }
}
