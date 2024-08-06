namespace WindowsFormsExercicio1
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
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.gbrgastos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.txtAlimentacao = new System.Windows.Forms.TextBox();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.totaldegastos = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.gbrgastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(384, 31);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(100, 20);
            this.txtRenda.TabIndex = 0;
            // 
            // gbrgastos
            // 
            this.gbrgastos.Controls.Add(this.label7);
            this.gbrgastos.Controls.Add(this.label6);
            this.gbrgastos.Controls.Add(this.label5);
            this.gbrgastos.Controls.Add(this.label4);
            this.gbrgastos.Controls.Add(this.label3);
            this.gbrgastos.Controls.Add(this.txtOutros);
            this.gbrgastos.Controls.Add(this.txtAlimentacao);
            this.gbrgastos.Controls.Add(this.txtTV);
            this.gbrgastos.Controls.Add(this.txtAgua);
            this.gbrgastos.Controls.Add(this.txtEnergia);
            this.gbrgastos.Location = new System.Drawing.Point(160, 71);
            this.gbrgastos.Name = "gbrgastos";
            this.gbrgastos.Size = new System.Drawing.Size(450, 229);
            this.gbrgastos.TabIndex = 1;
            this.gbrgastos.TabStop = false;
            this.gbrgastos.Text = "Gastos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Outro gasto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alimentação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TV/ Fone/ Internet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Água";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Energia Elétrica";
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(329, 192);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(100, 20);
            this.txtOutros.TabIndex = 4;
            // 
            // txtAlimentacao
            // 
            this.txtAlimentacao.Location = new System.Drawing.Point(329, 154);
            this.txtAlimentacao.Name = "txtAlimentacao";
            this.txtAlimentacao.Size = new System.Drawing.Size(100, 20);
            this.txtAlimentacao.TabIndex = 3;
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(329, 112);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(100, 20);
            this.txtTV.TabIndex = 2;
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(329, 70);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(100, 20);
            this.txtAgua.TabIndex = 1;
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(329, 30);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(100, 20);
            this.txtEnergia.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(202, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(362, 318);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Novo Cálculo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(502, 318);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // totaldegastos
            // 
            this.totaldegastos.AutoSize = true;
            this.totaldegastos.Location = new System.Drawing.Point(199, 362);
            this.totaldegastos.Name = "totaldegastos";
            this.totaldegastos.Size = new System.Drawing.Size(90, 13);
            this.totaldegastos.TabIndex = 5;
            this.totaldegastos.Text = "Total dos Gastos:";
            this.totaldegastos.Click += new System.EventHandler(this.totaldegastos_Click);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(228, 393);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(37, 13);
            this.saldo.TabIndex = 6;
            this.saldo.Text = "Saldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Renda Familiar:";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Location = new System.Drawing.Point(330, 362);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(0, 13);
            this.lblGastos.TabIndex = 8;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(333, 393);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.totaldegastos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbrgastos);
            this.Controls.Add(this.txtRenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbrgastos.ResumeLayout(false);
            this.gbrgastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.GroupBox gbrgastos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.TextBox txtAlimentacao;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label totaldegastos;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblSaldo;
    }
}

