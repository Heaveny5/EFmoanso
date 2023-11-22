using CAPA_DATOS;
using CAPA_ENTIDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA
{
    public class logEntrevista
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEntrevista _instancia = new logEntrevista();
        //privado para evitar la instanciación directa
        public static logEntrevista Instancia
        {
            get
            {
                return logEntrevista._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entEntrevista> ListarEntrevista()
        {

            return datEntrevista.Instancia.ListarEntrevistas();
        }
        ///inserta
        public void InsertaEntrevista(entEntrevista ent)
        {
            datEntrevista.Instancia.InsertarEntrevista(ent);
        }

        public void DeshabilitarPublicacion(entEntrevista ent)
        {
            datEntrevista.Instancia.DeshabilitarEntrevista(ent);

        }
        #endregion metodos
    }
}

