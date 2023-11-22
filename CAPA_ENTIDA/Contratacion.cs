using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class Contratacion
    {
        public int ID_Contratacion { get; set; }
        public int ID_Trabajador { get; set; }
        public DateTime Fecha_Contratacion { get; set; }
        public int ID_Puesto { get; set; }
        public int sueldo { get; set; }
        public Boolean Estado { get; set; }
    }
}