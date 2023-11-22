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
    public class datOferta
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOferta _instancia = new datOferta();
        //privado para evitar la instanciación directa
        public static datOferta Instancia
        {
            get
            {
                return datOferta._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entOfertaTrabajo> ListarOfertaTrabajo()
        {
            SqlCommand cmd = null;
            List<entOfertaTrabajo> lista = new List<entOfertaTrabajo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarOfertas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOfertaTrabajo pu = new entOfertaTrabajo();
                    pu.idoferta = Convert.ToInt32(dr["OfertaID"]);
                    pu.titulo = dr["Titulo"].ToString();
                    pu.descripcion = dr["Descripcion"].ToString();
                    pu.fechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                    pu.fechaFin = Convert.ToDateTime(dr["FechaFin"]);
                    pu.estado = dr["Estado"].ToString();
                    pu.vacantes = Convert.ToInt32(dr["vacante"]);
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
        public Boolean InsertarOfertaTrabajo(entOfertaTrabajo pu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarOferta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Titulo", pu.titulo);
                cmd.Parameters.AddWithValue("@Descripcion", pu.descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", pu.fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", pu.fechaFin);
                cmd.Parameters.AddWithValue("@Estado", pu.estado);
                cmd.Parameters.AddWithValue("@vacantes", pu.vacantes);
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


        public Boolean EditarOfertaVacantes(entOfertaTrabajo pu)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarOferta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfertaID", pu.idoferta);
                cmd.Parameters.AddWithValue("@Vacantes", pu.vacantes);
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
        
        public Boolean DeshabilitarOferta(entOfertaTrabajo pu)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InhabilitarOferta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfertaID", pu.idoferta);
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
