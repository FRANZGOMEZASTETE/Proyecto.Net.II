namespace CapaPresentacion
{
    partial class FrmEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiante));
            this.Control1 = new System.Windows.Forms.TabControl();
            this.Mantenimiento = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNum_Doc = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataEstudiante = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Control1.SuspendLayout();
            this.Mantenimiento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiante)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control1
            // 
            this.Control1.Controls.Add(this.Mantenimiento);
            this.Control1.Controls.Add(this.tabPage2);
            this.Control1.Location = new System.Drawing.Point(0, 35);
            this.Control1.Name = "Control1";
            this.Control1.SelectedIndex = 0;
            this.Control1.Size = new System.Drawing.Size(725, 525);
            this.Control1.TabIndex = 0;
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.Controls.Add(this.panel2);
            this.Mantenimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.Mantenimiento.Size = new System.Drawing.Size(717, 499);
            this.Mantenimiento.TabIndex = 0;
            this.Mantenimiento.Text = "Mantenimiento Estudiante";
            this.Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textApellidoMaterno);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtApellidoPaterno);
            this.panel2.Controls.Add(this.checkEstado);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtNum_Doc);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 304);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Codigo:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 32);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(178, 25);
            this.txtId.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(522, 164);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "        Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Apellido Materno:";
            // 
            // textApellidoMaterno
            // 
            this.textApellidoMaterno.Location = new System.Drawing.Point(229, 144);
            this.textApellidoMaterno.Multiline = true;
            this.textApellidoMaterno.Name = "textApellidoMaterno";
            this.textApellidoMaterno.Size = new System.Drawing.Size(178, 25);
            this.textApellidoMaterno.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(15, 257);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(192, 25);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(15, 144);
            this.txtApellidoPaterno.Multiline = true;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(178, 25);
            this.txtApellidoPaterno.TabIndex = 12;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstado.Location = new System.Drawing.Point(379, 82);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(76, 17);
            this.checkEstado.TabIndex = 10;
            this.checkEstado.Text = "ESTADO";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(513, 93);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(154, 46);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "       Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 200);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 25);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 82);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(295, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // txtNum_Doc
            // 
            this.txtNum_Doc.Location = new System.Drawing.Point(229, 35);
            this.txtNum_Doc.Multiline = true;
            this.txtNum_Doc.Name = "txtNum_Doc";
            this.txtNum_Doc.Size = new System.Drawing.Size(178, 25);
            this.txtNum_Doc.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGreen;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(522, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(136, 46);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "        Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista Estudiante";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnListar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(9, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 78);
            this.panel3.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Yellow;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(552, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListar.Size = new System.Drawing.Size(111, 44);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "        Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(96, 29);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 30);
            this.txtBuscar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataEstudiante);
            this.panel1.Location = new System.Drawing.Point(9, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 383);
            this.panel1.TabIndex = 1;
            // 
            // dataEstudiante
            // 
            this.dataEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstudiante.Location = new System.Drawing.Point(3, 3);
            this.dataEstudiante.Name = "dataEstudiante";
            this.dataEstudiante.RowHeadersWidth = 62;
            this.dataEstudiante.Size = new System.Drawing.Size(693, 377);
            this.dataEstudiante.TabIndex = 0;
            this.dataEstudiante.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEstudiante_CellContentDoubleClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(725, 35);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSalir);
            this.panel7.Location = new System.Drawing.Point(691, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(31, 31);
            this.panel7.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(-1, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(522, 237);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(136, 45);
            this.button2.TabIndex = 26;
            this.button2.Text = "        Reporte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 565);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiante";
            this.Text = "Form1";
            this.Control1.ResumeLayout(false);
            this.Mantenimiento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiante)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Control1;
        private System.Windows.Forms.TabPage Mantenimiento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNum_Doc;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataEstudiante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button2;
    }
}