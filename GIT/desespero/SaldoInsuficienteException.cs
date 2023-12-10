using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.desespero
{
    class SaldoInsuficienteException : Exception
    {
        private double saldoAtual;
        private double valorSaque;

        public SaldoInsuficienteException(double saldoAtual, double valorSaque)
        {
            this.saldoAtual = saldoAtual;
            this.valorSaque = valorSaque;
        }

        public double getSaldoAtual()
        {
            return saldoAtual;
        }

        public double getValorSaque()
        {
            return valorSaque;
        }

    }
}
