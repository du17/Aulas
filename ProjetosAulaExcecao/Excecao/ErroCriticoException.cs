using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    class ErroCriticoException : Exception
    {
        //atributos/campos da classe
        private int valor;
        private string texto;

        //Construtor
        public ErroCriticoException(int valor, string texto) {

            this.valor = valor;
            this.texto = texto;
        }

        // retorna o conteúdo do atributo valor
        public int getValor()
        {
            return valor;
        }

        //retorna o conteúdo do atributo texto
        public string getTexto()
        {
            return texto;
        }
    }
}
