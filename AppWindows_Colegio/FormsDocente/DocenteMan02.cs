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
    public partial class DocenteMan02 : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        public DocenteMan02()
        {
            InitializeComponent();
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

                if (txtGrado.Text.Length == 0)
                { 
                    throw new Exception("El grado de estudio no puede estar vacio");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }

                objDocenteBE.Nombres = txtNombre.Text.Trim();
                objDocenteBE.Apellidos = txtApellido.Text.Trim();
                objDocenteBE.DNI1 = mskDNI.Text;
                objDocenteBE.FechaNac = dtpFecNac.Value.Date;
                objDocenteBE.Sexo = txtSexo.Text.Trim();
                objDocenteBE.Ciudad = txtCiudad.Text.Trim();
                objDocenteBE.Direccion1 = txtDireccion.Text.Trim();
                objDocenteBE.Grado_estudio = txtGrado.Text.Trim();
                objDocenteBE.Numero_tel1 = txtNroTel.Text.Trim();

                if (objDocente.InsertDocente(objDocenteBE) == true)
                {
                    MessageBox.Show("Docente registrado correctamente");
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
