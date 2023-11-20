using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class SaldoInsuficienteException : Exception
    {
        //dados guardados pela exceção
        private double saldoAtual;
        private double valorSaque;

        //construtor da classe
        public SaldoInsuficienteException(double saldoAtual, double valorSaque)
        {
            this.saldoAtual = saldoAtual;
            this.valorSaque = valorSaque;
        }

        // recupera o valor do saldo atual
        public double getSaldoAtual()
        {
            return saldoAtual;
        }

        // recupera o valor do saque inválido
        public double getValorSaque()
        {
            return valorSaque;
        }
    }
}
