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
    public partial class CursoMan01 : Form
    {
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();

        public CursoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            //Codifique
            dtgCursos.DataSource = objCurso.GetCursos();
            lblRegistros.Text = dtgCursos.Rows.Count.ToString();
        }

        private void CursoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCursos.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                CursoMan02 oCursoMan02 = new CursoMan02();
                oCursoMan02.ShowDialog();

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
                CursoMan03 oCursoMan03 = new CursoMan03();
                oCursoMan03.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();
                oCursoMan03.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
