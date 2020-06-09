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
        dto_cad_paciente Paciente;
        dto_cad_cidade Cidade;

        private int CodigoCidade { get; set; }

        public form_cadastro_paciente()
        {
            InitializeComponent();
        }

        private void btnLocPaciente_Click(object sender, EventArgs e)
        {
            LocalizarPaciente(edtCPF.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPaciente();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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
            LocalizarCidade();
        }


        #region Métodos do Formulário

        private void CadastrarPaciente()
        {
            if (ValidarDados() == false)
                return;

            AtualizarDadosPaciente();

            bool resultado = bll_cad_paciente.Incluir(Paciente);
            if (resultado == false)
            {
                MessageBox.Show("Não foi possível incluir o paciente. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Cadastro Realizado!");
            LimparTela();
        }

        private void LocalizarPaciente(string cpf)
        {
            dto_cad_paciente paciente = null;
            if (String.IsNullOrEmpty(cpf))
            {
                form_loc_paciente frmLocPaciente = new form_loc_paciente();
                frmLocPaciente.ShowDialog();
                if (frmLocPaciente.DialogResult == DialogResult.OK)
                    paciente = frmLocPaciente.Paciente;
                else
                    return;
            }
            else
                paciente = bll_cad_paciente.Selecionar(cpf);

            if (paciente == null)
            {
                MessageBox.Show("Não foi Possível Localizar o Paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                edtNome.Text = paciente.Nome;
                edtCPF.Text = paciente.CPF;

                switch (paciente.Genero)
                {
                    case 'M': cbGenero.SelectedIndex = 0; break;
                    case 'F': cbGenero.SelectedIndex = 1; break;
                    case 'O': cbGenero.SelectedIndex = 2; break;
                    case 'N': cbGenero.SelectedIndex = 3; break;
                    default: cbGenero.SelectedIndex = 0; break;
                }

                dtNascimento.Value = paciente.DataNascimento;
                Cidade = bll_cad_cidade.Selecionar(paciente.Cidade);
                edtNomeCidade.Text = Cidade.Nome;
            }
        }

        private void AtualizarDadosPaciente()
        {
            Paciente = new dto_cad_paciente();
            Paciente.Nome = edtNome.Text;
            Paciente.CPF = edtCPF.Text;
            Paciente.DataNascimento = dtNascimento.Value.Date;
            Paciente.Genero = Convert.ToChar(cbGenero.Text.Substring(0, 1));
            Paciente.Cidade = Cidade.Codigo;
        }

        private void LocalizarCidade()
        {
            form_loc_cidades frmLocCidades = new form_loc_cidades();
            frmLocCidades.ShowDialog();
            if (frmLocCidades.DialogResult == DialogResult.OK)
            {
                Cidade = frmLocCidades.Cidade;
                edtNomeCidade.Text = Cidade.Nome;
            }
        }

        private void LimparTela()
        {
            edtNome.Text = "";
            edtCPF.Text = "";
            cbGenero.Text = "";
            dtNascimento.Value = DateTime.Now.Date;
            edtNomeCidade.Text = "";
            Paciente = null;
            Cidade = null;
        }


        private bool ValidarDados()
        {
            if (edtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Paciente não pode ficar com o nome em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtNome.Focus();
                return false;
            }

            if (edtCPF.Text.Trim() == "" || edtCPF.Text.Length < 11)
            {
                MessageBox.Show("O CPF do Paciente está incorreto. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtCPF.Focus();
                return false;
            }

            if (edtNomeCidade.Text.Trim() == "")
            {
                MessageBox.Show("O Paciente não pode ficar com a Cidade em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtNomeCidade.Focus();
                return false;
            }

            return true;
        }

        
        #endregion
    }
}
