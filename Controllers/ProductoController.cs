using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPOS.Models;

namespace SistemaPOS.Controllers
{
    internal class ProductoController
    {
        public DataTable ListarProductos()
        {
            return Producto.ObtenerProductos();
        }
        public int CrearProducto(int id, string nombre, decimal precio, int cantidad, string tipo, decimal impuesto)
        {

            Producto producto = new Producto
            {
                Id = id,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad,
                Tipo = tipo,
                Impuesto = impuesto

            };

            return producto.Guardar();
        }

        public int ActualizarProducto(int id, string nombre, decimal precio, int cantidad, string tipo, decimal impuesto)
        {

            Producto producto = new Producto
            {
                Id = id,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad,
                Tipo = tipo,
                Impuesto = impuesto

            };

            return producto.Actualizar();
        }


        public int EliminarProducto(int id) { 
        
            return Producto.Eliminar(id);   
        
        }




    }
}
