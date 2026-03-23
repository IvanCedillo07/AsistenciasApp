using Asistencias.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asistencias
{
    public partial class frmHistorial : Form
    {
        ConxDatos datos = new ConxDatos();
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Activated(object sender, EventArgs e)
        {
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpFecha.Value = DateTime.Today;
            BuscarAsistencia();
        }

        private void BuscarAsistencia()
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            DataSet ds = datos.ejecutar($@"
                SELECT 
                    a.Ncontrol AS 'No.Control',
                    a.nombre AS 'Nombre',
                    a.apellidoPat AS 'Apellido Paterno',
                    a.apellidoMat AS 'Apellido Materno',
                    a.semestre AS 'Semestre',
                    CASE WHEN s.presente = 1 THEN 'Presente' 
                         WHEN s.presente = 0 THEN 'Ausente'
                         ELSE 'Sin registro' 
                    END AS 'Estado'
                FROM alumnos a
                LEFT JOIN asistencias s 
                    ON a.id = s.alumno_id AND s.fecha = '{fecha}'
                ORDER BY a.apellidoPat");

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dgvHistorial.DataSource = ds.Tables[0];
                ContarAsistencia(ds.Tables[0]);
            }
            else
            {
                dgvHistorial.DataSource = null;
                dgvHistorial.Rows.Clear();
                lbPrsentes.Text = "0";
                lbAusentes.Text = "0";
                lbAlumnostot.Text = "0";
                MessageBox.Show("No hay registros para esta fecha.", "Sistema");
            }
        }

        private void ContarAsistencia(DataTable tabla)
        {
            int presentes = 0;
            int ausentes = 0;
            int sinRegistro = 0;

            foreach (DataRow row in tabla.Rows)
            {
                string estado = row["Estado"].ToString();
                if (estado == "Presente") presentes++;
                else if (estado == "Ausente") ausentes++;
                else sinRegistro++;
            }

            int total = tabla.Rows.Count;
            lbPrsentes.Text = $"{presentes}";
            lbAusentes.Text = $"{ausentes}";
            lbAlumnostot.Text = $"{total}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAsistencia();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alu = new frmAlumnos();
            alu.Show();
            this.Close();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia asis = new frmAsistencia();
            asis.Show();
            this.Close();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal men=new frmMenuPrincipal();
            men.Show();
            this.Close();
        }
    }

}
