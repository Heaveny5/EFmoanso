using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
   public class entNomina
    {
        public int ID_Nomina { get; set; }
        public int ID_Trabajador { get; set; }
        public DateTime Fecha_Nomina { get; set; }
        public int Sueldo { get; set; }
        public int ID_Bono { get; set; }
        public int ID_Horas { get; set; }
    }
}
