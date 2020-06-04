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
        public form_cad_exc_hosp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close()  ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_msn4 form_msn4 = new form_msn4();
            form_msn4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //form_msn6 form_Msn6 = new form_msn6();
            //form_Msn6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_msn5 form_Msn5 = new form_msn5();
            form_Msn5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_msn7cs form_Msn7 = new form_msn7cs();
            form_Msn7.Show();
        }
    }
}
