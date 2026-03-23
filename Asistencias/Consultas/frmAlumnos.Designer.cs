namespace Asistencias
{
    partial class frmAlumnos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            cbBuscarPor = new ComboBox();
            btnImpAlumnos = new Button();
            btnAggAlumno = new Button();
            txtBuscAlumno = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            revisarToolStripMenuItem = new ToolStripMenuItem();
            AsistenciaToolStripMenuItem = new ToolStripMenuItem();
            MenuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dgvAlumnos = new DataGridView();
            cmsAlumnos = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            ofdExcel = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            cmsAlumnos.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(cbBuscarPor);
            splitContainer1.Panel1.Controls.Add(btnImpAlumnos);
            splitContainer1.Panel1.Controls.Add(btnAggAlumno);
            splitContainer1.Panel1.Controls.Add(txtBuscAlumno);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(961, 404);
            splitContainer1.SplitterDistance = 102;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 33);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "Buscar Por:";
            // 
            // cbBuscarPor
            // 
            cbBuscarPor.Cursor = Cursors.Hand;
            cbBuscarPor.FormattingEnabled = true;
            cbBuscarPor.Items.AddRange(new object[] { "No.Control", "Apellido Paterno" });
            cbBuscarPor.Location = new Point(518, 59);
            cbBuscarPor.Name = "cbBuscarPor";
            cbBuscarPor.Size = new Size(187, 28);
            cbBuscarPor.TabIndex = 5;
            cbBuscarPor.SelectedIndexChanged += cbBuscarPor_SelectedIndexChanged;
            // 
            // btnImpAlumnos
            // 
            btnImpAlumnos.Location = new Point(734, 59);
            btnImpAlumnos.Name = "btnImpAlumnos";
            btnImpAlumnos.Size = new Size(215, 29);
            btnImpAlumnos.TabIndex = 3;
            btnImpAlumnos.Text = "IMPORTAR";
            btnImpAlumnos.UseVisualStyleBackColor = true;
            btnImpAlumnos.Click += btnImpAlumnos_Click;
            // 
            // btnAggAlumno
            // 
            btnAggAlumno.Location = new Point(734, 24);
            btnAggAlumno.Name = "btnAggAlumno";
            btnAggAlumno.Size = new Size(215, 29);
            btnAggAlumno.TabIndex = 2;
            btnAggAlumno.Text = "AGREGAR ALUMNO";
            btnAggAlumno.UseVisualStyleBackColor = true;
            btnAggAlumno.Click += btnAggAlumno_Click;
            // 
            // txtBuscAlumno
            // 
            txtBuscAlumno.Enabled = false;
            txtBuscAlumno.Location = new Point(149, 36);
            txtBuscAlumno.Name = "txtBuscAlumno";
            txtBuscAlumno.PlaceholderText = "Seleccione una opcion de busqueda...";
            txtBuscAlumno.Size = new Size(315, 27);
            txtBuscAlumno.TabIndex = 1;
            txtBuscAlumno.TextChanged += txtBuscAlumno_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Alumno:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { revisarToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(961, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // revisarToolStripMenuItem
            // 
            revisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AsistenciaToolStripMenuItem, MenuPrincipalToolStripMenuItem, historialToolStripMenuItem });
            revisarToolStripMenuItem.Name = "revisarToolStripMenuItem";
            revisarToolStripMenuItem.Size = new Size(85, 24);
            revisarToolStripMenuItem.Text = "Consultar";
            // 
            // AsistenciaToolStripMenuItem
            // 
            AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem";
            AsistenciaToolStripMenuItem.Size = new Size(224, 26);
            AsistenciaToolStripMenuItem.Text = "Asistencia";
            AsistenciaToolStripMenuItem.Click += AsistenciaToolStripMenuItem_Click;
            // 
            // MenuPrincipalToolStripMenuItem
            // 
            MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem";
            MenuPrincipalToolStripMenuItem.Size = new Size(224, 26);
            MenuPrincipalToolStripMenuItem.Text = "Menu Principal";
            MenuPrincipalToolStripMenuItem.Click += MenuPrincipalToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(224, 26);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.ContextMenuStrip = cmsAlumnos;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(961, 298);
            dgvAlumnos.TabIndex = 0;
            // 
            // cmsAlumnos
            // 
            cmsAlumnos.ImageScalingSize = new Size(20, 20);
            cmsAlumnos.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, editarToolStripMenuItem });
            cmsAlumnos.Name = "cmsAlumnos";
            cmsAlumnos.Size = new Size(133, 52);
            cmsAlumnos.Text = "cmsAlumnos";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(132, 24);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // ofdExcel
            // 
            ofdExcel.FileName = "openFileDialog1";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 404);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            Activated += frmAlumnos_Activated;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            cmsAlumnos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnImpAlumnos;
        private Button btnAggAlumno;
        private TextBox txtBuscAlumno;
        private Label label1;
        private DataGridView dgvAlumnos;
        private ContextMenuStrip cmsAlumnos;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private OpenFileDialog ofdExcel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem revisarToolStripMenuItem;
        private ToolStripMenuItem AsistenciaToolStripMenuItem;
        private ToolStripMenuItem MenuPrincipalToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private Label label2;
        private ComboBox cbBuscarPor;
    }
}
