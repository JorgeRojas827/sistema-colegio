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
    public partial class AlumnoMan02 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();

        public AlumnoMan02()
        {
            InitializeComponent();
        }

        private void AlumnoMan02_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El nombre no puede estar vacio");
                }

                if (txtApellido.Text.Length == 0)
                {
                    throw new Exception("El apellido no puede estar vacio");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }

                objAlumnoBE.Mvarnom_al = txtNombre.Text.Trim();
                objAlumnoBE.Mvarape_al = txtApellido.Text.Trim();
                objAlumnoBE.Mvardocide_al = mskDNI.Text;
                objAlumnoBE.Mvarfecnac_al = dtpFecNac.Value.Date;
                objAlumnoBE.Mvarsex_al = txtSexo.Text.Trim();
                objAlumnoBE.Mvarnom_distrito =txtCiudad.Text.Trim();
                objAlumnoBE.Mvardir_al = txtDireccion.Text.Trim();

                if (objAlumno.InsertAlumno(objAlumnoBE) == true)
                {
                    MessageBox.Show("Alumno registrado correctamente");
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no se insertó. Contacte con IT");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }

           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
