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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        Guid id;
        int variabledecancel = 0;
        string nombre = "";
        string apellido = "";
        string apellidom = "";
        string direcccion = "";
        string email = "";
        string telefono = "";
        string msgbody = "";

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Mostrarclientes();
            iconbtnguardarCliente.Enabled = false;
        }
        //Inicializa en cero para el switch case
        int estado = 0;

        //Funciones
        private void mensaje(string message1)
        {

            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }
        //funcion para mostrar cliente
        public void Mostrarclientes()
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {

                var listaClientes = from clientes in conexion.Clientes
                select new
                {
                    clientes.id,
                    clientes.nombrec,
                    clientes.apellidoP,
                    clientes.apellidoM,
                    clientes.direccion,
                    clientes.email,
                    clientes.telefono
                    
                };
                                    

                dgvdatosCliente.DataSource = listaClientes.ToList();
                dgvdatosCliente.Columns[1].HeaderText = "Nombre del cliente";
                dgvdatosCliente.Columns[2].HeaderText = "Apellido Paterno";
                dgvdatosCliente.Columns[3].HeaderText = "Apellido Materno";
                dgvdatosCliente.Columns[4].HeaderText = "Dirección";
                dgvdatosCliente.Columns[5].HeaderText = "Email";
                dgvdatosCliente.Columns[6].HeaderText = "Telefono";
            }
        }

        //funcion para validar campos
        public void validarcamposcliente()
        {
            var validarcliente = !string.IsNullOrEmpty(txtnombreCliente.Text) &&
                !string.IsNullOrEmpty(txtapellidoCliente.Text) &&
                !string.IsNullOrEmpty(txtapellidomCliente.Text) &&
                !string.IsNullOrEmpty(txtdireccionCliente.Text) &&
                !string.IsNullOrEmpty(txtemailCliente.Text) &&
                !string.IsNullOrEmpty(txttelefonoCliente.Text);
            iconbtnguardarCliente.Enabled = validarcliente;

            if (iconbtnguardarCliente.Enabled == false)
                iconbtnguardarCliente.IconColor = Color.OrangeRed;
            else
                iconbtnguardarCliente.IconColor = Color.DarkSeaGreen;

        }

        //función CRUD
        public void CRUD()
        {
            switch(estado)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Cliente nuevocliente = new Cliente();
                            nuevocliente.id = Guid.NewGuid();
                            nuevocliente.nombrec = txtnombreCliente.Text;
                            nuevocliente.apellidoP = txtapellidoCliente.Text;
                            nuevocliente.apellidoM = txtapellidomCliente.Text;
                            nuevocliente.direccion = txtdireccionCliente.Text;
                            nuevocliente.email = txtemailCliente.Text;
                            nuevocliente.telefono = txttelefonoCliente.Text;
                            conexion.Clientes.Add(nuevocliente);
                            conexion.SaveChanges();
                            id = nuevocliente.id;
                            msgbody = "Cliente registrado";
                            mensaje(msgbody);
                            Mostrarclientes();
                            variabledecancel = 1;
                            
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Cliente no registrado";
                        mensaje(msgbody);
                    }
                    break;

                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Guid idcliente = Guid.Parse(txtidCliente.Text);
                            var consultadatoscliente = (from cliente in conexion.Clientes where cliente.id == idcliente select cliente).FirstOrDefault();
                            id = consultadatoscliente.id;
                            nombre = consultadatoscliente.nombrec;
                            apellido = consultadatoscliente.apellidoP;
                            apellidom = consultadatoscliente.apellidoM;
                            direcccion = consultadatoscliente.direccion;
                            email = consultadatoscliente.email;
                            telefono = consultadatoscliente.telefono;
                            if (consultadatoscliente != null)
                            {
                                consultadatoscliente.nombrec = txtnombreCliente.Text;
                                consultadatoscliente.apellidoP = txtapellidoCliente.Text;
                                consultadatoscliente.apellidoM = txtapellidomCliente.Text;
                                consultadatoscliente.direccion = txtdireccionCliente.Text;
                                consultadatoscliente.email = txtemailCliente.Text;
                                consultadatoscliente.telefono = txttelefonoCliente.Text;
                                conexion.SaveChanges();
                                msgbody = "Cliente modificado";
                                mensaje(msgbody);
                                Mostrarclientes();
                                variabledecancel = 2;

                            }
                            else
                            {
                                msgbody = "Cliente no encontrado";
                                mensaje(msgbody);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Cliente no modificado";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        //METODO PARA CANCELAR LA INSERCIÓN A LA MODIFICACIÓN DE LOS DATOS
        public void Canceloperación()
        {
            switch (variabledecancel)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            var cancelaroperacion = (from cliente in conexion.Clientes where cliente.id == id select cliente).FirstOrDefault();
                            if (cancelaroperacion != null)
                            { 
                                conexion.Clientes.Remove(cancelaroperacion);
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                Mostrarclientes();
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
                        msgbody = "No se pudo cancelar";
                        mensaje(msgbody);
                    }
                    break;
                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {

                            var cancelaroperacion = (from cliente in conexion.Clientes where cliente.id == id select cliente).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {

                                cancelaroperacion.nombrec = nombre;
                                cancelaroperacion.apellidoP = apellido;
                                cancelaroperacion.apellidoM = apellidom;
                                cancelaroperacion.direccion = direcccion;
                                cancelaroperacion.email = email;
                                cancelaroperacion.telefono = telefono;
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                Mostrarclientes();

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

        //oculta el id
        private void dgvdatosCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosCliente.Columns[0].Visible = false;
        }

        private void iconbtnguardarCliente_Click(object sender, EventArgs e)
        {
            CRUD();
            iconbtnagregardatosCliente.Enabled = true;
            iconbtnagregardatosCliente.IconColor = Color.OrangeRed;
            iconbtnmodificarCliente.Enabled = true;
            iconbtnmodificarCliente.IconColor = Color.OrangeRed;
            iconbtneliminarCliente.Enabled = true;
            iconbtneliminarCliente.IconColor = Color.OrangeRed;
            txtidCliente.Text = "";
            txtnombreCliente.Text = "";
            txtapellidoCliente.Text = "";
            txtapellidomCliente.Text = "";
            txtdireccionCliente.Text = "";
            txtemailCliente.Text = "";
            txttelefonoCliente.Text = "";
        }

       
        private void iconbtnagregardatosCliente_Click(object sender, EventArgs e)
        {
            estado = 1;
            iconbtnagregardatosCliente.IconColor = Color.DarkSeaGreen;
            iconbtnmodificarCliente.Enabled = false;
            iconbtneliminarCliente.Enabled = false;
        }

        private void txtnombreCliente_TextChanged(object sender, EventArgs e)
        {
            validarcamposcliente();
        }

        private void txtapellidoCliente_TextChanged(object sender, EventArgs e)
        {
            validarcamposcliente();
        }

        private void txtapellidomCliente_TextChanged(object sender, EventArgs e)
        {
            validarcamposcliente();
        }

        private void txtdireccionCliente_TextChanged(object sender, EventArgs e)
        {
            validarcamposcliente();
        }

        private void txtemailCliente_TextChanged(object sender, EventArgs e)
        {
            validarcamposcliente();
        }

        private void txttelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            validarcamposcliente();
        }

        //Al presionar el datagrid envia los datos a los textbox
        private void dgvdatosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidCliente.Text = dgvdatosCliente.SelectedCells[0].Value.ToString();
            txtnombreCliente.Text = dgvdatosCliente.SelectedCells[1].Value.ToString();
            txtapellidoCliente.Text = dgvdatosCliente.SelectedCells[2].Value.ToString();
            txtapellidomCliente.Text = dgvdatosCliente.SelectedCells[3].Value.ToString();
            txtdireccionCliente.Text = dgvdatosCliente.SelectedCells[4].Value.ToString();
            txtemailCliente.Text = dgvdatosCliente.SelectedCells[5].Value.ToString();
            txttelefonoCliente.Text = dgvdatosCliente.SelectedCells[6].Value.ToString();
        }

        
        private void iconbtnmodificarCliente_Click(object sender, EventArgs e)
        {
            estado = 2;
            iconbtnmodificarCliente.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosCliente.Enabled = false;
            iconbtneliminarCliente.Enabled = false;
        }

       
        private void iconPicturebtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Canceloperación();
            iconbtneliminarCliente.IconColor = Color.DarkSeaGreen;
            iconbtnagregardatosCliente.Enabled = false;
            iconbtnmodificarCliente.Enabled = false;
        }

        //private void btnrefrescar_Click(object sender, EventArgs e)
        //{
        //    Mostrarclientes();
        //}

       
        private void iconbtnlimpiarCliente_Click(object sender, EventArgs e)
        {
            iconbtnagregardatosCliente.Enabled = true;
            iconbtnagregardatosCliente.IconColor = Color.OrangeRed;
            iconbtnmodificarCliente.Enabled = true;
            iconbtnmodificarCliente.IconColor = Color.OrangeRed;
            iconbtneliminarCliente.Enabled = true;
            iconbtneliminarCliente.IconColor = Color.OrangeRed;
            txtidCliente.Text = "";
            txtnombreCliente.Text = "";
            txtapellidoCliente.Text = "";
            txtapellidomCliente.Text = "";
            txtdireccionCliente.Text = "";
            txtemailCliente.Text = "";
            txttelefonoCliente.Text = "";
        }

        //Filtra los registros de la bd a traves del nombre
        private void txtbuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var filtrardatoscliente = conexion.Clientes.SqlQuery("select * from Veter.Clientes where nombrec like ('" + txtbuscarCliente.Text + "%')");
                dgvdatosCliente.DataSource = filtrardatoscliente.ToList();
            }
        }

        private void txtbuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbuscarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void iconcerrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
