using AppWindows_Colegio.Clases;
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
    public partial class AlumnoMan03 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();

        public AlumnoMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void AlumnoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE = objAlumno.GetAlumno(Convert.ToInt16(Codigo));

                lblCodigo.Text = objAlumnoBE.Mvarcod_al;
                txtNombre.Text = objAlumnoBE.Mvarnom_al;
                txtApellido.Text = objAlumnoBE.Mvarape_al;
                mskDNI.Text = objAlumnoBE.Mvardocide_al;
                dtpFecNac.Value = Convert.ToDateTime(objAlumnoBE.Mvarfecnac_al);
                txtSexo.Text = objAlumnoBE.Mvarsex_al;
                txtCiudad.Text = Convert.ToString(objAlumnoBE.Mvarnom_distrito);
                txtDireccion.Text = objAlumnoBE.Mvardir_al;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);    
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Length == 0)
                {
                    MessageBox.Show("El Nombre no puede estar vacio.");
                }

                if (txtApellido.Text.Length == 0)
                {
                    MessageBox.Show("El Apellido no puede estar vacio.");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");

                }


                objAlumnoBE.Mvarnom_al = txtNombre.Text.Trim();
                objAlumnoBE.Mvarape_al = txtApellido.Text.Trim();
                objAlumnoBE.Mvardocide_al = mskDNI.Text;
                objAlumnoBE.Mvarfecnac_al = dtpFecNac.Value.Date;
                objAlumnoBE.Mvarsex_al = txtSexo.Text.Trim();
                objAlumnoBE.Mvarnom_distrito = txtCiudad.Text.Trim();
                objAlumnoBE.Mvardir_al = txtDireccion.Text.Trim();

                objAlumnoBE.Usu_ult_mod = clsCredenciales.Usuario;
               

                if (objAlumno.UpdateAlumno(objAlumnoBE) == true)
                {
                    MessageBox.Show("Actualizacion exitosa");
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no se actualizo. Contacto con IT");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
