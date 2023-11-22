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
    public class datSolicitud
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datSolicitud _instancia = new datSolicitud();
        //privado para evitar la instanciación directa
        public static datSolicitud Instancia
        {
            get
            {
                return datSolicitud._instancia;
            }
        }
        #endregion singleton
        #region metodos

        public List<entSolicitud> ListarSolicitudes()
        {
            SqlCommand cmd = null;
            List<entSolicitud> lista = new List<entSolicitud>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listarSolicitud", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSolicitud so = new entSolicitud();
                    entOfertaTrabajo ofertaTrabajo = new entOfertaTrabajo();
                    entCandidato candidato = new entCandidato();

                    so.solicitudid = Convert.ToInt32(dr["SolicitudID"]);
                    so.estado = dr["Estado"].ToString();
                    so.fechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"]);
                    so.ofertaID = Convert.ToInt32(dr["OfertaID"]);
                    so.candidatoID = Convert.ToInt32(dr["CandidatoID"]);

                    //so.idoferta = ofertaTrabajo;
                    //so.idcandidato = candidato;


                    lista.Add(so);
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

        public Boolean InsertarSolicitud(entSolicitud pu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarSolicitud", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CandidatoID", pu.idcandidato.CandidatoID);
                cmd.Parameters.AddWithValue("@OfertaID", pu.idoferta.idoferta);
                cmd.Parameters.AddWithValue("@FechaSolicitud", pu.fechaSolicitud);
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

        public Boolean DeshabilitarSolicitud(entSolicitud pu)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InhabilitarSolicitud", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SolicitudID", pu.solicitudid);
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
