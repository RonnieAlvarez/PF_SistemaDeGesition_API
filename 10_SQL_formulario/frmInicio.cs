using SistemaGestionApp.formularios;

namespace SistemaGestionApp
{
    public partial class frmInicio : Form
    {

        public frmInicio()
        {
            InitializeComponent();
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            this.Hide();
            frmUsuarios.ShowDialog();
            this.Show();

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
          /*  frmProductos frmProductos = new frmProductos();
            this.Hide();
            frmProductos.ShowDialog();
            this.Show();
          */
        }

        private void btnProductovendido_Click(object sender, EventArgs e)
        {
            /*
            frmProductoVendido frmProductoVendido = new frmProductoVendido();
            this.Hide();
            frmProductoVendido.ShowDialog();
            this.Show();
            */
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            /*
            frmVenta frmVenta = new frmVenta();
            this.Hide();
            frmVenta.ShowDialog();
            this.Show();
            */
        }
    }
}

