using ControleEquipamentos.Code.DAL;
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
        private AcessoBancoDados AcessoBanco;
        private DataTable DtHospitais { get; set; }


        public form_loc_leitos()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLocCPF_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edtCPF.Text))
            {
                form_loc_paciente frmLocPaciente = new form_loc_paciente();
                frmLocPaciente.ShowDialog();
            }

            CarregarPaciente(edtCPF.Text);
            CarregarHospitais(lbCidade.Text);
        }

        private void btnLocCidade_Click(object sender, EventArgs e)
        {
            form_loc_cidades frmLocCidades = new form_loc_cidades();
            frmLocCidades.ShowDialog();
            if (frmLocCidades.DialogResult == DialogResult.OK)
            {
                edtCidade.Text = frmLocCidades.Codigo.ToString();
                if (CarregarCidade(edtCidade.Text))
                {
                    CarregarHospitais(lbCidade.Text);
                }
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_loc_leitos_Load(object sender, EventArgs e)
        {
            AcessoBanco = new AcessoBancoDados();
            AcessoBanco.conectar();
        }


        private void CarregarPaciente(string cpf)
        {
            string comando = $@"Select p.nome, p.cpf, p.cidade, p.CodigoCidade, c.Nome NomeCidade from paciente p
                                  left join cidade c on c.nome = p.Cidade
                                 where p.cpf = '{cpf}'";


            using (var DtPaciente = AcessoBanco.RetDataTable(comando))
            {
                foreach (DataRow linha in DtPaciente.Rows)
                {
                    lbNome.Text = linha["nome"].ToString();
                    edtCidade.Text = linha["CodigoCidade"].ToString();
                    lbCidade.Text = linha["NomeCidade"].ToString();
                    break;
                }
            }
        }

        private bool CarregarCidade(string codCidade)
        {
            if (codCidade == "" || Convert.ToInt32(codCidade) == 0) return false;

            bool resultado = false;

            string comando = $@"Select c.nome, c.codigo from cidade c
                                 where c.codigo = {codCidade}";

            try
            {
                using (var DtCidade = AcessoBanco.RetDataTable(comando))
                {
                    foreach (DataRow linha in DtCidade.Rows)
                    {
                        lbCidade.Text = linha["nome"].ToString();
                        break;
                    }

                    if (DtCidade.Rows.Count > 0)
                        resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        private void CarregarHospitais(string cidade)
        {
            string comando = $"Select Nome, LeitosDisponiveis from hospital where cidade = '{cidade}'";
            DataTable dt = AcessoBanco.RetDataTable(comando);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Nome"].FillWeight = 100;
            dataGridView1.Columns["LeitosDisponiveis"].FillWeight = 75;
            dataGridView1.Columns["LeitosDisponiveis"].Width = 120;
        }
    }
}
