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
    public partial class FormCita : Form
    {
        public FormCita()
        {
            InitializeComponent();
        }

        //INICIALIZA EL SWITCH CASE
        int estadocita = 1;
        int variablecita = 0;
        int idhora = 0;
        string idcliente = "";
        string idservicio = "";
        DateTime fechadia = DateTime.Today;
        int variabledecancel = 0;
        DateTime fecha;
        Guid id;
        int idhoracita;
        Guid idclientecancel;
        Guid idserviciocancel;
        int idestadocita;
        string msgbody = "";

        private void FormCita_Load(object sender, EventArgs e)
        {
            mostrarCitas();
            iconbtnguardarCita.Enabled = false;
        }

        //FUNCIONES
        private void mensaje(string message1)
        {
           
            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }

        //JOIN QUE MUESTRA LOS DATOS DE LAS CITAS
        public void mostrarCitas()
        {
            try
            {
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    var mostrarcita = (from cita in conexion.Citas
                                       join cliente in conexion.Clientes on
                                       cita.idcliente equals cliente.id
                                       join servicio in conexion.Servicios on
                                       cita.idservicio equals servicio.id
                                       join hora in conexion.Horacitas on
                                       cita.idhoracita equals hora.idhoracita
                                       join estado in conexion.Estadocitas on
                                       cita.idestadocita equals estado.idestadocita
                                       orderby cita.fecha
                                       select new
                                       {
                                           cita.idcita, //
                                           cita.fecha,
                                           hora.hora_inicio,
                                           hora.hora_fin,
                                           servicio.tipo,
                                           servicio.precio,
                                           cliente.id,  //
                                           cliente.nombrec,
                                           cliente.apellidoP,
                                           cliente.apellidoM,
                                           estado.estado
                                       });
                    dgvdatosCita.DataSource = mostrarcita.ToList();
                    dgvdatosCita.Columns[1].HeaderText = "Fecha";
                    dgvdatosCita.Columns[2].HeaderText = "Hora inicio";
                    dgvdatosCita.Columns[3].HeaderText = "Hora fin";
                    dgvdatosCita.Columns[4].HeaderText = "Tipo de servicio";
                    dgvdatosCita.Columns[5].HeaderText = "Precio";
                    dgvdatosCita.Columns[7].HeaderText = "Nombre del cliente";
                    dgvdatosCita.Columns[8].HeaderText = "Apellido Paterno";
                    dgvdatosCita.Columns[9].HeaderText = "Apellido Materno";
                    dgvdatosCita.Columns[10].HeaderText = "Estado de la cita";
                }
            }
            catch (Exception)
            {
                msgbody = "No se pudo visualizar";
                mensaje(msgbody);
            }
        }

        //FUNCION SWITCH PARA CRUD CITAS
        public void CRUDcitas()
        {
            switch (variablecita)
            {
                case 1:
                    try 
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Cita nuevacita = new Cita();
                            nuevacita.idcita = Guid.NewGuid();
                            nuevacita.fecha = DateTime.Parse(txtfechaCita.Text);
                            nuevacita.idhoracita = idhora;
                            nuevacita.idcliente = Guid.Parse(idcliente);
                            nuevacita.idservicio = Guid.Parse(idservicio);
                            nuevacita.idestadocita = estadocita;
                            conexion.Citas.Add(nuevacita);
                            conexion.SaveChanges();
                            id = nuevacita.idcita;
                            msgbody = "Cita agendada";
                            mensaje(msgbody);
                            mostrarCitas();
                            variabledecancel = 1;

                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "No se pudo agenda la cita";
                        mensaje(msgbody);
                    }
                    break;
                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Guid idcita = Guid.Parse(txtidCita.Text);
                            var modificarcita = (from cita in conexion.Citas where cita.idcita == idcita select cita).FirstOrDefault();
                            fecha = modificarcita.fecha;
                            idhoracita  = modificarcita.idhoracita;
                            idclientecancel = modificarcita.idcliente;
                            idserviciocancel = modificarcita.idservicio;
                            idestadocita = modificarcita.idestadocita;
                            if(modificarcita != null)
                            {
                                modificarcita.fecha = DateTime.Parse(txtfechaCita.Text); //no estoy seguro que sea así
                                modificarcita.idhoracita = idhora;
                                modificarcita.idcliente = Guid.Parse(idcliente);
                                modificarcita.idservicio = Guid.Parse(idservicio);
                                modificarcita.idestadocita = estadocita;
                                conexion.SaveChanges();
                                msgbody = "Cita modificada";
                                mensaje(msgbody);
                                mostrarCitas();
                                variabledecancel = 2;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Ocurrió un error al editar la cita";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        //METODO PARA CANCELAR LA INSERCIÓN DE LOS DATOS
        public void Canceloperación()
        {
            switch (variabledecancel)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            var cancelaroperacion = (from citas in conexion.Citas where citas.idcita == id select citas).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {
                                conexion.Citas.Remove(cancelaroperacion);
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                mostrarCitas();
                            }
                            else
                            {

                                msgbody = "No se pudo cancelar la operación";
                                mensaje(msgbody);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Ocurrió un error";
                        mensaje(msgbody);
                    }
                    break;
                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {

                            var cancelaroperacion = (from citas in conexion.Citas where citas.idcita == id select citas).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {

                                cancelaroperacion.fecha = fecha;
                                cancelaroperacion.idhoracita = idhora;
                                cancelaroperacion.idcliente = idclientecancel;
                                cancelaroperacion.idservicio = idserviciocancel;
                                cancelaroperacion.idestadocita = idestadocita;
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                mostrarCitas();

                            }
                            else
                            {
                                msgbody = "No se pudo cancelar la operación";
                                mensaje(msgbody);
                            }

                        }

                    }
                    catch (Exception)
                    {
                        msgbody = "Ocurrió un error";
                        mensaje(msgbody);
                    }
                    break;
            }
        }


        //METODO PARA VALIDAR LOS TEXBOX
        public void validarcamposCita()
        {
            var validarcampos = !string.IsNullOrEmpty(txtfechaCita.Text) &&
                !string.IsNullOrEmpty(txthorainicioCita.Text) &&
                !string.IsNullOrEmpty(txthorafinCita.Text) &&
                !string.IsNullOrEmpty(txttiposervicioCita.Text) &&
                !string.IsNullOrEmpty(txtprecioservicioCita.Text) &&
                !string.IsNullOrEmpty(txtnombreclienteCita.Text) &&
                !string.IsNullOrEmpty(txtapellidoclienteCita.Text) &&
                !string.IsNullOrEmpty(txtapellidomclienteCita.Text);
            iconbtnguardarCita.Enabled = validarcampos;

            if (iconbtnguardarCita.Enabled == false)
                iconbtnguardarCita.IconColor = Color.OrangeRed;
            else
                iconbtnguardarCita.IconColor = Color.DarkSeaGreen;

        }

        //FUNCION PARA FILTRAR DATOS A TRAVES DEL NOMBRE
        public void filtrarcliente(string nombre)
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var nombrecliente = nombre;
                var mostrarcitacliente = (from cita in conexion.Citas
                                          join cliente in conexion.Clientes on
                                          cita.idcliente equals cliente.id
                                          join servicio in conexion.Servicios on
                                          cita.idservicio equals servicio.id
                                          join hora in conexion.Horacitas on
                                          cita.idhoracita equals hora.idhoracita
                                          join estado in conexion.Estadocitas on
                                          cita.idestadocita equals estado.idestadocita
                                          where cliente.nombrec.Contains(nombrecliente)
                                          select new
                                          {
                                              cita.idcita,
                                              cita.fecha,
                                              hora.hora_inicio,
                                              hora.hora_fin,
                                              servicio.tipo,
                                              servicio.precio,
                                              cliente.id,
                                              cliente.nombrec,
                                              cliente.apellidoP,
                                              cliente.apellidoM,
                                              estado.estado
                                          }); ;
                dgvdatosCita.DataSource = mostrarcitacliente.ToList();
            }
        }

        //AGREGA LOS VALORES DEL DATAGRID A LOS TEXBOX
        

        private void dgvdatosCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidCita.Text = dgvdatosCita.SelectedCells[0].Value.ToString();
        }
        private void dgvdatosCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        //OCULTA EL ID DEL DATAGRID
        private void dgvdatosCita_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosCita.Columns[0].Visible = false;
            this.dgvdatosCita.Columns[6].Visible = false;
        }

        

        //CAMBIA EL FORMATO DE FECHA PARA PODER INSERTARLA EN LA BD
        private void dateTimefechaCita_ValueChanged(object sender, EventArgs e)
        {

            DateTime fechaingresada = DateTime.Parse(dateTimefechaCita.Text);
            if (fechaingresada >= fechadia)
            {
                String fecha = dateTimefechaCita.Value.ToString("yyyy-MM-dd");
                txtfechaCita.Text = fecha;
            }
            else
            {
                msgbody = "Ingrese la fecha de hoy o posterior a ella";
                mensaje(msgbody);
            }
        }


        
        //MUETRA LAS HORAS DISPONIBLES DE ACUERDO A LA FECHA INGRESADA
        
        private void iconbtnhoraCita_Click(object sender, EventArgs e)
        {
            FormHorario datos = new FormHorario();
            datos.txtfechi.Text = txtfechaCita.Text;
            datos.ControlBox = false;
            datos.Text = string.Empty;
            datos.StartPosition = FormStartPosition.Manual;
            datos.Location = new Point(300, 100);
            datos.BringToFront();
            datos.ShowDialog();
            idhora = Convert.ToInt32(datos.dgvdatosHorario.SelectedCells[0].Value.ToString());
            txthorainicioCita.Text = datos.dgvdatosHorario.SelectedCells[1].Value.ToString();
            txthorafinCita.Text = datos.dgvdatosHorario.SelectedCells[2].Value.ToString();
            msgbody = "Hora seleccionada";
            mensaje(msgbody);
        }

        //private void btbnservis_Click(object sender, EventArgs e)
        //{

        //}

        //AGREGA LOS SERVICIOS A LA CITA
        private void iconbtnservis_Click(object sender, EventArgs e)
        {
            FormServicios datos1 = new FormServicios();
            datos1.ControlBox = false;
            datos1.Text = string.Empty;
            datos1.StartPosition = FormStartPosition.Manual;
            datos1.Location = new Point(300, 100);
            datos1.BringToFront();
            datos1.ShowDialog();
            idservicio = datos1.dgvdatosServicio.SelectedCells[0].Value.ToString();
            txttiposervicioCita.Text = datos1.dgvdatosServicio.SelectedCells[1].Value.ToString();
            txtprecioservicioCita.Text = datos1.dgvdatosServicio.SelectedCells[2].Value.ToString();
            msgbody = "Servicio agregado";
            mensaje(msgbody);
        }



        //AGREGA EL CLIENTE A LA CITA
        private void iconbtnbuscarclienteCita_Click(object sender, EventArgs e)
        {
            FormCliente datos2 = new FormCliente();
            datos2.ControlBox = false;
            datos2.Text = string.Empty;
            datos2.StartPosition = FormStartPosition.Manual;
            datos2.Location = new Point(300, 100);
            datos2.BringToFront();
            datos2.ShowDialog();
            idcliente = datos2.dgvdatosCliente.SelectedCells[0].Value.ToString();
            txtnombreclienteCita.Text = datos2.dgvdatosCliente.SelectedCells[1].Value.ToString();
            txtapellidoclienteCita.Text = datos2.dgvdatosCliente.SelectedCells[2].Value.ToString();
            txtapellidomclienteCita.Text = datos2.dgvdatosCliente.SelectedCells[3].Value.ToString();
            msgbody = "Cliente agregado";
            mensaje(msgbody);
        }


        private void iconbtnagregardatosCita_Click(object sender, EventArgs e)
        {
            variablecita = 1;
            iconbtnagregardatosCita.IconColor = Color.DarkSeaGreen;
            iconbtnmodificarCita.Enabled = false;
            iconbtneliminarCita.Enabled = false;
        }


     
        private void iconbtnmodificarCita_Click(object sender, EventArgs e)
        {
            variablecita = 2;
            iconbtnmodificarCita.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosCita.Enabled = false;
            iconbtneliminarCita.Enabled = false;
        }


        private void iconbtneliminarCita_Click(object sender, EventArgs e)
        {
            Canceloperación();
            iconbtneliminarCita.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosCita.Enabled = false;
            iconbtnmodificarCita.Enabled = false;
        }


        private void iconbtnlimpiarCita_Click(object sender, EventArgs e)
        {
            iconbtnagregardatosCita.Enabled = true;
            iconbtnagregardatosCita.IconColor = Color.OrangeRed;
            iconbtnmodificarCita.Enabled = true;
            iconbtnmodificarCita.IconColor = Color.OrangeRed;
            iconbtneliminarCita.Enabled = true;
            iconbtneliminarCita.IconColor = Color.OrangeRed;
            txtidCita.Text = "";
            txtfechaCita.Text = "";
            txthorainicioCita.Text = "";
            txthorafinCita.Text = "";
            txttiposervicioCita.Text = "";
            txtprecioservicioCita.Text = "";
            txtnombreclienteCita.Text = "";
            txtapellidoclienteCita.Text = "";
            txtapellidomclienteCita.Text = "";
        }

        private void iconbtnguardarCita_Click(object sender, EventArgs e)
        {
            CRUDcitas();
            iconbtnagregardatosCita.Enabled = true;
            iconbtnagregardatosCita.IconColor = Color.OrangeRed;
            iconbtnmodificarCita.Enabled = true;
            iconbtnmodificarCita.IconColor = Color.OrangeRed;
            iconbtneliminarCita.Enabled = true;
            iconbtneliminarCita.IconColor = Color.OrangeRed;
            txtidCita.Text = "";
            txtfechaCita.Text = "";
            txthorainicioCita.Text = "";
            txthorafinCita.Text = "";
            txttiposervicioCita.Text = "";
            txtprecioservicioCita.Text = "";
            txtnombreclienteCita.Text = "";
            txtapellidoclienteCita.Text = "";
            txtapellidomclienteCita.Text = "";
        }

        //FILTRAR A TRAVES DE NOMBRE
        private void txtbuscarcita_KeyUp_1(object sender, KeyEventArgs e)
        {
            filtrarcliente(txtbuscarcita.Text);
        }

       
        private void txtfechaCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }
       

        private void txthorainicioCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }

        
        private void txthorafinCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }

        
        private void txttiposervicioCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }

        
        private void txtprecioservicioCita_TextChanged(object sender, EventArgs e)
        {
            validarcamposCita();
        }


      
        private void txtnombreclienteCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }

       
        private void txtapellidoclienteCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }

        
        private void txtapellidomclienteCita_TextChanged_1(object sender, EventArgs e)
        {
            validarcamposCita();
        }

        //INECESARIOS 
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void monthCita_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void txtfechaCita_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnbuscarservicioCita_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarcita_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconcerrarCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
