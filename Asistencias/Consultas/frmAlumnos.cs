using Asistencias.Clases;
using System.Data;
using OfficeOpenXml;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asistencias
{
    public partial class frmAlumnos : Form
    {
        ConxDatos datos = new ConxDatos();
        DataSet ds;
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnAggAlumno_Click(object sender, EventArgs e)
        {
            frmAlumno aggAlu = new frmAlumno();
            aggAlu.ShowDialog();
        }

        private void frmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM alumnos");
                if (ds != null)
                    dgvAlumnos.DataSource = ds.Tables[0];
                else
                    MessageBox.Show("No se pudo cargar la lista de alumnos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM alumnos");
                if (ds != null)
                    dgvAlumnos.DataSource = ds.Tables[0];
                else
                    MessageBox.Show("No se pudo cargar la lista de alumnos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow != null)
                {
                    int idAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
                    if (MessageBox.Show("¿Deseas eliminar a este alumno?",
                        "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool res = datos.ejecutarComando($"DELETE FROM alumnos WHERE id={idAlumno}");
                        if (res)
                        {
                            MessageBox.Show("Alumno Eliminado Correctamente", "Sistema");
                        }
                        else
                        {
                            MessageBox.Show("Error al elimninar alumno", "Sistema");
                            CargarDatos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el Alumno: " + ex.Message, "Sistema");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno edalumno = new frmAlumno(
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[5].Value)
            );
            edalumno.ShowDialog();
        }

        private void btnImpAlumnos_Click(object sender, EventArgs e)
        {
            System.String path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Carlos Ivan");
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    if (worksheet.Dimension == null)
                    {
                        MessageBox.Show("La hoja de Excel está vacía.", "Sistema");
                        return;
                    }

                    int totalRows = worksheet.Dimension.Rows;
                    int insertados = 0;
                    int errores = 0;

                    for (int row = 2; row <= totalRows; row++)
                    {
                        string nombre = worksheet.Cells[row, 1].Text.Trim();
                        string apellidoPat = worksheet.Cells[row, 2].Text.Trim();
                        string apellidoMat = worksheet.Cells[row, 3].Text.Trim();
                        string nctxt = worksheet.Cells[row, 4].Text.Trim();
                        string semestretxt = worksheet.Cells[row, 5].Text.Trim();

                        
                        if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellidoPat))
                            continue;

                        
                        if (!int.TryParse(nctxt, out int NC) ||
                            !int.TryParse(semestretxt, out int semestre))
                        {
                            errores++;
                            continue;
                        }

                       
                        bool ok = datos.ejecutarComando(
                            $"INSERT INTO alumnos (nombre, apellidoPat, apellidoMat,Ncontrol, semestre) " +
                            $"VALUES ('{nombre}', '{apellidoPat}', '{apellidoMat}', {NC}, {semestre})"
                        );

                        if (ok) insertados++;
                        else errores++;
                    }

                    MessageBox.Show(
                        $"Importación completada.\nInsertados: {insertados}\nErrores: {errores}",
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                   
                    ds = datos.ejecutar("SELECT * FROM alumnos");
                    if (ds != null)
                        dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
        }



        private void MenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmMenuPrincipal m= new frmMenuPrincipal();
            m.Show();
            this.Close();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia asis = new frmAsistencia();
            asis.Show();
            this.Close();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial his = new frmHistorial();
            his.Show();
            this.Close();
        }

        private void BuscarNcontrol()
        {
            DataSet ds = datos.ejecutar($"SELECT id,nombre,apellidoPat,apellidoMat,Ncontrol,semestre FROM alumnos WHERE Ncontrol LIKE '{txtBuscAlumno.Text}%'");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void BuscarApat()
        {
            DataSet ds = datos.ejecutar($"SELECT id,nombre,apellidoPat,apellidoMat,Ncontrol,semestre FROM alumnos WHERE apellidoPat LIKE '{txtBuscAlumno.Text}%'");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }
        private void txtBuscAlumno_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscarPor.SelectedItem.ToString() == "No.Control")
            {

                BuscarNcontrol();
            }
            else if (cbBuscarPor.SelectedItem.ToString() == "Apellido Paterno")
            {

                BuscarApat();
            }
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarPor.SelectedItem == null)
            {
                txtBuscAlumno.Enabled= false;
            }
            else
            {
                txtBuscAlumno.Enabled = true;
                if (cbBuscarPor.SelectedItem.ToString() == "No.Control")
                {
                    txtBuscAlumno.PlaceholderText = "27000...";
                }else if(cbBuscarPor.SelectedItem.ToString() == "Apellido Paterno")
                {
                    txtBuscAlumno.PlaceholderText = "Carranza...";
                }
            }
        }
    }
}
