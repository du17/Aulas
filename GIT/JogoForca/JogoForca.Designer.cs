
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
            this.textBoxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetra.Location = new System.Drawing.Point(12, 234);
            this.textBoxLetra.Name = "textBoxLetra";
            this.textBoxLetra.Size = new System.Drawing.Size(267, 29);
            this.textBoxLetra.TabIndex = 0;
            this.textBoxLetra.TextChanged += new System.EventHandler(this.textBoxLetra_TextChanged);
            // 
            // labelPalavraSecreta
            // 
            this.labelPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalavraSecreta.Location = new System.Drawing.Point(12, 22);
            this.labelPalavraSecreta.Name = "labelPalavraSecreta";
            this.labelPalavraSecreta.Size = new System.Drawing.Size(425, 70);
            this.labelPalavraSecreta.TabIndex = 1;
            this.labelPalavraSecreta.Text = "Palavra Secreta";
            // 
            // labelLetrasTentadas
            // 
            this.labelLetrasTentadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetrasTentadas.Location = new System.Drawing.Point(495, 126);
            this.labelLetrasTentadas.Name = "labelLetrasTentadas";
            this.labelLetrasTentadas.Size = new System.Drawing.Size(106, 83);
            this.labelLetrasTentadas.TabIndex = 2;
            this.labelLetrasTentadas.Text = "Tentativas";
            this.labelLetrasTentadas.Click += new System.EventHandler(this.labelLetrasTentadas_Click);
            // 
            // labelErrosRestantes
            // 
            this.labelErrosRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrosRestantes.Location = new System.Drawing.Point(471, 22);
            this.labelErrosRestantes.Name = "labelErrosRestantes";
            this.labelErrosRestantes.Size = new System.Drawing.Size(130, 50);
            this.labelErrosRestantes.TabIndex = 3;
            this.labelErrosRestantes.Text = "Erros Restantes";
            // 
            // buttonTentarLetra
            // 
            this.buttonTentarLetra.Location = new System.Drawing.Point(315, 225);
            this.buttonTentarLetra.Name = "buttonTentarLetra";
            this.buttonTentarLetra.Size = new System.Drawing.Size(144, 52);
            this.buttonTentarLetra.TabIndex = 5;
            this.buttonTentarLetra.Text = "Tentativa";
            this.buttonTentarLetra.UseVisualStyleBackColor = true;
            this.buttonTentarLetra.Click += new System.EventHandler(this.buttonTentarLetra_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(474, 225);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(144, 52);
            this.buttonReiniciar.TabIndex = 6;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // JogoForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 298);
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