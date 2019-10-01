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
            this.dgv_responsables = new System.Windows.Forms.DataGridView();
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
            this.lbl_razon_social = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.txt_cliente_telefono = new System.Windows.Forms.TextBox();
            this.txt_cliente_email = new System.Windows.Forms.TextBox();
            this.btn_nuevo_cliente = new System.Windows.Forms.Button();
            this.btn_agregar_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.txt_resp_telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_resp_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(294, 65);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(1070, 310);
            this.dgv_clientes.TabIndex = 0;
            // 
            // dgv_responsables
            // 
            this.dgv_responsables.AllowUserToAddRows = false;
            this.dgv_responsables.AllowUserToDeleteRows = false;
            this.dgv_responsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_responsables.Location = new System.Drawing.Point(294, 430);
            this.dgv_responsables.Name = "dgv_responsables";
            this.dgv_responsables.ReadOnly = true;
            this.dgv_responsables.RowTemplate.Height = 24;
            this.dgv_responsables.Size = new System.Drawing.Size(1070, 309);
            this.dgv_responsables.TabIndex = 1;
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
            this.cmb_buscarRes.TabIndex = 6;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(378, 31);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(204, 24);
            this.cmb_clientes.TabIndex = 7;
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
            this.txt_responsables.TabIndex = 10;
            // 
            // txt_clientes
            // 
            this.txt_clientes.Location = new System.Drawing.Point(687, 33);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(281, 22);
            this.txt_clientes.TabIndex = 11;
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
            this.panel_clientes.Size = new System.Drawing.Size(276, 310);
            this.panel_clientes.TabIndex = 13;
            // 
            // lbl_razon_social
            // 
            this.lbl_razon_social.AutoSize = true;
            this.lbl_razon_social.Location = new System.Drawing.Point(12, 10);
            this.lbl_razon_social.Name = "lbl_razon_social";
            this.lbl_razon_social.Size = new System.Drawing.Size(95, 17);
            this.lbl_razon_social.TabIndex = 0;
            this.lbl_razon_social.Text = "Razón Social:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(15, 30);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(248, 22);
            this.txt_razon_social.TabIndex = 3;
            // 
            // txt_cliente_telefono
            // 
            this.txt_cliente_telefono.Location = new System.Drawing.Point(15, 75);
            this.txt_cliente_telefono.Name = "txt_cliente_telefono";
            this.txt_cliente_telefono.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_telefono.TabIndex = 4;
            // 
            // txt_cliente_email
            // 
            this.txt_cliente_email.Location = new System.Drawing.Point(15, 120);
            this.txt_cliente_email.Name = "txt_cliente_email";
            this.txt_cliente_email.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_email.TabIndex = 5;
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(15, 148);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_nuevo_cliente.TabIndex = 6;
            this.btn_nuevo_cliente.Text = "Nuevo";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_cliente
            // 
            this.btn_agregar_cliente.Location = new System.Drawing.Point(15, 187);
            this.btn_agregar_cliente.Name = "btn_agregar_cliente";
            this.btn_agregar_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_agregar_cliente.TabIndex = 7;
            this.btn_agregar_cliente.Text = "Agregar";
            this.btn_agregar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.Location = new System.Drawing.Point(15, 226);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_modificar_cliente.TabIndex = 8;
            this.btn_modificar_cliente.Text = "Modificar";
            this.btn_modificar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(15, 265);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(248, 33);
            this.btn_eliminar_cliente.TabIndex = 9;
            this.btn_eliminar_cliente.Text = "Eliminar";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(276, 409);
            this.panel1.TabIndex = 14;
            // 
            // btn_eliminar_resp
            // 
            this.btn_eliminar_resp.Location = new System.Drawing.Point(15, 366);
            this.btn_eliminar_resp.Name = "btn_eliminar_resp";
            this.btn_eliminar_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_eliminar_resp.TabIndex = 9;
            this.btn_eliminar_resp.Text = "Eliminar";
            this.btn_eliminar_resp.UseVisualStyleBackColor = true;
            // 
            // btn_modificar_resp
            // 
            this.btn_modificar_resp.Location = new System.Drawing.Point(15, 327);
            this.btn_modificar_resp.Name = "btn_modificar_resp";
            this.btn_modificar_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_modificar_resp.TabIndex = 8;
            this.btn_modificar_resp.Text = "Modificar";
            this.btn_modificar_resp.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_resp
            // 
            this.btn_agregar_resp.Location = new System.Drawing.Point(15, 288);
            this.btn_agregar_resp.Name = "btn_agregar_resp";
            this.btn_agregar_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_agregar_resp.TabIndex = 7;
            this.btn_agregar_resp.Text = "Agregar";
            this.btn_agregar_resp.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_resp
            // 
            this.btn_nuevo_resp.Location = new System.Drawing.Point(15, 249);
            this.btn_nuevo_resp.Name = "btn_nuevo_resp";
            this.btn_nuevo_resp.Size = new System.Drawing.Size(248, 33);
            this.btn_nuevo_resp.TabIndex = 6;
            this.btn_nuevo_resp.Text = "Nuevo";
            this.btn_nuevo_resp.UseVisualStyleBackColor = true;
            // 
            // txt_resp_apellido
            // 
            this.txt_resp_apellido.Location = new System.Drawing.Point(15, 120);
            this.txt_resp_apellido.Name = "txt_resp_apellido";
            this.txt_resp_apellido.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_apellido.TabIndex = 5;
            // 
            // txt_resp_nombre
            // 
            this.txt_resp_nombre.Location = new System.Drawing.Point(15, 75);
            this.txt_resp_nombre.Name = "txt_resp_nombre";
            this.txt_resp_nombre.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_nombre.TabIndex = 4;
            // 
            // txt_resp_dni
            // 
            this.txt_resp_dni.Location = new System.Drawing.Point(15, 30);
            this.txt_resp_dni.Name = "txt_resp_dni";
            this.txt_resp_dni.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_dni.TabIndex = 3;
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
            // txt_resp_telefono
            // 
            this.txt_resp_telefono.Location = new System.Drawing.Point(15, 163);
            this.txt_resp_telefono.Name = "txt_resp_telefono";
            this.txt_resp_telefono.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_telefono.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefono:";
            // 
            // txt_resp_email
            // 
            this.txt_resp_email.Location = new System.Drawing.Point(15, 212);
            this.txt_resp_email.Name = "txt_resp_email";
            this.txt_resp_email.Size = new System.Drawing.Size(248, 22);
            this.txt_resp_email.TabIndex = 11;
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
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(294, 757);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(1071, 72);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 848);
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
            this.Name = "frm_Clientes";
            this.Text = "Empresas y Clientes";
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
    }
}