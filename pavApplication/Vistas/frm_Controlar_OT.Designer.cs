namespace pavApplication.Vistas
{
    partial class frm_Controlar_OT
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
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_estimado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_nro_ot = new System.Windows.Forms.Label();
            this.lbl_numero_ot = new System.Windows.Forms.Label();
            this.btn_completar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pav_dbDataSet = new pavApplication._pav_dbDataSet();
            this.empleadosTableAdapter = new pavApplication._pav_dbDataSetTableAdapters.empleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToDeleteRows = false;
            this.dgv_detalles.AllowUserToResizeColumns = false;
            this.dgv_detalles.AllowUserToResizeRows = false;
            this.dgv_detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detalle,
            this.legajo_empleado,
            this.id_maquina,
            this.estado,
            this.fecha_hora_inicio,
            this.tiempo_estimado,
            this.tiempo_real});
            this.dgv_detalles.Location = new System.Drawing.Point(12, 37);
            this.dgv_detalles.MultiSelect = false;
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_detalles.RowTemplate.Height = 24;
            this.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles.Size = new System.Drawing.Size(963, 535);
            this.dgv_detalles.TabIndex = 0;
            this.dgv_detalles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellClick);
            this.dgv_detalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellContentClick);
            this.dgv_detalles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_detalles_CellMouseClick);
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "Nro Boleta";
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.ReadOnly = true;
            // 
            // legajo_empleado
            // 
            this.legajo_empleado.HeaderText = "Empleado Asignado";
            this.legajo_empleado.Name = "legajo_empleado";
            this.legajo_empleado.ReadOnly = true;
            // 
            // id_maquina
            // 
            this.id_maquina.HeaderText = "ID Maquina";
            this.id_maquina.Name = "id_maquina";
            this.id_maquina.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // fecha_hora_inicio
            // 
            this.fecha_hora_inicio.HeaderText = "Inicio";
            this.fecha_hora_inicio.Name = "fecha_hora_inicio";
            this.fecha_hora_inicio.ReadOnly = true;
            // 
            // tiempo_estimado
            // 
            this.tiempo_estimado.HeaderText = "Tiempo Estimado";
            this.tiempo_estimado.Name = "tiempo_estimado";
            this.tiempo_estimado.ReadOnly = true;
            // 
            // tiempo_real
            // 
            this.tiempo_real.HeaderText = "Tiempo Real";
            this.tiempo_real.Name = "tiempo_real";
            this.tiempo_real.ReadOnly = true;
            // 
            // lbl_nro_ot
            // 
            this.lbl_nro_ot.AutoSize = true;
            this.lbl_nro_ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_ot.Location = new System.Drawing.Point(7, 9);
            this.lbl_nro_ot.Name = "lbl_nro_ot";
            this.lbl_nro_ot.Size = new System.Drawing.Size(270, 25);
            this.lbl_nro_ot.TabIndex = 1;
            this.lbl_nro_ot.Text = "Número Orden de Trabajo:";
            // 
            // lbl_numero_ot
            // 
            this.lbl_numero_ot.AutoSize = true;
            this.lbl_numero_ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_ot.Location = new System.Drawing.Point(347, 12);
            this.lbl_numero_ot.Name = "lbl_numero_ot";
            this.lbl_numero_ot.Size = new System.Drawing.Size(88, 20);
            this.lbl_numero_ot.TabIndex = 2;
            this.lbl_numero_ot.Text = "numeroOT";
            this.lbl_numero_ot.Click += new System.EventHandler(this.lbl_numero_ot_Click);
            // 
            // btn_completar
            // 
            this.btn_completar.Enabled = false;
            this.btn_completar.Location = new System.Drawing.Point(981, 172);
            this.btn_completar.Name = "btn_completar";
            this.btn_completar.Size = new System.Drawing.Size(296, 134);
            this.btn_completar.TabIndex = 1;
            this.btn_completar.Text = "Completar Boleta";
            this.btn_completar.UseVisualStyleBackColor = true;
            this.btn_completar.Click += new System.EventHandler(this.btn_completar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(210, 3);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(86, 123);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar Boleta";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(981, 444);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(296, 128);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(981, 312);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(296, 126);
            this.btn_finalizar.TabIndex = 2;
            this.btn_finalizar.Text = "Finalizar Orden de Trabajo";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_legajo);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btn_iniciar);
            this.panel1.Location = new System.Drawing.Point(981, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 129);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.Location = new System.Drawing.Point(6, 9);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(121, 17);
            this.lbl_legajo.TabIndex = 2;
            this.lbl_legajo.Text = "Legajo empleado:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadosBindingSource;
            this.comboBox1.DisplayMember = "legajo_empleado";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "legajo_empleado";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this._pav_dbDataSet;
            // 
            // _pav_dbDataSet
            // 
            this._pav_dbDataSet.DataSetName = "_pav_dbDataSet";
            this._pav_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Controlar_OT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_completar);
            this.Controls.Add(this.lbl_numero_ot);
            this.Controls.Add(this.lbl_nro_ot);
            this.Controls.Add(this.dgv_detalles);
            this.Name = "frm_Controlar_OT";
            this.Text = "frm_Controlar_OT";
            this.Load += new System.EventHandler(this.frm_Controlar_OT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.Label lbl_nro_ot;
        private System.Windows.Forms.Label lbl_numero_ot;
        private System.Windows.Forms.Button btn_completar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private _pav_dbDataSet _pav_dbDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private _pav_dbDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_estimado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_real;
    }
}