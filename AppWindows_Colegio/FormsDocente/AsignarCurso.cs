using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows_Colegio.FormsDocente
{
    public partial class AsignarCurso : Form
    {
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyExtra.IServicioExtraClient objExtra= new ProxyExtra.IServicioExtraClient();

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        public AsignarCurso()
        {
            InitializeComponent();
        }

        private void AsignarCurso_Load(object sender, EventArgs e)
        {
            cbxCursos.DataSource = objCurso.GetCursos();
            cbxCursos.DisplayMember = "Descripcion";
            cbxCursos.ValueMember = "IdCurso";
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyDocente.DocenteBE docenteBE = objDocente.GetDocente(Convert.ToInt16(Codigo));
                if (docenteBE.Id_Curso1 == 0)
                {
                    objExtra.AsignarCursoDocente(Convert.ToInt16(cbxCursos.SelectedValue), Convert.ToInt16(Codigo));
                    MessageBox.Show("Curso asignado");
                } else
                {
                    MessageBox.Show("El docente ya está asignado a un curso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
