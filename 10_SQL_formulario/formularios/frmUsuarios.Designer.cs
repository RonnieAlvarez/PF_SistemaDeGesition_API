namespace SistemaGestionApp.formularios
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            panel1 = new Panel();
            btnBorrarUsuarioxID = new Button();
            panel4 = new Panel();
            lblEmail = new Label();
            lblPassword = new Label();
            lblApellido = new Label();
            lblNombreUsuario = new Label();
            lblNombre = new Label();
            lblId = new Label();
            btnLimpiarDatos = new Button();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            btnAgregarUsuario = new Button();
            btnActualizaUsuarioxID = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnBuscarUsuarioXiD = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnBorrarUsuarioxID);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Controls.Add(btnActualizaUsuarioxID);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnBuscarUsuarioXiD);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 550);
            panel1.TabIndex = 0;
            // 
            // btnBorrarUsuarioxID
            // 
            btnBorrarUsuarioxID.BackColor = Color.Red;
            btnBorrarUsuarioxID.CausesValidation = false;
            btnBorrarUsuarioxID.FlatStyle = FlatStyle.Flat;
            btnBorrarUsuarioxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarUsuarioxID.ForeColor = SystemColors.ControlLightLight;
            btnBorrarUsuarioxID.Location = new Point(552, 260);
            btnBorrarUsuarioxID.Name = "btnBorrarUsuarioxID";
            btnBorrarUsuarioxID.Size = new Size(121, 35);
            btnBorrarUsuarioxID.TabIndex = 9;
            btnBorrarUsuarioxID.Text = "Borrar Usuario";
            btnBorrarUsuarioxID.UseVisualStyleBackColor = false;
            btnBorrarUsuarioxID.Click += btnBorrarUsuarioxID_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblEmail);
            panel4.Controls.Add(lblPassword);
            panel4.Controls.Add(lblApellido);
            panel4.Controls.Add(lblNombreUsuario);
            panel4.Controls.Add(lblNombre);
            panel4.Controls.Add(lblId);
            panel4.Controls.Add(btnLimpiarDatos);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtContrasena);
            panel4.Controls.Add(txtNombreUsuario);
            panel4.Controls.Add(txtApellido);
            panel4.Controls.Add(txtNombre);
            panel4.Controls.Add(txtID);
            panel4.Location = new Point(24, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 190);
            panel4.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.ControlDarkDark;
            lblEmail.Location = new Point(160, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "eMail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = SystemColors.ControlDarkDark;
            lblPassword.Location = new Point(326, 88);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Contraseña";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = SystemColors.ControlDarkDark;
            lblApellido.Location = new Point(326, 40);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.ForeColor = SystemColors.ControlDarkDark;
            lblNombreUsuario.Location = new Point(49, 88);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 11;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ControlDarkDark;
            lblNombre.Location = new Point(48, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = SystemColors.ControlDarkDark;
            lblId.Location = new Point(235, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 11;
            lblId.Text = "Id";
            // 
            // btnLimpiarDatos
            // 
            btnLimpiarDatos.BackColor = Color.FromArgb(0, 192, 192);
            btnLimpiarDatos.CausesValidation = false;
            btnLimpiarDatos.FlatStyle = FlatStyle.Flat;
            btnLimpiarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarDatos.ForeColor = SystemColors.ControlLightLight;
            btnLimpiarDatos.Location = new Point(527, 143);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(102, 31);
            btnLimpiarDatos.TabIndex = 10;
            btnLimpiarDatos.Text = "Limpiar Datos";
            btnLimpiarDatos.UseVisualStyleBackColor = false;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 23);
            txtEmail.TabIndex = 5;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(327, 103);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(245, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.KeyDown += TextBox_KeyDown;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(49, 103);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(245, 23);
            txtNombreUsuario.TabIndex = 3;
            txtNombreUsuario.KeyDown += TextBox_KeyDown;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(326, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 23);
            txtApellido.TabIndex = 2;
            txtApellido.KeyDown += TextBox_KeyDown;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(48, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyDown += TextBox_KeyDown;
            // 
            // txtID
            // 
            txtID.Location = new Point(258, 14);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.RoyalBlue;
            btnAgregarUsuario.CausesValidation = false;
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarUsuario.ForeColor = SystemColors.ControlLightLight;
            btnAgregarUsuario.Location = new Point(200, 260);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(121, 35);
            btnAgregarUsuario.TabIndex = 7;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnActualizaUsuarioxID
            // 
            btnActualizaUsuarioxID.BackColor = Color.FromArgb(255, 128, 0);
            btnActualizaUsuarioxID.CausesValidation = false;
            btnActualizaUsuarioxID.FlatStyle = FlatStyle.Flat;
            btnActualizaUsuarioxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizaUsuarioxID.ForeColor = SystemColors.ControlLightLight;
            btnActualizaUsuarioxID.Location = new Point(376, 260);
            btnActualizaUsuarioxID.Name = "btnActualizaUsuarioxID";
            btnActualizaUsuarioxID.Size = new Size(121, 35);
            btnActualizaUsuarioxID.TabIndex = 8;
            btnActualizaUsuarioxID.Text = "Actualizar Usuario";
            btnActualizaUsuarioxID.UseVisualStyleBackColor = false;
            btnActualizaUsuarioxID.Click += btnActualizaUsuarioxID_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(24, 301);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 235);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(650, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(659, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 36);
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnBuscarUsuarioXiD
            // 
            btnBuscarUsuarioXiD.BackColor = Color.FromArgb(0, 192, 192);
            btnBuscarUsuarioXiD.CausesValidation = false;
            btnBuscarUsuarioXiD.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuarioXiD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsuarioXiD.ForeColor = SystemColors.ControlLightLight;
            btnBuscarUsuarioXiD.Location = new Point(24, 260);
            btnBuscarUsuarioXiD.Name = "btnBuscarUsuarioXiD";
            btnBuscarUsuarioXiD.Size = new Size(121, 35);
            btnBuscarUsuarioXiD.TabIndex = 6;
            btnBuscarUsuarioXiD.Text = "Buscar X ID";
            btnBuscarUsuarioXiD.UseVisualStyleBackColor = false;
            btnBuscarUsuarioXiD.Click += btnBuscarUsuarioxID_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.Location = new Point(253, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "USUARIOS";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(128, 64, 0);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 550);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 522);
            label2.Name = "label2";
            label2.Size = new Size(95, 16);
            label2.TabIndex = 1;
            label2.Text = "Ronnie Alvarez";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 507);
            label1.Name = "label1";
            label1.Size = new Size(108, 16);
            label1.TabIndex = 1;
            label1.Text = "Desarrollado por:";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(69, 172);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(145, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "USUARIOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button btnBorrarUsuarioxID;
        private Button btnActualizaUsuarioxID;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private Button btnBuscarUsuarioXiD;
        private Button btnAgregarUsuario;
        private Button btnLimpiarDatos;
        private Label lblPassword;
        private Label lblApellido;
        private Label lblNombreUsuario;
        private Label lblNombre;
        private Label lblId;
        private Label lblEmail;
    }

     
}