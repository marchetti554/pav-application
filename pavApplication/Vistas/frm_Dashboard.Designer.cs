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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_orden_trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_estimada_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_responsable_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_clientes_responsables = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_controlar = new System.Windows.Forms.Button();
            this.lbl_ot = new System.Windows.Forms.Label();
            this.btn_nueva_ot = new System.Windows.Forms.Button();
            this._pav_dbDataSet = new pavApplication._pav_dbDataSet();
            this.ordentrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pavdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDeTrabajoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_user_logged = new System.Windows.Forms.Label();
            this.lbl_nmb_usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavdbDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(266, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 665);
            this.panel1.TabIndex = 1;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_orden_trabajo,
            this.id_estado,
            this.fecha_estimada_entrega,
            this.dni_responsable_cliente,
            this.precio_total});
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 597);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_orden_trabajo
            // 
            this.id_orden_trabajo.HeaderText = "ID";
            this.id_orden_trabajo.Name = "id_orden_trabajo";
            // 
            // id_estado
            // 
            this.id_estado.HeaderText = "Estado";
            this.id_estado.Name = "id_estado";
            // 
            // fecha_estimada_entrega
            // 
            this.fecha_estimada_entrega.HeaderText = "Fecha Estimada Entrega";
            this.fecha_estimada_entrega.Name = "fecha_estimada_entrega";
            // 
            // dni_responsable_cliente
            // 
            this.dni_responsable_cliente.HeaderText = "DNI Contacto ";
            this.dni_responsable_cliente.Name = "dni_responsable_cliente";
            // 
            // precio_total
            // 
            this.precio_total.HeaderText = "Precio Total";
            this.precio_total.Name = "precio_total";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_clientes_responsables);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_controlar);
            this.panel2.Controls.Add(this.lbl_ot);
            this.panel2.Controls.Add(this.btn_nueva_ot);
            this.panel2.Location = new System.Drawing.Point(24, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 665);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sesión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(18, 549);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 37);
            this.button8.TabIndex = 10;
            this.button8.Text = "Salir";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 502);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Cerrar sesión";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 37);
            this.button6.TabIndex = 7;
            this.button6.Text = "Usuarios";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Empleados";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reportes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_clientes_responsables
            // 
            this.btn_clientes_responsables.Location = new System.Drawing.Point(18, 236);
            this.btn_clientes_responsables.Name = "btn_clientes_responsables";
            this.btn_clientes_responsables.Size = new System.Drawing.Size(179, 37);
            this.btn_clientes_responsables.TabIndex = 3;
            this.btn_clientes_responsables.Text = "Clientes y Responsables";
            this.btn_clientes_responsables.UseVisualStyleBackColor = false;
            this.btn_clientes_responsables.Click += new System.EventHandler(this.btn_clientes_responsables_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recursos";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(25, 149);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(168, 35);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_controlar
            // 
            this.btn_controlar.Location = new System.Drawing.Point(25, 101);
            this.btn_controlar.Name = "btn_controlar";
            this.btn_controlar.Size = new System.Drawing.Size(168, 35);
            this.btn_controlar.TabIndex = 1;
            this.btn_controlar.Text = "Controlar";
            this.btn_controlar.UseVisualStyleBackColor = false;
            this.btn_controlar.Click += new System.EventHandler(this.btn_controlar_Click);
            // 
            // lbl_ot
            // 
            this.lbl_ot.AutoSize = true;
            this.lbl_ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ot.Location = new System.Drawing.Point(34, 18);
            this.lbl_ot.Name = "lbl_ot";
            this.lbl_ot.Size = new System.Drawing.Size(154, 17);
            this.lbl_ot.TabIndex = 1;
            this.lbl_ot.Text = "Ordenes de Trabajo";
            this.lbl_ot.Click += new System.EventHandler(this.lbl_ot_Click);
            // 
            // btn_nueva_ot
            // 
            this.btn_nueva_ot.Location = new System.Drawing.Point(25, 54);
            this.btn_nueva_ot.Name = "btn_nueva_ot";
            this.btn_nueva_ot.Size = new System.Drawing.Size(168, 35);
            this.btn_nueva_ot.TabIndex = 0;
            this.btn_nueva_ot.Text = "Nueva";
            this.btn_nueva_ot.UseVisualStyleBackColor = false;
            this.btn_nueva_ot.Click += new System.EventHandler(this.button1_Click);
            // 
            // _pav_dbDataSet
            // 
            this._pav_dbDataSet.DataSetName = "_pav_dbDataSet";
            this._pav_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordentrabajoBindingSource
            // 
            this.ordentrabajoBindingSource.DataMember = "orden_trabajo";
            this.ordentrabajoBindingSource.DataSource = this.pavdbDataSetBindingSource;
            // 
            // pavdbDataSetBindingSource
            // 
            this.pavdbDataSetBindingSource.DataSource = this._pav_dbDataSet;
            this.pavdbDataSetBindingSource.Position = 0;
            // 
            // ordenDeTrabajoToolStripMenuItem1
            // 
            this.ordenDeTrabajoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.controlarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.ordenDeTrabajoToolStripMenuItem1.Name = "ordenDeTrabajoToolStripMenuItem1";
            this.ordenDeTrabajoToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.ordenDeTrabajoToolStripMenuItem1.Text = "Orden de Trabajo";
            this.ordenDeTrabajoToolStripMenuItem1.Click += new System.EventHandler(this.ordenDeTrabajoToolStripMenuItem1_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // controlarToolStripMenuItem
            // 
            this.controlarToolStripMenuItem.Name = "controlarToolStripMenuItem";
            this.controlarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.controlarToolStripMenuItem.Text = "Controlar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeTrabajoToolStripMenuItem1,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarUsuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.modificarPerfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar usuario";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // modificarPerfilToolStripMenuItem
            // 
            this.modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            this.modificarPerfilToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.modificarPerfilToolStripMenuItem.Text = "Modificar perfil";
            // 
            // lbl_user_logged
            // 
            this.lbl_user_logged.AutoSize = true;
            this.lbl_user_logged.Location = new System.Drawing.Point(272, 13);
            this.lbl_user_logged.Name = "lbl_user_logged";
            this.lbl_user_logged.Size = new System.Drawing.Size(142, 17);
            this.lbl_user_logged.TabIndex = 3;
            this.lbl_user_logged.Text = "Has ingresado como:";
            // 
            // lbl_nmb_usuario
            // 
            this.lbl_nmb_usuario.AutoSize = true;
            this.lbl_nmb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmb_usuario.Location = new System.Drawing.Point(420, 13);
            this.lbl_nmb_usuario.Name = "lbl_nmb_usuario";
            this.lbl_nmb_usuario.Size = new System.Drawing.Size(118, 17);
            this.lbl_nmb_usuario.TabIndex = 4;
            this.lbl_nmb_usuario.Text = "nombreUsuario";
            this.lbl_nmb_usuario.Click += new System.EventHandler(this.lbl_nmb_usuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(544, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permisos especiales - Solo para reportes.";
            this.label3.Visible = false;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1342, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nmb_usuario);
            this.Controls.Add(this.lbl_user_logged);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Methfarbi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_Dashboard_Activated);
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.Enter += new System.EventHandler(this.frm_Dashboard_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavdbDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pavdbDataSetBindingSource;
        private _pav_dbDataSet _pav_dbDataSet;
        private System.Windows.Forms.BindingSource ordentrabajoBindingSource;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.Button btn_nueva_ot;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_controlar;
        private System.Windows.Forms.Button btn_clientes_responsables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPerfilToolStripMenuItem;
        private System.Windows.Forms.Label lbl_user_logged;
        private System.Windows.Forms.Label lbl_nmb_usuario;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_orden_trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_estimada_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_responsable_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_total;
        private System.Windows.Forms.Label label3;
    }
}