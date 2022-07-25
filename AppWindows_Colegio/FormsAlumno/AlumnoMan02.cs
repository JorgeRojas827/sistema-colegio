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
    public partial class AlumnoMan02 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();

        public AlumnoMan02()
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

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }

                if (cbxSexo.SelectedItem == null)
                {
                    throw new Exception("El sexo debe ser obligatorio");
                }

                objAlumnoBE.Mvarnom_al = txtNombre.Text.Trim();
                objAlumnoBE.Mvarape_al = txtApellido.Text.Trim();
                objAlumnoBE.Mvardocide_al = mskDNI.Text;
                if (cbxSexo.SelectedItem.ToString() == "Femenino")
                {
                    objAlumnoBE.Mvarsex_al = "Femenino";
                } else
                {
                    objAlumnoBE.Mvarsex_al = "Masculino";
                }
                objAlumnoBE.Mvarfecnac_al = dtpFecNac.Value.Date;
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
