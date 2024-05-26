namespace CapaPresentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.SlideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Estudiante = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SlideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Escritorio = new System.Windows.Forms.Panel();
            this.upla = new System.Windows.Forms.PictureBox();
            this.SlideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Escritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upla)).BeginInit();
            this.SuspendLayout();
            // 
            // SlideBar
            // 
            this.SlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(115)))));
            this.SlideBar.Controls.Add(this.panel1);
            this.SlideBar.Controls.Add(this.panel2);
            this.SlideBar.Controls.Add(this.panel3);
            this.SlideBar.Controls.Add(this.panel4);
            this.SlideBar.Controls.Add(this.panel5);
            this.SlideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideBar.Location = new System.Drawing.Point(0, 0);
            this.SlideBar.MaximumSize = new System.Drawing.Size(175, 600);
            this.SlideBar.MinimumSize = new System.Drawing.Size(60, 600);
            this.SlideBar.Name = "SlideBar";
            this.SlideBar.Size = new System.Drawing.Size(175, 600);
            this.SlideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 110);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(9, 47);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 31);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 50);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-5, -12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(185, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "               Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Estudiante);
            this.panel3.Location = new System.Drawing.Point(3, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 50);
            this.panel3.TabIndex = 4;
            // 
            // Estudiante
            // 
            this.Estudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estudiante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudiante.ForeColor = System.Drawing.Color.White;
            this.Estudiante.Image = ((System.Drawing.Image)(resources.GetObject("Estudiante.Image")));
            this.Estudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estudiante.Location = new System.Drawing.Point(-5, -12);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Estudiante.Size = new System.Drawing.Size(185, 76);
            this.Estudiante.TabIndex = 2;
            this.Estudiante.Text = "               Estudiante";
            this.Estudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estudiante.UseMnemonic = false;
            this.Estudiante.UseVisualStyleBackColor = true;
            this.Estudiante.Click += new System.EventHandler(this.Estudiante_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 50);
            this.panel4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-5, -12);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(185, 76);
            this.button4.TabIndex = 2;
            this.button4.Text = "               Docente";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(3, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 50);
            this.panel5.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-5, -12);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(185, 76);
            this.button5.TabIndex = 2;
            this.button5.Text = "               Asistencia";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SlideBarTimer
            // 
            this.SlideBarTimer.Interval = 10;
            this.SlideBarTimer.Tick += new System.EventHandler(this.SlideBarTimer_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 35);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button2);
            this.panel7.Location = new System.Drawing.Point(869, 1);
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
            // Escritorio
            // 
            this.Escritorio.BackColor = System.Drawing.Color.White;
            this.Escritorio.Controls.Add(this.upla);
            this.Escritorio.Location = new System.Drawing.Point(175, 35);
            this.Escritorio.MaximumSize = new System.Drawing.Size(740, 565);
            this.Escritorio.MinimumSize = new System.Drawing.Size(625, 565);
            this.Escritorio.Name = "Escritorio";
            this.Escritorio.Size = new System.Drawing.Size(725, 565);
            this.Escritorio.TabIndex = 2;
            // 
            // upla
            // 
            this.upla.Image = ((System.Drawing.Image)(resources.GetObject("upla.Image")));
            this.upla.Location = new System.Drawing.Point(232, 130);
            this.upla.Name = "upla";
            this.upla.Size = new System.Drawing.Size(171, 247);
            this.upla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upla.TabIndex = 0;
            this.upla.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Escritorio);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.SlideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.SlideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.Escritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SlideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Estudiante;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SlideBarTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel Escritorio;
        private System.Windows.Forms.PictureBox upla;
    }
}

