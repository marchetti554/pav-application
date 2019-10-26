using System;

namespace pavApplication.Views
{
    partial class frm_Clientes
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_responsables = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_buscarRes = new System.Windows.Forms.ComboBox();
            this.cmb_clientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_responsables = new System.Windows.Forms.TextBox();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.panel_clientes = new System.Windows.Forms.Panel();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.btn_agregar_cliente = new System.Windows.Forms.Button();
            this.btn_nuevo_cliente = new System.Windows.Forms.Button();
            this.txt_cliente_email = new System.Windows.Forms.TextBox();
            this.txt_cliente_telefono = new System.Windows.Forms.TextBox();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_razon_social = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_empresa_pertenece = new System.Windows.Forms.TextBox();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.txt_resp_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_resp_telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_eliminar_resp = new System.Windows.Forms.Button();
            this.btn_modificar_resp = new System.Windows.Forms.Button();
            this.btn_agregar_resp = new System.Windows.Forms.Button();
            this.btn_nuevo_resp = new System.Windows.Forms.Button();
            this.txt_resp_apellido = new System.Windows.Forms.TextBox();
            this.txt_resp_nombre = new System.Windows.Forms.TextBox();
            this.txt_resp_dni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsables)).BeginInit();
            this.panel_clientes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.razon_social,
            this.email,
            this.telefono});
            this.dgv_clientes.Location = new System.Drawing.Point(294, 65);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(1070, 310);
            this.dgv_clientes.TabIndex = 0;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            this.dgv_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Cliente ID";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razón Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Télefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // dgv_responsables
            // 
            this.dgv_responsables.AllowUserToAddRows = false;
            this.dgv_responsables.AllowUserToDeleteRows = false;
            this.dgv_responsables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_responsables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_responsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_responsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombre,
            this.apellido,
            this.telefono_1,
            this.email_1,
            this.id_cliente_1});
            this.dgv_responsables.Location = new System.Drawing.Point(294, 430);
            this.dgv_responsables.MultiSelect = false;
            this.dgv_responsables.Name = "dgv_responsables";
            this.dgv_responsables.ReadOnly = true;
            this.dgv_responsables.RowTemplate.Height = 24;
            this.dgv_responsables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_responsables.Size = new System.Drawing.Size(1070, 309);
            this.dgv_responsables.TabIndex = 1;
            this.dgv_responsables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_responsables_CellContentClick);
            // 
            // dni
            // 
            this.dni.HeaderText = "Documento";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
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
            // telefono_1
            // 
            this.telefono_1.HeaderText = "Telefono";
            this.telefono_1.Name = "telefono_1";
            this.telefono_1.ReadOnly = true;
            // 
            // email_1
            // 
            this.email_1.HeaderText = "Email";
            this.email_1.Name = "email_1";
            this.email_1.ReadOnly = true;
            // 
            // id_cliente_1
            // 
            this.id_cliente_1.HeaderText = "Cliente ID";
            this.id_cliente_1.Name = "id_cliente_1";
            this.id_cliente_1.ReadOnly = true;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.Location = new System.Drawing.Point(6, 20);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(122, 36);
            this.lbl_clientes.TabIndex = 2;
            this.lbl_clientes.Text = "Clientes";
            // 
            // lbl_responsable
            // 
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_responsable.Location = new System.Drawing.Point(6, 388);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(205, 36);
            this.lbl_responsable.TabIndex = 3;
            this.lbl_responsable.Text = "Responsables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar por:";
            // 
            // cmb_buscarRes
            // 
            this.cmb_buscarRes.FormattingEnabled = true;
            this.cmb_buscarRes.Location = new System.Drawing.Point(378, 391);
            this.cmb_buscarRes.Name = "cmb_buscarRes";
            this.cmb_buscarRes.Size = new System.Drawing.Size(204, 24);
            this.cmb_buscarRes.TabIndex = 2;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(378, 31);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(204, 24);
            this.cmb_clientes.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor:";
            // 
            // txt_responsables
            // 
            this.txt_responsables.Location = new System.Drawing.Point(687, 394);
            this.txt_responsables.Name = "txt_responsables";
            this.txt_responsables.Size = new System.Drawing.Size(281, 22);
            this.txt_responsables.TabIndex = 3;
            // 
            // txt_clientes
            // 
            this.txt_clientes.Location = new System.Drawing.Point(687, 33);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(281, 22);
            this.txt_clientes.TabIndex = 1;
            // 
            // panel_clientes
            // 
            this.panel_clientes.Controls.Add(this.btn_eliminar_cliente);
            this.panel_clientes.Controls.Add(this.btn_modificar_cliente);
            this.panel_clientes.Controls.Add(this.btn_agregar_cliente);
            this.panel_clientes.Controls.Add(this.btn_nuevo_cliente);
            this.panel_clientes.Controls.Add(this.txt_cliente_email);
            this.panel_clientes.Controls.Add(this.txt_cliente_telefono);
            this.panel_clientes.Controls.Add(this.txt_razon_social);
            this.panel_clientes.Controls.Add(this.label6);
            this.panel_clientes.Controls.Add(this.label1);
            this.panel_clientes.Controls.Add(this.lbl_razon_social);
            this.panel_clientes.Location = new System.Drawing.Point(12, 65);
            this.panel_clientes.Name = "panel_clientes";
            this.panel_clientes.Size = new System.Drawing.Size(276, 320);
            this.panel_clientes.TabIndex = 1;
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(15, 275);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_eliminar_cliente.TabIndex = 6;
            this.btn_eliminar_cliente.Text = "Eliminar";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = true;
            this.btn_eliminar_cliente.Click += new System.EventHandler(this.btn_eliminar_cliente_Click_1);
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.Location = new System.Drawing.Point(15, 236);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_modificar_cliente.TabIndex = 5;
            this.btn_modificar_cliente.Text = "Modificar";
            this.btn_modificar_cliente.UseVisualStyleBackColor = true;
            this.btn_modificar_cliente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // btn_agregar_cliente
            // 
            this.btn_agregar_cliente.Location = new System.Drawing.Point(15, 197);
            this.btn_agregar_cliente.Name = "btn_agregar_cliente";
            this.btn_agregar_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_agregar_cliente.TabIndex = 4;
            this.btn_agregar_cliente.Text = "Agregar";
            this.btn_agregar_cliente.UseVisualStyleBackColor = true;
            this.btn_agregar_cliente.Click += new System.EventHandler(this.btn_agregar_cliente_Click_1);
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(15, 158);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_nuevo_cliente.TabIndex = 3;
            this.btn_nuevo_cliente.Text = "Limpiar";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = true;
            this.btn_nuevo_cliente.Click += new System.EventHandler(this.btn_nuevo_cliente_Click);
            // 
            // txt_cliente_email
            // 
            this.txt_cliente_email.Location = new System.Drawing.Point(15, 126);
            this.txt_cliente_email.MaxLength = 40;
            this.txt_cliente_email.Name = "txt_cliente_email";
            this.txt_cliente_email.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_email.TabIndex = 2;
            // 
            // txt_cliente_telefono
            // 
            this.txt_cliente_telefono.Location = new System.Drawing.Point(15, 75);
            this.txt_cliente_telefono.MaxLength = 40;
            this.txt_cliente_telefono.Name = "txt_cliente_telefono";
            this.txt_cliente_telefono.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_telefono.TabIndex = 1;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(15, 30);
            this.txt_razon_social.MaxLength = 30;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(248, 22);
            this.txt_razon_social.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefono:";
            // 
            // lbl_razon_social
            // 
            this.lbl_razon_social.AutoSize = true;
            this.lbl_razon_social.Location = new System.Drawing.Point(12, 10);
            this.lbl_razon_social.Name = "lbl_razon_social";
            this.lbl_razon_social.Size = new System.Drawing.Size(95, 17);
            this.lbl_razon_social.TabIndex = 9;
            this.lbl_razon_social.Text = "Razón Social:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_empresa_pertenece);
            this.panel1.Controls.Add(this.lbl_empresa);
            this.panel1.Controls.Add(this.txt_resp_email);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_resp_telefono);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_eliminar_resp);
            this.panel1.Controls.Add(this.btn_modificar_resp);
            this.panel1.Controls.Add(this.btn_agregar_resp);
            this.panel1.Controls.Add(this.btn_nuevo_resp);
            this.panel1.Controls.Add(this.txt_resp_apellido);
            this.panel1.Controls.Add(this.txt_resp_nombre);
            this.panel1.Controls.Add(this.txt_resp_dni);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 453);
            this.panel1.TabIndex = 14;
            // 
            // txt_empresa_pertenece
            // 
            this.txt_empresa_pertenece.Location = new System.Drawing.Point(15, 266);
            this.txt_empresa_pertenece.Name = "txt_empresa_pertenece";
            this.txt_empresa_pertenece.ReadOnly = true;
            this.txt_empresa_pertenece.Size = new System.Drawing.Size(248, 22);
            this.txt_empresa_pertenece.TabIndex = 11;
            this.txt_empresa_pertenece.TextChanged += new System.EventHandler(this.txt_empresa_pertenece_TextChanged);
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Location = new System.Drawing.Point(12, 246);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(179, 17);
            this.lbl_empresa.TabIndex = 12;
            this.lbl_empresa.Text = "Empresa al que pertenece:";
            // 
            // txt_resp_email
            // 
            this.txt_resp_email.Location = new System.Drawing.Point(15, 212);
            this.txt_resp_email.Name = "txt_resp_email";
            this.txt_resp_email.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_email.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email:";
            // 
            // txt_resp_telefono
            // 
            this.txt_resp_telefono.Location = new System.Drawing.Point(15, 165);
            this.txt_resp_telefono.Name = "txt_resp_telefono";
            this.txt_resp_telefono.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_telefono.TabIndex = 3;
            this.txt_resp_telefono.TextChanged += new System.EventHandler(this.txt_resp_telefono_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefono:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btn_eliminar_resp
            // 
            this.btn_eliminar_resp.Location = new System.Drawing.Point(15, 414);
            this.btn_eliminar_resp.Name = "btn_eliminar_resp";
            this.btn_eliminar_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_eliminar_resp.TabIndex = 8;
            this.btn_eliminar_resp.Text = "Eliminar";
            this.btn_eliminar_resp.UseVisualStyleBackColor = true;
            this.btn_eliminar_resp.Click += new System.EventHandler(this.btn_eliminar_resp_Click_1);
            // 
            // btn_modificar_resp
            // 
            this.btn_modificar_resp.Location = new System.Drawing.Point(15, 375);
            this.btn_modificar_resp.Name = "btn_modificar_resp";
            this.btn_modificar_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_modificar_resp.TabIndex = 7;
            this.btn_modificar_resp.Text = "Modificar";
            this.btn_modificar_resp.UseVisualStyleBackColor = true;
            this.btn_modificar_resp.Click += new System.EventHandler(this.btn_modificar_resp_Click);
            // 
            // btn_agregar_resp
            // 
            this.btn_agregar_resp.Location = new System.Drawing.Point(15, 336);
            this.btn_agregar_resp.Name = "btn_agregar_resp";
            this.btn_agregar_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_agregar_resp.TabIndex = 6;
            this.btn_agregar_resp.Text = "Agregar";
            this.btn_agregar_resp.UseVisualStyleBackColor = true;
            this.btn_agregar_resp.Click += new System.EventHandler(this.btn_agregar_resp_Click);
            // 
            // btn_nuevo_resp
            // 
            this.btn_nuevo_resp.Location = new System.Drawing.Point(15, 297);
            this.btn_nuevo_resp.Name = "btn_nuevo_resp";
            this.btn_nuevo_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_nuevo_resp.TabIndex = 5;
            this.btn_nuevo_resp.Text = "Nuevo";
            this.btn_nuevo_resp.UseVisualStyleBackColor = true;
            // 
            // txt_resp_apellido
            // 
            this.txt_resp_apellido.Location = new System.Drawing.Point(15, 120);
            this.txt_resp_apellido.Name = "txt_resp_apellido";
            this.txt_resp_apellido.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_apellido.TabIndex = 2;
            // 
            // txt_resp_nombre
            // 
            this.txt_resp_nombre.Location = new System.Drawing.Point(15, 75);
            this.txt_resp_nombre.Name = "txt_resp_nombre";
            this.txt_resp_nombre.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_nombre.TabIndex = 1;
            // 
            // txt_resp_dni
            // 
            this.txt_resp_dni.Location = new System.Drawing.Point(15, 30);
            this.txt_resp_dni.Name = "txt_resp_dni";
            this.txt_resp_dni.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_dni.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "DNI:";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1103, 761);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(261, 120);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1377, 891);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_clientes);
            this.Controls.Add(this.txt_clientes);
            this.Controls.Add(this.txt_responsables);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.cmb_buscarRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_responsable);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.dgv_responsables);
            this.Controls.Add(this.dgv_clientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas y Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsables)).EndInit();
            this.panel_clientes.ResumeLayout(false);
            this.panel_clientes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridView dgv_responsables;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_buscarRes;
        private System.Windows.Forms.ComboBox cmb_clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_responsables;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.Panel panel_clientes;
        private System.Windows.Forms.Label lbl_razon_social;
        private System.Windows.Forms.Button btn_eliminar_cliente;
        private System.Windows.Forms.Button btn_modificar_cliente;
        private System.Windows.Forms.Button btn_agregar_cliente;
        private System.Windows.Forms.Button btn_nuevo_cliente;
        private System.Windows.Forms.TextBox txt_cliente_email;
        private System.Windows.Forms.TextBox txt_cliente_telefono;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_resp_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_resp_telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_eliminar_resp;
        private System.Windows.Forms.Button btn_modificar_resp;
        private System.Windows.Forms.Button btn_agregar_resp;
        private System.Windows.Forms.Button btn_nuevo_resp;
        private System.Windows.Forms.TextBox txt_resp_apellido;
        private System.Windows.Forms.TextBox txt_resp_nombre;
        private System.Windows.Forms.TextBox txt_resp_dni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.TextBox txt_empresa_pertenece;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente_1;
    }
}