using SistemaPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.Controllers
{
    internal class UsuarioController
    {

        public DataTable ListarUsuarios()
        {
            return Usuario.ObtenerUsuarios();
        }
        public int CrearUsuario(int id, string nombre, string correo, string direccion, string telefono)
        {

            Usuario usuario = new Usuario
            {
                Id = id,
                Nombre = nombre,
                Correo = correo,
                Direccion = direccion,
                Telefono = telefono

            };

            return usuario.Guardar();
        }

        public int ActualizarUsuario(int id, string nombre, string correo, string direccion, string telefono)
        {

            Usuario usuario = new Usuario
            {
                Id = id,
                Nombre = nombre,
                Correo = correo,
                Direccion = direccion,
                Telefono = telefono

            };
            return usuario.Actualizar();
        }


        public int EliminarUsuario(int id)
        {

            return Usuario.Eliminar(id);

        }





    }
}
