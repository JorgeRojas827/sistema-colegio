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

        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                bool res = objExtra.LoginUsuario(txtLogin.Text.Trim(), txtPassword.Text.Trim());
                if (res != true)
                {
                    MessageBox.Show("Usuario no existe", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    intentos += 1;
                    ValidaAccesos();
                } else
                {
                    this.Hide();
                    timer1.Enabled = false;
                    Inicio inicio = new Inicio();
                    inicio.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }

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
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
