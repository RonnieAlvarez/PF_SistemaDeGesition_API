namespace SistemaGestionApp
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnProductos;
            Button btnUsuarios;
            Button btnVentas;
            Button btnProductovendido;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            panel1 = new Panel();
            panel3 = new Panel();
            btnClose = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            btnProductos = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnProductovendido = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.OliveDrab;
            btnProductos.CausesValidation = false;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(38, 28);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(170, 170);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(128, 64, 0);
            btnUsuarios.CausesValidation = false;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(38, 231);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(170, 170);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Purple;
            btnVentas.CausesValidation = false;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(262, 28);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(170, 170);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductovendido
            // 
            btnProductovendido.BackColor = Color.Teal;
            btnProductovendido.CausesValidation = false;
            btnProductovendido.FlatStyle = FlatStyle.Flat;
            btnProductovendido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductovendido.ForeColor = Color.White;
            btnProductovendido.Location = new Point(262, 230);
            btnProductovendido.Name = "btnProductovendido";
            btnProductovendido.Size = new Size(170, 170);
            btnProductovendido.TabIndex = 4;
            btnProductovendido.Text = "Producto Vendido";
            btnProductovendido.UseVisualStyleBackColor = false;
            btnProductovendido.Click += btnProductovendido_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 550);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnProductovendido);
            panel3.Controls.Add(btnUsuarios);
            panel3.Controls.Add(btnVentas);
            panel3.Controls.Add(btnProductos);
            panel3.Location = new Point(114, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 415);
            panel3.TabIndex = 10;
            panel3.TabStop = true;
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
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.Location = new Point(307, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(76, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INICIO";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(41, 128, 185);
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
            label2.Location = new Point(181, 508);
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
            label1.Location = new Point(168, 493);
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
            lblWelcome.Location = new Point(81, 170);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(156, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Inventarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
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
    }
}
