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
    public partial class DocenteMan03 : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        public DocenteMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void DocenteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                //objDocenteBE = objDocente.GetDocente(this, Codigo);

                lblCodigo.Text = Convert.ToString(objDocenteBE.Id_Docente1);
                txtNombre.Text = objDocenteBE.Nombres;
                txtApellido.Text = objDocenteBE.Apellidos;
                mskDNI.Text = objDocenteBE.DNI1;
                dtpFecNac.Value = Convert.ToDateTime(objDocenteBE.FechaNac);
                txtSexo.Text = objDocenteBE.Sexo;
                txtCiudad.Text = objDocenteBE.Ciudad;
                txtDireccion.Text = objDocenteBE.Direccion1;
                txtGrado.Text = objDocenteBE.Grado_estudio;
                txtNroTel.Text = objDocenteBE.Numero_tel1;
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


                objDocenteBE.Nombres = txtNombre.Text.Trim();
                objDocenteBE.Apellidos = txtApellido.Text.Trim();
                objDocenteBE.DNI1 = mskDNI.Text;
                objDocenteBE.FechaNac = dtpFecNac.Value.Date;
                objDocenteBE.Sexo = txtSexo.Text.Trim();
                objDocenteBE.Ciudad = txtCiudad.Text.Trim();
                objDocenteBE.Direccion1 = txtDireccion.Text.Trim();
                objDocenteBE.Grado_estudio = txtGrado.Text.Trim();
                objDocenteBE.Numero_tel1 = txtNroTel.Text.Trim();




                if (objDocente.UpdateDocente(objDocenteBE) == true)
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
