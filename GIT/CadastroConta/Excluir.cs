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
    public partial class Excluir : Form
    {

        private Cadastro cadastro;
        private String cpf;

        public Excluir(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cpf = txtPesquisar.Text;

            Pessoa pessoa = cadastro.PesquisarCpf(cpf);

            if(pessoa != null)
            {
                txtNome.Text = pessoa.getNome();
                txtIdade.Text = pessoa.getIdade().ToString();
                txtCPF.Text = pessoa.getCpf();
            }

            else
            {
                MessageBox.Show("CPF não encontrado!!!!");
                clearTextBox();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cpf = txtPesquisar.Text;

            if (cadastro.RemoverPessoa(cpf) == true)
            {
                MessageBox.Show("Remoção feita com sucesso!!!");
            }

            else
            {
                MessageBox.Show("Não foi possivel ser feita a operação!!!");
            }

            clearTextBox();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearTextBox()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtCPF.Clear();
        }
    }
}
