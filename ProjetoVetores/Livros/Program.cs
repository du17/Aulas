using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria um vetor para armazer até 9 referências para 
            //objetos do tipo livro
            Livro[] Estante = new Livro[9];

            //ERRO:  System.NullReferenceException
            //string TituloDoLivro = Estante[4].Titulo;

            //cria um objeto do tipo Livro e guarda a referência dele na
            //quinta posição (índice 4) do vetor
            Estante[4] = new Livro("Moby Dick", "Herman Melville");

            //recupera a referência para um objeto do tipo livro e acessa
            //o valor do campo "Titulo"
            string TituloDoLivro = Estante[4].Titulo;
            Console.WriteLine("Título: {0}", TituloDoLivro);

            //Percorre o vetor de Livros
            Console.WriteLine("\nLivros: ");
            for(int i = 0; i < Estante.Length; i++)
            {
                //verifica se a posição do vetor contém uma referência válida
                //para um objeto do tipo Livro
                if(Estante[i] != null)
                {
                    //imprime o título do livro na tela
                    Console.WriteLine("* {0}", Estante[i].Titulo);
                } 
            }
        }
    }
}
