﻿using System;
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

        public void CargarDatos()
        {


            dtgDocente.DataSource = objDocente.GetAllDocentes();
            lblRegistros.Text = dtgDocente.Rows.Count.ToString();
        }

        private void DocenteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDocente.AutoGenerateColumns = false;

                CargarDatos();
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
                DocenteMan03 ODocenteMan03 = new DocenteMan03();
                ODocenteMan03.Codigo = dtgDocente.CurrentRow.Cells[0].Value.ToString();
                ODocenteMan03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}