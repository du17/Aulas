using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // cria e inicializa uma matriz 4 X 6
            /*int[,] itens = { {  1,  2,  3,  4 },
                                {  5,  6,  7,  8 },
                                {  9, 10, 11, 12 },
                                { 13, 14, 15, 16 },
                                { 17, 18, 19, 20 } };*/

            // cria  uma matriz 6 X 4 (6 linhas e 4 colunas)
            int[,] itens = new int[6, 4];

            itens[2, 3] = 99; // o elemento na posição (2,3) recebe “99”

            itens[2, 2] = itens[2, 3]; //copia o elemento (2,3) para o (2,2)

            itens[2, 3]++; // incrementa o valor do elemento (2,3)

            //Percorre todos os elementos da matriz
            for (int i = 0; i < itens.GetLength(0); i++)
            {
                for(int j = 0; j < itens.GetLength(1); j++)
                {
                    Console.Write("{0}\t", itens[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
