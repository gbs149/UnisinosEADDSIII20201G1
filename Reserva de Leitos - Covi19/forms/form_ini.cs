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
    public partial class form_ini : Form
    {
        public form_ini()
        {
            InitializeComponent();
        }

        private void form_ini_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_cadastro_paciente frm1 = new form_cadastro_paciente();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_cad_exc_hosp frm2 = new form_cad_exc_hosp();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_loc_leitos frm3 = new form_loc_leitos();
            frm3.Show();
        }
    }
}
