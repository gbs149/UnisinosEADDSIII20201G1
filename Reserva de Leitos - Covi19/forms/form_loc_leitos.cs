using ControleEquipamentos.Code.DAL;
using MySqlX.XDevAPI.Common;
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
    public partial class form_loc_leitos : Form
    {
        private dto_cad_paciente Paciente;
        private dto_cad_internacao Internacao;
        private dto_cad_cidade Cidade;
        private dto_cad_leito Leito;
        private DataTable DtHospitaisLeitos = new DataTable();

        private enum eTipoLeito { Normal = 'N', UTI = 'U'};
        
        private enum eMotivoLiberacao {Alta = 'A', Obito = 'O' };


        public form_loc_leitos()
        {
            InitializeComponent();
        }


        private void btnLocCPF_Click(object sender, EventArgs e)
        {
            LocalizarPaciente(edtCPF.Text);
        }


        private void btnLocCidade_Click(object sender, EventArgs e)
        {
            LocalizarCidade();
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Paciente == null)
            {
                MessageBox.Show("É necessário informar o Paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edtCPF.Focus();
                return;
            }

            if (Internacao != null)
                LiberarPaciente();
            else
                InternarPaciente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_loc_leitos_Load(object sender, EventArgs e)
        {
            ConfiguracoesIniciais();
        }

        private void dgvHospitaisLeitos_DataSourceChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = DtHospitaisLeitos.Rows.Count > 0;
        }

        #region Metodos e Funções

        #region Paciente
        private void LocalizarPaciente(string cpf)
        {
            dto_cad_paciente paciente = null;

            if (String.IsNullOrEmpty(cpf))
            {
                form_loc_paciente frmLocPaciente = new form_loc_paciente();
                frmLocPaciente.ShowDialog();
                if (frmLocPaciente.DialogResult == DialogResult.OK)
                {
                    paciente = frmLocPaciente.Paciente;
                    edtCPF.Text = paciente.CPF;
                }
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

            if (bll_cad_internacao.SelecionarObito(paciente))
            {
                MessageBox.Show("O paciente informado possui um óbito, o mesmo não pode ser carregado! Selecione outro paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparTela();
                edtCPF.Focus();
                return;
            }

            Paciente = paciente;

            CarregarInternacao();
            PreencherTela();
        }

        private void PreencherTela()
        {
            lbNome.Text = Paciente.Nome;

            if (Internacao == null)
            {
                Cidade = bll_cad_cidade.Selecionar(Paciente.Cidade);
                edtCidade.Text = Cidade.Nome;
                lbSituacao.Text = "Aguardando Leito";
                lbSituacao.ForeColor = Color.Blue;
                cbMotivoLiberacao.Visible = false;
                lbMotivoLiberacao.Visible = false;
                rbNormal.Checked = true;

                DtHospitaisLeitos = bll_cad_hospital.CarregarLeitosDisponiveis(Cidade.Codigo);
                dgvHospitaisLeitos.DataSource = DtHospitaisLeitos;
            }
            else
            {
                Cidade = bll_cad_cidade.Selecionar(Internacao.Cidade_Id);
                edtCidade.Text = Cidade.Nome;
                lbSituacao.Text = "Internado";
                lbSituacao.ForeColor = Color.Red;
                cbMotivoLiberacao.Visible = true;
                lbMotivoLiberacao.Visible = true;

                Leito = bll_cad_leitos.Selecionar(Internacao.Leito_Id);

                if (Leito.Tipo == 'N')
                    rbNormal.Checked = true;
                else
                    rbUTI.Checked = true;

                DtHospitaisLeitos = bll_cad_hospital.CarregarLeitoInternacao(Internacao.Leito_Id);
                dgvHospitaisLeitos.DataSource = DtHospitaisLeitos;
            }
        }

        private void LiberarPaciente()
        {
            var resultado = MessageBox.Show("Deseja liberar este paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int idHospital = Convert.ToInt32(dgvHospitaisLeitos.CurrentRow.Cells["Hospital_Id"].Value);
                if (!LiberarLeito(idHospital))
                {
                    MessageBox.Show("Não foi possível realizar a liberação do Leito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!AlterarInternacao())
                {
                    MessageBox.Show("Não foi possível registrar a internação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Paciente Liberado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparTela();
            }
        }

        private void InternarPaciente()
        {
            var resultado = MessageBox.Show("Deseja internar este paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int idHospital = Convert.ToInt32(dgvHospitaisLeitos.CurrentRow.Cells["Hospital_Id"].Value);
                if (!ReservarLeito(idHospital))
                {
                    MessageBox.Show("Não foi possível realizar a reserva do Leito! \nTente outro Tipo ou selecione outro Hospital.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IncluirInternacao())
                {
                    MessageBox.Show("Não foi possível registrar a internação!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Paciente Internado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparTela();
            }
        }
        #endregion

        #region Leito
        private bool ReservarLeito(int idHospital)
        {
            bool resultado = false;
            char tipoLeito = rbUTI.Checked ? Convert.ToChar(eTipoLeito.UTI) : Convert.ToChar(eTipoLeito.Normal);

            Leito = bll_cad_leitos.SelecionarLeitoDisponivel(tipoLeito, idHospital);

            if (Leito != null)
            {
                Leito.Situacao = 'O';
                resultado = bll_cad_leitos.Atualizar(Leito);
            }

            return resultado;
        }

        private bool LiberarLeito(int idHospital)
        {
            bool resultado = false;

            Leito = bll_cad_leitos.Selecionar(Internacao.Leito_Id);

            if (Leito != null)
            {
                Leito.Situacao = 'D';
                resultado = bll_cad_leitos.Atualizar(Leito);
            }

            return resultado;
        }

        #endregion

        #region Internacao
        private void CarregarInternacao()
        {
            if (Paciente != null)
                Internacao = bll_cad_internacao.SelecionarInternacaoPaciente(Paciente);
        }

        private bool IncluirInternacao()
        {
            bool resultado = false;

            if (Internacao == null)
            {
                Internacao = new dto_cad_internacao();
                Internacao.Data_Inicio = DateTime.Now;
                Internacao.Situacao = 'I';
                Internacao.Leito_Id = Leito.Id;
                Internacao.Paciente_Id = Paciente.Codigo;

                resultado = bll_cad_internacao.Incluir(Internacao);
            }

            return resultado;
        }

        private bool AlterarInternacao()
        {
            bool resultado = false;

            if (Internacao != null)
            {
                eMotivoLiberacao motivoLiberacao = (eMotivoLiberacao)cbMotivoLiberacao.SelectedItem;
                Internacao.Situacao = Convert.ToChar(motivoLiberacao);
                Internacao.Leito_Id = Leito.Id;
                Internacao.Paciente_Id = Paciente.Codigo;
                Internacao.Data_Fim = DateTime.Now;

                resultado = bll_cad_internacao.Alterar(Internacao);
            }

            return resultado;
        }
        #endregion

        #region Cidade
        private void LocalizarCidade()
        {
            if (Internacao != null)
            {
                MessageBox.Show("O Paciente já está internado, não será possível alterar a cidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            form_loc_cidades frmLocCidades = new form_loc_cidades();
            frmLocCidades.ShowDialog();
            if (frmLocCidades.DialogResult == DialogResult.OK)
            {
                Cidade = frmLocCidades.Cidade;
                edtCidade.Text = Cidade.Nome;
            }
            else
                return;

            DtHospitaisLeitos = bll_cad_hospital.CarregarLeitosDisponiveis(Cidade.Codigo);
            dgvHospitaisLeitos.DataSource = DtHospitaisLeitos;
        }

        #endregion

        #region Outros Métodos
        private void LimparTela()
        {
            edtCPF.Text = "";
            lbNome.Text = "";
            edtCidade.Text = "";
            lbSituacao.Text = "";
            rbNormal.Checked = true;
            rbUTI.Checked = false;
            Paciente = null;
            Cidade = null;
            Internacao = null;
            Leito = null;
            cbMotivoLiberacao.SelectedIndex = 0;
            cbMotivoLiberacao.Visible = false;
            lbMotivoLiberacao.Visible = false;
            btnConfirmar.Enabled = false;
            DtHospitaisLeitos.Rows.Clear();
        }

        private void ConfiguracoesIniciais()
        {
            #region Tabela de Hospitais / Leitos
            DtHospitaisLeitos.Columns.Add("Hospital", typeof(string));
            DtHospitaisLeitos.Columns.Add("LeitosNormais", typeof(int));
            DtHospitaisLeitos.Columns.Add("LeitosUTI", typeof(int));
            DtHospitaisLeitos.Columns.Add("Hospital_Id", typeof(int));
            DtHospitaisLeitos.Columns.Add("CNPJ", typeof(string));
            #endregion

            #region DataGrid dos Hospitais / Leitos
            dgvHospitaisLeitos.DataSource = DtHospitaisLeitos;

            dgvHospitaisLeitos.Columns["Hospital"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHospitaisLeitos.Columns["LeitosNormais"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHospitaisLeitos.Columns["LeitosUTI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvHospitaisLeitos.Columns["LeitosNormais"].HeaderText = "Qtd. Leitos Normais";
            dgvHospitaisLeitos.Columns["LeitosUTI"].HeaderText = "Qtd. Leitos UTI";

            dgvHospitaisLeitos.Columns["Hospital_Id"].Visible = false;
            dgvHospitaisLeitos.Columns["CNPJ"].Visible = false;
            #endregion

            #region Outros componentes
            btnConfirmar.Enabled = false;
            rbUTI.Checked = false;
            rbNormal.Checked = true;
            cbMotivoLiberacao.DataSource = Enum.GetValues(typeof(eMotivoLiberacao));
            cbMotivoLiberacao.SelectedItem = eMotivoLiberacao.Alta; 
            #endregion

        }
        #endregion

        #endregion

    }
}
