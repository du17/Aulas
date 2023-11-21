using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT
{
    class ContaBancariaClass
    {

        private Double saldoAtual;

        public ContaBancariaClass()
        {
            saldoAtual = 100.00;
        }

        public Double Saldo()
        {
            return saldoAtual;
        }

        public bool Deposito(double valor)
        {
            if(valor < 50.0)
            {
                return false;
            }

            else
            {
                saldoAtual = +valor;

                DescontarTarifa();

                return true;
            }

        }

        public bool Saque(double valor)
        {
            if(valor < 10)
            {
                return false;
            }

            else if(valor > saldoAtual)
            {
                return false;
            }

            else
            {
                saldoAtual = saldoAtual - valor;

                DescontarTarifa();

                return true;

            }

        }

        private void DescontarTarifa()
        {
            saldoAtual -= 0.1;
        }

    }
}
