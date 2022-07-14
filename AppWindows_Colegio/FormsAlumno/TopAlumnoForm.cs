using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows_Colegio.FormsAlumno
{
    public partial class TopAlumnoForm : Form
    {
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();
        public TopAlumnoForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaximo.Text.Length == 0)
                {
                    throw new Exception("El campo no puede estar vacio");
                }
                dtgAlumnos.DataSource = objExtra.GetTopAlumnos(Convert.ToInt16(txtMaximo.Text.Trim()));
                lblRegistros.Text = dtgAlumnos.Rows.Count.ToString();
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

        private void TopAlumnoForm_Load(object sender, EventArgs e)
        {
            try
            {
                dtgAlumnos.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
