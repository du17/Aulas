using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.CadastroConta
{
    public partial class Cadastrar : Form
    {

        private Cadastro cadastro;
        private String nome, cpf;
        private Int16 idade;

        public Cadastrar(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            idade = Int16.Parse(txtIdade.Text);
            cpf = txtCPF.Text;

            Pessoa pessoa = new Pessoa(nome, cpf, idade);

            cadastro.CadastrarPessoa(pessoa);

            MessageBox.Show("Cadastro realizado com sucesso");

            Close();

        }
    }
}
