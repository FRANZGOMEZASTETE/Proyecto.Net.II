namespace CapaPresentacion
{
    partial class FrmInforme
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
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDUPLADataSet = new CapaPresentacion.BDUPLADataSet();
            this.bDUPLADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDUPLADataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDUPLADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDUPLADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDUPLADataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDUPLADataSet
            // 
            this.bDUPLADataSet.DataSetName = "BDUPLADataSet";
            this.bDUPLADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDUPLADataSetBindingSource
            // 
            this.bDUPLADataSetBindingSource.DataSource = this.bDUPLADataSet;
            this.bDUPLADataSetBindingSource.Position = 0;
            // 
            // bDUPLADataSetBindingSource1
            // 
            this.bDUPLADataSetBindingSource1.DataSource = this.bDUPLADataSet;
            this.bDUPLADataSetBindingSource1.Position = 0;
            // 
            // FrmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInforme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDUPLADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDUPLADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDUPLADataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDUPLADataSetBindingSource;
        private BDUPLADataSet bDUPLADataSet;
        private System.Windows.Forms.BindingSource bDUPLADataSetBindingSource1;
    }
}