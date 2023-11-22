using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_ENTIDA;
namespace CAPA_DATOS
{
    public class datTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTrabajador _instancia = new datTrabajador();
        //privado para evitar la instanciación directa
        public static datTrabajador Instancia
        {
            get
            {
                return datTrabajador._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entTrabajador> ListarTrabajador()
        {
            SqlCommand cmd = null;
            List<entTrabajador> lista = new List<entTrabajador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListar_Trabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTrabajador Tra = new entTrabajador();

                   
                    Tra.IDtrabajador= Convert.ToInt32(dr["ID_Trabajador"]);
                    Tra.Nombre=dr["Nombres"].ToString();
                    Tra.Apellidos= dr["Apellidos"].ToString();
                    Tra.Dni = Convert.ToInt32(dr["Dni"]);
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Telefono = dr["Telefono"].ToString();
                    Tra.ID_Banco = Convert.ToInt32( dr["ID_Banco"]);
                    Tra.N_Cuenta = dr["N_Cuenta"].ToString();
                    Tra.ID_Puesto = Convert.ToInt16(dr["ID_Puesto"]);
                    Tra.FechaCon = Convert.ToDateTime(dr["F_Contratacion"]);
                    Tra.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Tra);
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
        public Boolean InsertarTrabajador(entTrabajador Tra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", Tra.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", Tra.Apellidos);
                cmd.Parameters.AddWithValue("@Dni", Tra.Dni); 
                cmd.Parameters.AddWithValue("@Direccion", Tra.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Tra.Telefono);
                cmd.Parameters.AddWithValue("@ID_Banco", Tra.ID_Banco);
                cmd.Parameters.AddWithValue("@N_Cuenta", Tra.N_Cuenta);
                cmd.Parameters.AddWithValue("@ID_Puesto", Tra.ID_Puesto);
                cmd.Parameters.AddWithValue("@F_Contratacion", Tra.FechaCon);
                cmd.Parameters.AddWithValue("@Estado", Tra.Estado);
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
        public Boolean EditarTrabajador(entTrabajador Tra)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", Tra.IDtrabajador);
                cmd.Parameters.AddWithValue("@Nombres", Tra.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", Tra.Apellidos);
                cmd.Parameters.AddWithValue("@Dni", Tra.Dni);
                cmd.Parameters.AddWithValue("@Direccion", Tra.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Tra.Telefono);
                cmd.Parameters.AddWithValue("@ID_Banco", Tra.ID_Banco);
                cmd.Parameters.AddWithValue("@N_Cuenta", Tra.N_Cuenta);
                cmd.Parameters.AddWithValue("@ID_Puesto", Tra.ID_Puesto);
                cmd.Parameters.AddWithValue("@F_Contratacion", Tra.FechaCon);
                cmd.Parameters.AddWithValue("@Estado", Tra.Estado);
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
        public Boolean DeshabilitarTrabajador(entTrabajador tra)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaTrabajador", cn);   
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", tra.IDtrabajador);
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
        public entTrabajador BuscarTrabajador(int idtra)
        {
            SqlCommand cmd = null;
            entTrabajador Tra = new entTrabajador();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaridTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", idtra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Tra.IDtrabajador = Convert.ToInt32(dr["ID_Trabajador"]);
                    Tra.Nombre = dr["Nombres"].ToString();
                    Tra.Apellidos = dr["Apellidos"].ToString();
                    Tra.Dni = Convert.ToInt32(dr["Dni"]);
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Telefono = dr["Telefono"].ToString();
                    Tra.ID_Banco = Convert.ToInt32(dr["ID_Banco"]);
                    Tra.N_Cuenta = dr["N_Cuenta"].ToString();
                    Tra.ID_Puesto = Convert.ToInt16(dr["ID_Puesto"]);
                    Tra.FechaCon = Convert.ToDateTime(dr["F_Contratacion"]);
                    Tra.Estado = Convert.ToBoolean(dr["Estado"]);
                   

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); 
            }
            return Tra;
        }
       

        #endregion metodos

    }
}