namespace pavApplication.Vistas
{
    partial class frm_Maquinas
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
            this.dgv_maquinas = new System.Windows.Forms.DataGridView();
            this.lbl_nombre_maq = new System.Windows.Forms.Label();
            this.lbl_tipo_maq = new System.Windows.Forms.Label();
            this.txt_nombre_maq = new System.Windows.Forms.TextBox();
            this.cmb_tipo_maq = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.brn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this._pav_dbDataComboTipoMaq = new pavApplication._pav_dbDataComboTipoMaq();
            this.tiposmaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_maquinaTableAdapter = new pavApplication._pav_dbDataComboTipoMaqTableAdapters.tipos_maquinaTableAdapter();
            this.id_maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo_maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataComboTipoMaq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposmaquinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_maquinas
            // 
            this.dgv_maquinas.AllowUserToAddRows = false;
            this.dgv_maquinas.AllowUserToDeleteRows = false;
            this.dgv_maquinas.AllowUserToResizeColumns = false;
            this.dgv_maquinas.AllowUserToResizeRows = false;
            this.dgv_maquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_maquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_maquinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_maquina,
            this.nombre_maquina,
            this.nombre_tipo_maquina});
            this.dgv_maquinas.Location = new System.Drawing.Point(294, 12);
            this.dgv_maquinas.MultiSelect = false;
            this.dgv_maquinas.Name = "dgv_maquinas";
            this.dgv_maquinas.RowTemplate.Height = 24;
            this.dgv_maquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_maquinas.Size = new System.Drawing.Size(523, 311);
            this.dgv_maquinas.TabIndex = 0;
            // 
            // lbl_nombre_maq
            // 
            this.lbl_nombre_maq.AutoSize = true;
            this.lbl_nombre_maq.Location = new System.Drawing.Point(12, 12);
            this.lbl_nombre_maq.Name = "lbl_nombre_maq";
            this.lbl_nombre_maq.Size = new System.Drawing.Size(120, 17);
            this.lbl_nombre_maq.TabIndex = 1;
            this.lbl_nombre_maq.Text = "Nombre máquina:";
            // 
            // lbl_tipo_maq
            // 
            this.lbl_tipo_maq.AutoSize = true;
            this.lbl_tipo_maq.Location = new System.Drawing.Point(12, 77);
            this.lbl_tipo_maq.Name = "lbl_tipo_maq";
            this.lbl_tipo_maq.Size = new System.Drawing.Size(118, 17);
            this.lbl_tipo_maq.TabIndex = 2;
            this.lbl_tipo_maq.Text = "Tipo de máquina:";
            // 
            // txt_nombre_maq
            // 
            this.txt_nombre_maq.Location = new System.Drawing.Point(15, 42);
            this.txt_nombre_maq.Name = "txt_nombre_maq";
            this.txt_nombre_maq.Size = new System.Drawing.Size(252, 22);
            this.txt_nombre_maq.TabIndex = 4;
            // 
            // cmb_tipo_maq
            // 
            this.cmb_tipo_maq.DataSource = this.tiposmaquinaBindingSource;
            this.cmb_tipo_maq.DisplayMember = "nombre";
            this.cmb_tipo_maq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_maq.FormattingEnabled = true;
            this.cmb_tipo_maq.Location = new System.Drawing.Point(15, 108);
            this.cmb_tipo_maq.Name = "cmb_tipo_maq";
            this.cmb_tipo_maq.Size = new System.Drawing.Size(252, 24);
            this.cmb_tipo_maq.TabIndex = 5;
            this.cmb_tipo_maq.ValueMember = "id_tipo_maquina";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 157);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(252, 37);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // brn_modificar
            // 
            this.brn_modificar.Location = new System.Drawing.Point(12, 200);
            this.brn_modificar.Name = "brn_modificar";
            this.brn_modificar.Size = new System.Drawing.Size(252, 37);
            this.brn_modificar.TabIndex = 8;
            this.brn_modificar.Text = "Modificar";
            this.brn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(12, 243);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(252, 37);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 286);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(252, 37);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // _pav_dbDataComboTipoMaq
            // 
            this._pav_dbDataComboTipoMaq.DataSetName = "_pav_dbDataComboTipoMaq";
            this._pav_dbDataComboTipoMaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposmaquinaBindingSource
            // 
            this.tiposmaquinaBindingSource.DataMember = "tipos_maquina";
            this.tiposmaquinaBindingSource.DataSource = this._pav_dbDataComboTipoMaq;
            // 
            // tipos_maquinaTableAdapter
            // 
            this.tipos_maquinaTableAdapter.ClearBeforeFill = true;
            // 
            // id_maquina
            // 
            this.id_maquina.HeaderText = "ID Máquina";
            this.id_maquina.Name = "id_maquina";
            // 
            // nombre_maquina
            // 
            this.nombre_maquina.HeaderText = "Nombre";
            this.nombre_maquina.Name = "nombre_maquina";
            // 
            // nombre_tipo_maquina
            // 
            this.nombre_tipo_maquina.HeaderText = "Tipo Máquina";
            this.nombre_tipo_maquina.Name = "nombre_tipo_maquina";
            // 
            // frm_Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 334);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.brn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_tipo_maq);
            this.Controls.Add(this.txt_nombre_maq);
            this.Controls.Add(this.lbl_tipo_maq);
            this.Controls.Add(this.lbl_nombre_maq);
            this.Controls.Add(this.dgv_maquinas);
            this.Name = "frm_Maquinas";
            this.Text = "Maquinas";
            this.Load += new System.EventHandler(this.frm_Maquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pav_dbDataComboTipoMaq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposmaquinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_maquinas;
        private System.Windows.Forms.Label lbl_nombre_maq;
        private System.Windows.Forms.Label lbl_tipo_maq;
        private System.Windows.Forms.TextBox txt_nombre_maq;
        private System.Windows.Forms.ComboBox cmb_tipo_maq;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button brn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private _pav_dbDataComboTipoMaq _pav_dbDataComboTipoMaq;
        private System.Windows.Forms.BindingSource tiposmaquinaBindingSource;
        private _pav_dbDataComboTipoMaqTableAdapters.tipos_maquinaTableAdapter tipos_maquinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo_maquina;
    }
}