using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDentado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria e inicializa uma matriz com 5 linhas
            //e com um número variável de colunas
            /*int[][] itens = new int[5][];
            itens[0] = new int[] { 1, 2, 3, 4 };
            itens[1] = new int[] { 1, 2, 3, 4, 5 };
            itens[2] = new int[] { 1, 2, 3 };
            itens[3] = new int[] { 1, 2, 3, 4 };
            itens[4] = new int[] { 1, 2 };*/


            // uma matriz de 5 linhas e número variável de colunas
            int[][] itens = new int[5][];
            itens[0] = new int[4]; //primeira linha tem 4 colunas
            itens[1] = new int[5]; //primeira linha tem 5 colunas
            itens[2] = new int[3]; //primeira linha tem 3 colunas
            itens[3] = new int[4]; //primeira linha tem 4 colunas
            itens[4] = new int[2]; //primeira linha tem 2 colunas

            itens[0][2] = 15;
            itens[3][3] = 23;

            //Percorre as linhas
            for (int i = 0; i < itens.GetLength(0); i++)
            {
                //Percorre as colunas
                for (int j = 0; j < itens[i].GetLength(0); j++)
                {
                    Console.Write("{0}\t", itens[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
