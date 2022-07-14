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
    public partial class DocenteMan01 : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();

        public DocenteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            if (strFiltro.Equals(""))
            {
                dtgDocente.DataSource = objDocente.GetAllDocentes();
            }
            else
            {
                dtgDocente.DataSource = objDocente.BuscarDocentes(strFiltro);
            }
            
            lblRegistrosDocentes.Text = dtgDocente.Rows.Count.ToString();
        }


        private void DocenteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDocente.AutoGenerateColumns = false;

                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                DocenteMan02 oDocenteMan02 = new DocenteMan02();
                oDocenteMan02.ShowDialog();

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
                DocenteMan03 ODocenteMan03 = new DocenteMan03();
                ODocenteMan03.Codigo = dtgDocente.CurrentRow.Cells[0].Value.ToString();
                ODocenteMan03.ShowDialog();
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
                objDocente.DeleteDocente(Convert.ToInt16(dtgDocente.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Docente eliminado");
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro2_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro2.Text.Trim());
        }
    }
}
