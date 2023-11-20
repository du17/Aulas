using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Copas = new int[5];
            Copas[0] = 1958;
            Copas[1] = 1962;
            Copas[2] = 1970;
            Copas[3] = 1994;
            Copas[4] = 2002;*/
            
            int[] Copas = new int[5] { 1958, 1962, 1970, 1994, 2002 };

            int bicampeonato;
            bicampeonato = Copas[1];
            Console.WriteLine("Ano do bicampeonato: {0}", bicampeonato);

            Console.WriteLine("\nAnos que o Brasil venceu Copas do Mundo: ");
            for(int i=0; i < Copas.Length; i++)
            {
                Console.WriteLine(Copas[i]);
            }
        }
    }
}
