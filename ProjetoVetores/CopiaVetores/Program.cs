using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vetor original
            int[] matriculas = new int[4] { 23, 37, 45, 92 };

            //guarda a referência do vetor em outra variável
            int[] referencia = matriculas; 

            //cria um novo vetor do mesmo tamanho que matriculas
            int[] copia = new int[matriculas.Length];

            //copia os valores do vetor matriculas para o vetor copia
            for (int i = 0; i < copia.Length; i++)
            {
                //copia o elemento do vetor matriculas para o vetor copia
                copia[i] = matriculas[i];
            }

            //modifica o elemento na posição 0 do vetor matricula utilizando
            //a variável referência
            referencia[0] = 30;

            //imprime os elementos do vetor matriculas
            Console.Write("matriculas: ");
            for (int i = 0; i < matriculas.Length; i++)
            {
                Console.Write("{0}, ", matriculas[i]);
            }
            Console.WriteLine("\n");

            //imprime os elementos do vetor matriculas utilizando
            //a referência
            Console.Write("referencia: ");
            for(int i = 0; i < referencia.Length; i++)
            {
                Console.Write("{0}, ", referencia[i]);
            }
            Console.WriteLine("\n");

            //imprime os elementos do vetor cópia
            Console.Write("copia: ");
            for (int i = 0; i < copia.Length; i++)
            {
                Console.Write("{0}, ", copia[i]);
            }
            Console.WriteLine("\n\n");
        }
    }
}
