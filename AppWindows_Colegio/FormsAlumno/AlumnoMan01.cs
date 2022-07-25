using AppWindows_Colegio.FormsAlumno;
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
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();
  

        public AlumnoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            if (strFiltro.Equals(""))
            {
                dtgAlumnos.DataSource = objAlumno.GetAllAlumnos();
            }
            else 
            {
                dtgAlumnos.DataSource = objAlumno.BuscarAlumnos(strFiltro);
            }
    
            
            lblRegistros.Text = dtgAlumnos.Rows.Count.ToString();
        }

        private void AlumnoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgAlumnos.AutoGenerateColumns = false;
              
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoMan02 oAlumnoMan02 = new AlumnoMan02();
                oAlumnoMan02.ShowDialog();

                CargarDatos("");
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
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objAlumno.DeleteAlumno(Convert.ToInt16(dtgAlumnos.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Alumno inhabilitado");
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnTopAlumno_Click(object sender, EventArgs e)
        {
            TopAlumnoForm topAlumnoForm = new TopAlumnoForm();
            topAlumnoForm.ShowDialog();
        }

        private void dtgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
