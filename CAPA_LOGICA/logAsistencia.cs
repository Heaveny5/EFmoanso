using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDA;
using CAPA_DATOS;
namespace CAPA_LOGICA
{
   public class logAsistencia
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAsistencia _instancia = new logAsistencia();
        //privado para evitar la instanciación directa
        public static logAsistencia Instancia
        {
            get
            {
                return logAsistencia._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAsistencia> ListarAsistencia()
        {

            return datAsistencia.Instancia.ListarAsistencia();
        }
        ///inserta
        public void InsertaAsistencia(entAsistencia asist)
        {
            datAsistencia.Instancia.InsertarAsistencia(asist);
        }
        public void InsertaAsistenciaSalida(entAsistencia asist)
        {
            datAsistencia.Instancia.InsertarAsistencia(asist);
        }
        #endregion metodos
    }
}
