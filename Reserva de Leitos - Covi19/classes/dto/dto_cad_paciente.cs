using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Leitos___Covi19.classes.dto
{
    public class dto_cad_paciente
    {
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String Sexo { get; set; }
        public int Idade { get; set; }
        public int Cidade { get; set; }
    }
}
