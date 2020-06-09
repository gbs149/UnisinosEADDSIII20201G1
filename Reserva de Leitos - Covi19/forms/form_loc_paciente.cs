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
    public partial class form_loc_paciente : Form
    {
        public dto_cad_paciente Paciente = new dto_cad_paciente();
        private DataTable DtPacientes;

        public form_loc_paciente()
        {
            InitializeComponent();
        }

        private void LocalizarPaciente(string nomePaciente)
        {
            if (DtPacientes != null)
            {
                if (!String.IsNullOrEmpty(nomePaciente.Trim()))
                    DtPacientes.DefaultView.RowFilter = $"Nome Like '%{nomePaciente.Trim()}%'";
                else
                    DtPacientes.DefaultView.RowFilter = "";
            }
        }

        private void dgvPaciente_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPaciente.Rows.Count > 0)
            {
                string cpf = dgvPaciente.CurrentRow.Cells["CPF"].Value.ToString();
                Paciente = bll_cad_paciente.Selecionar(cpf);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnLocPaciente_Click(object sender, EventArgs e)
        {
            LocalizarPaciente(edtNome.Text);
        }

        private void form_loc_paciente_Load(object sender, EventArgs e)
        {
            DtPacientes = bll_cad_paciente.CarregarPacientes();
            dgvPaciente.DataSource = DtPacientes;
        }

        private void edtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter
            {
                LocalizarPaciente(edtNome.Text);
            }
        }
    }
}
