using CAPA_DATOS;
using CAPA_LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_proyecto_MOANSO
{

    public partial class FormEntrevista : Form
    {
        private SqlConnection connection = Conexion.Instancia.Conectar();
        public FormEntrevista()
        {
            InitializeComponent();
            listarEntrevistas();
            listarSolicitudes();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void listarSolicitudes()
        {

            dataGridView1.DataSource = logSolicitud.Instancia.ListarSolicitudes();
            dataGridView1.Columns["idcandidato"].Visible = false;
            dataGridView1.Columns["idoferta"].Visible = false;
        }

        public void listarEntrevistas()
        {

            dataGridView2.DataSource = logEntrevista.Instancia.ListarEntrevista();
            //dataGridView1.Columns["idSolicitud"].Visible = false;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0) {
                int idsolicitud = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["solicitudid"].Value);
            }

            using (SqlCommand cmd = new SqlCommand("ListarSolicitudesNombre", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro
                cmd.Parameters.AddWithValue("@idSolicitud", Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["solicitudid"].Value));

                // Crear el lector de datos
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Verificar si hay filas devueltas
                    if (reader.HasRows)
                    {
                        // Leer los datos y asignarlos a variables
                        while (reader.Read())
                        {
                            int solicitudID = reader.GetInt32(0);
                            string candidatoNombre = reader.GetString(1);
                            string ofertaTitulo = reader.GetString(2);
                            DateTime fechaSolicitud = reader.GetDateTime(3);
                            string estado = reader.GetString(4);

                            // Asignar valores a TextBox (asume que tienes TextBox llamados txtSolicitudID, txtCandidatoNombre, etc.)
                            txtIdSolicitud.Text = solicitudID.ToString();
                            txtNombreCand.Text = candidatoNombre;
                            txtOferta.Text = ofertaTitulo;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados para la solicitud especificada.");
                    }
                }
            }
        }

    }
}
