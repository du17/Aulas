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
    public partial class FrmPrincipal : Form
    {
        //campo usado para guardar uma referência para um objeto Cadastro;
        private Cadastro cadastro;

        //o construtor recebe uma referência para um objeto Cadastro;
        public FrmPrincipal(Cadastro cadastro)
        {
            InitializeComponent();

            //guarda a referencia do objeto cadastro no campo da classe
            this.cadastro = cadastro;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //cria a janela de cadastro
            FrmCadastrar frmCadastro = new FrmCadastrar(cadastro);

            //exibe a janela
            frmCadastro.ShowDialog();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //cria a janela de pesquisa
            FrmPesquisar frmPesquisar = new FrmPesquisar(cadastro);

            //exibe a janela
            frmPesquisar.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //cria a janela de exclusão de cadastro
            FrmExcluir frmExcluir = new FrmExcluir(cadastro);

            //exibe a janela
            frmExcluir.ShowDialog();
        }
    }
}
