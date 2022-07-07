using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppWindows_Colegio
{
    public partial class frmLogin : Form
    {
        // Declaramos variableas de intentos y tiempo....
        Int16 intentos = 0;
        Int16 tiempo = 20;
        // Declaramos instancias para autenficacion de Usuarios....
        //UsuarioBE objUsuarioBE = new UsuarioBE();
        //UsuarioBL objUsuarioBL = new UsuarioBL();

        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if(txtLogin .Text.Trim() != "" & txtPassword.Text.Trim() != "")
            // {
            //    //Codifique...
            //    //Obtenemos las credenciales segun el login
            //    objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

            //    //Si el usuario no existiera
            //    if (objUsuarioBE.Login_Usuario == null)
            //    {
            //        MessageBox.Show("Usuario no existe", "Mensaje",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        intentos += 1;
            //        ValidaAccesos();
            //    }

            //    else 
            //    {
            //        if (txtLogin.Text == objUsuarioBE.Login_Usuario & txtPassword.Text == objUsuarioBE.Pass_Usuario)
            //        {
            //            //Las credenciales son correctas y se guardan en la clase estatica clsCrendenciales
            //            this.Hide();
            //            timer1.Enabled = false;
            //            clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
            //            clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
            //            clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;

            //            MDIPrincipal oMDIPrincipal = new MDIPrincipal();
            //            oMDIPrincipal.ShowDialog();
            //        }

            //        else
            //        {
            //            MessageBox.Show("Password incorrecto", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            intentos += 1;
            //            ValidaAccesos();

            //        }
            //    }      
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o Password obligatorios",
            //        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //   intentos +=1;
            //    ValidaAccesos();
            //}
           
        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            
            }
        }
    }
}
