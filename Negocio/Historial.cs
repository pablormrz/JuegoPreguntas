using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Historial
    {
        public string NombreParticipante { get; set; }
        public int RondaAlcanzada { get; set; }
        public decimal PremioConseguido { get; set; }
        public bool RetiroVoluntario { get; set; }
    }
}
