using Huellitas.Empleadosws.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huellitas.Empleadosws
{
    public partial class FormServicios : Form
    {
        public FormServicios()
        {
            InitializeComponent();
        }
        int variabledecancel = 0;
        Guid id;
        string tipo = "";
        decimal precio = 0;
        string msgbody = "";
        private void FormServicios_Load(object sender, EventArgs e)
        {
            Mostrarservicios();
            iconbtnguardarServicios.Enabled = false;
        }

        int estadoservicio = 0;
        //funciones
        private void mensaje(string message1)
        {

            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }

        //función para mostrar los servicios
        public void Mostrarservicios()
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {

                var listaServicios = from servicios in conexion.Servicios
                                    select new
                                    {
                                        servicios.id,
                                        servicios.tipo,
                                        servicios.precio
                                    };
                dgvdatosServicio.DataSource = listaServicios.ToList();
                dgvdatosServicio.Columns[1].HeaderText = "Nombre del servicio";
                dgvdatosServicio.Columns[2].HeaderText = "Precio";
            }
        }

        //funcion para validar campos
        public void validarcamposservicio()
        {
            var validarservicio = !string.IsNullOrEmpty(txttipoServicio.Text) &&
                !string.IsNullOrEmpty(txtprecioServicio.Text);
            iconbtnguardarServicios.Enabled = validarservicio;

            if (iconbtnguardarServicios.Enabled == false)
                iconbtnguardarServicios.IconColor = Color.OrangeRed;
            else
                iconbtnguardarServicios.IconColor = Color.DarkSeaGreen;

        }

        //función para CRUD utilizando switch
        public void CRUDServicios()
        {
            switch(estadoservicio)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Servicio nuevoservicio = new Servicio();
                            nuevoservicio.id = Guid.NewGuid();
                            nuevoservicio.tipo = txttipoServicio.Text;
                            nuevoservicio.precio = Convert.ToDecimal(txtprecioServicio.Text);
                            conexion.Servicios.Add(nuevoservicio);
                            conexion.SaveChanges();
                            id = nuevoservicio.id;
                            msgbody = "Servicio registrado";
                            mensaje(msgbody);
                            Mostrarservicios();
                            variabledecancel = 1;
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Servicio no registrado";
                        mensaje(msgbody);
                    }
                    break;

                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Guid idservicio = Guid.Parse(txtidServicio.Text);
                            var consultadatosservicio = (from servicio in conexion.Servicios where servicio.id == idservicio select servicio).FirstOrDefault();
                            id = consultadatosservicio.id;
                            tipo = consultadatosservicio.tipo;
                            precio = consultadatosservicio.precio;
                            if (consultadatosservicio != null)
                            {
                                consultadatosservicio.tipo = txttipoServicio.Text;
                                consultadatosservicio.precio = Convert.ToDecimal(txtprecioServicio.Text);
                                conexion.SaveChanges();
                                msgbody = "Servicio modificado";
                                mensaje(msgbody);
                                Mostrarservicios();
                                variabledecancel = 2;
                            }
                            else
                            {
                                msgbody = "Servicio no registrado";
                                mensaje(msgbody);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Servicio no registrado";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        public void Canceloperacion()
        {
            switch (variabledecancel)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            var cancelaroperacion = (from servicio in conexion.Servicios where servicio.id == id select servicio).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {
                                conexion.Servicios.Remove(cancelaroperacion);
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                Mostrarservicios();
                            }
                            else
                            {

                                msgbody = "No se pudo cancelar";
                                mensaje(msgbody);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "No se pudo cancelar";
                        mensaje(msgbody);
                    }
                    break;
                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {

                            var cancelaroperacion = (from servicio in conexion.Servicios where servicio.id == id select servicio).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {

                                cancelaroperacion.tipo = tipo;
                                cancelaroperacion.precio = precio;
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                Mostrarservicios();

                            }
                            else
                            {
                                msgbody = "No se pudo cancelar";
                                mensaje(msgbody);
                            }

                        }

                    }
                    catch (Exception)
                    {
                        msgbody = "No se pudo cancelar";
                        mensaje(msgbody);
                    }
                    break;
            }
        }
        //oculta el id en el datagridview
        private void dgvdatosServicio_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosServicio.Columns[0].Visible = false;
        }

        private void iconbtnguardarServicios_Click(object sender, EventArgs e)
        {
            CRUDServicios();
            iconbtnagregardatosServicios.Enabled = true;
            iconbtnagregardatosServicios.IconColor = Color.OrangeRed;
            iconbtnmodificarServicios.Enabled = true;
            iconbtnmodificarServicios.IconColor = Color.OrangeRed;
            iconbtneliminarServicios.Enabled = true;
            iconbtneliminarServicios.IconColor = Color.OrangeRed;
            txtidServicio.Text = "";
            txttipoServicio.Text = "";
            txtprecioServicio.Text = "";
        }

        private void iconbtnagregardatosServicios_Click(object sender, EventArgs e)
        {
            estadoservicio = 1;
            iconbtnagregardatosServicios.IconColor = Color.DarkSeaGreen;
            iconbtnmodificarServicios.Enabled = false;
            iconbtneliminarServicios.Enabled = false;
        }

       
        private void iconbtnmodificarServicios_Click(object sender, EventArgs e)
        {
            estadoservicio = 2;
            iconbtnmodificarServicios.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosServicios.Enabled = false;
            iconbtneliminarServicios.Enabled = false;
        }
        
        private void iconbtneliminarServicios_Click(object sender, EventArgs e)
        {
            Canceloperacion();
            iconbtneliminarServicios.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosServicios.Enabled = false;
            iconbtnmodificarServicios.Enabled = false;
        }

        private void iconbtnlimpiarServicios_Click(object sender, EventArgs e)
        {
            iconbtnagregardatosServicios.Enabled = true;
            iconbtnagregardatosServicios.IconColor = Color.OrangeRed;
            iconbtnmodificarServicios.Enabled = true;
            iconbtnmodificarServicios.IconColor = Color.OrangeRed;
            iconbtneliminarServicios.Enabled = true;
            iconbtneliminarServicios.IconColor = Color.OrangeRed;
            txtidServicio.Text = "";
            txttipoServicio.Text = "";
            txtprecioServicio.Text = "";
        }

        //Agrega los datos del datagridview a los textboxs
        private void dgvdatosServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidServicio.Text = dgvdatosServicio.SelectedCells[0].Value.ToString();
            txttipoServicio.Text = dgvdatosServicio.SelectedCells[1].Value.ToString();
            txtprecioServicio.Text = dgvdatosServicio.SelectedCells[2].Value.ToString();
        }

        //filtra los datos del datagrid a traves del tipo de servicio
        private void txtbuscarServicio_KeyUp(object sender, KeyEventArgs e)
        {

            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var filtrardatosservicio = conexion.Servicios.SqlQuery("select * from Veter.Servicios where tipo like ('" + txttipoServicio.Text + "%')");
                dgvdatosServicio.DataSource = filtrardatosservicio.ToList();
            }
        }
        //valida cada textbox para que ninguno quede vacio
        private void txttipoServicio_TextChanged(object sender, EventArgs e)
        {
            validarcamposservicio();
        }

        private void txtprecioServicio_TextChanged(object sender, EventArgs e)
        {
            validarcamposservicio();
        }


        private void dgvdatosServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtidServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscarServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbuscarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconbtnrecargarServicios_Click(object sender, EventArgs e)
        {
            Mostrarservicios();
        }

        private void iconcerrarServicios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
