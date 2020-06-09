namespace Reserva_de_Leitos___Covi19.forms
{
    partial class form_loc_paciente
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
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocPaciente = new System.Windows.Forms.Button();
            this.lbNOme = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaciente.Location = new System.Drawing.Point(0, 55);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.RowHeadersVisible = false;
            this.dgvPaciente.RowHeadersWidth = 50;
            this.dgvPaciente.Size = new System.Drawing.Size(423, 395);
            this.dgvPaciente.TabIndex = 4;
            this.dgvPaciente.DoubleClick += new System.EventHandler(this.dgvPaciente_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLocPaciente);
            this.panel1.Controls.Add(this.lbNOme);
            this.panel1.Controls.Add(this.edtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 55);
            this.panel1.TabIndex = 3;
            // 
            // btnLocPaciente
            // 
            this.btnLocPaciente.Image = global::Reserva_de_Leitos___Covi19.Properties.Resources.lupa2;
            this.btnLocPaciente.Location = new System.Drawing.Point(364, 21);
            this.btnLocPaciente.Name = "btnLocPaciente";
            this.btnLocPaciente.Size = new System.Drawing.Size(25, 22);
            this.btnLocPaciente.TabIndex = 5;
            this.btnLocPaciente.UseVisualStyleBackColor = true;
            this.btnLocPaciente.Click += new System.EventHandler(this.btnLocPaciente_Click);
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
            this.edtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtNome_KeyPress);
            // 
            // form_loc_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.panel1);
            this.Name = "form_loc_paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Paciente";
            this.Load += new System.EventHandler(this.form_loc_paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLocPaciente;
        private System.Windows.Forms.Label lbNOme;
        private System.Windows.Forms.TextBox edtNome;
    }
}