using CAPA_DATOS;
using CAPA_ENTIDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA
{
    public class logSolicitud
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logSolicitud _instancia = new logSolicitud();
        //privado para evitar la instanciación directa
        public static logSolicitud Instancia
        {
            get
            {
                return logSolicitud._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entSolicitud> ListarSolicitudes()
        {

            return datSolicitud.Instancia.ListarSolicitudes();
        }
        ///inserta
        public void InsertaSolicitud(entSolicitud so)
        {
            datSolicitud.Instancia.InsertarSolicitud(so);
        }
        
        public void DeshabilitarPublicacion(entSolicitud so)
        {
            datSolicitud.Instancia.DeshabilitarSolicitud(so);

        }
        #endregion metodos
    }
}

