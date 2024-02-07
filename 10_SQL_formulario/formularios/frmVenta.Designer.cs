namespace SistemaGestionApp.formularios
{
    partial class frmVenta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            panel1 = new Panel();
            btnBorrarVentaxID = new Button();
            panel4 = new Panel();
            lblIdUsuario = new Label();
            lblComentarios = new Label();
            txtComentarios = new TextBox();
            txtIdUsuario = new TextBox();
            lblId = new Label();
            btnLimpiarDatos = new Button();
            txtID = new TextBox();
            btnAgregarVenta = new Button();
            btnActualizaVentaxID = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnBuscarVentaXiD = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            lblRonnieAlvarez = new Label();
            lblDesarrolladoPor = new Label();
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
            panel1.Controls.Add(btnBorrarVentaxID);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnAgregarVenta);
            panel1.Controls.Add(btnActualizaVentaxID);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnBuscarVentaXiD);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 550);
            panel1.TabIndex = 0;
            // 
            // btnBorrarVentaxID
            // 
            btnBorrarVentaxID.BackColor = Color.Red;
            btnBorrarVentaxID.CausesValidation = false;
            btnBorrarVentaxID.FlatStyle = FlatStyle.Flat;
            btnBorrarVentaxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarVentaxID.ForeColor = SystemColors.ControlLightLight;
            btnBorrarVentaxID.Location = new Point(552, 260);
            btnBorrarVentaxID.Name = "btnBorrarVentaxID";
            btnBorrarVentaxID.Size = new Size(121, 35);
            btnBorrarVentaxID.TabIndex = 9;
            btnBorrarVentaxID.Text = "Borrar Venta";
            btnBorrarVentaxID.UseVisualStyleBackColor = false;
            btnBorrarVentaxID.Click += btnBorrarVentaxID_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblIdUsuario);
            panel4.Controls.Add(lblComentarios);
            panel4.Controls.Add(txtComentarios);
            panel4.Controls.Add(txtIdUsuario);
            panel4.Controls.Add(lblId);
            panel4.Controls.Add(btnLimpiarDatos);
            panel4.Controls.Add(txtID);
            panel4.Location = new Point(24, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 185);
            panel4.TabIndex = 11;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.ForeColor = SystemColors.ControlDarkDark;
            lblIdUsuario.Location = new Point(52, 126);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(57, 15);
            lblIdUsuario.TabIndex = 11;
            lblIdUsuario.Text = "IdUsuario";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.ForeColor = SystemColors.ControlDarkDark;
            lblComentarios.Location = new Point(52, 62);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(75, 15);
            lblComentarios.TabIndex = 11;
            lblComentarios.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(52, 80);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(512, 23);
            txtComentarios.TabIndex = 1;
            txtComentarios.KeyDown += txtID_KeyDown;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(52, 144);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(106, 23);
            txtIdUsuario.TabIndex = 2;
            txtIdUsuario.KeyDown += txtAgregar_KeyDown;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = SystemColors.ControlDarkDark;
            lblId.Location = new Point(229, 17);
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
            btnLimpiarDatos.Location = new Point(528, 137);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(102, 31);
            btnLimpiarDatos.TabIndex = 10;
            btnLimpiarDatos.Text = "Limpiar Datos";
            btnLimpiarDatos.UseVisualStyleBackColor = false;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(258, 14);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = Color.RoyalBlue;
            btnAgregarVenta.CausesValidation = false;
            btnAgregarVenta.FlatStyle = FlatStyle.Flat;
            btnAgregarVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarVenta.ForeColor = SystemColors.ControlLightLight;
            btnAgregarVenta.Location = new Point(200, 260);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(121, 35);
            btnAgregarVenta.TabIndex = 7;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnActualizaVentaxID
            // 
            btnActualizaVentaxID.BackColor = Color.FromArgb(255, 128, 0);
            btnActualizaVentaxID.CausesValidation = false;
            btnActualizaVentaxID.FlatStyle = FlatStyle.Flat;
            btnActualizaVentaxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizaVentaxID.ForeColor = SystemColors.ControlLightLight;
            btnActualizaVentaxID.Location = new Point(376, 260);
            btnActualizaVentaxID.Name = "btnActualizaVentaxID";
            btnActualizaVentaxID.Size = new Size(121, 35);
            btnActualizaVentaxID.TabIndex = 8;
            btnActualizaVentaxID.Text = "Actualizar Producto";
            btnActualizaVentaxID.UseVisualStyleBackColor = false;
            btnActualizaVentaxID.Click += btnActualizaVentaxID_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
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
            // btnBuscarVentaXiD
            // 
            btnBuscarVentaXiD.BackColor = Color.FromArgb(0, 192, 192);
            btnBuscarVentaXiD.CausesValidation = false;
            btnBuscarVentaXiD.FlatStyle = FlatStyle.Flat;
            btnBuscarVentaXiD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarVentaXiD.ForeColor = SystemColors.ControlLightLight;
            btnBuscarVentaXiD.Location = new Point(24, 260);
            btnBuscarVentaXiD.Name = "btnBuscarVentaXiD";
            btnBuscarVentaXiD.Size = new Size(121, 35);
            btnBuscarVentaXiD.TabIndex = 6;
            btnBuscarVentaXiD.Text = "Buscar X ID";
            btnBuscarVentaXiD.UseVisualStyleBackColor = false;
            btnBuscarVentaXiD.Click += btnBuscarVentaxID_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.Location = new Point(253, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ventas";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.Purple;
            panel2.Controls.Add(lblRonnieAlvarez);
            panel2.Controls.Add(lblDesarrolladoPor);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 550);
            panel2.TabIndex = 1;
            // 
            // lblRonnieAlvarez
            // 
            lblRonnieAlvarez.AutoSize = true;
            lblRonnieAlvarez.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRonnieAlvarez.ForeColor = Color.White;
            lblRonnieAlvarez.Location = new Point(181, 522);
            lblRonnieAlvarez.Name = "lblRonnieAlvarez";
            lblRonnieAlvarez.Size = new Size(95, 16);
            lblRonnieAlvarez.TabIndex = 1;
            lblRonnieAlvarez.Text = "Ronnie Alvarez";
            // 
            // lblDesarrolladoPor
            // 
            lblDesarrolladoPor.AutoSize = true;
            lblDesarrolladoPor.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesarrolladoPor.ForeColor = Color.White;
            lblDesarrolladoPor.Location = new Point(168, 507);
            lblDesarrolladoPor.Name = "lblDesarrolladoPor";
            lblDesarrolladoPor.Size = new Size(108, 16);
            lblDesarrolladoPor.TabIndex = 1;
            lblDesarrolladoPor.Text = "Desarrollado por:";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(81, 179);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(104, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Ventas";
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
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += frmVenta_Load;
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
        private Label lblRonnieAlvarez;
        private Label lblDesarrolladoPor;
        private Button btnClose;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button btnBorrarVentaxID;
        private Button btnActualizaVentaxID;
        private TextBox txtComentarios;
        private TextBox txtID;
        private Button btnBuscarVentaXiD;
        private Button btnAgregarVenta;
        private Button btnLimpiarDatos;
        private Label lblId;
        private Label lblComentarios;
        private TextBox txtIdUsuario;
        private Label lblIdUsuario;
    }

     
}