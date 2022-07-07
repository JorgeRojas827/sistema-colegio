using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows_Colegio
{
    public partial class AlumnoMan01 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
  

        public AlumnoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            
    
            dtgAlumnos.DataSource = objAlumno.GetAllAlumnos();
            lblRegistros.Text = dtgAlumnos.Rows.Count.ToString();
        }

        private void AlumnoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgAlumnos.AutoGenerateColumns = false;
              
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoMan02 oAlumnoMan02 = new AlumnoMan02();
                oAlumnoMan02.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoMan03 OAlumnoMan03 = new AlumnoMan03();
                OAlumnoMan03.Codigo = dtgAlumnos.CurrentRow.Cells[0].Value.ToString();
                OAlumnoMan03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
