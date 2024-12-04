using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPOS.Controllers;

namespace SistemaPOS
{
    public partial class Form1 : Form
    {

        ProductoController pc = new ProductoController();
        public Form1()
        {
            InitializeComponent();
        }


        private void CargarProductos() 
        {

            DataTable productos = pc.ListarProductos();
            dataGridView1.DataSource = productos;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
