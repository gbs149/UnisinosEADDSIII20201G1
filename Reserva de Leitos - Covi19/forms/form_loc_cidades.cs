using ControleEquipamentos.Code.DAL;
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
    public partial class form_loc_cidades : Form
    {
        public dto_cad_cidade Cidade = new dto_cad_cidade();
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
            DtCidades = bll_cad_cidade.CarregarCidades(); 
            dgvCidades.DataSource = DtCidades;
        }

        //private bool CarregarCidades()
        //{
        //    bool resultado = false;
        //    String sql = $@"Select Codigo, Nome, UF From Cidade";
        //    DtCidades = AcessoBanco.RetDataTable(sql);
        //    DtCidades.CaseSensitive = false;

        //    if (DtCidades.Rows.Count > 0) 
        //        resultado = true;

        //    return resultado;
        //}

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
                int codigo = Convert.ToInt32(dgvCidades.CurrentRow.Cells["Codigo"].Value);
                Cidade = bll_cad_cidade.Selecionar(codigo);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
