using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Leitos___Covi19.classes.dto
{
    class dto_cad_internacao
    {
        public int Id { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
        public char Situacao { get; set; }
        public int Paciente_Id { get; set; }
        public int Leito_Id { get; set; }
        public int Cidade_Id { get; set; }
    }
}
