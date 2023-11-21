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
    public partial class TelaInicial : Form
    {

        private Cadastro cadastro;

        public TelaInicial(Cadastro cadastro)
        {
            InitializeComponent();

            this.cadastro = cadastro;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar Cadastro = new Cadastrar(cadastro);

            Cadastro.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //pois é vamo la
        }
    }
}
