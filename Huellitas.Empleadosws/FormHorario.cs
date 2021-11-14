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
    public partial class FormHorario : Form
    {
        public FormHorario()
        {
            InitializeComponent();
        }

        string horasistema = DateTime.Now.ToString("HH:mm:ss");
        //string horaejemplo = "10:00:00";
        private void FormHorario_Load(object sender, EventArgs e)
        {
            mostrarhorario();
        
        }

        public void mostrarhorario()
        {
            using (HuellitasEntities1 conexion = new HuellitasEntities1())
            {
                var fechi = txtfechi.Text;
                var hora = horasistema;
                
                var mostrarhorarios = conexion.Horacitas.SqlQuery("SELECT Veter.Horacita.idhoracita, Veter.Horacita.hora_inicio, Veter.Horacita.hora_fin FROM Veter.Horacita WHERE Veter.Horacita.idhoracita NOT IN (SELECT Veter.Citas.idhoracita FROM Veter.Citas WHERE Veter.Citas.fecha = '"+fechi+ "') and Veter.Horacita.hora_inicio > '"+hora+"'");
                //var mostrarhorarios = conexion.SP_Mostrarhorarios(fechi,horasistema);
                dgvdatosHorario.DataSource = mostrarhorarios.ToList();
                dgvdatosHorario.Columns[1].HeaderText = "Hora de Inicio";
                dgvdatosHorario.Columns[2].HeaderText = "Hora de Finalización";
            }
                

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {
            
        }

        private void txtfechi_TextChanged(object sender, EventArgs e)
        {

        }
        //oculta el id
        private void dgvdatosHorario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvdatosHorario.Columns[0].Visible = false;
        }

        private void iconcerrarHora_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
