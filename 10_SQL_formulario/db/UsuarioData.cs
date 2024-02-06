using System.Data.SqlClient;
using System.Windows.Forms;

namespace _10_SQL_formulario.db
{
    class UsuarioData
    {
        private static string stringConnection;

        static UsuarioData()
        {
            UsuarioData.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
          public static modelo.clsUsuario ObtenerUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(UsuarioData.stringConnection))
            {
                string query = "SELECT * FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id); // binding para evitar el SQL Injection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    modelo.clsUsuario usuario = new modelo.clsUsuario(id, nombre, apellido, nombreUsuario, password, email);

                    return usuario;
                }
                throw new Exception("Id No encontrado");
            }
        }
        public static bool AgregarUsuario(modelo.clsUsuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(UsuarioData.stringConnection))
            {
                string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)  values" +
                    " (@nombre,@apellido,@nombreUsuario,@password,@eMail)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool BorraUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(UsuarioData.stringConnection))
            {
                string query = "DELETE FROM Usuario WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Usuario no encontrado");
        }

        public static bool UpdateUsuarioPorId(int id, modelo.clsUsuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(UsuarioData.stringConnection))
            {
                string query = "UPDATE Usuario SET  Nombre=@nombre,Apellido=@apellido,NombreUsuario=@nombreUsuario,Contraseña=@password,Mail=@email WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Usuario Actualizado");
        }
        public static List<modelo.clsUsuario> ListarUsuarios()
        {
            List<modelo.clsUsuario> usuarios = new List<modelo.clsUsuario>();
            using (SqlConnection connection = new SqlConnection(UsuarioData.stringConnection))
            {
                string query = "SELECT * FROM Usuario";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    modelo.clsUsuario usuario = new modelo.clsUsuario(idObtenido, nombre, apellido, nombreUsuario, password, email);
                    usuarios.Add(usuario);
                }
                return usuarios;
            }

            throw new Exception("Id No encontrado");
        }
    }
}
