using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.CadastroConta
{
    class Cadastro
    {

        private List<Pessoa> lista_pessoas;

        public Cadastro()
        {
            lista_pessoas = new List<Pessoa>();
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            if(pessoa != null)
            {
                lista_pessoas.Add(pessoa);
            }
        }

        public Pessoa PesquisarCpf(string cpf)
        {
            foreach (Pessoa pessoa in lista_pessoas)
            {

                if (String.Compare(pessoa.getCpf(), cpf, true) == 0)
                {
                    return pessoa;
                }
            }
            return null;
        }

        public bool RemoverPessoa(String cpf)
        {
            Pessoa pessoa = PesquisarCpf(cpf);

            if(pessoa != null)
            {
                lista_pessoas.Remove(pessoa);
                return true;
            }

            return false;
        }

        public String Relatorio()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Pessoa pessoa in lista_pessoas)
            {
                sb.AppendFormat("* Nome: {0} - Idade: {1} - CPF {2}; \n", pessoa.getNome(), pessoa.getIdade(), pessoa.getCpf());
            }

            return sb.ToString();
        }

    }
}
