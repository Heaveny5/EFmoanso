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
    public class datEntrevista
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEntrevista _instancia = new datEntrevista();
        //privado para evitar la instanciación directa
        public static datEntrevista Instancia
        {
            get
            {
                return datEntrevista._instancia;
            }
        }
        #endregion singleton
        #region metodos

        public List<entEntrevista> ListarEntrevistas()
        {
            SqlCommand cmd = null;
            List<entEntrevista> lista = new List<entEntrevista>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarEntrevista", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEntrevista pu = new entEntrevista();
                    //entSolicitud sol= new entSolicitud();
                    pu.identrevista = Convert.ToInt32(dr["EntrevistaID"]);
                    pu.fecha = Convert.ToDateTime(dr["FechaEntrevista"]);
                    pu.estado = dr["Estado"].ToString();
                    pu.solicitudID = Convert.ToInt32(dr["SolicitudID"]);

                    //sol.solicitudid = Convert.ToInt32(dr["SolicitudID"]);
                    //pu.idSolicitud = sol;
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
        public Boolean InsertarEntrevista(entEntrevista pu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarEntrevista", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SolicitudID", pu.idSolicitud.solicitudid);
                cmd.Parameters.AddWithValue("@FechaEntrevista", pu.fecha);
                cmd.Parameters.AddWithValue("@Estado", pu.estado);
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
        public Boolean DeshabilitarEntrevista(entEntrevista pu)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InhabilitarEntrevista", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EntrevistaID", pu.identrevista);
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
