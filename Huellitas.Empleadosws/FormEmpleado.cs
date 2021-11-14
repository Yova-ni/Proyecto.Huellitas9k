using Huellitas.Empleadosws.Models;
using System;
using System.Collections;
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
    public partial class FormEmpleado : System.Windows.Forms.Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        //Inicia estadoempleado en 0;
        int estadoempleado = 0;
        int variabledecancel = 0;
        Guid id;
        string nombre = "";
        string apellidop = "";
        string apellidoM = "";
        string puesto = "";
        string msgbody = "";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        


        private void dgvdatosEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void mensaje(string message1)
        {
            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }

        //función para hacer la consulta a la bd
        public void MostrarEmpleados()
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                
                var listaEmpleados = from empleado in conexion.Empleados 
                select new
                {
                    empleado.id,
                    empleado.nombre,
                    empleado.apellidoP,
                    empleado.apellidoM,
                    empleado.puesto
                    
                };

                dgvdatosEmpleado.DataSource = listaEmpleados.ToList();
                //dgvdatosEmpleado.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(19, 19, 70);
                dgvdatosEmpleado.Columns[1].HeaderText = "Nombre del empleado";
                dgvdatosEmpleado.Columns[2].HeaderText = "Apellido Paterno";
                dgvdatosEmpleado.Columns[3].HeaderText = "Apellido Materno";
                dgvdatosEmpleado.Columns[4].HeaderText = "Puesto";
            }
        }
        //Funcion para valida textbox vacios
        public void validarcampos()
        {
            var validar = !string.IsNullOrEmpty(txtnombreEmpleado.Text) &&
                !string.IsNullOrEmpty(txtapellidoEmpleado.Text) &&
                !string.IsNullOrEmpty(txtapellidomEmpleado.Text) &&
                !string.IsNullOrEmpty(txtpuestoEmpleado.Text);
            iconPicturebtnguardarEmpleado.Enabled = validar;

            if (iconPicturebtnguardarEmpleado.Enabled == false)
                iconPicturebtnguardarEmpleado.IconColor = Color.OrangeRed;
            else
                iconPicturebtnguardarEmpleado.IconColor = Color.DarkSeaGreen;

        }

        //FuncióN CRUD EMPLEADO
        public void CRUDEMPLEADO()
        {
            switch (estadoempleado)
            {
                //Registrar un nuevo empleado
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Empleado nuevoempleado = new Empleado();
                            nuevoempleado.id = Guid.NewGuid();
                            nuevoempleado.nombre = txtnombreEmpleado.Text;
                            nuevoempleado.apellidoP = txtapellidoEmpleado.Text;
                            nuevoempleado.apellidoM = txtapellidomEmpleado.Text;
                            nuevoempleado.puesto = txtpuestoEmpleado.Text;
                            conexion.Empleados.Add(nuevoempleado);
                            conexion.SaveChanges();
                            id = nuevoempleado.id;
                            msgbody = "Empleado registrado con exito";
                            mensaje(msgbody);
                            MostrarEmpleados();
                            variabledecancel = 1;
                        }
                    }
                    catch (Exception)
                    {
                        string text1 = "Datos no registrados";
                        MessageBox.Show(text1);
                    }
                    break;
                
                //Modificar registro de empleado
                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Guid id1 = Guid.Parse(txtidEmpleado.Text);
                            var consultadatos = (from empleado in conexion.Empleados where empleado.id == id1 select empleado).FirstOrDefault();
                            id = consultadatos.id;
                            nombre = consultadatos.nombre;
                            apellidop = consultadatos.apellidoP;
                            apellidoM = consultadatos.apellidoM;
                            puesto = consultadatos.puesto;
                            if (consultadatos != null)
                            {
                                consultadatos.nombre = txtnombreEmpleado.Text;
                                consultadatos.apellidoP = txtapellidoEmpleado.Text;
                                consultadatos.apellidoM = txtapellidomEmpleado.Text;
                                consultadatos.puesto = txtpuestoEmpleado.Text;
                                conexion.SaveChanges();
                                msgbody = "Datos modificados con éxito";
                                mensaje(msgbody);
                                MostrarEmpleados();
                                variabledecancel = 2;

                            }
                            else
                            {
                                msgbody = "No se encontró el registro";
                                mensaje(msgbody);
                            }
                            id = id1;
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Datos no registrados";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        public void Canceloperación()
        {
            switch (variabledecancel)
            {
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            var eliminardatos = (from empleado in conexion.Empleados where empleado.id == id select empleado).FirstOrDefault();
                                        if (eliminardatos != null)
                                        {
                                            conexion.Empleados.Remove(eliminardatos);
                                            conexion.SaveChanges();
                                            msgbody = "Operación cancelada";
                                            mensaje(msgbody);
                                            MostrarEmpleados();
                                        }
                                        else
                                       {
                                            msgbody = "No se puedo Cancelar";
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
                            
                                var consultadatos = (from empleado in conexion.Empleados where empleado.id == id select empleado).FirstOrDefault();
                                if (consultadatos != null)
                                {
                                   
                                        consultadatos.nombre = nombre;
                                        consultadatos.apellidoP = apellidop;
                                        consultadatos.apellidoM = apellidoM;
                                        consultadatos.puesto = puesto;
                                        conexion.SaveChanges();
                                        msgbody = "Operación cancelad";
                                        mensaje(msgbody);
                                        MostrarEmpleados();
                                    
                                }
                                else
                                {
                                    msgbody = "No se pudo modificar";
                                    mensaje(msgbody);
                                }
                            
                        }
                        
                    }
                    catch (Exception)
                    {
                        msgbody = "Ocurrio un error";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        //Evento load manda a llamar a la función mostrarempleado cada que se carga el form
        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            iconPicturebtnguardarEmpleado.Enabled = false;
            

        }
        //Al seleccionar una fila los datos se agregan a los textbox
        private void dgvdatosEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidEmpleado.Text = dgvdatosEmpleado.SelectedCells[0].Value.ToString();
            txtnombreEmpleado.Text = dgvdatosEmpleado.SelectedCells[1].Value.ToString();
            txtapellidoEmpleado.Text = dgvdatosEmpleado.SelectedCells[2].Value.ToString();
            txtapellidomEmpleado.Text = dgvdatosEmpleado.SelectedCells[3].Value.ToString();
            txtpuestoEmpleado.Text = dgvdatosEmpleado.SelectedCells[4].Value.ToString();
        }

        //Agrega los datos a la bd
        //private void btnagregarEmpleado_Click(object sender, EventArgs e)
        //{


        //}
        private void iconPicturebtnAgregarEmpleado_Click(object sender, EventArgs e) //Agregar empleado
        {
            estadoempleado = 1;
            iconPicturebtnAgregarEmpleado.IconColor = Color.DarkSeaGreen;
            iconbtnmodificarEmpleado.Enabled = false;
            iconPicturebtnEliminarEmpleado.Enabled = false;
        }

        private void iconbtnmodificarEmpleado_Click(object sender, EventArgs e)
        {
            estadoempleado = 2;
            iconbtnmodificarEmpleado.IconColor = Color.DarkSeaGreen;
            iconPicturebtnAgregarEmpleado.Enabled = false;
            iconPicturebtnEliminarEmpleado.Enabled = false;
        }

        //oculta la columna id en el datagrid
        private void dgvdatosEmpleado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosEmpleado.Columns[0].Visible = false;
        }

       
        private void iconPicturebtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Canceloperación();
            iconPicturebtnEliminarEmpleado.IconColor = Color.DarkSeaGreen;
            iconPicturebtnAgregarEmpleado.Enabled = false;
            iconbtnmodificarEmpleado.Enabled = false;
        }


        private void iconbtnlimpiarEmpleado_Click(object sender, EventArgs e)
        {
            iconPicturebtnAgregarEmpleado.Enabled = true;
            iconPicturebtnAgregarEmpleado.IconColor = Color.OrangeRed;
            iconPicturebtnEliminarEmpleado.Enabled = true;
            iconPicturebtnEliminarEmpleado.IconColor = Color.OrangeRed;
            iconbtnmodificarEmpleado.Enabled = true;
            iconbtnmodificarEmpleado.IconColor = Color.OrangeRed;
            txtidEmpleado.Text = "";
            txtnombreEmpleado.Text = "";
            txtapellidoEmpleado.Text = "";
            txtapellidomEmpleado.Text = "";
            txtpuestoEmpleado.Text = "";
        }

        private void iconbtnrecargarEmpleado_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
            iconPicturebtnAgregarEmpleado.Enabled = true;
            iconbtnmodificarEmpleado.Enabled = true;
            iconPicturebtnEliminarEmpleado.Enabled = true;
        }
        //Filtra los datos mediante el textboxbuscarEmpleado
        private void txtbuscarEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var filtrardatos = conexion.Empleados.SqlQuery("select * from Veter.Empleados where nombre like ('" + txtbuscarEmpleado.Text + "%')");
                dgvdatosEmpleado.DataSource = filtrardatos.ToList();
            }   
        }

        private void txtnombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtapellidoEmpleado_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtapellidomEmpleado_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtpuestoEmpleado_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

       

        private void iconPicturebtnguardarEmpleado_Click(object sender, EventArgs e)
        {
            CRUDEMPLEADO();
            iconPicturebtnAgregarEmpleado.Enabled = true;
            iconPicturebtnAgregarEmpleado.IconColor = Color.OrangeRed;
            iconbtnmodificarEmpleado.Enabled = true;
            iconbtnmodificarEmpleado.IconColor = Color.OrangeRed;
            iconPicturebtnEliminarEmpleado.Enabled = true;
            iconPicturebtnEliminarEmpleado.IconColor = Color.OrangeRed;
            txtidEmpleado.Text = "";
            txtnombreEmpleado.Text = "";
            txtapellidoEmpleado.Text = "";
            txtapellidomEmpleado.Text = "";
            txtpuestoEmpleado.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
