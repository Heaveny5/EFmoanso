using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_LOGICA;
using CAPA_ENTIDA;
namespace Interfaz_proyecto_MOANSO
{
    public partial class Registro_Asistencia : Form
    {
        public Registro_Asistencia()
        {
            InitializeComponent();
            listarAsistenci();

        }
        public void listarAsistenci()
        {


            dgv_Asistencia.DataSource = logAsistencia.Instancia.ListarAsistencia();
        }
        private void Hora_Actual_Tick(object sender, EventArgs e)
        {
            lb_hora.Text = DateTime.Now.ToString("h:mm:ss");
            lb_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entAsistencia Asist = new entAsistencia();
                Asist.IDtrabajador = Convert.ToInt32(txtentrada.Text);
                

                logAsistencia.Instancia.InsertaAsistencia(Asist);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarAsistenci();
        }

        
    }
    
}
