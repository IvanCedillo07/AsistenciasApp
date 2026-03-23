using Asistencias.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace Asistencias
{
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Activated(object sender, EventArgs e)
        {
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            dgvAsistencia.Rows.Clear();

            ConxDatos datos = new ConxDatos();
            DataSet ds = datos.ejecutar(
                "SELECT id, nombre,apellidoPat, apellidoMat, Ncontrol, semestre FROM alumnos ORDER BY apellidoPat");

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dgvAsistencia.Rows.Add(
                        row["id"],
                        row["nombre"],
                        row["apellidoPat"],
                        row["apellidoMat"],
                        row["Ncontrol"],
                        row["semestre"],
                        false
                    );
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvAsistencia.Rows.Count == 0)
            {
                MessageBox.Show("No hay alumnos cargados.", "Sistema");
                return;
            }

            DateTime fecha = dtpFecha.Value.Date;
            ConxDatos datos = new ConxDatos();

            // Verificar si ya existe asistencia para esa fecha
            DataSet ds = datos.ejecutar($"SELECT COUNT(*) as total FROM asistencias WHERE fecha='{fecha:yyyy-MM-dd}'");
            int existe = Convert.ToInt32(ds.Tables[0].Rows[0]["total"]);

            if (existe > 0)
            {
                if (MessageBox.Show("Ya existe asistencia para esta fecha. ¿Deseas sobreescribirla?",
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    datos.ejecutarComando($"DELETE FROM asistencias WHERE fecha='{fecha:yyyy-MM-dd}'");
                }
            }

            // Insertar asistencias
            int guardados = 0;
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                if (row.IsNewRow) continue;
                int idAlumno = Convert.ToInt32(row.Cells["coluID"].Value);
                bool presente = Convert.ToBoolean(row.Cells["colPresente"].Value);

                bool ok = datos.ejecutarComando(
                    $"INSERT INTO asistencias (alumno_id, fecha, presente) VALUES ({idAlumno}, '{fecha:yyyy-MM-dd}', {(presente ? 1 : 0)})");

                if (ok) guardados++;
            }

            MessageBox.Show($"Asistencia guardada correctamente.\n{guardados} alumnos registrados.",
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.Show();
            this.Close();
        }

        private void MenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmMenuPrincipal menu= new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void hIstorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial h = new frmHistorial();
            h.Show();
            this.Close();
        }
    }
}
