using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class entSolicitud
    {
        public int solicitudid { get; set; }
        public entCandidato idcandidato { get; set; }
        public entOfertaTrabajo idoferta { get; set; }

        public int ofertaID { get; set; }
        public int candidatoID { get; set; }

        public DateTime fechaSolicitud { get; set; }
        public string estado { get; set; }
    }
}
