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
   public class datBanco
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datBanco _instancia = new datBanco();
        //privado para evitar la instanciación directa
        public static datBanco Instancia
        {
            get
            {
                return datBanco._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entBanco> ListarBanco()
        {
            SqlCommand cmd = null;
            List<entBanco> lista = new List<entBanco>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entBanco ba = new entBanco();

                    ba.ID_Banco = Convert.ToInt32(dr["ID_Banco"]);
                    ba.Nombre = dr["Nombre"].ToString();

                    lista.Add(ba);
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
        public Boolean InsertarBanco(entBanco ba)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", ba.Nombre);

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
        //////////////////////////////////EditaCliente
        public Boolean EditarBanco(entBanco ba)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Banco", ba.ID_Banco);
                cmd.Parameters.AddWithValue("@Nombre", ba.Nombre);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        //deshabilitaCliente


        #endregion metodos
    }
}
