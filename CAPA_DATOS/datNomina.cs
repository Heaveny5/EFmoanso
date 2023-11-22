using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class datNomina
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datNomina _instancia = new datNomina();
        //privado para evitar la instanciación directa
        public static datNomina Instancia
        {
            get
            {
                return datNomina._instancia;
            }
        }
        #endregion singleton
        #region metodos
       
        #endregion metodos
    }
}
