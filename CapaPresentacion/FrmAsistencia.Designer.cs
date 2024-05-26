namespace CapaPresentacion
{
    partial class FrmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckEstudiante = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CheckDocente = new System.Windows.Forms.CheckBox();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSalida = new System.Windows.Forms.Button();
            this.BtnEntrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bienvenido = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 200);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(725, 35);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button2);
            this.panel7.Location = new System.Drawing.Point(691, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(31, 31);
            this.panel7.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-1, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckEstudiante
            // 
            this.CheckEstudiante.AutoSize = true;
            this.CheckEstudiante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckEstudiante.Location = new System.Drawing.Point(39, 53);
            this.CheckEstudiante.Name = "CheckEstudiante";
            this.CheckEstudiante.Size = new System.Drawing.Size(101, 25);
            this.CheckEstudiante.TabIndex = 3;
            this.CheckEstudiante.Text = "Estudiante";
            this.CheckEstudiante.UseVisualStyleBackColor = true;
            this.CheckEstudiante.CheckedChanged += new System.EventHandler(this.CheckEstudiante_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumDoc);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.CheckDocente);
            this.panel1.Controls.Add(this.CheckEstudiante);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 100);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar:";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.Location = new System.Drawing.Point(360, 54);
            this.txtNumDoc.Multiline = true;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(118, 27);
            this.txtNumDoc.TabIndex = 6;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(543, 32);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(114, 46);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "      Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CheckDocente
            // 
            this.CheckDocente.AutoSize = true;
            this.CheckDocente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDocente.Location = new System.Drawing.Point(169, 53);
            this.CheckDocente.Name = "CheckDocente";
            this.CheckDocente.Size = new System.Drawing.Size(86, 25);
            this.CheckDocente.TabIndex = 4;
            this.CheckDocente.Text = "Docente";
            this.CheckDocente.UseVisualStyleBackColor = true;
            this.CheckDocente.CheckedChanged += new System.EventHandler(this.CheckDocente_CheckedChanged);
            // 
            // pnlResultados
            // 
            this.pnlResultados.BackColor = System.Drawing.Color.White;
            this.pnlResultados.Controls.Add(this.lblNombre);
            this.pnlResultados.Controls.Add(this.label6);
            this.pnlResultados.Controls.Add(this.BtnSalida);
            this.pnlResultados.Controls.Add(this.BtnEntrada);
            this.pnlResultados.Controls.Add(this.pictureBox1);
            this.pnlResultados.Controls.Add(this.lblCargo);
            this.pnlResultados.Controls.Add(this.lblEstado);
            this.pnlResultados.Controls.Add(this.label15);
            this.pnlResultados.Controls.Add(this.lblTelefono);
            this.pnlResultados.Controls.Add(this.label13);
            this.pnlResultados.Controls.Add(this.lblEmail);
            this.pnlResultados.Controls.Add(this.label10);
            this.pnlResultados.Controls.Add(this.lblApellidoMaterno);
            this.pnlResultados.Controls.Add(this.label9);
            this.pnlResultados.Controls.Add(this.lblApellidoPaterno);
            this.pnlResultados.Controls.Add(this.label7);
            this.pnlResultados.Controls.Add(this.Bienvenido);
            this.pnlResultados.Location = new System.Drawing.Point(0, 135);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(725, 430);
            this.pnlResultados.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(188, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 21);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "............";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre:";
            // 
            // BtnSalida
            // 
            this.BtnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalida.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalida.Image")));
            this.BtnSalida.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalida.Location = new System.Drawing.Point(402, 329);
            this.BtnSalida.Name = "BtnSalida";
            this.BtnSalida.Size = new System.Drawing.Size(179, 69);
            this.BtnSalida.TabIndex = 24;
            this.BtnSalida.Text = "Registrar Salida";
            this.BtnSalida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalida.UseVisualStyleBackColor = false;
            this.BtnSalida.Click += new System.EventHandler(this.BtnSalida_Click);
            // 
            // BtnEntrada
            // 
            this.BtnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrada.Image = ((System.Drawing.Image)(resources.GetObject("BtnEntrada.Image")));
            this.BtnEntrada.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEntrada.Location = new System.Drawing.Point(165, 329);
            this.BtnEntrada.Name = "BtnEntrada";
            this.BtnEntrada.Size = new System.Drawing.Size(179, 69);
            this.BtnEntrada.TabIndex = 23;
            this.BtnEntrada.Text = "Registrar Asistencia";
            this.BtnEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEntrada.UseVisualStyleBackColor = false;
            this.BtnEntrada.Click += new System.EventHandler(this.BtnEntrada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(384, 29);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(79, 32);
            this.lblCargo.TabIndex = 21;
            this.lblCargo.Text = ".............";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(188, 256);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 21);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "............";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(102, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "Estado:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(188, 224);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(46, 21);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "............";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(102, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "Telefono:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(172, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 21);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "............";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Apellido Matermo:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(246, 160);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(46, 21);
            this.lblApellidoMaterno.TabIndex = 14;
            this.lblApellidoMaterno.Text = "............";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(240, 128);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(46, 21);
            this.lblApellidoPaterno.TabIndex = 12;
            this.lblApellidoPaterno.Text = "............";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Apellido Patermo:";
            // 
            // Bienvenido
            // 
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.Location = new System.Drawing.Point(235, 29);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(134, 32);
            this.Bienvenido.TabIndex = 7;
            this.Bienvenido.Text = "Bienvenido";
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 565);
            this.Controls.Add(this.pnlResultados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAsistencia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAsistencia_Load);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CheckEstudiante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.CheckBox CheckDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button BtnSalida;
        private System.Windows.Forms.Button BtnEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
    }
}