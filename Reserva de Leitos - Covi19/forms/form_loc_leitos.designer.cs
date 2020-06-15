namespace Reserva_de_Leitos___Covi19.forms
{
    partial class form_loc_leitos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMotivoLiberacao = new System.Windows.Forms.Label();
            this.cbMotivoLiberacao = new System.Windows.Forms.ComboBox();
            this.lbSituacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnLocCPF = new System.Windows.Forms.Button();
            this.btnLocCidade = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.edtCidade = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.edtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dgvHospitaisLeitos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbUTI = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitaisLeitos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUTI);
            this.panel1.Controls.Add(this.rbNormal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbMotivoLiberacao);
            this.panel1.Controls.Add(this.cbMotivoLiberacao);
            this.panel1.Controls.Add(this.lbSituacao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.btnLocCPF);
            this.panel1.Controls.Add(this.btnLocCidade);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.edtCidade);
            this.panel1.Controls.Add(this.lbCPF);
            this.panel1.Controls.Add(this.edtCPF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 82);
            this.panel1.TabIndex = 1;
            // 
            // lbMotivoLiberacao
            // 
            this.lbMotivoLiberacao.AutoSize = true;
            this.lbMotivoLiberacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotivoLiberacao.Location = new System.Drawing.Point(261, 51);
            this.lbMotivoLiberacao.Name = "lbMotivoLiberacao";
            this.lbMotivoLiberacao.Size = new System.Drawing.Size(123, 13);
            this.lbMotivoLiberacao.TabIndex = 13;
            this.lbMotivoLiberacao.Text = "Motivo da Liberação";
            this.lbMotivoLiberacao.Visible = false;
            // 
            // cbMotivoLiberacao
            // 
            this.cbMotivoLiberacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivoLiberacao.FormattingEnabled = true;
            this.cbMotivoLiberacao.Location = new System.Drawing.Point(390, 48);
            this.cbMotivoLiberacao.Name = "cbMotivoLiberacao";
            this.cbMotivoLiberacao.Size = new System.Drawing.Size(153, 21);
            this.cbMotivoLiberacao.TabIndex = 12;
            this.cbMotivoLiberacao.Visible = false;
            // 
            // lbSituacao
            // 
            this.lbSituacao.AutoSize = true;
            this.lbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacao.Location = new System.Drawing.Point(127, 51);
            this.lbSituacao.Name = "lbSituacao";
            this.lbSituacao.Size = new System.Drawing.Size(0, 13);
            this.lbSituacao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Situacao";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNome.Location = new System.Drawing.Point(261, 24);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(19, 13);
            this.lbNome.TabIndex = 8;
            this.lbNome.Text = "   ";
            // 
            // btnLocCPF
            // 
            this.btnLocCPF.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.lupa2;
            this.btnLocCPF.Location = new System.Drawing.Point(230, 20);
            this.btnLocCPF.Name = "btnLocCPF";
            this.btnLocCPF.Size = new System.Drawing.Size(25, 22);
            this.btnLocCPF.TabIndex = 6;
            this.btnLocCPF.UseVisualStyleBackColor = true;
            this.btnLocCPF.Click += new System.EventHandler(this.btnLocCPF_Click);
            // 
            // btnLocCidade
            // 
            this.btnLocCidade.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.lupa2;
            this.btnLocCidade.Location = new System.Drawing.Point(851, 21);
            this.btnLocCidade.Name = "btnLocCidade";
            this.btnLocCidade.Size = new System.Drawing.Size(25, 22);
            this.btnLocCidade.TabIndex = 5;
            this.btnLocCidade.UseVisualStyleBackColor = true;
            this.btnLocCidade.Click += new System.EventHandler(this.btnLocCidade_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(568, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Cidade";
            // 
            // edtCidade
            // 
            this.edtCidade.Location = new System.Drawing.Point(615, 22);
            this.edtCidade.Name = "edtCidade";
            this.edtCidade.ReadOnly = true;
            this.edtCidade.Size = new System.Drawing.Size(235, 20);
            this.edtCidade.TabIndex = 3;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(22, 25);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(102, 13);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF do Paciente";
            // 
            // edtCPF
            // 
            this.edtCPF.Location = new System.Drawing.Point(130, 21);
            this.edtCPF.Mask = "000.000.000-00";
            this.edtCPF.Name = "edtCPF";
            this.edtCPF.Size = new System.Drawing.Size(100, 20);
            this.edtCPF.TabIndex = 1;
            this.edtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dgvHospitaisLeitos
            // 
            this.dgvHospitaisLeitos.AllowUserToAddRows = false;
            this.dgvHospitaisLeitos.AllowUserToResizeRows = false;
            this.dgvHospitaisLeitos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHospitaisLeitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitaisLeitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospitaisLeitos.Location = new System.Drawing.Point(0, 82);
            this.dgvHospitaisLeitos.Name = "dgvHospitaisLeitos";
            this.dgvHospitaisLeitos.ReadOnly = true;
            this.dgvHospitaisLeitos.RowHeadersVisible = false;
            this.dgvHospitaisLeitos.RowHeadersWidth = 50;
            this.dgvHospitaisLeitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitaisLeitos.Size = new System.Drawing.Size(896, 398);
            this.dgvHospitaisLeitos.TabIndex = 2;
            this.dgvHospitaisLeitos.DataSourceChanged += new System.EventHandler(this.dgvHospitaisLeitos_DataSourceChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 61);
            this.panel2.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.cancel2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(780, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.OK_Ico;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(660, 11);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(114, 38);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo do Leito";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(673, 49);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 15;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbUTI
            // 
            this.rbUTI.AutoSize = true;
            this.rbUTI.Location = new System.Drawing.Point(762, 49);
            this.rbUTI.Name = "rbUTI";
            this.rbUTI.Size = new System.Drawing.Size(43, 17);
            this.rbUTI.TabIndex = 16;
            this.rbUTI.TabStop = true;
            this.rbUTI.Text = "UTI";
            this.rbUTI.UseVisualStyleBackColor = true;
            // 
            // form_loc_leitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvHospitaisLeitos);
            this.Controls.Add(this.panel1);
            this.Name = "form_loc_leitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração de Leitos";
            this.Load += new System.EventHandler(this.form_loc_leitos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitaisLeitos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHospitaisLeitos;
        private System.Windows.Forms.Button btnLocCPF;
        private System.Windows.Forms.Button btnLocCidade;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox edtCidade;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.MaskedTextBox edtCPF;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMotivoLiberacao;
        private System.Windows.Forms.ComboBox cbMotivoLiberacao;
        private System.Windows.Forms.RadioButton rbUTI;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label label2;
    }
}

