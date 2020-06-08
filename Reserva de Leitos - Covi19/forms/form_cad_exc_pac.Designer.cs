namespace Reserva_de_Leitos___Covi19
{
    partial class form_cadastro_paciente
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
            this.edtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLocCidade = new System.Windows.Forms.Button();
            this.btnLocPaciente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.edtNomeCidade = new System.Windows.Forms.TextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.edtIdade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtIdade);
            this.groupBox1.Controls.Add(this.edtCPF);
            this.groupBox1.Controls.Add(this.btnLocCidade);
            this.groupBox1.Controls.Add(this.btnLocPaciente);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.edtNomeCidade);
            this.groupBox1.Controls.Add(this.edtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(531, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciamento do cadastro de pacientes";
            // 
            // edtCPF
            // 
            this.edtCPF.Location = new System.Drawing.Point(104, 70);
            this.edtCPF.Mask = "000.000.000-00";
            this.edtCPF.Name = "edtCPF";
            this.edtCPF.Size = new System.Drawing.Size(141, 26);
            this.edtCPF.TabIndex = 24;
            this.edtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnLocCidade
            // 
            this.btnLocCidade.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.lupa2;
            this.btnLocCidade.Location = new System.Drawing.Point(452, 163);
            this.btnLocCidade.Name = "btnLocCidade";
            this.btnLocCidade.Size = new System.Drawing.Size(25, 22);
            this.btnLocCidade.TabIndex = 23;
            this.btnLocCidade.UseVisualStyleBackColor = true;
            this.btnLocCidade.Click += new System.EventHandler(this.btnLocCidade_Click);
            // 
            // btnLocPaciente
            // 
            this.btnLocPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocPaciente.Location = new System.Drawing.Point(271, 72);
            this.btnLocPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocPaciente.Name = "btnLocPaciente";
            this.btnLocPaciente.Size = new System.Drawing.Size(57, 23);
            this.btnLocPaciente.TabIndex = 22;
            this.btnLocPaciente.Text = "buscar";
            this.btnLocPaciente.UseVisualStyleBackColor = true;
            this.btnLocPaciente.Click += new System.EventHandler(this.btnLocPaciente_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 62);
            this.button4.TabIndex = 20;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 204);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 62);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBox1.Location = new System.Drawing.Point(104, 101);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // edtNomeCidade
            // 
            this.edtNomeCidade.Location = new System.Drawing.Point(104, 161);
            this.edtNomeCidade.Margin = new System.Windows.Forms.Padding(2);
            this.edtNomeCidade.Name = "edtNomeCidade";
            this.edtNomeCidade.ReadOnly = true;
            this.edtNomeCidade.Size = new System.Drawing.Size(343, 26);
            this.edtNomeCidade.TabIndex = 5;
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(104, 41);
            this.edtNome.Margin = new System.Windows.Forms.Padding(2);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(373, 26);
            this.edtNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtIdade
            // 
            this.edtIdade.Location = new System.Drawing.Point(104, 132);
            this.edtIdade.Name = "edtIdade";
            this.edtIdade.Size = new System.Drawing.Size(74, 26);
            this.edtIdade.TabIndex = 25;
            // 
            // form_cadastro_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 302);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_cadastro_paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerencia de Paciente";
            this.Load += new System.EventHandler(this.form_cadastro_paciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox edtNomeCidade;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLocPaciente;
        private System.Windows.Forms.Button btnLocCidade;
        private System.Windows.Forms.MaskedTextBox edtCPF;
        private System.Windows.Forms.TextBox edtIdade;
    }
}

