namespace pavApplication
{
    partial class reporteFinalDif
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordenesCompletadas = new pavApplication.ordenesCompletadas();
            this.orden_trabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_trabajoTableAdapter = new pavApplication.ordenesCompletadasTableAdapters.orden_trabajoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesCompletadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_trabajoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.orden_trabajoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pavApplication.informeDiferenciaFinal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1033, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // ordenesCompletadas
            // 
            this.ordenesCompletadas.DataSetName = "ordenesCompletadas";
            this.ordenesCompletadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orden_trabajoBindingSource
            // 
            this.orden_trabajoBindingSource.DataMember = "orden_trabajo";
            this.orden_trabajoBindingSource.DataSource = this.ordenesCompletadas;
            // 
            // orden_trabajoTableAdapter
            // 
            this.orden_trabajoTableAdapter.ClearBeforeFill = true;
            // 
            // reporteFinalDif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 587);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteFinalDif";
            this.Text = "reporteFinalDif";
            this.Load += new System.EventHandler(this.reporteFinalDif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordenesCompletadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_trabajoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource orden_trabajoBindingSource;
        private ordenesCompletadas ordenesCompletadas;
        private ordenesCompletadasTableAdapters.orden_trabajoTableAdapter orden_trabajoTableAdapter;
    }
}