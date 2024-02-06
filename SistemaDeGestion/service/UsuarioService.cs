using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestion.database;
using SistemaDeGestion.models;

namespace SistemaDeGestion.service
{
    public static class UsuarioService
    {
        private static string stringConnection;
        static UsuarioService()
        {
            UsuarioService.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
        public static Usuario GetUsuario(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario? UsuarioBuscado = context.Usuarios.Where(u => u.Id == id).FirstOrDefault();
                return UsuarioBuscado;
            }
        }
        public static List<Usuario> GetUsuarios()
        {
            using (CoderContext context = new CoderContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                return usuarios;
            }
        }

        public static bool AgregarUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Mail))
            {
                //throw new Exception(message: "No puede agregar un usuario Vacio");
                return false;
            }
            using (CoderContext context = new CoderContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return true;
            }
        }
        public static bool ActualizarUsuarioXId(Usuario usuario, int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario? usuarioBuscado = GetUsuario(Id);
                usuarioBuscado.Nombre = usuario.Nombre;
                usuarioBuscado.Apellido = usuario.Apellido;
                usuarioBuscado.NombreUsuario = usuario.NombreUsuario;
                usuarioBuscado.Contraseña = usuario.Contraseña;
                usuarioBuscado.Mail = usuario.Mail;

                context.Usuarios.Update(usuarioBuscado);
                context.SaveChanges();
                return true;
            }
        }
        public static bool EliminarUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = "DELETE FROM Usuario WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
                //return true;
            }
            throw new Exception(message: "Usuario no encontrado");
        }
    }
}
