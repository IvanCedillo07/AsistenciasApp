using Asistencias.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asistencias
{
    public partial class frmAlumno : Form
    {
        int id = 0;
        ConxDatos dt = new ConxDatos();
        bool update = false;
        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int id, string nombre, string Apat, string Amat, int NC, int semestre)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = nombre;
            txtApat.Text = Apat;
            txtAmat.Text = Amat;
            txtNC.Text = NC.ToString();
            cbSemestre.Text = semestre.ToString();
            update = true;
        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!update)
            {
                bool resultado = dt.ejecutarComando($"INSERT INTO alumnos(nombre, apellidoPat,apellidoMat,Ncontrol,semestre) " +
                    $"VALUES('{txtNombre.Text}', '{txtApat.Text}','{txtAmat.Text}','{txtNC.Text}','{cbSemestre.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente.");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al agregar el alumno.");
            }
            else
            {
                bool resultado = dt.ejecutarComando($"UPDATE alumnos SET nombre='{txtNombre.Text}', apellidoPat='{txtApat.Text}',apellidoMat='{txtAmat.Text}',Ncontrol='{txtNC.Text}',semestre='{cbSemestre.Text}' WHERE id={id}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente.");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al actualizar el alumno.");
            }
        }
    }
}
