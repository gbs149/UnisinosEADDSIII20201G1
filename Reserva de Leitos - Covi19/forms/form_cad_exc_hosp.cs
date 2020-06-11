using Reserva_de_Leitos___Covi19.classes.bll;
using Reserva_de_Leitos___Covi19.classes.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_de_Leitos___Covi19.forms
{
    public partial class form_cad_exc_hosp : Form
    {
        dto_cad_hospital Hospital;
        dto_cad_cidade Cidade;

        public form_cad_exc_hosp()
        {
            InitializeComponent();
        }


        private void btnLochospital_Click(object sender, EventArgs e)
        {
            Localizarhospital(edtCNPJ.Text);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrarhospital();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterarhospital();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluirhospital();

        }

        private void btnLocCidade_Click(object sender, EventArgs e)
        {
            LocalizarCidade();
        }


        #region Métodos do Formulário
        private void Excluirhospital()
        {

        }

        private void Alterarhospital()
        {

        }

        private void Cadastrarhospital()
        {
            if (ValidarDados() == false)
                return;

            var hospital = bll_cad_hospital.Selecionar(edtCNPJ.Text);
            if (hospital != null)
            {
                MessageBox.Show("Já existe um hospital com este CNPJ. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtualizarDadoshospital();

            bool resultado = bll_cad_hospital.Incluir(Hospital);
            if (resultado == false)
            {
                MessageBox.Show("Não foi possível incluir o hospital. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!",
                "Confirmação de Inclusão", MessageBoxButtons.OK);
                LimparTela();
            }

        }

        private void Localizarhospital(string CNPJ)
        {
            dto_cad_hospital hospital = null;
            if (String.IsNullOrEmpty(CNPJ))
            {
                form_loc_hospital frmLochospital = new form_loc_hospital();
                frmLochospital.ShowDialog();
                if (frmLochospital.DialogResult == DialogResult.OK)
                    hospital = frmLochospital.hospital;
                else
                    return;
            }
            else
                hospital = bll_cad_hospital.Selecionar(CNPJ);

            if (hospital == null)
            {
                MessageBox.Show("Não foi Possível Localizar o hospital!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                edtNome.Text = hospital.Nome;
                edtCNPJ.Text = hospital.CNPJ;
                Cidade = bll_cad_cidade.Selecionar(hospital.Cidade);
                edtNomeCidade.Text = Cidade.Nome;
                Hospital = hospital;
            }
        }

        private void AtualizarDadoshospital()
        {
            if (Hospital == null)
                Hospital = new dto_cad_hospital();

            Hospital.Nome = edtNome.Text;
            Hospital.CNPJ = edtCNPJ.Text;
            Hospital.Cidade = Cidade.Codigo;
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
            edtCNPJ.Text = "";
            edtNomeCidade.Text = "";
            Hospital = null;
            Cidade = null;
        }


        private bool ValidarDados()
        {
            if (edtNome.Text.Trim() == "")
            {
                MessageBox.Show("O hospital não pode ficar com o nome em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtNome.Focus();
                return false;
            }

            if (edtCNPJ.Text.Trim() == "" || edtCNPJ.Text.Length < 14)
            {
                MessageBox.Show("O CNPJ do hospital está incorreto. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtCNPJ.Focus();
                return false;
            }

            if (edtNomeCidade.Text.Trim() == "")
            {
                MessageBox.Show("O hospital não pode ficar com a Cidade em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtNomeCidade.Focus();
                return false;
            }

            return true;
        }
        #endregion
    }
}
