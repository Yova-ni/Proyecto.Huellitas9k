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
    public partial class FormVercitas : Form
    {
        public FormVercitas()
        {
            InitializeComponent();
        }

       
        int idestadocita = 0;
        int estadoswitch = 0;
        string fechasistema = DateTime.Now.ToString("yyyy-MM-dd");
        string msgbody = "";
        private void FormVercitas_Load(object sender, EventArgs e)
        {
            Visualizarcitas(fechasistema);
            cambiarcita();
            
        }

        //MENSAJES
        private void mensaje(string message1)
        {

            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }

        public void cambiarcita()
        {
            try
            {
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    conexion.Cambiarcita(DateTime.Parse(fechasistema));
                    conexion.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
        }

        //FUNCIONES
        public void buscarponombre(string nombre)
        {
            try
            {
                using(HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    //DateTime fecha2 = DateTime.Parse(fecha1);
                    var nombrecliente = nombre;
                    var mostraregistros = (from cita in conexion.Citas
                                           join cliente in conexion.Clientes on
                                           cita.idcliente equals cliente.id
                                           join servicio in conexion.Servicios on
                                           cita.idservicio equals servicio.id
                                           join hora in conexion.Horacitas on
                                           cita.idhoracita equals hora.idhoracita
                                           join estado in conexion.Estadocitas on
                                           cita.idestadocita equals estado.idestadocita
                                           where cliente.nombrec.Contains(nombrecliente) 
                                           orderby cita.fecha
                                           //cita.fecha == fecha2 &&
                                           select new
                                           {
                                               cita.idcita,
                                               cita.fecha,
                                               hora.hora_inicio,
                                               hora.hora_fin,
                                               cita.idservicio,
                                               servicio.tipo,
                                               servicio.precio,
                                               cliente.id,
                                               cliente.nombrec,
                                               cliente.apellidoP,
                                               cliente.apellidoM,
                                               estado.estado,
                                               cita.idestadocita
                                           }) ;
                    dgvverCitas.DataSource = mostraregistros.ToList();
                    dgvverCitas.Columns[1].HeaderText = "Fecha";
                    dgvverCitas.Columns[2].HeaderText = "Hora inicio";
                    dgvverCitas.Columns[3].HeaderText = "Hora fin";
                    dgvverCitas.Columns[5].HeaderText = "Tipo de servicio";
                    dgvverCitas.Columns[6].HeaderText = "Precio";
                    dgvverCitas.Columns[8].HeaderText = "Nombre del cliente";
                    dgvverCitas.Columns[9].HeaderText = "Apellido paterno";
                    dgvverCitas.Columns[10].HeaderText = "Apellido materno";
                    dgvverCitas.Columns[11].HeaderText = "Estado de la cita";
                    dgvverCitas.Columns[12].HeaderText = "Clave de la cita";
                }
            }
            catch (Exception)
            {
                msgbody = "No se pudo visualizar los datos";
                mensaje(msgbody);
            }
        }

        //FUNCION PARA BUSCAR MEDIANTE FECHA
        public void buscarcita(string fecha1)
        {
            try 
            {
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    DateTime fecha2 = DateTime.Parse(fecha1); 
                    var buscarcita = (from cita in conexion.Citas
                                      join cliente in conexion.Clientes on
                                      cita.idcliente equals cliente.id
                                      join servicio in conexion.Servicios on
                                      cita.idservicio equals servicio.id
                                      join hora in conexion.Horacitas on
                                      cita.idhoracita equals hora.idhoracita
                                      join estado in conexion.Estadocitas on
                                      cita.idestadocita equals estado.idestadocita
                                      where cita.fecha == fecha2 && cita.idestadocita == 1
                                      orderby cita.fecha 
                                      select new
                                      {
                                          cita.idcita,
                                          cita.fecha,
                                          hora.hora_inicio,
                                          hora.hora_fin,
                                          cita.idservicio,
                                          servicio.tipo,
                                          servicio.precio,
                                          cliente.id,
                                          cliente.nombrec,
                                          cliente.apellidoP,
                                          cliente.apellidoM,
                                          estado.estado,
                                          cita.idestadocita
                                      });
                    dgvverCitas.DataSource = buscarcita.ToList();
                    dgvverCitas.Columns[1].HeaderText = "Fecha";
                    dgvverCitas.Columns[2].HeaderText = "Hora inicio";
                    dgvverCitas.Columns[3].HeaderText = "Hora fin";
                    dgvverCitas.Columns[5].HeaderText = "Nombre del servicio";
                    dgvverCitas.Columns[6].HeaderText = "Precio";
                    dgvverCitas.Columns[8].HeaderText = "Nombre del cliente";
                    dgvverCitas.Columns[9].HeaderText = "Apellido paterno";
                    dgvverCitas.Columns[10].HeaderText = "Apellido materno";
                    dgvverCitas.Columns[11].HeaderText = "Estado";
                    dgvverCitas.Columns[12].HeaderText = "Clave cita";
                }
            }
            catch (Exception)
            {
                msgbody = "No existen citas para esta fecha";
                mensaje(msgbody);
            }
        }

        public void Visualizarcitas(string fecha1)
        {
            try
            {
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    DateTime fecha2 = DateTime.Parse(fecha1);
                    var buscarcita = (from cita in conexion.Citas
                                      join cliente in conexion.Clientes on
                                      cita.idcliente equals cliente.id
                                      join servicio in conexion.Servicios on
                                      cita.idservicio equals servicio.id
                                      join hora in conexion.Horacitas on
                                      cita.idhoracita equals hora.idhoracita
                                      join estado in conexion.Estadocitas on
                                      cita.idestadocita equals estado.idestadocita
                                      where cita.fecha == fecha2 
                                      orderby cita.fecha 
                                      select new
                                      {
                                          cita.idcita,
                                          cita.fecha,
                                          hora.hora_inicio,
                                          hora.hora_fin,
                                          cita.idservicio,
                                          servicio.tipo,
                                          servicio.precio,
                                          cliente.id,
                                          cliente.nombrec,
                                          cliente.apellidoP,
                                          cliente.apellidoM,
                                          estado.estado,
                                          cita.idestadocita
                                      });
                    dgvverCitas.DataSource = buscarcita.ToList();
                    dgvverCitas.Columns[1].HeaderText = "Fecha";
                    dgvverCitas.Columns[2].HeaderText = "Hora inicio";
                    dgvverCitas.Columns[3].HeaderText = "Hora fin";
                    dgvverCitas.Columns[5].HeaderText = "Nombre del servicio";
                    dgvverCitas.Columns[6].HeaderText = "Precio";
                    dgvverCitas.Columns[8].HeaderText = "Nombre del cliente";
                    dgvverCitas.Columns[9].HeaderText = "Apellido paterno";
                    dgvverCitas.Columns[10].HeaderText = "Apellido materno";
                    dgvverCitas.Columns[11].HeaderText = "Estado";
                    dgvverCitas.Columns[12].HeaderText = "Clave cita";
                }
            }
            catch (Exception)
            {
                msgbody = "No se pudo visualizar";
                mensaje(msgbody);
            }
        }



        //FUNCION PARA CAMBIAR EL ESTADO DE UNA CITA
        public void cambiarestadocita(int estadodelacita)
        {
                //CANCELADA
               
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            idestadocita = 4;
                            Guid id = Guid.Parse(txtclaveCita.Text);
                            var estadodecita = (from cita in conexion.Citas where cita.idcita == id & cita.idestadocita == 1  select cita).FirstOrDefault();  
                            if (estadodecita == null)
                            {
                                msgbody = "Solo puede modificar citas pendientes";
                                mensaje(msgbody);
                            }
                            
                            if (estadodecita != null)
                            {
                                var modificarestadocita = (from cita in conexion.Citas where cita.idcita == id select cita).FirstOrDefault();
                                modificarestadocita.idestadocita = idestadocita;
                                conexion.SaveChanges();
                                msgbody = "Cita cancelada";
                                mensaje(msgbody);
                                buscarcita(fechasistema);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Solo puede modificar citas pendientes";
                        mensaje(msgbody);
                    }
                   
            
        }
        //Carga el form de citas
        private void Nuevacita()
        {
            //Instancia a formulario cliente para obtener los datos
            FormCita abrir = new FormCita();
            abrir.ControlBox = false;
            abrir.Text = string.Empty;
            abrir.StartPosition = FormStartPosition.Manual;
            abrir.Location = new Point(300, 100);
            abrir.BringToFront();
            abrir.ShowDialog();
        }

        //CAMBIA EL FORMATO DE LA FECHA PARA PODER BUSCARLO EN LA BD
        private void dateTimeVerCitas_ValueChanged(object sender, EventArgs e)
        {
            string fecha = dateTimeVerCitas.Value.ToString("yyyy-MM-dd");
            txtfechaRegistro.Text = fecha;

        }

        //BUSCAR CITA POR FECHA
       
        private void iconbtnverCitas_Click(object sender, EventArgs e)
        {
            var fechi = txtfechaRegistro.Text;
            buscarcita(fechi);
        }
        //BUSCAR CITA POR NOMBRE DEL CLIENTE
        private void txtbuscarnombreCliente_KeyUp(object sender, KeyEventArgs e)
        {
            buscarponombre(txtbuscarnombreCliente.Text);
        }

        //AGREGAR NUEVA CITA
        private void iconbtnabrirformCita_Click(object sender, EventArgs e)
        {
            Nuevacita();
        }

        //MODIFICAR CITA
        private void iconbtnmodificarcita_Click(object sender, EventArgs e)
        {
            try
            {
                FormCita modificarcita = new FormCita();
                modificarcita.txtbuscarcita.Text = dgvverCitas.SelectedCells[8].Value.ToString();
                modificarcita.ControlBox = false;
                modificarcita.Text = string.Empty;
                modificarcita.StartPosition = FormStartPosition.Manual;
                modificarcita.Location = new Point(300, 100);
                modificarcita.BringToFront();
                modificarcita.ShowDialog();
            }
            catch (Exception)
            {
                msgbody = "Primero seleccione una cita";
                mensaje(msgbody);
            }
        }


        //OCULTA EL ID Y EL IDESTADOCITA
        private void dgvverCitas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvverCitas.Columns[0].Visible = false;
            this.dgvverCitas.Columns[4].Visible = false;
            this.dgvverCitas.Columns[7].Visible = false;


        }

        private void dgvverCitas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
                 
        }
        //Cambia el color dependiendo del estado
        private void dgvverCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvverCitas.Columns[e.ColumnIndex].Name == "Clave de la cita")
            {
                try
                {
                    //if (Convert.ToInt32(e.Value) == 1)
                    //{
                    //    dgvverCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow; 
                    //}
                    
                    //if(Convert.ToInt32(e.Value) == 2)
                    //{
                    //    dgvverCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    //}

                    //if(Convert.ToInt32(e.Value) == 3)
                    //{
                    //    dgvverCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    //}

                    if (Convert.ToInt32(e.Value) == 4)
                    {
                        dgvverCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
                catch (Exception)
                {
                    msgbody = "Ocurrió un error";
                    mensaje(msgbody);
                }
            }
        }

        private void dgvverCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtclaveCita.Text = dgvverCitas.SelectedCells[0].Value.ToString();
        }

        //BOTONES DE CAMBIO DE ESTADO
        private void btnEatendidaCita_Click(object sender, EventArgs e)
        {
            estadoswitch = 2;
            //cambiarestadocita(estadoswitch);
        }

        private void btnEpendienteCita_Click(object sender, EventArgs e)
        {
            estadoswitch = 1;
            //cambiarestadocita(estadoswitch);
        }

        private void btnEinasistenciaCita_Click(object sender, EventArgs e)
        {
            estadoswitch= 3;
            //cambiarestadocita(estadoswitch);
        }

        private void btnEcanceladaCita_Click(object sender, EventArgs e)
        {
            estadoswitch = 4;
            cambiarestadocita(estadoswitch);
        }
        //REFRESCA LOS DATOS
      
        private void iconbtnrefrescarCitas_Click(object sender, EventArgs e) //Aqui
        {
            buscarcita(fechasistema);
        }

        private void iconbtncitasHoy_Click(object sender, EventArgs e)
        {
            Visualizarcitas(fechasistema);
        }

        private void iconcerrarVerCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
