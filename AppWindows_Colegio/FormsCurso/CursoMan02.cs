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
    public partial class CursoMan02 : Form
    {
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        ProxyCurso.CursoBE objCursoBE = new ProxyCurso.CursoBE();

        public CursoMan02()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Length == 0)
                {
                    throw new Exception("El nombre no puede estar vacio");
                }

                objCursoBE.Descripcion = txtDescripcion.Text.Trim();

                if (objCurso.InsertCurso(objCursoBE) == true)
                {
                    MessageBox.Show("Insercion exitosa");
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no es inserto. Contacto con IT");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
