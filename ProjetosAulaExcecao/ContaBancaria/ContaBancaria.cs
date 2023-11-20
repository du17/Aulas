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
        public void deposito(double valor)
        {
            //gera uma exceção (do sistema) do tipo "Argumento Inválido"
            //caso o usuário tente depositar um valor menor que R$50,00
            if (valor < 50)
            {
                //cria uma mensagem de erro
                string textoErro = String.Format("Erro Depósito: O valor mínimo é de R$50,00.\nVocê tentou depositar {0:C}", valor);

                //gera/dispara uma exceção (Argumento Inválido)
                //passa a mensagem de erro para o construtor da classe
                //de exceção ArgumentException
                throw new ArgumentException(textoErro);
            }
            //caso o usuário deposite um valor maior ou igual a R$50,00
            else
            {
                //atualiza o valor do saldo
                saldoAtual += valor;

                // cobra/desconta a tarifa de 10 centavos
                descontaTarifa();
            }
        }

        //tenta efetuar o saque (usando o valor passado como parâmetro)
        public void saque(double valor)
        {
            //gera uma exceção (do sistema) do tipo "Argumento Inválido"
            //caso o usuário tente sacar um valor menor que "R$10,00"
            if (valor < 10)
            {
                //cria uma mensagem de erro
                string textoErro = String.Format("Erro Saque: O valor mínimo é de R$10,00.\nVocê tentou sacar {0:C}", valor);


                // gera / dispara uma exceção(Argumento Inválido)
                //passa a mensagem de erro para o construtor da classe
                //de exceção ArgumentException
                throw new ArgumentException(textoErro);
            }

            // Gera a exceção "SaldoInsuficienteException" definida pelo nosso programa !!!
            // Essa exceção (SaldoInsuficienteException) foi criada especialmente para a aplicação !!!
            // A exceção será disparada caso não exista saldo suficiente para efeturar o saque
            if (valor > saldoAtual)
            {
                //gera uma exceção (criada para a aplicação) de saldo insuficiente
                throw new SaldoInsuficienteException(saldoAtual, valor);
            }

            //Posso retirar um valor menor ou igual ao saldo atual 
            //atualiza o saldo da conta
            saldoAtual = saldoAtual - valor;

            // cobra/desconta a tarifa de 10 centavos
            descontaTarifa();
        }

        //metodo privado utilizado para descontar do saldo, a tarifa de 10 centavos
        // para cada operação de depósito ou saque realizada com sucesso
        // o metodo é privado para ser utilizado apenas dentro da classe.
        // Os objetos criados na classe Program não podem conseguir acessar esse método.
        private void descontaTarifa()
        {
            //desconta 10 centavos (0.1 reais) do saldo atual
            saldoAtual = saldoAtual - 0.1;
        }
    }
}
