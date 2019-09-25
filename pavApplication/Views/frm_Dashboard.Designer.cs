namespace pavApplication.Views
{
    partial class frm_Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ot = new System.Windows.Forms.Label();
            this._pav_dbDataSet = new pavApplication._pav_dbDataSet();
            this.pavdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordentrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_trabajoTableAdapter = new pavApplication._pav_dbDataSetTableAdapters.orden_trabajoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.btn_controlar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_filtrar_por = new System.Windows.Forms.Label();
            this.cmb_filtrar_por = new System.Windows.Forms.ComboBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeTrabajoToolStripMenuItem1,
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.máquinasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem1});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem,
            this.responsablesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem2});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // responsablesToolStripMenuItem
            // 
            this.responsablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem3});
            this.responsablesToolStripMenuItem.Name = "responsablesToolStripMenuItem";
            this.responsablesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.responsablesToolStripMenuItem.Text = "Responsables";
            // 
            // máquinasToolStripMenuItem
            // 
            this.máquinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.máquinasToolStripMenuItem.Name = "máquinasToolStripMenuItem";
            this.máquinasToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.máquinasToolStripMenuItem.Text = "Máquinas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeTrabajoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem4});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaciónToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_valor);
            this.panel1.Controls.Add(this.lbl_valor);
            this.panel1.Controls.Add(this.cmb_filtrar_por);
            this.panel1.Controls.Add(this.lbl_filtrar_por);
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(277, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 603);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_controlar);
            this.panel2.Controls.Add(this.lbl_ot);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(24, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 603);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_ot
            // 
            this.lbl_ot.AutoSize = true;
            this.lbl_ot.Location = new System.Drawing.Point(42, 28);
            this.lbl_ot.Name = "lbl_ot";
            this.lbl_ot.Size = new System.Drawing.Size(136, 17);
            this.lbl_ot.TabIndex = 1;
            this.lbl_ot.Text = "Ordenes de Trabajo";
            // 
            // _pav_dbDataSet
            // 
            this._pav_dbDataSet.DataSetName = "_pav_dbDataSet";
            this._pav_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pavdbDataSetBindingSource
            // 
            this.pavdbDataSetBindingSource.DataSource = this._pav_dbDataSet;
            this.pavdbDataSetBindingSource.Position = 0;
            // 
            // ordentrabajoBindingSource
            // 
            this.ordentrabajoBindingSource.DataMember = "orden_trabajo";
            this.ordentrabajoBindingSource.DataSource = this.pavdbDataSetBindingSource;
            // 
            // orden_trabajoTableAdapter
            // 
            this.orden_trabajoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 127);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nueva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.Location = new System.Drawing.Point(18, 18);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(136, 29);
            this.lbl_dashboard.TabIndex = 2;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // btn_controlar
            // 
            this.btn_controlar.Enabled = false;
            this.btn_controlar.Location = new System.Drawing.Point(26, 259);
            this.btn_controlar.Name = "btn_controlar";
            this.btn_controlar.Size = new System.Drawing.Size(168, 127);
            this.btn_controlar.TabIndex = 2;
            this.btn_controlar.Text = "Controlar";
            this.btn_controlar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(26, 447);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(168, 127);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_filtrar_por
            // 
            this.lbl_filtrar_por.AutoSize = true;
            this.lbl_filtrar_por.Location = new System.Drawing.Point(245, 28);
            this.lbl_filtrar_por.Name = "lbl_filtrar_por";
            this.lbl_filtrar_por.Size = new System.Drawing.Size(73, 17);
            this.lbl_filtrar_por.TabIndex = 3;
            this.lbl_filtrar_por.Text = "Filtrar por:";
            // 
            // cmb_filtrar_por
            // 
            this.cmb_filtrar_por.FormattingEnabled = true;
            this.cmb_filtrar_por.Location = new System.Drawing.Point(324, 26);
            this.cmb_filtrar_por.Name = "cmb_filtrar_por";
            this.cmb_filtrar_por.Size = new System.Drawing.Size(233, 24);
            this.cmb_filtrar_por.TabIndex = 4;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(575, 28);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(45, 17);
            this.lbl_valor.TabIndex = 5;
            this.lbl_valor.Text = "Valor:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(626, 28);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(336, 22);
            this.txt_valor.TabIndex = 6;
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Orden de Trabajo";
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem4.Text = "Consultar";
            // 
            // documentaciónToolStripMenuItem
            // 
            this.documentaciónToolStripMenuItem.Name = "documentaciónToolStripMenuItem";
            this.documentaciónToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.documentaciónToolStripMenuItem.Text = "Documentación";
            // 
            // ordenDeTrabajoToolStripMenuItem1
            // 
            this.ordenDeTrabajoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.controlarToolStripMenuItem});
            this.ordenDeTrabajoToolStripMenuItem1.Name = "ordenDeTrabajoToolStripMenuItem1";
            this.ordenDeTrabajoToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.ordenDeTrabajoToolStripMenuItem1.Text = "Orden de Trabajo";
            this.ordenDeTrabajoToolStripMenuItem1.Click += new System.EventHandler(this.ordenDeTrabajoToolStripMenuItem1_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // controlarToolStripMenuItem
            // 
            this.controlarToolStripMenuItem.Name = "controlarToolStripMenuItem";
            this.controlarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.controlarToolStripMenuItem.Text = "Controlar";
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Dashboard";
            this.Text = "Methfarbi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pavdbDataSetBindingSource;
        private _pav_dbDataSet _pav_dbDataSet;
        private System.Windows.Forms.BindingSource ordentrabajoBindingSource;
        private _pav_dbDataSetTableAdapters.orden_trabajoTableAdapter orden_trabajoTableAdapter;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_controlar;
        private System.Windows.Forms.ComboBox cmb_filtrar_por;
        private System.Windows.Forms.Label lbl_filtrar_por;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem documentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarToolStripMenuItem;
    }
}