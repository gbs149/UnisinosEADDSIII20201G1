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
            this.lbCidade = new System.Windows.Forms.Label();
            this.btnLocCPF = new System.Windows.Forms.Button();
            this.btnLocCidade = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.edtCidade = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.edtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.lbCidade);
            this.panel1.Controls.Add(this.btnLocCPF);
            this.panel1.Controls.Add(this.btnLocCidade);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.edtCidade);
            this.panel1.Controls.Add(this.lbCPF);
            this.panel1.Controls.Add(this.edtCPF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 60);
            this.panel1.TabIndex = 1;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCidade.Location = new System.Drawing.Point(707, 25);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(0, 13);
            this.lbCidade.TabIndex = 7;
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
            this.btnLocCidade.Location = new System.Drawing.Point(676, 20);
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
            this.label.Location = new System.Drawing.Point(574, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Cidade";
            // 
            // edtCidade
            // 
            this.edtCidade.Location = new System.Drawing.Point(620, 21);
            this.edtCidade.Name = "edtCidade";
            this.edtCidade.Size = new System.Drawing.Size(55, 20);
            this.edtCidade.TabIndex = 3;
            this.edtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(896, 420);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 63);
            this.panel2.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.cancel2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(780, 13);
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
            this.btnConfirmar.Location = new System.Drawing.Point(660, 13);
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
            // form_loc_leitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "form_loc_leitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração de Leitos";
            this.Load += new System.EventHandler(this.form_loc_leitos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label lbCidade;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label lbNome;
    }
}

