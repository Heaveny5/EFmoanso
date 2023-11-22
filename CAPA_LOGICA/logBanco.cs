using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDA;
namespace CAPA_LOGICA
{
   public class logBanco
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logBanco _instancia = new logBanco();
        //privado para evitar la instanciación directa
        public static logBanco Instancia
        {
            get
            {
                return logBanco._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entBanco> ListarBanco()
        {

            return datBanco.Instancia.ListarBanco();
        }
        ///inserta
        public void InsertaTrabajador(entBanco ba)
        {
            datBanco.Instancia.InsertarBanco(ba);
        }
        //edita
        public void EditaPuesto(entBanco ba)
        {
            datBanco.Instancia.EditarBanco(ba);
        }

        #endregion metodos

    }
}
