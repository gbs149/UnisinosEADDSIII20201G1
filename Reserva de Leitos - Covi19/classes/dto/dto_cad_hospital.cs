using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Leitos___Covi19.classes.dto
{
    public class dto_cad_hospital
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public String CNPJ { get; set; }
        public int Cidade { get; set; }
    }
}
