
namespace GIT.ContaBancaria
{
    partial class CaixaDeBanco
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
            this.groupBoxOperacao = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDeposito = new System.Windows.Forms.RadioButton();
            this.radioButtonSaque = new System.Windows.Forms.RadioButton();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.groupBoxInformacoes = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.groupBoxOperacao.SuspendLayout();
            this.groupBoxInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOperacao
            // 
            this.groupBoxOperacao.Controls.Add(this.txtValor);
            this.groupBoxOperacao.Controls.Add(this.label1);
            this.groupBoxOperacao.Controls.Add(this.radioButtonDeposito);
            this.groupBoxOperacao.Controls.Add(this.radioButtonSaque);
            this.groupBoxOperacao.Controls.Add(this.buttonExecutar);
            this.groupBoxOperacao.Location = new System.Drawing.Point(12, 24);
            this.groupBoxOperacao.Name = "groupBoxOperacao";
            this.groupBoxOperacao.Size = new System.Drawing.Size(241, 170);
            this.groupBoxOperacao.TabIndex = 0;
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
            // groupBoxInformacoes
            // 
            this.groupBoxInformacoes.Controls.Add(this.txtSaldo);
            this.groupBoxInformacoes.Controls.Add(this.lblSaldo);
            this.groupBoxInformacoes.Location = new System.Drawing.Point(283, 24);
            this.groupBoxInformacoes.Name = "groupBoxInformacoes";
            this.groupBoxInformacoes.Size = new System.Drawing.Size(241, 170);
            this.groupBoxInformacoes.TabIndex = 1;
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
            // CaixaDeBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 205);
            this.Controls.Add(this.groupBoxInformacoes);
            this.Controls.Add(this.groupBoxOperacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CaixaDeBanco";
            this.Text = "CaixaDeBanco";
            this.Load += new System.EventHandler(this.CaixaDeBanco_Load);
            this.groupBoxOperacao.ResumeLayout(false);
            this.groupBoxOperacao.PerformLayout();
            this.groupBoxInformacoes.ResumeLayout(false);
            this.groupBoxInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOperacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDeposito;
        private System.Windows.Forms.RadioButton radioButtonSaque;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.GroupBox groupBoxInformacoes;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
    }
}