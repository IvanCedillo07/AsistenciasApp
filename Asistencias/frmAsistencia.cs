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
            // Guarda los ID que ya estaban marcados como presentes
            List<int> presentes = new List<int>();
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                if (row.IsNewRow) continue;
                if (Convert.ToBoolean(row.Cells["colPresente"].Value))
                {
                    presentes.Add(Convert.ToInt32(row.Cells["coluID"].Value));
                }
            }


            dgvAsistencia.Rows.Clear();
            ConxDatos datos = new ConxDatos();
            DataSet ds = datos.ejecutar(
                "SELECT id, nombre, apellidoPat, apellidoMat, Ncontrol, semestre FROM alumnos ORDER BY apellidoPat");

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    bool estabaPresente = presentes.Contains(id);

                    int indice = dgvAsistencia.Rows.Add(
                        id,
                        row["nombre"],
                        row["apellidoPat"],
                        row["apellidoMat"],
                        row["Ncontrol"],
                        row["semestre"],
                        estabaPresente
                    );


                    if (estabaPresente)
                        dgvAsistencia.Rows[indice].DefaultCellStyle.BackColor = Color.LightGreen;
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
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void hIstorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial h = new frmHistorial();
            h.Show();
            this.Close();
        }

        private void txtCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nControl = txtCodBarras.Text.Trim();

                if (string.IsNullOrEmpty(nControl))
                {
                    e.SuppressKeyPress = true;
                    return;
                }

                bool encontrado = false;

                foreach (DataGridViewRow row in dgvAsistencia.Rows)
                {
                    if (row.IsNewRow) continue;

                    string ncGrid = row.Cells["colNc"].Value?.ToString().Trim();

                    if (ncGrid == nControl)
                    {
                        row.Cells["colPresente"].Value = true;
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                    MessageBox.Show($"Asistencia registrada correctamente.",
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"No se encontró alumno con No. Control: {nControl}",
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCodBarras.Clear();
                txtCodBarras.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvAsistencia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Cambia de color el renglon del checkbox segun su estado
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAsistencia.Rows[e.RowIndex];

            bool presente = Convert.ToBoolean(row.Cells["colPresente"].Value);

            if (presente)
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else
                row.DefaultCellStyle.BackColor = Color.White;
        }

        private void dgvAsistencia_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //Ayuda a hacer mas fluido el cambio de color en los checkbox
            if (dgvAsistencia.IsCurrentCellDirty)
                dgvAsistencia.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
