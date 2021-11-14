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
    public partial class FormMascotas : Form
    {
        //private Form formsecundario;
        public FormMascotas()
        {
            InitializeComponent();
        }
       

        //Variable que inicia el switch
        int estadomascota = 0;
        int variabledecancel = 0;
        Guid id;
        string nombre = "";
        string especie = "";
        string raza = "";
        string sexo = "";
        int edad = 0;
        Guid idcliente;
        string msgbody = "";
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormMascotas_Load(object sender, EventArgs e)
        {
            mostrarMascotas();
            iconbtnguardarMascota.Enabled = false;
        }

        private void mensaje(string message1)
        {

            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }

        //Función para visualizar mascotas
        public void mostrarMascotas()
        {
            try
            {
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    var mostramascotas = (from mascota in conexion.Mascotas
                                          join cliente in conexion.Clientes on
                                          mascota.idcliente equals cliente.id
                                          select new
                                          {
                                              mascota.id,
                                              mascota.nombre,
                                              mascota.especie,
                                              mascota.raza,
                                              mascota.sexo,
                                              mascota.edad,
                                              mascota.idcliente,
                                              cliente.nombrec,
                                              cliente.apellidoP,
                                              cliente.apellidoM
                                          });
                    dgvdatosMascota.DataSource = mostramascotas.ToList();
                    dgvdatosMascota.Columns[1].HeaderText = "Nombre de la mascota";
                    dgvdatosMascota.Columns[2].HeaderText = "Especie";
                    dgvdatosMascota.Columns[3].HeaderText = "Raza";
                    dgvdatosMascota.Columns[4].HeaderText = "Sexo";
                    dgvdatosMascota.Columns[5].HeaderText = "Edad";
                    dgvdatosMascota.Columns[7].HeaderText = "Nombre del cliente";
                    dgvdatosMascota.Columns[8].HeaderText = "Apellido Paterno";
                    dgvdatosMascota.Columns[9].HeaderText = "Apellido Materno";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        //Función CRUD Mascotas
        public void CRUDmascota()
        {
            switch (estadomascota)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            //Guid idclientemascota = Guid.Parse(txtidclienteMascota.Text);
                            Mascota nuevamascota = new Mascota();
                            nuevamascota.id = Guid.NewGuid();
                            nuevamascota.nombre = txtnombreMascota.Text;
                            nuevamascota.especie = txtespecieMascota.Text;
                            nuevamascota.raza = txtrazaMascota.Text;
                            nuevamascota.sexo = txtsexoMascota.Text;
                            nuevamascota.edad = Convert.ToInt32(txtedadMascota.Text);
                            nuevamascota.idcliente = Guid.Parse(txtidclienteMascota.Text);
                            conexion.Mascotas.Add(nuevamascota);
                            conexion.SaveChanges();
                            id = nuevamascota.id;
                            msgbody = "Mascota registrada";
                            mensaje(msgbody);
                            mostrarMascotas();
                            variabledecancel = 1;
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Mascota no registrada";
                        mensaje(msgbody);
                    }
                    break;
                case 2:
                    try {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Guid idmascota = Guid.Parse(txtidMascota.Text);
                            var modificarmascota = (from mascota in conexion.Mascotas where mascota.id == idmascota select mascota).FirstOrDefault();
                            id = modificarmascota.id;
                            nombre= modificarmascota.nombre;
                            especie = modificarmascota.especie;
                            raza = modificarmascota.raza;
                            sexo = modificarmascota.sexo;
                            edad = modificarmascota.edad;
                            idcliente = modificarmascota.idcliente;
                            if(modificarmascota != null)
                            {
                                modificarmascota.nombre = txtnombreMascota.Text;
                                modificarmascota.especie = txtespecieMascota.Text;
                                modificarmascota.raza = txtrazaMascota.Text;
                                modificarmascota.sexo = txtsexoMascota.Text;
                                modificarmascota.edad = Convert.ToInt32(txtedadMascota.Text);
                                modificarmascota.idcliente = Guid.Parse(txtidclienteMascota.Text);
                                conexion.SaveChanges();
                                msgbody = "Datos modificados";
                                mensaje(msgbody);
                                mostrarMascotas();
                                variabledecancel = 2;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Datos no modificados";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        //METODO PARA CANCELAR LAS OPERACIONES INSERT Y UPDATE
        public void Canceloperacion()
        {
            switch (variabledecancel)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            var cancelaroperacion = (from mascota in conexion.Mascotas where mascota.id == id select mascota).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {
                                conexion.Mascotas.Remove(cancelaroperacion);
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                mostrarMascotas();
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

                            var cancelaroperacion = (from mascota in conexion.Mascotas where mascota.id == id select mascota).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {

                                cancelaroperacion.nombre = nombre;
                                cancelaroperacion.especie = especie;
                                cancelaroperacion.raza = raza;
                                cancelaroperacion.sexo = sexo;
                                cancelaroperacion.edad = edad;
                                cancelaroperacion.idcliente = idcliente;
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                mostrarMascotas();

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
                        msgbody = "No se pudo modificar";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        //Función para validar los textbox
        public void validamascotastxt()
        {
            var validarmascota = !string.IsNullOrEmpty(txtnombreMascota.Text) &&
                !string.IsNullOrEmpty(txtespecieMascota.Text) &&
                !string.IsNullOrEmpty(txtrazaMascota.Text) &&
                !string.IsNullOrEmpty(txtsexoMascota.Text) &&
                !string.IsNullOrEmpty(txtedadMascota.Text) &&
                !string.IsNullOrEmpty(txtidclienteMascota.Text);
            iconbtnguardarMascota.Enabled = validarmascota;

            if (iconbtnguardarMascota.Enabled == false)
                iconbtnguardarMascota.IconColor = Color.OrangeRed;
            else
                iconbtnguardarMascota.IconColor = Color.DarkSeaGreen;

        }

        private void mostrarcliente()
        {
            //Instancia a formulario cliente para obtener los datos
            FormCliente datos = new FormCliente();
            datos.ControlBox = false;
            datos.Text = string.Empty;
            datos.StartPosition = FormStartPosition.Manual;
            datos.Location = new Point(300, 100);
            datos.BringToFront();
            datos.ShowDialog();
            txtidclienteMascota.Text = datos.dgvdatosCliente.SelectedCells[0].Value.ToString();

            msgbody = "Cliente seleccionado";
            mensaje(msgbody);
        }


        //obtiene los datos de otra tabla
        private void iconbtnbuscarclienteMascota_Click(object sender, EventArgs e)
        {
            mostrarcliente();
        }

        private void iconbtnayudacliente_Click(object sender, EventArgs e)
        {
            msgbody = "Seleccione un cliente y cierre la ventana";
            mensaje(msgbody);
        }

        //Ocultar el id de la mascota
        private void dgvdatosMascota_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosMascota.Columns[0].Visible = false;
            this.dgvdatosMascota.Columns[6].Visible = false;
        }

        //Agrega los valores del datagrid a los textbox
        private void dgvdatosMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidMascota.Text = dgvdatosMascota.SelectedCells[0].Value.ToString();
            txtnombreMascota.Text = dgvdatosMascota.SelectedCells[1].Value.ToString();
            txtespecieMascota.Text = dgvdatosMascota.SelectedCells[2].Value.ToString();
            txtrazaMascota.Text = dgvdatosMascota.SelectedCells[3].Value.ToString();
            txtsexoMascota.Text = dgvdatosMascota.SelectedCells[4].Value.ToString();
            txtedadMascota.Text = dgvdatosMascota.SelectedCells[5].Value.ToString();
            txtidclienteMascota.Text = dgvdatosMascota.SelectedCells[6].Value.ToString();
        }

        private void iconbtnguardarMascota_Click(object sender, EventArgs e)
        {
            CRUDmascota();
            iconbtnagregardatosMascota.Enabled = true;
            iconbtnagregardatosMascota.IconColor = Color.OrangeRed;
            iconbtnmodificarMascota.Enabled = true;
            iconbtnmodificarMascota.IconColor = Color.OrangeRed;
            iconbtneliminarMascota.Enabled = true;
            iconbtneliminarMascota.IconColor = Color.OrangeRed;
            txtidMascota.Text = "";
            txtnombreMascota.Text = "";
            txtespecieMascota.Text = "";
            txtrazaMascota.Text = "";
            txtsexoMascota.Text = "";
            txtedadMascota.Text = "";
            txtidclienteMascota.Text = "";
        }


        private void iconbtnagregardatosMascota_Click(object sender, EventArgs e) 
        {
            estadomascota = 1;
            iconbtnagregardatosMascota.IconColor = Color.DarkSeaGreen;
            iconbtnmodificarMascota.Enabled = false;
            iconbtneliminarMascota.Enabled = false;
        }
        
        private void iconbtnmodificarMascota_Click(object sender, EventArgs e)
        {
            estadomascota = 2;
            iconbtnmodificarMascota.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosMascota.Enabled = false;
            iconbtneliminarMascota.Enabled = false;
        }

        private void iconbtneliminarMascota_Click(object sender, EventArgs e)
        {
            Canceloperacion();
            iconbtneliminarMascota.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosMascota.Enabled = false;
            iconbtnmodificarMascota.Enabled = true;
        }

        
        private void iconbtnlimpiarMascota_Click(object sender, EventArgs e)
        {
            iconbtnagregardatosMascota.Enabled = true;
            iconbtnagregardatosMascota.IconColor = Color.OrangeRed;
            iconbtnmodificarMascota.Enabled = true;
            iconbtnmodificarMascota.IconColor = Color.OrangeRed;
            iconbtneliminarMascota.Enabled = true;
            iconbtneliminarMascota.IconColor = Color.OrangeRed;
            txtidMascota.Text = "";
            txtnombreMascota.Text = "";
            txtespecieMascota.Text = "";
            txtrazaMascota.Text = "";
            txtsexoMascota.Text = "";
            txtedadMascota.Text = "";
            txtidclienteMascota.Text = "";
        }


        private void txtnombreMascota_TextChanged(object sender, EventArgs e)
        {
            validamascotastxt();
        }

        private void txtespecieMascota_TextChanged(object sender, EventArgs e)
        {
            validamascotastxt();
        }

        private void txtrazaMascota_TextChanged(object sender, EventArgs e)
        {
            validamascotastxt();
        }

        private void txtsexoMascota_TextChanged(object sender, EventArgs e)
        {
            validamascotastxt();
        }

        private void txtedadMascota_TextChanged(object sender, EventArgs e)
        {
            validamascotastxt();
        }

        private void txtidclienteMascota_TextChanged(object sender, EventArgs e)
        {
            validamascotastxt();
        }

        private void txtbuscarMascota_KeyUp(object sender, KeyEventArgs e)
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var filtrardatosmascota = conexion.Mascotas.SqlQuery("select * from Veter.Mascotas where nombre like ('" + txtbuscarMascota.Text + "%')");
                dgvdatosMascota.DataSource = filtrardatosmascota.ToList();
            }
        }

        
    }
 }

