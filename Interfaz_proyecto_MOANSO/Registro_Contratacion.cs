using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDA;
using CAPA_LOGICA;
namespace Interfaz_proyecto_MOANSO
{
    public partial class Registro_Contratacion : Form
    {
       
        public Registro_Contratacion()
        {
            InitializeComponent();
            ListarComboxPuesto();
            listarContratacion();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void AgregarTrabajador_Click(object sender, EventArgs e)
        {
            Contratacion co = new Contratacion();

            co.ID_Trabajador = Convert.ToInt32(txtidtrabajador.Text);
            co.Fecha_Contratacion = Convert.ToDateTime(dtpFC.Value);
            co.sueldo= Convert.ToInt32(txtSueldo.Text);
            co.ID_Puesto= Convert.ToInt32(cbpuesto.SelectedValue);
            co.Estado = checkBoxE.Checked;
            logContratacion.Instancia.InsertarContratacion(co);
            listarContratacion();

        }
        public void listarContratacion()
        {

            dataGridView1.DataSource = logContratacion.Instancia.ListarContratacion();


        }
        private void ListarComboxPuesto()
        {
            cbpuesto.DataSource = logPuesto.Instancia.Listarpuesto();
            cbpuesto.DisplayMember = "Nombre";
            cbpuesto.ValueMember = "ID_Puesto";
        }
       
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Contratacion co = new Contratacion();
                co.ID_Trabajador = int.Parse(txtIdco.Text);
               
                logContratacion.Instancia.DeshabilitarContratacion(co);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarContratacion();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex];
            txtIdco.Text = filaActual.Cells[0].Value.ToString();
            txtidtrabajador.Text = filaActual.Cells[1].Value.ToString();
            cbpuesto.Text = filaActual.Cells[3].Value.ToString();
            txtSueldo.Text = filaActual.Cells[4].Value.ToString();
            checkBoxE.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
