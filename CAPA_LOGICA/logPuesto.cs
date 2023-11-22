using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDA;
namespace CAPA_LOGICA
{
   public class logPuesto
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPuesto _instancia = new logPuesto();
        //privado para evitar la instanciación directa
        public static logPuesto Instancia
        {
            get
            {
                return logPuesto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entPuesto> Listarpuesto()
        {

            return datPuesto.Instancia.ListarPuesto();
        }
        ///inserta
        public void InsertaTrabajador(entPuesto pu)
        {
            datPuesto.Instancia.InsertarPuesto(pu);
        }
        //edita
        public void EditaPuesto(entPuesto pu)
        {
            datPuesto.Instancia.EditarPuesto(pu);
        }
       
        #endregion metodos
    }
}
