using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaSemExcecao
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
            //aceita depósitos maiores ou iguais à R$50,00
            if (valor >= 50)
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
            //aceita saques maiores ou iguais à "R$10,00"
            //não permite saques maiores que o saldo atual
            if (valor >= 10 && valor <= saldoAtual)
            {
                //atualiza o saldo da conta
                saldoAtual = saldoAtual - valor;

                // cobra/desconta a tarifa de 10 centavos
                descontaTarifa();
            }
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
