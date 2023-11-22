
namespace Interfaz_proyecto_MOANSO
{
    partial class Registro_Trabajador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Trabajador));
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.txttel1 = new System.Windows.Forms.TextBox();
            this.txtnumero_cuenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AgregarTrabajador = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.VerTrabajador = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CB_puesto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DTP_FC = new System.Windows.Forms.DateTimePicker();
            this.DTP_FN = new System.Windows.Forms.DateTimePicker();
            this.CB_Banco = new System.Windows.Forms.ComboBox();
            this.btnrefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VerTrabajador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(200, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de nacimiento :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "N_Cuenta_Bancaria :";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(201, 49);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(157, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(38, 97);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(144, 20);
            this.txtapellidos.TabIndex = 11;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(568, 51);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(146, 20);
            this.txtdni.TabIndex = 12;
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(202, 96);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(157, 20);
            this.txtdirec.TabIndex = 14;
            // 
            // txttel1
            // 
            this.txttel1.Location = new System.Drawing.Point(380, 94);
            this.txttel1.Name = "txttel1";
            this.txttel1.Size = new System.Drawing.Size(158, 20);
            this.txttel1.TabIndex = 15;
            // 
            // txtnumero_cuenta
            // 
            this.txtnumero_cuenta.Location = new System.Drawing.Point(202, 149);
            this.txtnumero_cuenta.Name = "txtnumero_cuenta";
            this.txtnumero_cuenta.Size = new System.Drawing.Size(157, 20);
            this.txtnumero_cuenta.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Banco :";
            // 
            // AgregarTrabajador
            // 
            this.AgregarTrabajador.BackColor = System.Drawing.Color.White;
            this.AgregarTrabajador.FlatAppearance.BorderSize = 0;
            this.AgregarTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarTrabajador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarTrabajador.Image = ((System.Drawing.Image)(resources.GetObject("AgregarTrabajador.Image")));
            this.AgregarTrabajador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarTrabajador.Location = new System.Drawing.Point(367, 22);
            this.AgregarTrabajador.Name = "AgregarTrabajador";
            this.AgregarTrabajador.Size = new System.Drawing.Size(108, 55);
            this.AgregarTrabajador.TabIndex = 22;
            this.AgregarTrabajador.Text = "Agregar";
            this.AgregarTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTrabajador.UseVisualStyleBackColor = false;
            this.AgregarTrabajador.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(573, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 16);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Estado Trabajador";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // VerTrabajador
            // 
            this.VerTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerTrabajador.Location = new System.Drawing.Point(36, 326);
            this.VerTrabajador.Name = "VerTrabajador";
            this.VerTrabajador.Size = new System.Drawing.Size(692, 253);
            this.VerTrabajador.TabIndex = 25;
            this.VerTrabajador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerTrabajador_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(102)))), ((int)(((byte)(56)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.AgregarTrabajador);
            this.groupBox1.Location = new System.Drawing.Point(38, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 90);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ingrese ID :";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(110, 38);
            this.txtBusca.Multiline = true;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(141, 25);
            this.txtBusca.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(268, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 53);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(587, 22);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(89, 55);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.White;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(491, 21);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 55);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "ID Trabajador";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(38, 50);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 20);
            this.txtid.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(566, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "Puesto :";
            // 
            // CB_puesto
            // 
            this.CB_puesto.FormattingEnabled = true;
            this.CB_puesto.Location = new System.Drawing.Point(570, 96);
            this.CB_puesto.Name = "CB_puesto";
            this.CB_puesto.Size = new System.Drawing.Size(144, 20);
            this.CB_puesto.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(378, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 12);
            this.label14.TabIndex = 33;
            this.label14.Text = "Fecha de contratacion:";
            // 
            // DTP_FC
            // 
            this.DTP_FC.CustomFormat = "DD:MM:YY";
            this.DTP_FC.Location = new System.Drawing.Point(380, 146);
            this.DTP_FC.Name = "DTP_FC";
            this.DTP_FC.Size = new System.Drawing.Size(158, 20);
            this.DTP_FC.TabIndex = 34;
            this.DTP_FC.Value = new System.DateTime(2023, 11, 9, 0, 0, 0, 0);
            // 
            // DTP_FN
            // 
            this.DTP_FN.Location = new System.Drawing.Point(380, 48);
            this.DTP_FN.Name = "DTP_FN";
            this.DTP_FN.Size = new System.Drawing.Size(158, 20);
            this.DTP_FN.TabIndex = 35;
            // 
            // CB_Banco
            // 
            this.CB_Banco.FormattingEnabled = true;
            this.CB_Banco.Location = new System.Drawing.Point(38, 152);
            this.CB_Banco.Name = "CB_Banco";
            this.CB_Banco.Size = new System.Drawing.Size(144, 20);
            this.CB_Banco.TabIndex = 36;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Image")));
            this.btnrefrescar.Location = new System.Drawing.Point(696, 292);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(35, 28);
            this.btnrefrescar.TabIndex = 37;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // Registro_Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.CB_Banco);
            this.Controls.Add(this.DTP_FN);
            this.Controls.Add(this.DTP_FC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CB_puesto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VerTrabajador);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnumero_cuenta);
            this.Controls.Add(this.txttel1);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Trabajador";
            this.Text = "REGISTRO_EMPLEADOS";
            ((System.ComponentModel.ISupportInitialize)(this.VerTrabajador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.TextBox txttel1;
        private System.Windows.Forms.TextBox txtnumero_cuenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AgregarTrabajador;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.DataGridView VerTrabajador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CB_puesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DTP_FC;
        private System.Windows.Forms.DateTimePicker DTP_FN;
        private System.Windows.Forms.ComboBox CB_Banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnrefrescar;
    }
}

