using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public string TextoPreguntaa { get; set; }
        public int NumCategoria { get; set; }

        public List<OpcionRespueta> OpcionRespueta { get; set; }
        
    }
}
