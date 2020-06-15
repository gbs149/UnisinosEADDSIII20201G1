using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Leitos___Covi19.classes.dto
{
    class dto_cad_leito
    {
        public int Id { get; set; }
        public char Tipo { get; set; }
        public char Situacao { get; set; }
        public int Hospital_Id { get; set; }
    }
}
