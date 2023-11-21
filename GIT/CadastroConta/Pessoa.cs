using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.CadastroConta
{
    class Pessoa
    {

        private String nome, cpf;
        private Int16 idade;

        public Pessoa(String nome, String cpf, Int16 idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        public String getNome()
        {
            return nome;
        }

        public String getCpf()
        {
            return cpf;
        }

        public Int16 getIdade()
        {
            return idade;
        }

    }
}
