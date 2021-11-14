using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Huellitas.Empleadosws
{
    public partial class FormInicio : Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formhijo;
        public FormInicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Colores
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(172, 118, 114);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(10,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono formulario activo
                iconformularioActivo.IconChar = currentBtn.IconChar;
                iconformularioActivo.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(19, 19, 70);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.OrangeRed;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Abrirformulariohijo(Form hijo)
        {
            if (formhijo != null)
            {
                //abre solo un formulario
                formhijo.Close();
            }
            formhijo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelformSecundarios.Controls.Add(hijo);
            panelformSecundarios.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
            lblIformularioActivo.Text = hijo.Text;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void iconBtnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Abrirformulariohijo(new FormEmpleado());
        }

        private void iconBtnCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            Abrirformulariohijo(new FormCliente());
        }

        private void iconBtnMascota_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            Abrirformulariohijo(new FormMascotas());
        }

        private void iconBtnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            Abrirformulariohijo(new FormProducto());
        }

        private void iconBtnServicios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            Abrirformulariohijo(new FormServicios());
        }

        private void iconBtnCitas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Abrirformulariohijo(new FormVercitas());
        }

        private void iconBtnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            Abrirformulariohijo(new FormVentas());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                formhijo.Close();
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        ///REINICIAR
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconformularioActivo.IconChar = IconChar.Home;
            iconformularioActivo.IconColor = Color.OrangeRed;
            lblIformularioActivo.Text = "Inicio";

        }
        //MOVER EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelbarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012, 0 );
        }

        private void iconPictureCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelformSecundarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelbarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
