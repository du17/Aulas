using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int NumPaginas;
        private int ISBN;

        public Livro(string T, string A) {
            Titulo = T;
            Autor = A;
        }

        public int GetISBN()
        {
            return ISBN;
        }
    }
}
