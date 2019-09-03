namespace pav_application
{
    partial class userLogin_form
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
            this.username_tbox = new System.Windows.Forms.TextBox();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.intro_lbl = new System.Windows.Forms.Label();
            this.salir_btn = new System.Windows.Forms.Button();
            this.iniciar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_tbox
            // 
            this.username_tbox.Location = new System.Drawing.Point(193, 84);
            this.username_tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_tbox.Name = "username_tbox";
            this.username_tbox.Size = new System.Drawing.Size(293, 22);
            this.username_tbox.TabIndex = 1;
            // 
            // password_tbox
            // 
            this.password_tbox.Location = new System.Drawing.Point(193, 133);
            this.password_tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(293, 22);
            this.password_tbox.TabIndex = 2;
            this.password_tbox.UseSystemPasswordChar = true;
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Location = new System.Drawing.Point(29, 87);
            this.usuario_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(131, 17);
            this.usuario_lbl.TabIndex = 2;
            this.usuario_lbl.Text = "Nombre de Usuario";
            this.usuario_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(29, 137);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(81, 17);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Contraseña";
            this.password_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // intro_lbl
            // 
            this.intro_lbl.AutoSize = true;
            this.intro_lbl.BackColor = System.Drawing.SystemColors.Menu;
            this.intro_lbl.Location = new System.Drawing.Point(24, 31);
            this.intro_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intro_lbl.Name = "intro_lbl";
            this.intro_lbl.Size = new System.Drawing.Size(533, 17);
            this.intro_lbl.TabIndex = 4;
            this.intro_lbl.Text = "Bienvenido al programa de gestión de Metfarbi, por favor, ingrese sus credenciale" +
    "s";
            // 
            // salir_btn
            // 
            this.salir_btn.Location = new System.Drawing.Point(28, 181);
            this.salir_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(127, 55);
            this.salir_btn.TabIndex = 5;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            // 
            // iniciar_btn
            // 
            this.iniciar_btn.Location = new System.Drawing.Point(425, 181);
            this.iniciar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iniciar_btn.Name = "iniciar_btn";
            this.iniciar_btn.Size = new System.Drawing.Size(127, 55);
            this.iniciar_btn.TabIndex = 3;
            this.iniciar_btn.Text = "Iniciar";
            this.iniciar_btn.UseVisualStyleBackColor = true;
            this.iniciar_btn.Click += new System.EventHandler(this.iniciar_btn_Click);
            // 
            // userLogin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 251);
            this.Controls.Add(this.iniciar_btn);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.intro_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.usuario_lbl);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.username_tbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userLogin_form";
            this.Text = "Metfarbi";
            this.Load += new System.EventHandler(this.userLogin_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tbox;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label intro_lbl;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Button iniciar_btn;
    }
}