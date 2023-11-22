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
    public class datContratacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datContratacion _instancia = new datContratacion();
        //privado para evitar la instanciación directa
        public static datContratacion Instancia
        {
            get
            {
                return datContratacion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<Contratacion> ListarContratacion()
        {
            SqlCommand cmd = null;
            List<Contratacion> lista = new List<Contratacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarContratacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contratacion co = new Contratacion();
                    co.ID_Contratacion = Convert.ToInt32(dr["ID_Contratacion"]);
                    co.ID_Trabajador = Convert.ToInt32(dr["ID_Trabajador"]);
                    co.Fecha_Contratacion = Convert.ToDateTime(dr["F_Contratacion"]);
                    co.ID_Puesto = Convert.ToInt32(dr["ID_Puesto"]);
                    co.sueldo = Convert.ToInt32(dr["Sueldo"]);
                    co.Estado = Convert.ToBoolean( dr["Estado"]);
             
                    lista.Add(co);
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
        public Boolean InsertarContrato(Contratacion co)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarContratacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", co.ID_Trabajador);
                cmd.Parameters.AddWithValue("@F_Contratacion", co.Fecha_Contratacion);
                cmd.Parameters.AddWithValue("@ID_Puesto", co.ID_Puesto);
                cmd.Parameters.AddWithValue("@Sueldo", co.sueldo);
                cmd.Parameters.AddWithValue("@Estado", co.Estado);
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
        public Boolean DeshabilitarContrato(Contratacion co)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarContratacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", co.ID_Trabajador);
                //cmd.Parameters.AddWithValue("@Estado", tra.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos

    }
}
