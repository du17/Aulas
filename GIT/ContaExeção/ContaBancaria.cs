using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.ContaExeção
{
    class ContaBancaria
    {

        private Double saldoAtual;
        private Double textoErro;

        public ContaBancaria()
        {
            saldoAtual = 100;
        }

        public Double Saldo()
        {
            return saldoAtual;
        }

        public void Deposito(Double valor)
        {
            if(valor < 50)
            {
                textoErro = String.Format("Erro: valor mínimo é de R$50,00.\nVocê tentou depositar {0:C}", valor);

                throw new ArgumentException(textoErro);
            }

            else
            {
                saldoAtual += valor;

                DescontarTarifa();
            }
        }

        public void Saque(Double valor)
        {
            if(valor < 10)
            {
                textoErro = String.Format("Erro: valor mínimo é de R$10,00.\nVocê tentou sacar {0:C}", valor);

                throw new ArgumentException(textoErro);
            }

            if(valor > saldoAtual)
            {
                throw new SaldoInsuficienteException(saldoAtual, valor);
            }

            saldoAtual = saldoAtual - valor;

            DescontarTarifa();

        }

        public void DescontarTarifa()
        {
            saldoAtual = saldoAtual - 0.1;
        }

    }
}
