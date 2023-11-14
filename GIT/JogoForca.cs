using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT
{
    public partial class JogoForca : Form
    {

        private void textBoxLetra_TextChanged(object sender, EventArgs e)
        {

        }

        private List<string> palavras = new List<string>
        {
            "ABACAXI", "ELEFANTE", "GIRASSOL", "PNEUMONIA", "PROGRAMACAO",
            "CACHORRO", "GATO", "BANANA", "COMPUTADOR", "CARRO",
            "MESA", "CADEIRA", "TELEFONE", "LIVRO", "CADERNO",
            "PASTA", "CANETA", "JANELA", "PORTA", "COZINHA"
        };

        private List<char> letrasTentadas = new List<char>();
        private string palavraSecreta;
        private int errosRestantes;
        private bool jogoEmAndamento = false;

        public JogoForca()
        {
            InitializeComponent();
            ReiniciarJogo();
        }

        private void ReiniciarJogo()
        {
            Random rnd = new Random();
            palavraSecreta = palavras[rnd.Next(palavras.Count)];
            letrasTentadas.Clear();
            errosRestantes = 6;
            jogoEmAndamento = true;

            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            labelPalavraSecreta.Text = string.Join(" ", palavraSecreta.Select(c => letrasTentadas.Contains(c) ? c : '_'));
            labelLetrasTentadas.Text = string.Join(", ", letrasTentadas);

            labelErrosRestantes.Text = $"Erros restantes: {errosRestantes}";

            if (!jogoEmAndamento)
            {
                MessageBox.Show("Fim do jogo!");
                ReiniciarJogo();
            }
        }

        private void VerificarLetra(char letra)
        {
            if (!jogoEmAndamento || letrasTentadas.Contains(letra))
                return;

            letrasTentadas.Add(letra);

            if (!palavraSecreta.Contains(letra))
                errosRestantes--;

            if (errosRestantes == 0 || palavraSecreta.All(c => letrasTentadas.Contains(c)))
                jogoEmAndamento = false;

            AtualizarInterface();
        }

        private void JogoForca_Load(object sender, EventArgs e)
        {

        }

        private void buttonTentarLetra_Click(object sender, EventArgs e)
        {
            if (textBoxLetra.Text.Length == 1)
            {
                char letra = textBoxLetra.Text.ToUpper()[0];
                VerificarLetra(letra);
            }
            else
            {
                MessageBox.Show("Por favor, insira apenas uma letra.");
            }
            textBoxLetra.Clear();
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
        }
    }
}
