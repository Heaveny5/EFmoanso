using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class entEntrevista
    {
        public int identrevista { get; set; }
        public entSolicitud idSolicitud { get; set; }
        public int solicitudID { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
    }
}
