namespace SistemaCanal9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUsuarioInicioSesion = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoUsuarioRegistro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtApellidoRegistro = new System.Windows.Forms.TextBox();
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.txtContraseniaRegistro = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenia = new System.Windows.Forms.TextBox();
            this.btnSalirInicioSesion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(132, 111);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(134, 20);
            this.txtContrasenia.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(105, 198);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Ingresar";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUsuarioInicioSesion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIniciarSesion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtContrasenia);
            this.groupBox1.Location = new System.Drawing.Point(41, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 336);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de Sesion";
            // 
            // cmbUsuarioInicioSesion
            // 
            this.cmbUsuarioInicioSesion.FormattingEnabled = true;
            this.cmbUsuarioInicioSesion.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.cmbUsuarioInicioSesion.Location = new System.Drawing.Point(132, 68);
            this.cmbUsuarioInicioSesion.Name = "cmbUsuarioInicioSesion";
            this.cmbUsuarioInicioSesion.Size = new System.Drawing.Size(134, 21);
            this.cmbUsuarioInicioSesion.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbTipoUsuarioRegistro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRegistro);
            this.groupBox2.Controls.Add(this.txtApellidoRegistro);
            this.groupBox2.Controls.Add(this.txtNombreRegistro);
            this.groupBox2.Controls.Add(this.txtContraseniaRegistro);
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.txtConfirmarContrasenia);
            this.groupBox2.Location = new System.Drawing.Point(402, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 336);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre";
            // 
            // cmbTipoUsuarioRegistro
            // 
            this.cmbTipoUsuarioRegistro.FormattingEnabled = true;
            this.cmbTipoUsuarioRegistro.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.cmbTipoUsuarioRegistro.Location = new System.Drawing.Point(144, 60);
            this.cmbTipoUsuarioRegistro.Name = "cmbTipoUsuarioRegistro";
            this.cmbTipoUsuarioRegistro.Size = new System.Drawing.Size(134, 21);
            this.cmbTipoUsuarioRegistro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(115, 282);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // txtApellidoRegistro
            // 
            this.txtApellidoRegistro.Location = new System.Drawing.Point(144, 155);
            this.txtApellidoRegistro.Name = "txtApellidoRegistro";
            this.txtApellidoRegistro.Size = new System.Drawing.Size(134, 20);
            this.txtApellidoRegistro.TabIndex = 6;
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.Location = new System.Drawing.Point(144, 111);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(134, 20);
            this.txtNombreRegistro.TabIndex = 6;
            // 
            // txtContraseniaRegistro
            // 
            this.txtContraseniaRegistro.Location = new System.Drawing.Point(144, 191);
            this.txtContraseniaRegistro.Name = "txtContraseniaRegistro";
            this.txtContraseniaRegistro.Size = new System.Drawing.Size(134, 20);
            this.txtContraseniaRegistro.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(44, 60);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(80, 13);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Tipo de usuario";
            // 
            // txtConfirmarContrasenia
            // 
            this.txtConfirmarContrasenia.Location = new System.Drawing.Point(144, 236);
            this.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            this.txtConfirmarContrasenia.Size = new System.Drawing.Size(134, 20);
            this.txtConfirmarContrasenia.TabIndex = 6;
            // 
            // btnSalirInicioSesion
            // 
            this.btnSalirInicioSesion.Location = new System.Drawing.Point(713, 415);
            this.btnSalirInicioSesion.Name = "btnSalirInicioSesion";
            this.btnSalirInicioSesion.Size = new System.Drawing.Size(75, 23);
            this.btnSalirInicioSesion.TabIndex = 6;
            this.btnSalirInicioSesion.Text = "Salir";
            this.btnSalirInicioSesion.UseVisualStyleBackColor = true;
            this.btnSalirInicioSesion.Click += new System.EventHandler(this.btnSalirInicioSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirInicioSesion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Canal 9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUsuarioInicioSesion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoUsuarioRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtApellidoRegistro;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.TextBox txtContraseniaRegistro;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtConfirmarContrasenia;
        private System.Windows.Forms.Button btnSalirInicioSesion;
    }
}

