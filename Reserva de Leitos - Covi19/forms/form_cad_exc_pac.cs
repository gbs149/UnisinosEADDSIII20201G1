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
        public form_cadastro_paciente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_cadastro_paciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_msn1 fmr_msn = new form_msn1();
            fmr_msn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

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
    }
}
