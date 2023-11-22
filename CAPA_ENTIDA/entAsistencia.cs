using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class entAsistencia
    {
        public int IDAsistencia { get; set; }
        public int IDtrabajador { get; set; }
        public string Hora_Entrada{ get; set; }
        public string Hora_Salida { get; set; }
  
        public int Justificacion { get; set; }

    }
}
