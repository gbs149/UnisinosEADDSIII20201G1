﻿namespace Reserva_de_Leitos___Covi19
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
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.edtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLocCidade = new System.Windows.Forms.Button();
            this.btnLocPaciente = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.edtNomeCidade = new System.Windows.Forms.TextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNascimento);
            this.groupBox1.Controls.Add(this.edtCPF);
            this.groupBox1.Controls.Add(this.btnLocCidade);
            this.groupBox1.Controls.Add(this.btnLocPaciente);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.cbGenero);
            this.groupBox1.Controls.Add(this.edtNomeCidade);
            this.groupBox1.Controls.Add(this.edtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCadastrar);
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
            // dtNascimento
            // 
            this.dtNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(155, 130);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(131, 26);
            this.dtNascimento.TabIndex = 4;
            // 
            // edtCPF
            // 
            this.edtCPF.Location = new System.Drawing.Point(104, 68);
            this.edtCPF.Mask = "000.000.000-00";
            this.edtCPF.Name = "edtCPF";
            this.edtCPF.Size = new System.Drawing.Size(182, 26);
            this.edtCPF.TabIndex = 2;
            this.edtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnLocCidade
            // 
            this.btnLocCidade.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.lupa2;
            this.btnLocCidade.Location = new System.Drawing.Point(452, 163);
            this.btnLocCidade.Name = "btnLocCidade";
            this.btnLocCidade.Size = new System.Drawing.Size(25, 22);
            this.btnLocCidade.TabIndex = 6;
            this.btnLocCidade.UseVisualStyleBackColor = true;
            this.btnLocCidade.Click += new System.EventHandler(this.btnLocCidade_Click);
            // 
            // btnLocPaciente
            // 
            this.btnLocPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocPaciente.Location = new System.Drawing.Point(292, 71);
            this.btnLocPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocPaciente.Name = "btnLocPaciente";
            this.btnLocPaciente.Size = new System.Drawing.Size(57, 23);
            this.btnLocPaciente.TabIndex = 22;
            this.btnLocPaciente.Text = "buscar";
            this.btnLocPaciente.UseVisualStyleBackColor = true;
            this.btnLocPaciente.Click += new System.EventHandler(this.btnLocPaciente_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(146, 204);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(107, 62);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(388, 204);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 62);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(267, 204);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 62);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.SystemColors.Window;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro",
            "Não Informado"});
            this.cbGenero.Location = new System.Drawing.Point(104, 99);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(182, 28);
            this.cbGenero.SelectedIndex = 0;
            this.cbGenero.TabIndex = 3;
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
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dt. Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gênero";
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
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(27, 204);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 62);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox edtNomeCidade;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLocPaciente;
        private System.Windows.Forms.Button btnLocCidade;
        private System.Windows.Forms.MaskedTextBox edtCPF;
        private System.Windows.Forms.DateTimePicker dtNascimento;
    }
}

