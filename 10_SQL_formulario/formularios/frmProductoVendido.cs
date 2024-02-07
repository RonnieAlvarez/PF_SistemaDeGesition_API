using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeGestion.models;
using SistemaDeGestion.service;

namespace SistemaGestionApp.formularios
{
    public partial class frmProductoVendido : Form
    {
        public frmProductoVendido()
        {
            InitializeComponent();
        }
       private async void frmProductoVendido_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTADO DE PRODUCTOS VENDIDOS";
            await Task.Delay(500);
            obtenerDatos();
        }
        public void obtenerDatos()
        {
            try
            {
                dataGridView1.DataSource = null;
                List<ProductoVendido> lstProductos = ProductoVendidoService.GetProductoVendidosVendidos();
                dataGridView1.DataSource = lstProductos;
                dataGridView1.AutoGenerateColumns = true;
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            btnBuscarProductoXiD.Visible = true;
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void btnBuscarProductoxID_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show($"No se permiten valores nulos.", $"Error en el valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    ProductoVendido ProductoObtenido = ProductoVendidoService.GetProductoVendido(@id);
                    txtStock.Text = ProductoObtenido.Stock.ToString();
                    txtIdProducto.Text = ProductoObtenido.IdProducto.ToString();
                    txtIdVenta.Text = ProductoObtenido.IdVenta.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarProductoxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?", "Confirmación de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);

                    if (ProductoVendidoService.EliminarProductoVendidoPorId(@id))
                    {
                        limpiarDatos();
                        obtenerDatos();
                        txtID.Enabled = true;
                        TareaCompletada("eliminación");
                    }
                    else TareaCompletada("eliminación no");
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void limpiarDatos()
        {
            txtID.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtIdVenta.Text = string.Empty;
            txtIdProducto.Text = string.Empty;
        }
        private void btnActualizaProductoxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Actualizar este registro?", "Confirmación de Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);
                    ProductoVendido ProductoActualizar = new ProductoVendido{
                       Stock= int.Parse(txtStock.Text),
                       IdProducto= int.Parse(txtIdProducto.Text),
                       IdVenta= int.Parse(txtIdVenta.Text)
                    };
                    if (ProductoVendidoService.ActualizarProductoVendidoXId(ProductoActualizar, @id ))
                    {
                        obtenerDatos();
                        limpiarDatos();
                        TareaCompletada("actualización");
                    }
                    else TareaCompletada("actualización no");
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void TareaCompletada(string msm)
        {
            if (msm.Contains(" no"))
                MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                limpiarDatos();
                txtID.Enabled = true;
                int fila = e.RowIndex;
                txtID.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                txtStock.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                txtIdProducto.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                txtIdVenta.Text = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                    ProductoVendido ProductoNuevo = new ProductoVendido{
                    Stock=int.Parse(txtStock.Text),
                    IdProducto=int.Parse(txtIdProducto.Text),
                    IdVenta=int.Parse(txtIdVenta.Text)
                    };
                if (ProductoVendidoService.AgregarProductoVendido(ProductoNuevo))
                {
                    obtenerDatos();
                    limpiarDatos();
                    txtID.Enabled = true;
                    TareaCompletada("Inserción");
                }
                else TareaCompletada("Inserción no");
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            txtID.Enabled = false;
            txtStock.Focus();
        }

        private void txtAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btnAgregarProducto.Focus();
            }
        }

   
    }
}
