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
    public partial class form_loc_paciente : Form
    {
        public int Codigo { get; private set; }

        private AcessoBancoDados AcessoBanco;
        private DataTable DtCidades;

        public form_loc_paciente()
        {
            InitializeComponent();
        }
    }
}
