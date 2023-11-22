using CAPA_LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_proyecto_MOANSO
{
    public partial class FormEntrevista : Form
    {
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
            dataGridView1.Columns[2].Visible = false;



        }
    }
}
