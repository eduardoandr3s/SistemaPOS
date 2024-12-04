using DatabaseConnectionEjemploPOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.Models
{
    internal class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public decimal Impuesto { get; set; }

        public static DataTable ObtenerProductos()
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = "SELECT * FROM Productos;";

            return db.ExecuteQuery(query);

        }


        public int Guardar()
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = $"INSERT INTO Productos " +
                $"VALUES({Id}, '{Nombre}',{Precio},{Cantidad}, '{Tipo}', {Impuesto});";
            return db.ExecuteNonQuery(query);

        }

        public int Actualizar()
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = $"UPDATE Productos SET " +
                $"Nombre = '{Nombre}'," +
                $" Precio = {Precio}," +
                $" Cantidad = {Cantidad}," +
                $" Tipo = '{Tipo}'," +
                $" Impuesto = {Impuesto}" +
                $" WHERE Id = {Id};";
            return db.ExecuteNonQuery(query);

        }

      public static int Eliminar(int id)
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = $"DELETE FROM Productos WHERE Id = {id};";
            return db.ExecuteNonQuery(query);
        }

    }
}
