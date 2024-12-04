using SistemaPOS.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPOS.Views
{
    public partial class frmProductos : Form
    {

        private ProductoController controller;
        public frmProductos()
        {
            InitializeComponent();

            controller = new ProductoController();  
        }

        private void CargaProductos() {


            DataTable dt = controller.ListarProductos();
            dataGridView1.DataSource = dt;
                
                }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargaProductos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
             {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtIdProducto.Text = fila.Cells["Id"].Value.ToString();
                txtNombreProducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecioProducto.Text = fila.Cells["Precio"].Value.ToString();
                txtCantidadproducto.Text = fila.Cells["Cantidad"].Value.ToString();
            
                string tipo = fila.Cells["Tipo"].Value.ToString();

                if (cbTipoProducto.Items.Contains(tipo)) { 
                    cbTipoProducto.SelectedItem = tipo;
                }

                txtImpuestoProducto.Text = fila.Cells["Impuesto"].Value.ToString();


            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCantidadproducto.Text = "0";
            txtImpuestoProducto.Text = "0";
            txtPrecioProducto.Text = "0";
            cbTipoProducto.Text = "";
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProducto.Text);
            string nombre = txtNombreProducto.Text;
            decimal precio = Convert.ToDecimal(txtPrecioProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidadproducto.Text);
            string tipo = cbTipoProducto.Text;
            decimal impuesto = Convert.ToDecimal(txtImpuestoProducto.Text);

            int filasAfectadas = controller.CrearProducto(id, nombre, precio, cantidad, tipo, impuesto);

            if (filasAfectadas > 0) {
                MessageBox.Show("Producto creado con éxito");
                CargaProductos();
            }


        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProducto.Text);
            int filasAfectadas = controller.EliminarProducto(id);


            if (filasAfectadas > 0)
            {
                MessageBox.Show("Producto eliminado con éxito");
                CargaProductos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtIdProducto.Text);
            string nombre = txtNombreProducto.Text;
            decimal precio = Convert.ToDecimal(txtPrecioProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidadproducto.Text);
            string tipo = cbTipoProducto.Text;
            decimal impuesto = Convert.ToDecimal(txtImpuestoProducto.Text);

            int filasAfectadas = controller.ActualizarProducto(id, nombre, precio, cantidad, tipo, impuesto);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Producto actualizado con éxito");
                CargaProductos();
            }


        }
    }
}
