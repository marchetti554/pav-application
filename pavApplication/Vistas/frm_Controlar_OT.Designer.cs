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
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_reabrir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgv_detalles.Size = new System.Drawing.Size(895, 465);
            this.dgv_detalles.TabIndex = 0;
            this.dgv_detalles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellClick);
            this.dgv_detalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellContentClick);
            this.dgv_detalles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_detalles_CellMouseClick);
            this.dgv_detalles.SelectionChanged += new System.EventHandler(this.dgv_detalles_SelectionChanged);
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "Nro Boleta";
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.ReadOnly = true;
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
            // 
            // btn_completar
            // 
            this.btn_completar.Enabled = false;
            this.btn_completar.Location = new System.Drawing.Point(913, 162);
            this.btn_completar.Name = "btn_completar";
            this.btn_completar.Size = new System.Drawing.Size(241, 79);
            this.btn_completar.TabIndex = 1;
            this.btn_completar.Text = "Completar Boleta";
            this.btn_completar.UseVisualStyleBackColor = true;
            this.btn_completar.Click += new System.EventHandler(this.btn_completar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(3, 9);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(235, 99);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar Boleta";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(913, 426);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(241, 76);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(913, 247);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(241, 86);
            this.btn_finalizar.TabIndex = 2;
            this.btn_finalizar.Text = "Finalizar Orden de Trabajo";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_reabrir
            // 
            this.btn_reabrir.Enabled = false;
            this.btn_reabrir.Location = new System.Drawing.Point(913, 339);
            this.btn_reabrir.Name = "btn_reabrir";
            this.btn_reabrir.Size = new System.Drawing.Size(241, 81);
            this.btn_reabrir.TabIndex = 3;
            this.btn_reabrir.Text = "Reiniciar Boleta";
            this.btn_reabrir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_iniciar);
            this.panel1.Location = new System.Drawing.Point(913, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 113);
            this.panel1.TabIndex = 9;
            // 
            // frm_Controlar_OT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_reabrir);
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
        private System.Windows.Forms.Button btn_reabrir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_estimado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_real;
    }
}