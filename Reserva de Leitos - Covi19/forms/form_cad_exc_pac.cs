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
        dto_cad_paciente Paciente = new dto_cad_paciente();
        dto_cad_cidade Cidade = new dto_cad_cidade();

        private int CodigoCidade { get; set; }

        public form_cadastro_paciente()
        {
            InitializeComponent();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarCadPaciente();
            var resultado = bll_cad_paciente.Incluir(Paciente);

            if (resultado == false) return;


            LimparTela();
        }

        private void LimparTela()
        {
            edtNome.Text = "";
            edtCPF.Text = "";
            cbGenero.Text = "";
            dtNascimento.Value = DateTime.Now.Date;
            edtNomeCidade.Text = "";
            Paciente = new dto_cad_paciente();
            Cidade = new dto_cad_cidade();
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
                Cidade = frmLocCidades.Cidade;
                edtNomeCidade.Text = Cidade.Nome;
            }
        }

        private void AtualizarCadPaciente()
        {
            Paciente.Nome = edtNome.Text;
            Paciente.CPF = edtCPF.Text;
            Paciente.DataNascimento = dtNascimento.Value.Date;
            Paciente.Genero = Convert.ToChar(cbGenero.Text.Substring(0,1));
            Paciente.Cidade = Cidade.Codigo;
        }

        private void ValidarDados()
        {
            if (edtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Paciente não pode ficar com o nome em branco!");
                edtNome.Focus();
                return;
            }

            if (edtCPF.Text.Trim() == "")
            {
                MessageBox.Show("O Paciente não pode ficar com o CPF em branco!");
                edtCPF.Focus();
                return;
            }

            if (edtNomeCidade.Text.Trim() == "")
            {
                MessageBox.Show("O Paciente não pode ficar com a Cidade em branco!");
                edtNomeCidade.Focus();
                return;
            }
        }

        private void btnLocPaciente_Click(object sender, EventArgs e)
        {
            Paciente = bll_cad_paciente.Selecionar(edtCPF.Text);

            if (Paciente != null)
            {
                edtNome.Text = Paciente.Nome;
                edtCPF.Text  = Paciente.CPF;

                switch (Paciente.Genero)
                {
                    case 'M': cbGenero.Text = "Masculino"; break;
                    case 'F': cbGenero.Text = "Feminino"; break;
                    case 'O': cbGenero.Text = "Outros"; break;
                    case 'N': cbGenero.Text = "Não Informado"; break;
                    default:  cbGenero.Text = "Masculino"; break;
                }

                dtNascimento.Value = Paciente.DataNascimento;
                Cidade = bll_cad_cidade.Selecionar(Paciente.Cidade);
                edtNomeCidade.Text = Cidade.Nome;
            }
        }

    }


}
