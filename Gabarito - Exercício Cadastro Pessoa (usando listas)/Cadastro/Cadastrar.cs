using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmCadastrar : Form
    {
        //campo usado para guardar uma referência para um objeto Cadastro;
        private Cadastro cadastro;

        //o construtor recebe uma referência para um objeto Cadastro;
        public FrmCadastrar(Cadastro cadastro)
        {
            InitializeComponent();

            //recebe uma referencia para um objeto cadastro;
            this.cadastro = cadastro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //fecha a janela
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //variáveis temporárias utilizadas para guardar os dados
            //da pessoa que são entrados pelo usuário
            string nome;
            int idade;
            string cpf;

            //recupera os dados dos TextBox
            nome = txbNome.Text;
            idade = int.Parse(txbIdade.Text);
            cpf = txbCpf.Text;

            //cria e inicializa um objeto do tipo Pessoa
            Pessoa pessoa = new Pessoa(nome, idade, cpf);

            //adiciona a pessoa no cadastro
            cadastro.CadastrarPessoa(pessoa);

            //Exibe uma mensagem informado a inserção
            MessageBox.Show("Cadastro efetuado com sucesso !!!");

            //Fecha a janela
            Close();
        }
    }
}
