using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDA;
namespace CAPA_LOGICA
{
    public class logContratacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logContratacion _instancia = new logContratacion();
        //privado para evitar la instanciación directa
        public static logContratacion Instancia
        {
            get
            {
                return logContratacion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<Contratacion> ListarContratacion()
        {

            return datContratacion.Instancia.ListarContratacion();
        }
        ///inserta
        public void InsertarContratacion(Contratacion co)
        {
            datContratacion.Instancia.InsertarContrato(co);
        }
        //edita
       
        public void DeshabilitarContratacion(Contratacion co)
        {
            datContratacion.Instancia.DeshabilitarContrato(co);

        }
       
        #endregion metodos

    }

}
