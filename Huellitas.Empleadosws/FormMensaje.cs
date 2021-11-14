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
    public partial class FormMensaje : Form
    {
        String Message1 = "";
        public FormMensaje()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(450, 250);
           
        }

        private void FormMensaje_Load(object sender, EventArgs e)
        {
           
        }

        private void iconbtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            
        }
    }
}
