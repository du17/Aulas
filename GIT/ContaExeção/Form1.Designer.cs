
namespace GIT.ContaExeção
{
    partial class Form1
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
            this.groupBoxInformacoes = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.groupBoxOperacao = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDeposito = new System.Windows.Forms.RadioButton();
            this.radioButtonSaque = new System.Windows.Forms.RadioButton();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.groupBoxInformacoes.SuspendLayout();
            this.groupBoxOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformacoes
            // 
            this.groupBoxInformacoes.Controls.Add(this.txtSaldo);
            this.groupBoxInformacoes.Controls.Add(this.lblSaldo);
            this.groupBoxInformacoes.Location = new System.Drawing.Point(302, 37);
            this.groupBoxInformacoes.Name = "groupBoxInformacoes";
            this.groupBoxInformacoes.Size = new System.Drawing.Size(241, 170);
            this.groupBoxInformacoes.TabIndex = 3;
            this.groupBoxInformacoes.TabStop = false;
            this.groupBoxInformacoes.Text = "Informações";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(74, 89);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(161, 20);
            this.txtSaldo.TabIndex = 1;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(16, 92);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo :";
            // 
            // groupBoxOperacao
            // 
            this.groupBoxOperacao.Controls.Add(this.txtValor);
            this.groupBoxOperacao.Controls.Add(this.label1);
            this.groupBoxOperacao.Controls.Add(this.radioButtonDeposito);
            this.groupBoxOperacao.Controls.Add(this.radioButtonSaque);
            this.groupBoxOperacao.Controls.Add(this.buttonExecutar);
            this.groupBoxOperacao.Location = new System.Drawing.Point(31, 37);
            this.groupBoxOperacao.Name = "groupBoxOperacao";
            this.groupBoxOperacao.Size = new System.Drawing.Size(241, 170);
            this.groupBoxOperacao.TabIndex = 2;
            this.groupBoxOperacao.TabStop = false;
            this.groupBoxOperacao.Text = "Operação";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(74, 42);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(161, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor :";
            // 
            // radioButtonDeposito
            // 
            this.radioButtonDeposito.AutoSize = true;
            this.radioButtonDeposito.Location = new System.Drawing.Point(140, 92);
            this.radioButtonDeposito.Name = "radioButtonDeposito";
            this.radioButtonDeposito.Size = new System.Drawing.Size(67, 17);
            this.radioButtonDeposito.TabIndex = 2;
            this.radioButtonDeposito.TabStop = true;
            this.radioButtonDeposito.Text = "Deposito";
            this.radioButtonDeposito.UseVisualStyleBackColor = true;
            // 
            // radioButtonSaque
            // 
            this.radioButtonSaque.AutoSize = true;
            this.radioButtonSaque.Location = new System.Drawing.Point(36, 92);
            this.radioButtonSaque.Name = "radioButtonSaque";
            this.radioButtonSaque.Size = new System.Drawing.Size(56, 17);
            this.radioButtonSaque.TabIndex = 1;
            this.radioButtonSaque.TabStop = true;
            this.radioButtonSaque.Text = "Saque";
            this.radioButtonSaque.UseVisualStyleBackColor = true;
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Location = new System.Drawing.Point(36, 128);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(171, 34);
            this.buttonExecutar.TabIndex = 1;
            this.buttonExecutar.Text = "Executar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 248);
            this.Controls.Add(this.groupBoxInformacoes);
            this.Controls.Add(this.groupBoxOperacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInformacoes.ResumeLayout(false);
            this.groupBoxInformacoes.PerformLayout();
            this.groupBoxOperacao.ResumeLayout(false);
            this.groupBoxOperacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformacoes;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox groupBoxOperacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDeposito;
        private System.Windows.Forms.RadioButton radioButtonSaque;
        private System.Windows.Forms.Button buttonExecutar;
    }
}