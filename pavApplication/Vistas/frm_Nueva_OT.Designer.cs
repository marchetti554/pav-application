namespace pavApplication.Vistas
{
    partial class frm_Nueva_OT
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregar_detalle = new System.Windows.Forms.Button();
            this.lbl_desc_detalle = new System.Windows.Forms.Label();
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion_calibracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion_trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pav_dbDataSet1 = new pavApplication._pav_dbDataSet1();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nmr_cant_piezas = new System.Windows.Forms.NumericUpDown();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_cantidad_piezas = new System.Windows.Forms.Label();
            this.lbl_maquina = new System.Windows.Forms.Label();
            this.lbl_tipo_maquina = new System.Windows.Forms.Label();
            this.cmb_tipo_maquina = new System.Windows.Forms.ComboBox();
            this.tiposmaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_maquina = new System.Windows.Forms.ComboBox();
            this.maquinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_horas_estimadas = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.lbl_nro_ot = new System.Windows.Forms.Label();
            this.lbl_next_ot = new System.Windows.Forms.Label();
            this.btn_crear_ot = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_nueva = new System.Windows.Forms.Button();
            this._pav_dbDataSet = new pavApplication._pav_dbDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new pavApplication._pav_dbDataSetTableAdapters.clientesTableAdapter();
            this.clientesTableAdapter1 = new pavApplication._pav_dbDataSet1TableAdapters.clientesTableAdapter();
            this.tipos_maquinaTableAdapter = new pavApplication._pav_dbDataSet1TableAdapters.tipos_maquinaTableAdapter();
            this.maquinasTableAdapter = new pavApplication._pav_dbDataSet1TableAdapters.maquinasTableAdapter();
            this.empleadosTableAdapter = new pavApplication._pav_dbDataSet1TableAdapters.empleadosTableAdapter();
            this.lbl_total = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.cmb_responsable = new System.Windows.Forms.ComboBox();
            this.pnl_fecha = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha_creacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_cant_piezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposmaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1080, 298);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(294, 66);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_agregar_detalle
            // 
            this.btn_agregar_detalle.Location = new System.Drawing.Point(1080, 39);
            this.btn_agregar_detalle.Name = "btn_agregar_detalle";
            this.btn_agregar_detalle.Size = new System.Drawing.Size(296, 71);
            this.btn_agregar_detalle.TabIndex = 14;
            this.btn_agregar_detalle.Text = "Agregar Boleta";
            this.btn_agregar_detalle.UseVisualStyleBackColor = true;
            this.btn_agregar_detalle.Click += new System.EventHandler(this.btn_agregar_detalle_Click);
            // 
            // lbl_desc_detalle
            // 
            this.lbl_desc_detalle.AutoSize = true;
            this.lbl_desc_detalle.Location = new System.Drawing.Point(5, 113);
            this.lbl_desc_detalle.Name = "lbl_desc_detalle";
            this.lbl_desc_detalle.Size = new System.Drawing.Size(152, 17);
            this.lbl_desc_detalle.TabIndex = 4;
            this.lbl_desc_detalle.Text = "Observacion actividad:";
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToResizeColumns = false;
            this.dgv_detalles.AllowUserToResizeRows = false;
            this.dgv_detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detalle,
            this.duracion_calibracion,
            this.duracion_trabajo,
            this.id_maquina});
            this.dgv_detalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgv_detalles.Location = new System.Drawing.Point(10, 382);
            this.dgv_detalles.MultiSelect = false;
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.RowTemplate.Height = 24;
            this.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles.Size = new System.Drawing.Size(1364, 189);
            this.dgv_detalles.TabIndex = 5;
            this.dgv_detalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellContentClick);
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "Nro Boleta";
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.ReadOnly = true;
            // 
            // duracion_calibracion
            // 
            this.duracion_calibracion.HeaderText = "Duración Calibración";
            this.duracion_calibracion.Name = "duracion_calibracion";
            this.duracion_calibracion.ReadOnly = true;
            // 
            // duracion_trabajo
            // 
            this.duracion_trabajo.HeaderText = "Duración Trabajo";
            this.duracion_trabajo.Name = "duracion_trabajo";
            this.duracion_trabajo.ReadOnly = true;
            // 
            // id_maquina
            // 
            this.id_maquina.HeaderText = "Máquina";
            this.id_maquina.Name = "id_maquina";
            this.id_maquina.ReadOnly = true;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this._pav_dbDataSet1;
            // 
            // _pav_dbDataSet1
            // 
            this._pav_dbDataSet1.DataSetName = "_pav_dbDataSet1";
            this._pav_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.DataSource = this.clientesBindingSource1;
            this.cmb_cliente.DisplayMember = "razon_social";
            this.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(8, 26);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(322, 24);
            this.cmb_cliente.TabIndex = 2;
            this.cmb_cliente.ValueMember = "id_cliente";
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this._pav_dbDataSet1;
            // 
            // nmr_cant_piezas
            // 
            this.nmr_cant_piezas.Location = new System.Drawing.Point(9, 126);
            this.nmr_cant_piezas.Name = "nmr_cant_piezas";
            this.nmr_cant_piezas.Size = new System.Drawing.Size(322, 22);
            this.nmr_cant_piezas.TabIndex = 4;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(5, 6);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(55, 17);
            this.lbl_cliente.TabIndex = 10;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_cantidad_piezas
            // 
            this.lbl_cantidad_piezas.AutoSize = true;
            this.lbl_cantidad_piezas.Location = new System.Drawing.Point(5, 106);
            this.lbl_cantidad_piezas.Name = "lbl_cantidad_piezas";
            this.lbl_cantidad_piezas.Size = new System.Drawing.Size(134, 17);
            this.lbl_cantidad_piezas.TabIndex = 12;
            this.lbl_cantidad_piezas.Text = "Cantidad de Piezas:";
            // 
            // lbl_maquina
            // 
            this.lbl_maquina.AutoSize = true;
            this.lbl_maquina.Location = new System.Drawing.Point(9, 58);
            this.lbl_maquina.Name = "lbl_maquina";
            this.lbl_maquina.Size = new System.Drawing.Size(66, 17);
            this.lbl_maquina.TabIndex = 13;
            this.lbl_maquina.Text = "Maquina:";
            // 
            // lbl_tipo_maquina
            // 
            this.lbl_tipo_maquina.AutoSize = true;
            this.lbl_tipo_maquina.Location = new System.Drawing.Point(8, 9);
            this.lbl_tipo_maquina.Name = "lbl_tipo_maquina";
            this.lbl_tipo_maquina.Size = new System.Drawing.Size(98, 17);
            this.lbl_tipo_maquina.TabIndex = 14;
            this.lbl_tipo_maquina.Text = "Tipo Maquina:";
            // 
            // cmb_tipo_maquina
            // 
            this.cmb_tipo_maquina.DisplayMember = "id_tipo_maquina";
            this.cmb_tipo_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_maquina.FormattingEnabled = true;
            this.cmb_tipo_maquina.Location = new System.Drawing.Point(10, 27);
            this.cmb_tipo_maquina.Name = "cmb_tipo_maquina";
            this.cmb_tipo_maquina.Size = new System.Drawing.Size(212, 24);
            this.cmb_tipo_maquina.TabIndex = 9;
            this.cmb_tipo_maquina.ValueMember = "id_tipo_maquina";
            this.cmb_tipo_maquina.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_maquina_SelectedIndexChanged);
            // 
            // tiposmaquinaBindingSource
            // 
            this.tiposmaquinaBindingSource.DataMember = "tipos_maquina";
            this.tiposmaquinaBindingSource.DataSource = this._pav_dbDataSet1;
            // 
            // cmb_maquina
            // 
            this.cmb_maquina.DisplayMember = "id_maquina";
            this.cmb_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maquina.FormattingEnabled = true;
            this.cmb_maquina.Location = new System.Drawing.Point(10, 78);
            this.cmb_maquina.Name = "cmb_maquina";
            this.cmb_maquina.Size = new System.Drawing.Size(211, 24);
            this.cmb_maquina.TabIndex = 10;
            this.cmb_maquina.ValueMember = "id_maquina";
            // 
            // maquinasBindingSource
            // 
            this.maquinasBindingSource.DataMember = "maquinas";
            this.maquinasBindingSource.DataSource = this._pav_dbDataSet1;
            // 
            // lbl_horas_estimadas
            // 
            this.lbl_horas_estimadas.AutoSize = true;
            this.lbl_horas_estimadas.Location = new System.Drawing.Point(233, 9);
            this.lbl_horas_estimadas.Name = "lbl_horas_estimadas";
            this.lbl_horas_estimadas.Size = new System.Drawing.Size(180, 17);
            this.lbl_horas_estimadas.TabIndex = 17;
            this.lbl_horas_estimadas.Text = "Cantidad horas calibracion:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(237, 29);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad horas trabajo:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(236, 79);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Precio horas calibración:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Precio horas trabajo:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(10, 247);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(229, 22);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown5.Location = new System.Drawing.Point(9, 294);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(230, 22);
            this.numericUpDown5.TabIndex = 7;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // lbl_nro_ot
            // 
            this.lbl_nro_ot.AutoSize = true;
            this.lbl_nro_ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_ot.Location = new System.Drawing.Point(12, 16);
            this.lbl_nro_ot.Name = "lbl_nro_ot";
            this.lbl_nro_ot.Size = new System.Drawing.Size(81, 20);
            this.lbl_nro_ot.TabIndex = 31;
            this.lbl_nro_ot.Text = "Nro. OT:";
            // 
            // lbl_next_ot
            // 
            this.lbl_next_ot.AutoSize = true;
            this.lbl_next_ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_next_ot.Location = new System.Drawing.Point(99, 16);
            this.lbl_next_ot.Name = "lbl_next_ot";
            this.lbl_next_ot.Size = new System.Drawing.Size(157, 20);
            this.lbl_next_ot.TabIndex = 32;
            this.lbl_next_ot.Text = "numeroOTSiguiente";
            // 
            // btn_crear_ot
            // 
            this.btn_crear_ot.Location = new System.Drawing.Point(1082, 117);
            this.btn_crear_ot.Name = "btn_crear_ot";
            this.btn_crear_ot.Size = new System.Drawing.Size(295, 88);
            this.btn_crear_ot.TabIndex = 16;
            this.btn_crear_ot.Text = "Crear Orden de Trabajo";
            this.btn_crear_ot.UseVisualStyleBackColor = true;
            this.btn_crear_ot.Click += new System.EventHandler(this.btn_crear_ot_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "______________________________________________";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_nueva
            // 
            this.btn_nueva.Location = new System.Drawing.Point(1079, 213);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(295, 79);
            this.btn_nueva.TabIndex = 17;
            this.btn_nueva.Text = "Nueva Orden de Trabajo";
            this.btn_nueva.UseVisualStyleBackColor = true;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // _pav_dbDataSet
            // 
            this._pav_dbDataSet.DataSetName = "_pav_dbDataSet";
            this._pav_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this._pav_dbDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // tipos_maquinaTableAdapter
            // 
            this.tipos_maquinaTableAdapter.ClearBeforeFill = true;
            // 
            // maquinasTableAdapter
            // 
            this.maquinasTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(7, 55);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(83, 17);
            this.lbl_total.TabIndex = 35;
            this.lbl_total.Text = "Precio total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Margen ganancia:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(10, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(8, 133);
            this.txt_observaciones.MaxLength = 200;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(438, 183);
            this.txt_observaciones.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 183);
            this.textBox2.MaxLength = 150;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 39);
            this.textBox2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Descripcion pieza:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(613, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Detalles:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(375, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 111);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_observaciones);
            this.panel2.Controls.Add(this.lbl_desc_detalle);
            this.panel2.Controls.Add(this.lbl_maquina);
            this.panel2.Controls.Add(this.lbl_tipo_maquina);
            this.panel2.Controls.Add(this.cmb_tipo_maquina);
            this.panel2.Controls.Add(this.cmb_maquina);
            this.panel2.Controls.Add(this.lbl_horas_estimadas);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Location = new System.Drawing.Point(617, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 325);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_responsable);
            this.panel3.Controls.Add(this.cmb_responsable);
            this.panel3.Controls.Add(this.cmb_cliente);
            this.panel3.Controls.Add(this.nmr_cant_piezas);
            this.panel3.Controls.Add(this.lbl_cliente);
            this.panel3.Controls.Add(this.lbl_cantidad_piezas);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDown4);
            this.panel3.Controls.Add(this.numericUpDown5);
            this.panel3.Location = new System.Drawing.Point(16, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 325);
            this.panel3.TabIndex = 1;
            // 
            // lbl_responsable
            // 
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.Location = new System.Drawing.Point(6, 54);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(95, 17);
            this.lbl_responsable.TabIndex = 44;
            this.lbl_responsable.Text = "Responsable:";
            // 
            // cmb_responsable
            // 
            this.cmb_responsable.DataSource = this.clientesBindingSource1;
            this.cmb_responsable.DisplayMember = "razon_social";
            this.cmb_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_responsable.FormattingEnabled = true;
            this.cmb_responsable.Location = new System.Drawing.Point(8, 74);
            this.cmb_responsable.Name = "cmb_responsable";
            this.cmb_responsable.Size = new System.Drawing.Size(322, 24);
            this.cmb_responsable.TabIndex = 3;
            this.cmb_responsable.ValueMember = "id_cliente";
            this.cmb_responsable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnl_fecha
            // 
            this.pnl_fecha.Controls.Add(this.txt_fecha_creacion);
            this.pnl_fecha.Controls.Add(this.label4);
            this.pnl_fecha.Controls.Add(this.dateTimePicker1);
            this.pnl_fecha.Controls.Add(this.lbl_fecha);
            this.pnl_fecha.Location = new System.Drawing.Point(375, 172);
            this.pnl_fecha.Name = "pnl_fecha";
            this.pnl_fecha.Size = new System.Drawing.Size(230, 192);
            this.pnl_fecha.TabIndex = 44;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(8, 114);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(165, 17);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "Fecha estimada entrega:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha creación:";
            // 
            // txt_fecha_creacion
            // 
            this.txt_fecha_creacion.Location = new System.Drawing.Point(11, 50);
            this.txt_fecha_creacion.Name = "txt_fecha_creacion";
            this.txt_fecha_creacion.ReadOnly = true;
            this.txt_fecha_creacion.Size = new System.Drawing.Size(212, 22);
            this.txt_fecha_creacion.TabIndex = 38;
            // 
            // frm_Nueva_OT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 583);
            this.Controls.Add(this.pnl_fecha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_nueva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_crear_ot);
            this.Controls.Add(this.lbl_next_ot);
            this.Controls.Add(this.lbl_nro_ot);
            this.Controls.Add(this.dgv_detalles);
            this.Controls.Add(this.btn_agregar_detalle);
            this.Controls.Add(this.btn_salir);
            this.Name = "frm_Nueva_OT";
            this.Text = "frm_Nueva_OT";
            this.Load += new System.EventHandler(this.frm_Nueva_OT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_cant_piezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposmaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_fecha.ResumeLayout(false);
            this.pnl_fecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_agregar_detalle;
        private System.Windows.Forms.Label lbl_desc_detalle;
        private System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.NumericUpDown nmr_cant_piezas;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_cantidad_piezas;
        private System.Windows.Forms.Label lbl_maquina;
        private System.Windows.Forms.Label lbl_tipo_maquina;
        private System.Windows.Forms.ComboBox cmb_tipo_maquina;
        private System.Windows.Forms.ComboBox cmb_maquina;
        private System.Windows.Forms.Label lbl_horas_estimadas;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label lbl_nro_ot;
        private System.Windows.Forms.Label lbl_next_ot;
        private System.Windows.Forms.Button btn_crear_ot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_nueva;
        private _pav_dbDataSet _pav_dbDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private _pav_dbDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private _pav_dbDataSet1 _pav_dbDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private _pav_dbDataSet1TableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.BindingSource tiposmaquinaBindingSource;
        private _pav_dbDataSet1TableAdapters.tipos_maquinaTableAdapter tipos_maquinaTableAdapter;
        private System.Windows.Forms.BindingSource maquinasBindingSource;
        private _pav_dbDataSet1TableAdapters.maquinasTableAdapter maquinasTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private _pav_dbDataSet1TableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion_calibracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion_trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_maquina;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.ComboBox cmb_responsable;
        private System.Windows.Forms.Panel pnl_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_fecha_creacion;
        private System.Windows.Forms.Label label4;
    }
}