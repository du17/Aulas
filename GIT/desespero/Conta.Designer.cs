
namespace GIT.desespero
{
    partial class Conta
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
            this.Operação = new System.Windows.Forms.GroupBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rbDeposito = new System.Windows.Forms.RadioButton();
            this.rbSaque = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.info = new System.Windows.Forms.GroupBox();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.lblSaque = new System.Windows.Forms.Label();
            this.Operação.SuspendLayout();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Operação
            // 
            this.Operação.Controls.Add(this.btnExecutar);
            this.Operação.Controls.Add(this.rbDeposito);
            this.Operação.Controls.Add(this.rbSaque);
            this.Operação.Controls.Add(this.txtValor);
            this.Operação.Controls.Add(this.lblValor);
            this.Operação.Location = new System.Drawing.Point(26, 12);
            this.Operação.Name = "Operação";
            this.Operação.Size = new System.Drawing.Size(226, 193);
            this.Operação.TabIndex = 0;
            this.Operação.TabStop = false;
            this.Operação.Text = "Operação";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(27, 142);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(155, 30);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rbDeposito
            // 
            this.rbDeposito.AutoSize = true;
            this.rbDeposito.Location = new System.Drawing.Point(126, 91);
            this.rbDeposito.Name = "rbDeposito";
            this.rbDeposito.Size = new System.Drawing.Size(67, 17);
            this.rbDeposito.TabIndex = 1;
            this.rbDeposito.TabStop = true;
            this.rbDeposito.Text = "Deposito";
            this.rbDeposito.UseVisualStyleBackColor = true;
            // 
            // rbSaque
            // 
            this.rbSaque.AutoSize = true;
            this.rbSaque.Location = new System.Drawing.Point(27, 91);
            this.rbSaque.Name = "rbSaque";
            this.rbSaque.Size = new System.Drawing.Size(56, 17);
            this.rbSaque.TabIndex = 0;
            this.rbSaque.TabStop = true;
            this.rbSaque.Text = "Saque";
            this.rbSaque.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(67, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(24, 42);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor :";
            // 
            // info
            // 
            this.info.Controls.Add(this.txtSaque);
            this.info.Controls.Add(this.lblSaque);
            this.info.Location = new System.Drawing.Point(281, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(226, 193);
            this.info.TabIndex = 1;
            this.info.TabStop = false;
            this.info.Text = "Informações";
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(78, 90);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(115, 20);
            this.txtSaque.TabIndex = 2;
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Location = new System.Drawing.Point(25, 95);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(47, 13);
            this.lblSaque.TabIndex = 2;
            this.lblSaque.Text = "Saque : ";
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 228);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Operação);
            this.Name = "Conta";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Conta_Load);
            this.Operação.ResumeLayout(false);
            this.Operação.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Operação;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rbDeposito;
        private System.Windows.Forms.RadioButton rbSaque;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label lblSaque;
    }
}