using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaBancaria
    {
        //campo privado utilizado para guardar o saldo da conta
        private double saldoAtual;

        //contrutor que inicializa todo objeto criado do tipo "ContaBancaria"
        //com um saldo igual a R$100,00
        public ContaBancaria()
        {
            saldoAtual = 100;
        }


        //retorna o valor atual da conta (o saldo)
        public double saldo()
        {
            return saldoAtual;
        }


        //executa um deposito (usando o valor passado como parâmetro)
        // e cobra uma taxa
        public bool deposito(double valor)
        {
            //Se o valor depositado for menor R$50,00 não efetua o 
            //depósito e retorna false
            if (valor < 50.0)
            {
                //retorna e indica que ocorreu um erro durante o depósito!
                return false;
            }
            //Caso o valor do depósito seja maior ou igual a R$50,00
            else
            {
                //atualiza o valor do saldo
                saldoAtual += valor;

                //cobra uma tarifa
                descontaTarifa();

                //retorna e indica que o depósito foi efetuado com sucesso!
                return true;
            }
        }


        //tenta efetuar o saque (usando o valor passado como parâmetro)
        public bool saque(double valor)
        {
            //Se o valor do saque for inferior a R$10,00
            //não efetua o saque e retorna false
            if (valor < 10)
            {
                //retorna e indica que ocorreu um erro durante o saque !
                return false;
            }
            //Se o valor do saque maior que o valor do saldo, ou seja
            //se não houver saldo o suficiente para efetuar o saque
            //não efetua o saque e retorna false
            else if (valor > saldoAtual)
            {
                //retorna e indica que ocorreu um erro durante o saque!
                return false;
            }
            //Caso o valor do saque seja maior ou igual à R$10,00 e
            //a conta possua saldo o suficiente para efetuar o saque!
            else
            {
                //Posso retirar um valor menor ou igual ao saldo atual 
                //atualiza o saldo da conta
                saldoAtual = saldoAtual - valor;

                // cobra/desconta a tarifa de 10 centavos
                descontaTarifa();

                //retorna e indica que o saque foi efetuado com sucesso!
                return true;
            }
        }


        // Método privado utilizado para descontar a tarifa de 10 centavos
        // do saldo para cada operação de depósito ou saque realizada com sucesso.
        // O metodo é privado para ser utilizado apenas dentro da classe.
        // Os objetos criados na classe Program não podem conseguir acessar esse método!
        private void descontaTarifa()
        {
            //desconta 10 centavos (0.1 reais) do saldo atual
            saldoAtual -= 0.1;
        }
    }
}
