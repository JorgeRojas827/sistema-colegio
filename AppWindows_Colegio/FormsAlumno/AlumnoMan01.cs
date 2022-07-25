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
                ProxyAlumno.AlumnoBE[] alumnoBEs = objAlumno.GetAllAlumnos();
                dtgAlumnos.DataSource = alumnoBEs;

                for (int i = 0; i < alumnoBEs.Length; i++)
                {
                    if (alumnoBEs[i].Mvaract_al == false)
                    {
                         dtgAlumnos.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
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
                Int16 idAlumno = Convert.ToInt16(dtgAlumnos.CurrentRow.Cells[0].Value.ToString());
                ProxyAlumno.AlumnoBE alumnoBE = objAlumno.GetAlumno(idAlumno);

                objAlumno.DeleteAlumno(Convert.ToInt16(idAlumno));
                if (alumnoBE.Mvaract_al == true)
                {
                    MessageBox.Show("Alumno inhabilitado");
                }
                else
                {
                    MessageBox.Show("Alumno habilitado");
                }
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

    }
}
