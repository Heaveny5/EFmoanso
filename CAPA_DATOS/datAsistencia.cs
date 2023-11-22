using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDA;
namespace CAPA_DATOS
{
    public class datAsistencia
    {
        #region sigleton
       // Patron Singleton
        // Variable estática para la instancia
        private static readonly datAsistencia _instancia = new datAsistencia();
        //privado para evitar la instanciación directa
        public static datAsistencia Instancia
        {
            get
            {
                return datAsistencia._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entAsistencia> ListarAsistencia()
        {
            SqlCommand cmd = null;
            List<entAsistencia> lista = new List<entAsistencia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAsistencia Asist = new entAsistencia();
                    Asist.IDAsistencia = Convert.ToInt32(dr["Id_Asistencia"]);
                    Asist.IDtrabajador = Convert.ToInt32(dr["ID_Trabajador"]);
                    Asist.Hora_Entrada = dr["Entrada"].ToString();
                    Asist.Hora_Salida = dr["Salida"].ToString();

                    lista.Add(Asist);
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
        public Boolean InsertarAsistencia(entAsistencia Asist)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", Asist.IDtrabajador);
              

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

       

        #endregion metodos
    }
}
