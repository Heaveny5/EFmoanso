using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class entBono
    {
        public int ID_Bono { get; set; }
        public int ID_Trabajador { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public int Monto { get; set; }
        public string Motivo { get; set; }
    }
}
