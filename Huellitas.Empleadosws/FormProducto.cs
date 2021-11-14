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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }
        int variabledecancel = 0;
        Guid id;
        string nombre = "";
        string marca = "";
        string descripcion = "";
        decimal precio = 0;
        int stock = 0;
        string msgbody = "";

        private void FormProducto_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            iconbtnguardarProducto.Enabled = false;
            foreach (DataGridViewColumn column in dgvdatosProducto.Columns)
            {
                column.Width = 120;
            }
        }

        //VARIABLE PARA ACCEDER AL SWITCH
        int estadoproducto = 0;
        private void mensaje(string message1)
        {

            FormMensaje msg = new FormMensaje();
            msg.lblMensaje.Text = message1;
            //msg.TopLevel = false;
            msg.BringToFront();
            msg.ShowDialog();
        }

        //Función para visualizar los productos
        public void mostrarProductos()
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1()) 
            {
                var listaproductos = from productos in conexion.Productos
                                     select new
                                     {
                                         productos.id,
                                         productos.nombre,
                                         productos.marca,
                                         productos.descripcion,
                                         productos.precio,
                                         productos.stock
                                     };
                dgvdatosProducto.DataSource = listaproductos.ToList();
                dgvdatosProducto.Columns[1].HeaderText = "Nombre del producto";
                dgvdatosProducto.Columns[2].HeaderText = "Marca";
                dgvdatosProducto.Columns[3].HeaderText = "Descripción";
                dgvdatosProducto.Columns[4].HeaderText = "Precio";
                dgvdatosProducto.Columns[5].HeaderText = "Stock";
            }
        }

        //Función CRUD productos
        public void CRUDproductos()
        {
            switch (estadoproducto)
            {
                //Insertar productos
                case 1:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Producto nuevoproducto = new Producto();
                            nuevoproducto.id = Guid.NewGuid();
                            nuevoproducto.nombre = txtnombreProducto.Text;
                            nuevoproducto.marca = txtmarcaProducto.Text;
                            nuevoproducto.descripcion = txtdescripcionProducto.Text;
                            nuevoproducto.precio = Convert.ToInt32(txtprecioProducto.Text);
                            nuevoproducto.stock = Convert.ToInt32(txtstockProducto.Text);
                            conexion.Productos.Add(nuevoproducto);
                            conexion.SaveChanges();
                            id = nuevoproducto.id;
                            msgbody = "Producto registrado";
                            mensaje(msgbody);
                            mostrarProductos();
                            variabledecancel = 1;
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Producto no registrado";
                        mensaje(msgbody);
                    }
                    break;
                //Modificar productos
                case 2:
                    try
                    {
                        using (HuellitasEntities1 conexion = new HuellitasEntities1())
                        {
                            Guid idproducto = Guid.Parse(txtidProducto.Text);
                            var consultaproducto = (from productos in conexion.Productos where productos.id == idproducto select productos).FirstOrDefault();
                            id = consultaproducto.id;
                            nombre = consultaproducto.nombre;
                            marca = consultaproducto.marca;
                            descripcion = consultaproducto.descripcion;
                            precio = consultaproducto.precio;
                            stock = consultaproducto.stock;
                            if(consultaproducto != null)
                            {
                                consultaproducto.nombre = txtnombreProducto.Text;
                                consultaproducto.marca = txtmarcaProducto.Text;
                                consultaproducto.descripcion = txtdescripcionProducto.Text;
                                consultaproducto.precio = Convert.ToInt32(txtprecioProducto.Text);
                                consultaproducto.stock = Convert.ToInt32(txtstockProducto.Text);
                                conexion.SaveChanges();
                                msgbody = "Producto modificado";
                                mensaje(msgbody);
                                mostrarProductos();
                                variabledecancel = 2;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        msgbody = "Producto no modificado";
                        mensaje(msgbody);
                    }
                    break;
                //Eliminar productos
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
                            var cancelaroperacion = (from producto in conexion.Productos where producto.id == id select producto).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {
                                conexion.Productos.Remove(cancelaroperacion);
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                mostrarProductos();
                            }
                            else
                            {

                                msgbody = "No se puedo cancelar";
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

                            var cancelaroperacion = (from producto in conexion.Productos where producto.id == id select producto).FirstOrDefault();
                            if (cancelaroperacion != null)
                            {

                                cancelaroperacion.nombre = nombre;
                                cancelaroperacion.marca = marca;
                                cancelaroperacion.descripcion = descripcion;
                                cancelaroperacion.precio = precio;
                                cancelaroperacion.stock = stock;
                                conexion.SaveChanges();
                                msgbody = "Operación cancelada";
                                mensaje(msgbody);
                                mostrarProductos();

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

        //Función para validar los textbox
        public void validarcamposProducto()
        {
            var validarproducto = !string.IsNullOrEmpty(txtnombreProducto.Text) &&
                !string.IsNullOrEmpty(txtmarcaProducto.Text) &&
                !string.IsNullOrEmpty(txtdescripcionProducto.Text) &&
                !string.IsNullOrEmpty(txtprecioProducto.Text) &&
                !string.IsNullOrEmpty(txtstockProducto.Text);
            iconbtnguardarProducto.Enabled = validarproducto;

            if (iconbtnguardarProducto.Enabled == false) //Cambia los colores solo si los textbox estan llenos
                iconbtnguardarProducto.IconColor = Color.OrangeRed;
            else
                iconbtnguardarProducto.IconColor = Color.DarkSeaGreen;
        }
        
        private void iconbtnagregarProducto_Click(object sender, EventArgs e)
        {
            estadoproducto = 1;
            iconbtnagregarProducto.IconColor = Color.DarkSeaGreen;
            iconbtnmodificarProducto.Enabled = false;
            iconbtneliminarProducto.Enabled = false;
        }

       
        private void iconbtnmodificarProducto_Click(object sender, EventArgs e)
        {
            estadoproducto = 2;
            iconbtnmodificarProducto.IconColor = Color.DarkSeaGreen;
            iconbtnagregarProducto.Enabled = false;
            iconbtneliminarProducto.Enabled = false;
        }

        private void iconbtneliminarProducto_Click(object sender, EventArgs e)
        {
            Canceloperacion();
            iconbtneliminarProducto.IconColor = Color.DarkSeaGreen;
            iconbtnagregarProducto.Enabled = false;
            iconbtnmodificarProducto.Enabled = false;
        }

       
        private void iconbtnguardarProducto_Click(object sender, EventArgs e)
        {
            CRUDproductos();
            iconbtnagregarProducto.Enabled = true;
            iconbtnagregarProducto.IconColor = Color.OrangeRed;
            iconbtnmodificarProducto.Enabled = true;
            iconbtnmodificarProducto.IconColor = Color.OrangeRed;
            iconbtneliminarProducto.Enabled = true;
            iconbtneliminarProducto.IconColor = Color.OrangeRed;
            txtidProducto.Text = "";
            txtnombreProducto.Text = "";
            txtmarcaProducto.Text = "";
            txtdescripcionProducto.Text = "";
            txtprecioProducto.Text = "";
            txtstockProducto.Text = "";
        }

        private void iconbtnlimpiarProducto_Click(object sender, EventArgs e)
        {
            txtidProducto.Text = "";
            txtnombreProducto.Text = "";
            txtmarcaProducto.Text = "";
            txtdescripcionProducto.Text = "";
            txtprecioProducto.Text = "";
            txtstockProducto.Text = "";
            iconbtnagregarProducto.Enabled = true;
            iconbtnagregarProducto.IconColor = Color.OrangeRed;
            iconbtnmodificarProducto.Enabled = true;
            iconbtnmodificarProducto.IconColor = Color.OrangeRed;
            iconbtneliminarProducto.Enabled = true;
            iconbtneliminarProducto.IconColor = Color.OrangeRed;
        }


        //OCULTAR EL ID DEL DATAGRID
        private void dgvdatosProducto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosProducto.Columns[0].Visible = false;
        }

        private void dgvdatosProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidProducto.Text = dgvdatosProducto.SelectedCells[0].Value.ToString();
            txtnombreProducto.Text = dgvdatosProducto.SelectedCells[1].Value.ToString();
            txtmarcaProducto.Text = dgvdatosProducto.SelectedCells[2].Value.ToString();
            txtdescripcionProducto.Text = dgvdatosProducto.SelectedCells[3].Value.ToString();
            txtprecioProducto.Text = dgvdatosProducto.SelectedCells[4].Value.ToString();
            txtstockProducto.Text = dgvdatosProducto.SelectedCells[5].Value.ToString();
        }

        private void txtbuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var filtrardatos = conexion.Productos.SqlQuery("select * from Veter.Productos where nombre like ('" + txtbuscarProducto.Text + "%')");
                dgvdatosProducto.DataSource = filtrardatos.ToList();
            }
        }

        private void txtnombreProducto_TextChanged(object sender, EventArgs e)
        {
            validarcamposProducto();
        }

        private void txtmarcaProducto_TextChanged(object sender, EventArgs e)
        {
            validarcamposProducto();
        }

        private void txtdescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            validarcamposProducto();
        }

        private void txtprecioProducto_TextChanged(object sender, EventArgs e)
        {
            validarcamposProducto();
        }

        private void txtstockProducto_TextChanged(object sender, EventArgs e)
        {
            validarcamposProducto();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconcerrarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
