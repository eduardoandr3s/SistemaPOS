using DatabaseConnectionEjemploPOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.Models
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public static DataTable ObtenerUsuarios()
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = "SELECT * FROM Usuarios;";

            return db.ExecuteQuery(query);

        }

        public int Guardar()
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = $"INSERT INTO Usuarios " +
                $"VALUES({Id}, '{Nombre}', '{Correo}', '{Direccion}', '{Telefono}');";
            return db.ExecuteNonQuery(query);

        }

        public int Actualizar()
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = $"UPDATE Usuarios SET " +
                $"Nombre = '{Nombre}',Correo = '{Correo}', Direccion = '{Direccion}', Telefono = '{Telefono}' WHERE Id= {Id};";
            return db.ExecuteNonQuery(query);

        }

       public static int Eliminar(int id)
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();
            string query = $"DELETE FROM Usuarios WHERE = {id};";
            return db.ExecuteNonQuery(query);
        }


    }
}
