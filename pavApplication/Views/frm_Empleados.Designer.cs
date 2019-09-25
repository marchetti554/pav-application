namespace pavApplication.Views
{
    partial class frm_Empleados
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
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pav_dbDataSet = new pavApplication._pav_dbDataSet();
            this.pavdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new pavApplication._pav_dbDataSetTableAdapters.empleadosTableAdapter();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.legajo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToAddRows = false;
            this.dgv_empleados.AllowUserToDeleteRows = false;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo_empleado,
            this.nombre,
            this.apellido,
            this.email,
            this.telefono,
            this.domicilio});
            this.dgv_empleados.Location = new System.Drawing.Point(284, 84);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.RowTemplate.Height = 24;
            this.dgv_empleados.Size = new System.Drawing.Size(749, 339);
            this.dgv_empleados.TabIndex = 18;
            this.dgv_empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // pavdbDataSetBindingSource
            // 
            this.pavdbDataSetBindingSource.DataSource = this._pav_dbDataSet;
            this.pavdbDataSetBindingSource.Position = 0;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(908, 34);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(125, 42);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 148);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(12, 197);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(250, 22);
            this.txt_telefono.TabIndex = 3;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(12, 247);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(250, 22);
            this.txt_domicilio.TabIndex = 4;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(12, 103);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(250, 22);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 54);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 22);
            this.txt_nombre.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(483, 54);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(407, 22);
            this.textBox7.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 286);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(250, 34);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Domicilio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Valor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // legajo_empleado
            // 
            this.legajo_empleado.HeaderText = "Legajo";
            this.legajo_empleado.Name = "legajo_empleado";
            this.legajo_empleado.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "empleados";
            this.empleadosBindingSource1.DataSource = this.pavdbDataSetBindingSource;
            // 
            // empleadosBindingSource2
            // 
            this.empleadosBindingSource2.DataMember = "empleados";
            this.empleadosBindingSource2.DataSource = this.pavdbDataSetBindingSource;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_domicilio);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Empleados";
            this.Text = "Empleados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.BindingSource pavdbDataSetBindingSource;
        private _pav_dbDataSet _pav_dbDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private _pav_dbDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private System.Windows.Forms.BindingSource empleadosBindingSource2;
    }
}