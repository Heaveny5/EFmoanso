using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class entTrabajador
    {

        public int IDtrabajador { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public String Telefono { get; set; }
        public int ID_Banco { get; set; }
        public String N_Cuenta { get; set; }
        public int ID_Puesto { get; set; }
        public DateTime FechaCon { get; set; }
        public Boolean Estado { get; set; }
    }
}
