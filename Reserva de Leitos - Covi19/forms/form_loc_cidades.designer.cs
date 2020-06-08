namespace Reserva_de_Leitos___Covi19.forms
{
    partial class form_loc_cidades
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
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocCidade = new System.Windows.Forms.Button();
            this.lbNOme = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCidades
            // 
            this.dgvCidades.AllowUserToAddRows = false;
            this.dgvCidades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCidades.Location = new System.Drawing.Point(0, 55);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.RowHeadersWidth = 50;
            this.dgvCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCidades.Size = new System.Drawing.Size(423, 395);
            this.dgvCidades.TabIndex = 4;
            this.dgvCidades.DoubleClick += new System.EventHandler(this.dgvCidades_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLocCidade);
            this.panel1.Controls.Add(this.lbNOme);
            this.panel1.Controls.Add(this.edtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 55);
            this.panel1.TabIndex = 3;
            // 
            // btnLocCidade
            // 
            this.btnLocCidade.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.lupa2;
            this.btnLocCidade.Location = new System.Drawing.Point(364, 21);
            this.btnLocCidade.Name = "btnLocCidade";
            this.btnLocCidade.Size = new System.Drawing.Size(25, 22);
            this.btnLocCidade.TabIndex = 5;
            this.btnLocCidade.UseVisualStyleBackColor = true;
            this.btnLocCidade.Click += new System.EventHandler(this.btnLocCidade_Click);
            // 
            // lbNOme
            // 
            this.lbNOme.AutoSize = true;
            this.lbNOme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNOme.Location = new System.Drawing.Point(12, 25);
            this.lbNOme.Name = "lbNOme";
            this.lbNOme.Size = new System.Drawing.Size(39, 13);
            this.lbNOme.TabIndex = 4;
            this.lbNOme.Text = "Nome";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(57, 22);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(304, 20);
            this.edtNome.TabIndex = 3;
            // 
            // form_loc_cidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.panel1);
            this.Name = "form_loc_cidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Cidade";
            this.Load += new System.EventHandler(this.form_loc_cidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLocCidade;
        private System.Windows.Forms.Label lbNOme;
        private System.Windows.Forms.TextBox edtNome;
    }
}