﻿
namespace AppWindows_Colegio
{
    partial class DocenteMan02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtNroTel = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.labelEmail);
            this.grpDatos.Controls.Add(this.txtNroTel);
            this.grpDatos.Controls.Add(this.txtGrado);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtSexo);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.mskDNI);
            this.grpDatos.Controls.Add(this.btnRegistrar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.dtpFecNac);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.txtCiudad);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(485, 421);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtNroTel
            // 
            this.txtNroTel.Location = new System.Drawing.Point(112, 270);
            this.txtNroTel.Name = "txtNroTel";
            this.txtNroTel.Size = new System.Drawing.Size(274, 20);
            this.txtNroTel.TabIndex = 22;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(112, 234);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(274, 20);
            this.txtGrado.TabIndex = 22;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(112, 195);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 20);
            this.txtDireccion.TabIndex = 22;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(112, 128);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(126, 20);
            this.txtSexo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sexo:";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(112, 97);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(73, 20);
            this.mskDNI.TabIndex = 7;
            this.mskDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(266, 370);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 36);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(40, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombres:";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNac.Location = new System.Drawing.Point(295, 97);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(120, 20);
            this.dtpFecNac.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(40, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nro. Tel:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(112, 161);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(192, 20);
            this.txtCiudad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(40, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grado:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(303, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(40, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(40, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(40, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "DNI:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(40, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Apellidos:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(214, 100);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "F. Nacimiento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(366, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 36);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(43, 309);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // DocenteMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 445);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DocenteMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Docente";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpFecNac;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtCiudad;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNroTel;
        private System.Windows.Forms.TextBox txtGrado;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
    }
}