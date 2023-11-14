
namespace GIT
{
    partial class JogoForca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLetra = new System.Windows.Forms.TextBox();
            this.labelPalavraSecreta = new System.Windows.Forms.Label();
            this.labelLetrasTentadas = new System.Windows.Forms.Label();
            this.labelErrosRestantes = new System.Windows.Forms.Label();
            this.buttonTentarLetra = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLetra
            // 
            this.textBoxLetra.Location = new System.Drawing.Point(307, 93);
            this.textBoxLetra.Name = "textBoxLetra";
            this.textBoxLetra.Size = new System.Drawing.Size(113, 20);
            this.textBoxLetra.TabIndex = 0;
            this.textBoxLetra.TextChanged += new System.EventHandler(this.textBoxLetra_TextChanged);
            // 
            // labelPalavraSecreta
            // 
            this.labelPalavraSecreta.Location = new System.Drawing.Point(41, 218);
            this.labelPalavraSecreta.Name = "labelPalavraSecreta";
            this.labelPalavraSecreta.Size = new System.Drawing.Size(130, 36);
            this.labelPalavraSecreta.TabIndex = 1;
            this.labelPalavraSecreta.Text = "Palavra Secreta";
            // 
            // labelLetrasTentadas
            // 
            this.labelLetrasTentadas.Location = new System.Drawing.Point(41, 135);
            this.labelLetrasTentadas.Name = "labelLetrasTentadas";
            this.labelLetrasTentadas.Size = new System.Drawing.Size(130, 36);
            this.labelLetrasTentadas.TabIndex = 2;
            this.labelLetrasTentadas.Text = "Tentativas";
            // 
            // labelErrosRestantes
            // 
            this.labelErrosRestantes.Location = new System.Drawing.Point(41, 52);
            this.labelErrosRestantes.Name = "labelErrosRestantes";
            this.labelErrosRestantes.Size = new System.Drawing.Size(130, 36);
            this.labelErrosRestantes.TabIndex = 3;
            this.labelErrosRestantes.Text = "Erros Restantes";
            // 
            // buttonTentarLetra
            // 
            this.buttonTentarLetra.Location = new System.Drawing.Point(490, 93);
            this.buttonTentarLetra.Name = "buttonTentarLetra";
            this.buttonTentarLetra.Size = new System.Drawing.Size(96, 27);
            this.buttonTentarLetra.TabIndex = 5;
            this.buttonTentarLetra.Text = "Tentativa";
            this.buttonTentarLetra.UseVisualStyleBackColor = true;
            this.buttonTentarLetra.Click += new System.EventHandler(this.buttonTentarLetra_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(637, 93);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(96, 27);
            this.buttonReiniciar.TabIndex = 6;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // JogoForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonTentarLetra);
            this.Controls.Add(this.labelErrosRestantes);
            this.Controls.Add(this.labelLetrasTentadas);
            this.Controls.Add(this.labelPalavraSecreta);
            this.Controls.Add(this.textBoxLetra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JogoForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.JogoForca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLetra;
        private System.Windows.Forms.Label labelPalavraSecreta;
        private System.Windows.Forms.Label labelLetrasTentadas;
        private System.Windows.Forms.Label labelErrosRestantes;
        private System.Windows.Forms.Button buttonTentarLetra;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}