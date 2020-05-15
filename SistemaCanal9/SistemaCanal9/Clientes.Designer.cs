namespace SistemaCanal9
{
    partial class Clientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.dgvBusquedaClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombresyApellidosClientes = new System.Windows.Forms.TextBox();
            this.txtDireccionClientes = new System.Windows.Forms.TextBox();
            this.txtTelefonoClientes = new System.Windows.Forms.TextBox();
            this.cmbServicioClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoAlternativoClientes = new System.Windows.Forms.TextBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaDeIngreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreoElectronicoCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CAYAMBE VISION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres y Apellidos:";
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Location = new System.Drawing.Point(33, 347);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarClientes.TabIndex = 1;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(334, 347);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarClientes.TabIndex = 2;
            this.btnBuscarClientes.Text = "Buscar";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            // 
            // dgvBusquedaClientes
            // 
            this.dgvBusquedaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvBusquedaClientes.Location = new System.Drawing.Point(33, 384);
            this.dgvBusquedaClientes.Name = "dgvBusquedaClientes";
            this.dgvBusquedaClientes.Size = new System.Drawing.Size(542, 211);
            this.dgvBusquedaClientes.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombres";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellidos";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Servicio";
            this.Column5.Name = "Column5";
            // 
            // btnVolverClientes
            // 
            this.btnVolverClientes.Location = new System.Drawing.Point(955, 626);
            this.btnVolverClientes.Name = "btnVolverClientes";
            this.btnVolverClientes.Size = new System.Drawing.Size(75, 23);
            this.btnVolverClientes.TabIndex = 4;
            this.btnVolverClientes.Text = "Volver";
            this.btnVolverClientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teléfono/Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Servicio:";
            // 
            // txtNombresyApellidosClientes
            // 
            this.txtNombresyApellidosClientes.Location = new System.Drawing.Point(161, 69);
            this.txtNombresyApellidosClientes.Name = "txtNombresyApellidosClientes";
            this.txtNombresyApellidosClientes.Size = new System.Drawing.Size(276, 20);
            this.txtNombresyApellidosClientes.TabIndex = 5;
            this.txtNombresyApellidosClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombresyApellidosClientes_KeyPress);
            // 
            // txtDireccionClientes
            // 
            this.txtDireccionClientes.Location = new System.Drawing.Point(161, 104);
            this.txtDireccionClientes.Name = "txtDireccionClientes";
            this.txtDireccionClientes.Size = new System.Drawing.Size(276, 20);
            this.txtDireccionClientes.TabIndex = 5;
            // 
            // txtTelefonoClientes
            // 
            this.txtTelefonoClientes.Location = new System.Drawing.Point(128, 236);
            this.txtTelefonoClientes.Name = "txtTelefonoClientes";
            this.txtTelefonoClientes.Size = new System.Drawing.Size(121, 20);
            this.txtTelefonoClientes.TabIndex = 5;
            this.txtTelefonoClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoClientes_KeyPress);
            // 
            // cmbServicioClientes
            // 
            this.cmbServicioClientes.FormattingEnabled = true;
            this.cmbServicioClientes.Items.AddRange(new object[] {
            "Internet",
            "Televisión",
            "Ambos"});
            this.cmbServicioClientes.Location = new System.Drawing.Point(128, 269);
            this.cmbServicioClientes.Name = "cmbServicioClientes";
            this.cmbServicioClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbServicioClientes.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teléfono Alternativo:";
            // 
            // txtTelefonoAlternativoClientes
            // 
            this.txtTelefonoAlternativoClientes.Location = new System.Drawing.Point(380, 236);
            this.txtTelefonoAlternativoClientes.Name = "txtTelefonoAlternativoClientes";
            this.txtTelefonoAlternativoClientes.Size = new System.Drawing.Size(121, 20);
            this.txtTelefonoAlternativoClientes.TabIndex = 5;
            this.txtTelefonoAlternativoClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoAlternativoClientes_KeyPress);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(234, 306);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCliente.TabIndex = 7;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cédula:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(161, 141);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCedulaCliente.TabIndex = 5;
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha de ingreso:";
            // 
            // dtpFechaDeIngreso
            // 
            this.dtpFechaDeIngreso.Location = new System.Drawing.Point(128, 204);
            this.dtpFechaDeIngreso.Name = "dtpFechaDeIngreso";
            this.dtpFechaDeIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDeIngreso.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Correo Electrónico:";
            // 
            // txtCorreoElectronicoCliente
            // 
            this.txtCorreoElectronicoCliente.Location = new System.Drawing.Point(161, 170);
            this.txtCorreoElectronicoCliente.Name = "txtCorreoElectronicoCliente";
            this.txtCorreoElectronicoCliente.Size = new System.Drawing.Size(276, 20);
            this.txtCorreoElectronicoCliente.TabIndex = 5;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 676);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaDeIngreso);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.cmbServicioClientes);
            this.Controls.Add(this.txtTelefonoAlternativoClientes);
            this.Controls.Add(this.txtCorreoElectronicoCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.txtTelefonoClientes);
            this.Controls.Add(this.txtDireccionClientes);
            this.Controls.Add(this.txtNombresyApellidosClientes);
            this.Controls.Add(this.btnVolverClientes);
            this.Controls.Add(this.dgvBusquedaClientes);
            this.Controls.Add(this.btnBuscarClientes);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.DataGridView dgvBusquedaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnVolverClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombresyApellidosClientes;
        private System.Windows.Forms.TextBox txtDireccionClientes;
        private System.Windows.Forms.TextBox txtTelefonoClientes;
        private System.Windows.Forms.ComboBox cmbServicioClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoAlternativoClientes;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaDeIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreoElectronicoCliente;
    }
}