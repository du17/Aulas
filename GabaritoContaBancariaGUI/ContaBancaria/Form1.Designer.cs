namespace ContaBancaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.rdbSaque = new System.Windows.Forms.RadioButton();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExecutar);
            this.groupBox1.Controls.Add(this.rdbDeposito);
            this.groupBox1.Controls.Add(this.rdbSaque);
            this.groupBox1.Controls.Add(this.txbValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(197, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operação";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(12, 84);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(172, 28);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(95, 55);
            this.rdbDeposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(83, 20);
            this.rdbDeposito.TabIndex = 3;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Depósito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // rdbSaque
            // 
            this.rdbSaque.AutoSize = true;
            this.rdbSaque.Checked = true;
            this.rdbSaque.Location = new System.Drawing.Point(12, 55);
            this.rdbSaque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSaque.Name = "rdbSaque";
            this.rdbSaque.Size = new System.Drawing.Size(68, 20);
            this.rdbSaque.TabIndex = 2;
            this.rdbSaque.TabStop = true;
            this.rdbSaque.Text = "Saque";
            this.rdbSaque.UseVisualStyleBackColor = true;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(61, 23);
            this.txbValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(121, 22);
            this.txbValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbSaldo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(221, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(197, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // txbSaldo
            // 
            this.txbSaldo.Enabled = false;
            this.txbSaldo.Location = new System.Drawing.Point(57, 54);
            this.txbSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(131, 22);
            this.txbSaldo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saldo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 146);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Caixa Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.RadioButton rdbSaque;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.Label label2;
    }
}

