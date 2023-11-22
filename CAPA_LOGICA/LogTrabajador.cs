using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDA;
namespace CAPA_LOGICA
{
    public class LogTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogTrabajador _instancia = new LogTrabajador();
        //privado para evitar la instanciación directa
        public static LogTrabajador Instancia
        {
            get
            {
                return LogTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entTrabajador> ListarTrabajador()
        {
            
            return datTrabajador.Instancia.ListarTrabajador();
        }
        ///inserta
        public void InsertaTrabajador(entTrabajador Tra)
        {
            datTrabajador.Instancia.InsertarTrabajador(Tra);
        }
        //edita
        public void EditaTrabajador(entTrabajador tra)
        {
            datTrabajador.Instancia.EditarTrabajador(tra);
        }
        public void DeshabilitarTrabajador(entTrabajador tra)
        {
            datTrabajador.Instancia.DeshabilitarTrabajador(tra);
       
        }
        public entTrabajador BuscarTrabajador (int idtra)
        {
            try
            {
                return datTrabajador.Instancia.BuscarTrabajador(idtra);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos

    }
}
