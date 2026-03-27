namespace Asistencias
{
    partial class frmAsistencia
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
            splitContainer1 = new SplitContainer();
            txtCodBarras = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            revisarToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            MenuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            hIstorialToolStripMenuItem = new ToolStripMenuItem();
            btnGuardar = new Button();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            dgvAsistencia = new DataGridView();
            coluID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApat = new DataGridViewTextBoxColumn();
            colAmat = new DataGridViewTextBoxColumn();
            colNc = new DataGridViewTextBoxColumn();
            colSemestre = new DataGridViewTextBoxColumn();
            colPresente = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(txtCodBarras);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            splitContainer1.Panel1.Controls.Add(btnGuardar);
            splitContainer1.Panel1.Controls.Add(dtpFecha);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAsistencia);
            splitContainer1.Size = new Size(824, 381);
            splitContainer1.SplitterDistance = 84;
            splitContainer1.TabIndex = 0;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(430, 40);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "No.Control o Escanea";
            txtCodBarras.Size = new Size(178, 27);
            txtCodBarras.TabIndex = 7;
            txtCodBarras.KeyDown += txtCodBarras_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 40);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "Cod Barras:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { revisarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(824, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // revisarToolStripMenuItem
            // 
            revisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, MenuPrincipalToolStripMenuItem, hIstorialToolStripMenuItem });
            revisarToolStripMenuItem.Name = "revisarToolStripMenuItem";
            revisarToolStripMenuItem.Size = new Size(85, 24);
            revisarToolStripMenuItem.Text = "Consultar";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(224, 26);
            alumnosToolStripMenuItem.Text = "Alumnos";
            alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
            // 
            // MenuPrincipalToolStripMenuItem
            // 
            MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem";
            MenuPrincipalToolStripMenuItem.Size = new Size(224, 26);
            MenuPrincipalToolStripMenuItem.Text = "Menu Principal";
            MenuPrincipalToolStripMenuItem.Click += MenuPrincipalToolStripMenuItem_Click;
            // 
            // hIstorialToolStripMenuItem
            // 
            hIstorialToolStripMenuItem.Name = "hIstorialToolStripMenuItem";
            hIstorialToolStripMenuItem.Size = new Size(224, 26);
            hIstorialToolStripMenuItem.Text = "Historial";
            hIstorialToolStripMenuItem.Click += hIstorialToolStripMenuItem_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(625, 36);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(187, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Asistencia";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(68, 35);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Fecha:";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Columns.AddRange(new DataGridViewColumn[] { coluID, colNombre, colApat, colAmat, colNc, colSemestre, colPresente });
            dgvAsistencia.Dock = DockStyle.Fill;
            dgvAsistencia.Location = new Point(0, 0);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(824, 293);
            dgvAsistencia.TabIndex = 0;
            dgvAsistencia.CellValueChanged += dgvAsistencia_CellValueChanged;
            dgvAsistencia.CurrentCellDirtyStateChanged += dgvAsistencia_CurrentCellDirtyStateChanged;
            // 
            // coluID
            // 
            coluID.HeaderText = "ID";
            coluID.MinimumWidth = 6;
            coluID.Name = "coluID";
            coluID.ReadOnly = true;
            coluID.Visible = false;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            // 
            // colApat
            // 
            colApat.HeaderText = "Apellido Paterno";
            colApat.MinimumWidth = 6;
            colApat.Name = "colApat";
            // 
            // colAmat
            // 
            colAmat.HeaderText = "Apellido Materno";
            colAmat.MinimumWidth = 6;
            colAmat.Name = "colAmat";
            // 
            // colNc
            // 
            colNc.HeaderText = "No.Control";
            colNc.MinimumWidth = 6;
            colNc.Name = "colNc";
            // 
            // colSemestre
            // 
            colSemestre.HeaderText = "Semestre";
            colSemestre.MinimumWidth = 6;
            colSemestre.Name = "colSemestre";
            // 
            // colPresente
            // 
            colPresente.HeaderText = "Presente";
            colPresente.MinimumWidth = 6;
            colPresente.Name = "colPresente";
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 381);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "frmAsistencia";
            Activated += frmAsistencia_Activated;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DateTimePicker dtpFecha;
        private Label label1;
        private DataGridView dgvAsistencia;
        private Button btnGuardar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem revisarToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem MenuPrincipalToolStripMenuItem;
        private ToolStripMenuItem hIstorialToolStripMenuItem;
        private DataGridViewTextBoxColumn coluID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApat;
        private DataGridViewTextBoxColumn colAmat;
        private DataGridViewTextBoxColumn colNc;
        private DataGridViewTextBoxColumn colSemestre;
        private DataGridViewCheckBoxColumn colPresente;
        private TextBox txtCodBarras;
        private Label label2;
    }
}