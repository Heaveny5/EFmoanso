using CAPA_ENTIDA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class datCandidato
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCandidato _instancia = new datCandidato();
        //privado para evitar la instanciación directa
        public static datCandidato Instancia
        {
            get
            {
                return datCandidato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entCandidato> ListarCandidato()
        {
            SqlCommand cmd = null;
            List<entCandidato> lista = new List<entCandidato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarCandidatos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCandidato pu = new entCandidato();
                    pu.CandidatoID = Convert.ToInt32(dr["CandidatoID"]);
                    pu.nombre = dr["Nombre"].ToString();
                    pu.email = dr["Email"].ToString();
                    pu.telefono = dr["Telefono"].ToString();
                    pu.curriculum= dr["cv"].ToString();
                    lista.Add(pu);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;


        }
        #endregion metodos
    }
}
