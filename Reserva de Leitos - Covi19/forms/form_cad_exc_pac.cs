using Reserva_de_Leitos___Covi19.classes.bll;
using Reserva_de_Leitos___Covi19.classes.dto;
using Reserva_de_Leitos___Covi19.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_de_Leitos___Covi19
{
    public partial class form_cadastro_paciente : Form
    {
        dto_cad_paciente paciente = new dto_cad_paciente();

        private int CodigoCidade { get; set; }

        public form_cadastro_paciente()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_cadastro_paciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPaciente();
            var resultado = bll_cad_paciente.Incluir(paciente);

            if (resultado == false) return;
            LimparTela();
        }

        private void LimparTela()
        {
            edtNome.Text = "";
            edtCPF.Text = "";
            edtIdade.Text = "";
            CodigoCidade = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_msn4 form_msn4 = new form_msn4();
            form_msn4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_msn5 form_Msn5 = new form_msn5();
            form_Msn5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLocCidade_Click(object sender, EventArgs e)
        {
            form_loc_cidades frmLocCidades = new form_loc_cidades();
            frmLocCidades.ShowDialog();
            if (frmLocCidades.DialogResult == DialogResult.OK)
            {
                CodigoCidade = frmLocCidades.Codigo;
                edtNomeCidade.Text = frmLocCidades.Nome;
            }
        }

        private void CadastrarPaciente()
        {
            paciente.Nome = edtNome.Text;
            paciente.CPF = edtCPF.Text;
            paciente.Idade = 20;//dtNascimento.Value.Date;
            paciente.Sexo = "Masculino";
            paciente.Cidade = 397;
        }

        private void ValidarDados()
        {
            if (edtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Paciente não pode ficar com o nome em branco!");
                edtNome.Focus();
                return;
            }
        }

        private void btnLocPaciente_Click(object sender, EventArgs e)
        {
            paciente = bll_cad_paciente.Selecionar(edtCPF.Text);

            if (paciente != null)
            {
                edtNome.Text = paciente.Nome;
            }
        }
    }


}
