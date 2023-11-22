using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
namespace CAPA_LOGICA
{
   public class logNomina
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logNomina _instancia = new logNomina();
        //privado para evitar la instanciación directa
        public static logNomina Instancia
        {
            get
            {
                return logNomina._instancia;
            }
        }
        #endregion singleton
        #region metodos
        
        #endregion metodos
    }
}
