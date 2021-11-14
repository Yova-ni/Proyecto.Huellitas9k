using FontAwesome.Sharp;
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
    public partial class FormVentas : Form
    {
       
        public FormVentas()
        {
            InitializeComponent();
        }

        private struct RGBcolors
        {
            public static Color color1 = Color.DarkSeaGreen;
        }

       
        //VARIABLES
        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
        string hora = DateTime.Now.ToString("hh-mm-ss tt");
        string impuestoiva = "15%";
        double impuesto = 0.15;
        double totalservicioproducto = 0;
        double cantidadservicio = 0;
        double totalventa = 0;
        int estadoatendido = 2;
        string idcita;
        int variabledecancel = 0;
        Guid id;
        Guid idlista;
        string msgbody = "";
        private void FormVentas_Load(object sender, EventArgs e)
        {
            iconbtnagregarserviciolista.Enabled = false;
            iconbtnagregarLista.Enabled = false;
            txtfechadeldia.Text = fecha;
            txthoradeldia.Text = hora;
            //txtclaveCliente.Text = Convert.ToString(Guid.Empty);
            
        }

        //Metodos
        private void mensaje(string message1)
        {

            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }
        //VALIDAR LOS TEXTBOX DE LA CITA
        public void validartextcitas()
        {
            var validarcita = !string.IsNullOrEmpty(txtclaveCliente.Text) &&
                !string.IsNullOrEmpty(txtnombreCliente.Text) &&
                !string.IsNullOrEmpty(txtapellidoPCliente.Text) &&
                !string.IsNullOrEmpty(txtapellidoMCliente.Text) &&
                !string.IsNullOrEmpty(txtclaveServicio.Text) &&
                !string.IsNullOrEmpty(txttipoServicio.Text) &&
                !string.IsNullOrEmpty(txtprecioServicio.Text) &&
                !string.IsNullOrEmpty(txttipoServicio.Text) &&
                !string.IsNullOrEmpty(txtcantidadServicio.Text);
            iconbtnagregarserviciolista.Enabled = validarcita;

            if (iconbtnagregarserviciolista.Enabled == false)
                iconbtnagregarserviciolista.IconColor = Color.Black;
            else
                iconbtnagregarserviciolista.IconColor = Color.DarkSeaGreen;
            
        }

        // FUNCIÓN PARA VALIDAR TEXTBOX DE OTROS PRODUCTOS
        public void validartextproducservis()
        {
            var validarproservicios = !string.IsNullOrEmpty(txtclaveProductoServicio.Text) &&
                !string.IsNullOrEmpty(txtnombreProductoServicio.Text) &&
                !string.IsNullOrEmpty(txtprecioProductoServicio.Text) &&
                !string.IsNullOrEmpty(txtcantidadProductoServicio.Text);
            iconbtnagregarLista.Enabled = validarproservicios;

            if (iconbtnagregarLista.Enabled == false)
                iconbtnagregarLista.IconColor = Color.Black;
            else
                iconbtnagregarLista.IconColor = Color.DarkSeaGreen;
        }

        //FUNCION PARA GUARDAR LA VENTA EN LA BD
        public void guardarventa()
        {
            try
            {
                 int filas = Convert.ToInt32(dgvcobrarcitaProducto.RowCount.ToString());
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    Venta ventanueva = new Venta();
                    ventanueva.id = Guid.NewGuid();
                    ventanueva.fecha = DateTime.Parse(txtfechadeldia.Text);
                    ventanueva.hora = txthoradeldia.Text;
                    ventanueva.idcliente = Guid.Parse(txtclaveCliente.Text);
                    ventanueva.total = Convert.ToDecimal(totalventa);
                    conexion.Ventas.Add(ventanueva);
                    conexion.SaveChanges();
                    var idnew  = ventanueva.id;
                    id = idnew;
                  
                    List<Detalleventa> listaventa = new List<Detalleventa>();
                    foreach (DataGridViewRow dgvRow in dgvcobrarcitaProducto.Rows)
                    {
                        //Detalleventa detalle = new Detalleventa();
                        var detalle = new Detalleventa()
                        {
                            id = Guid.NewGuid(),
                            idventas = idnew,
                            idproductoservicio = Guid.Parse(dgvRow.Cells[0].Value.ToString()),
                            nombreprodservicio = Convert.ToString(dgvRow.Cells[1].Value),
                            precio = Convert.ToDecimal(dgvRow.Cells[2].Value),
                            cantidad = Convert.ToInt32(dgvRow.Cells[3].Value),
                            totalproducto = Convert.ToDecimal(dgvRow.Cells[6].Value)
                        };
                        listaventa.Add(detalle);
                    }
                    conexion.BulkInsert(listaventa.ToList());
                    msgbody = "Venta registrada";
                    mensaje(msgbody);
                    variabledecancel = 1;

                }
            }
            catch (Exception)
            {
                msgbody = "Venta no registrada";
                mensaje(msgbody);
            }
        }

       
        //FUNCION PARA LIMPIAR CAMPOS DEL CLIENTE Y SERVICIO
        public void limpiarclienteservicio()
        {
            txtclaveCliente.Text = "";
            txtnombreCliente.Text = "";
            txtapellidoPCliente.Text = "";
            txtapellidoMCliente.Text = "";
            txtclaveServicio.Text = "";
            txttipoServicio.Text = "";
            txtprecioServicio.Text = "";
            txtcantidadServicio.Text = "";
        }

        //FUNCION PARA LIMPIAR CAMPOS DEL PRODUCTO Y SERVICO
        public void limpiarproductoservicio()
        {
            txtclaveProductoServicio.Text = "";
            txtnombreProductoServicio.Text = "";
            txtprecioProductoServicio.Text = "";
            txtcantidadProductoServicio.Text = "";
        }

        //FUNCION PARA INICIAR UNA NUEVA VENTA
        public void nuevaventa()
        {
            txtclaveCliente.Text = "";
            txtnombreCliente.Text = "";
            txtapellidoPCliente.Text = "";
            txtapellidoMCliente.Text = "";
            txtclaveServicio.Text = "";
            txttipoServicio.Text = "";
            txtprecioServicio.Text = "";
            txtcantidadServicio.Text = "";
            txtclaveProductoServicio.Text = "";
            txtnombreProductoServicio.Text = "";
            txtprecioProductoServicio.Text = "";
            txtcantidadProductoServicio.Text = "";
            dgvcobrarcitaProducto.Rows.Clear();
            lbltotalventa.Text = "";
            txtefectivo.Text = "";
            lblcambioVenta.Text = "";

        }

        //FUNCION PARA VALIDAR IDCLIENTE
        public void validaidcliente()
        {
            if (string.IsNullOrEmpty(txtclaveCliente.Text))
            {
                txtclaveCliente.Text = Convert.ToString(Guid.Empty);
                
            }
        }

        //FUNCION PARA CAMBIAR ESTADO DE LA CITA DESPUES DE COBRAR
        public void Cambioestadocita(int idestadocita)
        {
            try
            {
                using (HuellitasEntities1 conexion = new HuellitasEntities1())
                {
                    
                    Guid id = Guid.Parse(idcita);
                    var modificarestadocita = (from cita in conexion.Citas where cita.idcita == id select cita).FirstOrDefault();
                    if (modificarestadocita != null)
                    {
                        modificarestadocita.idestadocita = idestadocita;
                        conexion.SaveChanges();
                        //MessageBox.Show("Estado modificado");
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("No se pudo modificar");
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
                            var cancelaroperacion = (from venta in conexion.Ventas where venta.id == id select venta).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {
                                conexion.Ventas.Remove(cancelaroperacion);
                                conexion.SaveChanges();
                                
                                var cancelaroperacion1 = (from detalleventa in conexion.Detalleventas where detalleventa.idventas == id select detalleventa).FirstOrDefault();
                                conexion.Detalleventas.Remove(cancelaroperacion1);
                                conexion.SaveChanges();
                                msgbody = "Venta cancelada";
                                mensaje(msgbody);
                            }
                            else
                            {

                                msgbody = "No se pudo cancelar la venta";
                                mensaje(msgbody);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "No se pudo cancelar la venta";
                        mensaje(msgbody);
                    }
                    break;
            }
        }

        //AGREGA LOS DATOS DE LA CITA A LOS TEXTBOX      
        private void iconbtnbuscarCita_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                FormVercitas invocar = new FormVercitas();
                invocar.ControlBox = false;
                invocar.Text = string.Empty;
                invocar.StartPosition = FormStartPosition.Manual;
                invocar.Location = new Point(300, 100);
                invocar.BringToFront();
                invocar.ShowDialog();
                idcita = invocar.dgvverCitas.SelectedCells[0].Value.ToString();
                txtclaveCliente.Text = invocar.dgvverCitas.SelectedCells[7].Value.ToString();
                txtnombreCliente.Text = invocar.dgvverCitas.SelectedCells[8].Value.ToString();
                txtapellidoPCliente.Text = invocar.dgvverCitas.SelectedCells[9].Value.ToString();
                txtapellidoMCliente.Text = invocar.dgvverCitas.SelectedCells[10].Value.ToString();
                txtclaveServicio.Text = invocar.dgvverCitas.SelectedCells[4].Value.ToString();
                txttipoServicio.Text = invocar.dgvverCitas.SelectedCells[5].Value.ToString();
                txtprecioServicio.Text = invocar.dgvverCitas.SelectedCells[6].Value.ToString();
            }
            catch (Exception)
            {
                msgbody = "No se pudo invocar la cita";
                mensaje(msgbody);
            }
        }

        //AGREGAR SOLO DATOS DEL CLIENTE AL TEXBOX
        private void iconbtnbuscarsoloCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormCliente invocar = new FormCliente();
                invocar.ControlBox = false;
                invocar.Text = string.Empty;
                invocar.StartPosition = FormStartPosition.Manual;
                invocar.Location = new Point(300, 100);
                invocar.BringToFront();
                invocar.ShowDialog();
                txtclaveCliente.Text = invocar.dgvdatosCliente.SelectedCells[0].Value.ToString();
                txtnombreCliente.Text = invocar.dgvdatosCliente.SelectedCells[1].Value.ToString();
                txtapellidoPCliente.Text = invocar.dgvdatosCliente.SelectedCells[2].Value.ToString();
                txtapellidoMCliente.Text = invocar.dgvdatosCliente.SelectedCells[3].Value.ToString();
            }
            catch (Exception)
            {
                msgbody = "No se pudo invocar los datos";
                mensaje(msgbody);
            }
        }

        //AGREGA CLIENTE Y SERVICIO A LA VENTA

      
        private void iconbtnagregarserviciolista_Click(object sender, EventArgs e)
        {
            cantidadservicio = Convert.ToDouble(txtcantidadServicio.Text);
            double subtotal = Convert.ToDouble(txtprecioServicio.Text) * cantidadservicio;
            double totaliva = subtotal * impuesto;
            totalservicioproducto = subtotal + totaliva;
            dgvcobrarcitaProducto.Rows.Add(txtclaveServicio.Text, txttipoServicio.Text, txtprecioServicio.Text, txtcantidadServicio.Text, subtotal,
                impuestoiva, totalservicioproducto);

            txtclaveServicio.Text = "";
            txttipoServicio.Text = "";
            txtprecioServicio.Text = "";
            txtcantidadServicio.Text = "";
        }


        //AGREGAR UN PRODUCTO A LOS TEXBOX
        private void iconbtnbuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FormProducto invocar = new FormProducto();
                invocar.ControlBox = false;
                invocar.Text = string.Empty;
                invocar.StartPosition = FormStartPosition.Manual;
                invocar.Location = new Point(300, 100);
                invocar.BringToFront();
                invocar.ShowDialog();
                txtclaveProductoServicio.Text = invocar.dgvdatosProducto.SelectedCells[0].Value.ToString();
                txtnombreProductoServicio.Text = invocar.dgvdatosProducto.SelectedCells[1].Value.ToString();
                txtprecioProductoServicio.Text = invocar.dgvdatosProducto.SelectedCells[4].Value.ToString();
            }
            catch (Exception)
            {
                msgbody = "Producto no agregado";
                mensaje(msgbody);
            }
        }

        //AGREGAR OTROS SERVICIOS A LOS TEXTBOX
        private void iconbtnagregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                FormServicios invocar = new FormServicios();
                invocar.ControlBox = false;
                invocar.Text = string.Empty;
                invocar.StartPosition = FormStartPosition.Manual;
                invocar.Location = new Point(300, 100);
                invocar.BringToFront();
                invocar.ShowDialog();
                txtclaveProductoServicio.Text = invocar.dgvdatosServicio.SelectedCells[0].Value.ToString();
                txtnombreProductoServicio.Text = invocar.dgvdatosServicio.SelectedCells[1].Value.ToString();
                txtprecioProductoServicio.Text = invocar.dgvdatosServicio.SelectedCells[2].Value.ToString();
            }
            catch (Exception)
            {
                msgbody = "Servicio no agregado";
                mensaje(msgbody);
            }
        }

        //AGREGA LOS PRODUCTOS O SERVICIOS A LA VENTA
        private void iconbtnagregarLista_Click(object sender, EventArgs e)
        {
            cantidadservicio = Convert.ToDouble(txtcantidadProductoServicio.Text);
            double subtotal = Convert.ToDouble(txtprecioProductoServicio.Text) * cantidadservicio;
            double totaliva = subtotal * impuesto;
            totalservicioproducto = subtotal + totaliva;
            dgvcobrarcitaProducto.Rows.Add(txtclaveProductoServicio.Text, txtnombreProductoServicio.Text, txtprecioProductoServicio.Text, txtcantidadProductoServicio.Text,
                subtotal, impuestoiva, totalservicioproducto);

            limpiarproductoservicio();
        }

        //ELIMINA DEL DATAGRID
        
        private void iconbtneliminarLista_Click(object sender, EventArgs e)
        {
            if (dgvcobrarcitaProducto.CurrentRow == null)
                return;
            dgvcobrarcitaProducto.Rows.Remove(dgvcobrarcitaProducto.CurrentRow);
        }

        //SUMA LOS TOTALES        
        private void iconbtntotalVenta_Click(object sender, EventArgs e)
        {
            validaidcliente();
            double suma = 0;
            foreach (DataGridViewRow row in dgvcobrarcitaProducto.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    suma += (Double)row.Cells["Total"].Value;
                }
                totalventa = suma;
                lbltotalventa.Text = "MXD $" + Convert.ToString(totalventa);
            }
        }

        //COBRAR        
        private void iconbtncobrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(totalventa);
                double efectivo = Convert.ToDouble(txtefectivo.Text);
                double cambio = efectivo - total;
                lblcambioVenta.Text = "MXD $" + Convert.ToString(cambio);
                guardarventa();
                Cambioestadocita(estadoatendido);

            }
            catch (Exception)
            {
                msgbody = "Llene bien los datos";
                mensaje(msgbody);
            }
            
        }


        //VALIDAR CADA TEXBOX
        private void txtclaveCliente_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtnombreCliente_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtapellidoPCliente_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtapellidoMCliente_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtclaveServicio_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txttipoServicio_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtprecioServicio_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtcantidadServicio_TextChanged(object sender, EventArgs e)
        {
            validartextcitas();
        }

        private void txtclaveProductoServicio_TextChanged(object sender, EventArgs e)
        {
            validartextproducservis();
        }

        private void txtnombreProductoServicio_TextChanged(object sender, EventArgs e)
        {
            validartextproducservis();
        }

        private void txtprecioProductoServicio_TextChanged(object sender, EventArgs e)
        {
            validartextproducservis();
        }

        private void txtcantidadProductoServicio_TextChanged(object sender, EventArgs e)
        {
            validartextproducservis();
        }

        //LIMPIAR CAMPOS POR BOTON      
        private void iconbtnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarclienteservicio();
        }

        private void iconbtnlimpiarproductosservis_Click(object sender, EventArgs e)
        {
            limpiarproductoservicio();
        }

        //LIMPIA TODO PARA INICIAR UNA NUEVA VENTA
        private void btnnuevaVenta_Click(object sender, EventArgs e)
        {
            nuevaventa();
        }

        //INECESARIOS
        private void dgvcobrarcitaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void dgvcobrarCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxVentas_Enter(object sender, EventArgs e)
        {

        }

        private void txthoradeldia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelarVenta_Click(object sender, EventArgs e)
        {
            Canceloperacion();
        }
    }
}
