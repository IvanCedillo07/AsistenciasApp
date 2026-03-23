namespace Asistencias
{
    partial class frmAlumno
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApat = new TextBox();
            txtAmat = new TextBox();
            txtNC = new TextBox();
            btnAceptar = new Button();
            cbSemestre = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 100);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 173);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 29);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "N.C:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApat
            // 
            txtApat.Location = new Point(152, 93);
            txtApat.Name = "txtApat";
            txtApat.Size = new Size(208, 27);
            txtApat.TabIndex = 5;
            // 
            // txtAmat
            // 
            txtAmat.Location = new Point(158, 166);
            txtAmat.Name = "txtAmat";
            txtAmat.Size = new Size(202, 27);
            txtAmat.TabIndex = 6;
            // 
            // txtNC
            // 
            txtNC.Location = new Point(429, 26);
            txtNC.Name = "txtNC";
            txtNC.Size = new Size(151, 27);
            txtNC.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(429, 152);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(151, 52);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cbSemestre
            // 
            cbSemestre.FormattingEnabled = true;
            cbSemestre.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbSemestre.Location = new Point(429, 93);
            cbSemestre.Name = "cbSemestre";
            cbSemestre.Size = new Size(151, 28);
            cbSemestre.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 70);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Semestre";
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 236);
            Controls.Add(label5);
            Controls.Add(cbSemestre);
            Controls.Add(btnAceptar);
            Controls.Add(txtNC);
            Controls.Add(txtAmat);
            Controls.Add(txtApat);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "frmAlumno";
            Load += Alumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApat;
        private TextBox txtAmat;
        private TextBox txtNC;
        private Button btnAceptar;
        private ComboBox cbSemestre;
        private Label label5;
    }
}