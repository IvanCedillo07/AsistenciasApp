namespace Asistencias
{
    partial class frmMenuPrincipal
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
            btnAlumnos = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAsistencia = new Button();
            btnHistorial = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = Color.FromArgb(234, 243, 222);
            btnAlumnos.Cursor = Cursors.Hand;
            btnAlumnos.FlatAppearance.BorderColor = Color.FromArgb(192, 221, 151);
            btnAlumnos.FlatStyle = FlatStyle.Flat;
            btnAlumnos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAlumnos.ForeColor = Color.FromArgb(39, 80, 10);
            btnAlumnos.Image = Properties.Resources.alumnos1;
            btnAlumnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlumnos.Location = new Point(96, 191);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(163, 139);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.TextAlign = ContentAlignment.MiddleRight;
            btnAlumnos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlumnos.UseVisualStyleBackColor = false;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 158, 117);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 166);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconop;
            pictureBox1.Location = new Point(348, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 99);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 0;
            label1.Text = "Control de Asitencia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAsistencia
            // 
            btnAsistencia.BackColor = Color.FromArgb(234, 243, 222);
            btnAsistencia.Cursor = Cursors.Hand;
            btnAsistencia.FlatAppearance.BorderColor = Color.FromArgb(192, 221, 151);
            btnAsistencia.FlatStyle = FlatStyle.Flat;
            btnAsistencia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAsistencia.ForeColor = Color.FromArgb(39, 80, 10);
            btnAsistencia.Image = Properties.Resources.asistencia;
            btnAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencia.Location = new Point(328, 191);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(163, 139);
            btnAsistencia.TabIndex = 2;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.TextAlign = ContentAlignment.MiddleRight;
            btnAsistencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsistencia.UseVisualStyleBackColor = false;
            btnAsistencia.Click += btnAsistencia_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(234, 243, 222);
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatAppearance.BorderColor = Color.FromArgb(192, 221, 151);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHistorial.ForeColor = Color.FromArgb(39, 80, 10);
            btnHistorial.Image = Properties.Resources.historial;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(548, 191);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(163, 139);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.TextAlign = ContentAlignment.MiddleRight;
            btnHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(btnHistorial);
            Controls.Add(btnAsistencia);
            Controls.Add(panel1);
            Controls.Add(btnAlumnos);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlumnos;
        private Panel panel1;
        private Label label1;
        private Button btnAsistencia;
        private Button btnHistorial;
        private PictureBox pictureBox1;
    }
}