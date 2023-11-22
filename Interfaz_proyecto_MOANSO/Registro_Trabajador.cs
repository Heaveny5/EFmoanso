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
    public partial class Registro_Trabajador : Form
    {
        int idtra;
        public Registro_Trabajador()
        {
            InitializeComponent();
            listarTrabajador();
            ListarComboxPuesto();
            ListarCBanco();
        }
        //agregar
        private void button2_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entTrabajador tra = new entTrabajador();
                tra.Nombre = txtnombre.Text.Trim();
                tra.Apellidos = txtapellidos.Text;
                tra.Dni = Convert.ToInt32( txtdni.Text);
                tra.Direccion = txtdirec.Text;
                tra.Telefono = txttel1.Text;    
                tra.ID_Banco =Convert.ToInt32(CB_Banco.SelectedValue);
                tra.N_Cuenta = txtnumero_cuenta.Text;
                tra.ID_Puesto = Convert.ToInt32( CB_puesto.SelectedValue);
                tra.FechaCon = DTP_FC.Value;
                tra.Estado = checkBox1.Checked;
                LogTrabajador.Instancia.InsertaTrabajador(tra);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarTrabajador();
            limpiar();

        }
        public void listarTrabajador()
        {

            VerTrabajador.DataSource= LogTrabajador.Instancia.ListarTrabajador();
            

        }
        //editar
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                entTrabajador tra = new entTrabajador();
                entBanco ba = new entBanco();
                entPuesto pu = new entPuesto();
                tra.IDtrabajador = int.Parse(txtid.Text.Trim());
                tra.Nombre = txtnombre.Text.Trim();
                tra.Apellidos = txtapellidos.Text.Trim();
                tra.Dni = Convert.ToInt32( txtapellidos.Text);
                tra.Direccion = txtdirec.Text.Trim();
                tra.Telefono = txttel1.Text.Trim();           
                tra.ID_Banco = Convert.ToInt32(CB_Banco.SelectedValue);
                tra.N_Cuenta = txtnumero_cuenta.Text.Trim();
                tra.ID_Puesto = Convert.ToInt32(CB_puesto.SelectedValue);
                tra.FechaCon = DTP_FC.Value;
                tra.Estado = checkBox1.Checked;
                LogTrabajador.Instancia.EditaTrabajador(tra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarTrabajador();
            limpiar();



        }

        private void VerTrabajador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = VerTrabajador.Rows[e.RowIndex];
            txtid.Text = filaActual.Cells[0].Value.ToString();
            txtnombre.Text = filaActual.Cells[1].Value.ToString();
            txtdni.Text = filaActual.Cells[2].Value.ToString();
            txtapellidos.Text = filaActual.Cells[3].Value.ToString();
           // DTP_FN.Text = filaActual.Cells[4].Value.ToString();
            txtdirec.Text = filaActual.Cells[4].Value.ToString();
            txttel1.Text = filaActual.Cells[5].Value.ToString();
            CB_Banco.Text = filaActual.Cells[6].Value.ToString();
            txtnumero_cuenta.Text = filaActual.Cells[7].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
            CB_puesto.Text = filaActual.Cells[8].Value.ToString();
           // DTP_FC.Text = filaActual.Cells[11].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entTrabajador tra = new entTrabajador();
                tra.IDtrabajador = int.Parse(txtid.Text.Trim());
                //checkBox1.Checked = false;
                //tra.Estado = checkBox1.Checked;
                LogTrabajador.Instancia.DeshabilitarTrabajador(tra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarTrabajador();
            limpiar();
                
        }
        public void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = " ";
            txtapellidos.Text = "";
            CB_Banco.Text = " ";
            txtdirec.Text = "";
            txtdni.Text = "";
            txtnumero_cuenta.Text = "";
            txttel1.Text= "";
            txtBusca.Text = "";
           
            
            
        }
        private void ListarComboxPuesto()
        {
            CB_puesto.DataSource = logPuesto.Instancia.Listarpuesto();
            CB_puesto.DisplayMember = "Nombre";
            CB_puesto.ValueMember = "ID_Puesto";
        }
        private void ListarCBanco()
        {
            CB_Banco.DataSource = logBanco.Instancia.ListarBanco();
            CB_Banco.DisplayMember = "Nombre";
            CB_Banco.ValueMember = "ID_Banco";
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            idtra = Convert.ToInt32(txtBusca.Text); // se obtiene el valor de una celda 
            entTrabajador tra = LogTrabajador.Instancia.BuscarTrabajador(idtra);

            if (tra != null && (tra.Estado = true))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID_Trabajador");
                dt.Columns.Add("Nombres");
                dt.Columns.Add("Apellidos");
                dt.Columns.Add("Dni");
                dt.Columns.Add("Direccion");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("ID_Banco");
                dt.Columns.Add("N_Cuenta");
                dt.Columns.Add("ID_Puesto");
                dt.Columns.Add("F_Contratacion");
                dt.Columns.Add("Estado");
                dt.Rows.Add(
                    tra.IDtrabajador,
                    tra.Nombre,
                    tra.Apellidos,
                    tra.Dni,
                    tra.Direccion,
                    tra.Telefono,
                    tra.ID_Banco,
                    tra.N_Cuenta,
                    tra.ID_Puesto,
                    tra.FechaCon,
                    tra.Estado
                    );
                VerTrabajador.DataSource = dt;
                limpiar();
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            listarTrabajador();
        }
    }
}
