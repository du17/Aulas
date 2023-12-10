using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.desespero
{
    class ContaBancaria
    {
        private double saldoAtual;

        public ContaBancaria()
        {
            saldoAtual = 100.00;
        }

        public double saldo()
        {
            return saldoAtual;
        }

        public void deposito(double valor)
        {
            if(valor < 50)
            {
                throw new ArgumentException("São permitidos depositos de no minimo 50,00!!");
            }

            else
            {
                saldoAtual = +valor;
                descontarTarifa();
            }
        }

        public void saque(double valor)
        {
            if(valor < 10)
            {
                throw new ArgumentException("São permitidos depositos de no minimo 10,00!!");
            }

            else if(valor > saldoAtual){
                throw new SaldoInsuficienteException(saldoAtual, valor);
            }

            saldoAtual = saldoAtual - valor;

            descontarTarifa();
        }

        private void descontarTarifa()
        {
            saldoAtual = saldoAtual - 0.1;
        }

    }
}
