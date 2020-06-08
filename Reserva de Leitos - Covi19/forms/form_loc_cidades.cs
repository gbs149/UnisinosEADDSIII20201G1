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
    public partial class form_loc_cidades : Form
    {
        public int Codigo { get; private set; }
        public String Nome { get; private set; }

        private AcessoBancoDados AcessoBanco;
        private DataTable DtCidades;

        public form_loc_cidades()
        {
            InitializeComponent();
        }

        private void form_loc_cidades_Load(object sender, EventArgs e)
        {
            AcessoBanco = new AcessoBancoDados();
            AcessoBanco.conectar();
            CarregarCidades();
            dgvCidades.DataSource = DtCidades;
        }

        private bool CarregarCidades()
        {
            bool resultado = false;
            String sql = $@"Select Codigo, Nome, UF From Cidade";
            DtCidades = AcessoBanco.RetDataTable(sql);
            DtCidades.CaseSensitive = false;

            if (DtCidades.Rows.Count > 0) 
                resultado = true;

            return resultado;
        }

        private void btnLocCidade_Click(object sender, EventArgs e)
        {
            LocalizarCidade(edtNome.Text);
        }

        private void LocalizarCidade(string cidade)
        {
            if (DtCidades != null) 
            {
                if (!String.IsNullOrEmpty(cidade.Trim()))
                    DtCidades.DefaultView.RowFilter = $"Nome Like '%{cidade.Trim()}%'";
                else
                    DtCidades.DefaultView.RowFilter = "";
            }
        }

        private void dgvCidades_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCidades.Rows.Count > 0)
            {
                Codigo = Convert.ToInt32(dgvCidades.CurrentRow.Cells["Codigo"].Value);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
