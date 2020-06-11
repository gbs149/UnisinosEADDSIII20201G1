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
    public partial class form_loc_hospital : Form
    {
        public dto_cad_hospital hospital = new dto_cad_hospital();
        private DataTable Dthospitais;
        public form_loc_hospital()
        {
            InitializeComponent();
        }

        private void Localizarhospital(string nomehospital)
        {
            if (Dthospitais != null)
            {
                if (!String.IsNullOrEmpty(nomehospital.Trim()))
                    Dthospitais.DefaultView.RowFilter = $"Nome Like '%{nomehospital.Trim()}%'";
                else
                    Dthospitais.DefaultView.RowFilter = "";
            }
        }

        private void dgvhospital_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHospital.Rows.Count > 0)
            {
                string cnpj = dgvHospital.CurrentRow.Cells["CNPJ"].Value.ToString();
                hospital = bll_cad_hospital.Selecionar(cnpj);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnLochospital_Click(object sender, EventArgs e)
        {
            Localizarhospital(edtNome.Text);
        }

        private void form_loc_hospital_Load(object sender, EventArgs e)
        {
            Dthospitais = bll_cad_hospital.Carregarhospitais();
            dgvHospital.DataSource = Dthospitais;
        }

        private void edtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter
            {
                Localizarhospital(edtNome.Text);
            }
        }
    }
}
