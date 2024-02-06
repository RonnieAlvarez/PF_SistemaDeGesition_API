using _10_SQL_formulario.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SQL_formulario.db
{
     class VentaData
    {
        private static string stringConnection;

        static VentaData()
        {
            VentaData.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
        public static modelo.clsVenta ObtenerVentaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(VentaData.stringConnection))
            {
                string query = "SELECT * FROM Venta WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id); // binding para evitar el SQL Injection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string comentarios = reader.GetString(1);
                    int idUsuario = Convert.ToInt32(reader[2]);
                    

                    modelo.clsVenta venta = new modelo.clsVenta(id, comentarios,idUsuario);

                    return venta;
                }
                throw new Exception("Id No encontrado");
            }
        }
        public static bool AgregarVenta(modelo.clsVenta venta)
        {
            using (SqlConnection connection = new SqlConnection(VentaData.stringConnection))
            {
                string query = "INSERT INTO Venta (comentarios,idUsuario)  values" +
                    " (@comentarios,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuarios", venta.IdUsuario);
                
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool BorraVentaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(VentaData.stringConnection))
            {
                string query = "DELETE FROM Venta WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Venta no encontrada");
        }

        public static bool UpdateVentaPorId(int id, modelo.clsVenta venta)
        {
            using (SqlConnection connection = new SqlConnection(VentaData.stringConnection))
            {
                string query = "UPDATE Venta SET  Comentarios=@comentarios,IdUsuario=@idUsuario WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuario", venta.IdUsuario);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Venta Actualizada");
        }
        public static List<modelo.clsVenta> ListarVentas()
        {
            List<modelo.clsVenta> lstVentas = new List<modelo.clsVenta>();
            using (SqlConnection connection = new SqlConnection(VentaData.stringConnection))
            {
                string query = "SELECT * FROM Venta";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string comentarios = reader.GetString(1);
                    int idUsuario = Convert.ToInt32(reader[2]);

                    modelo.clsVenta venta = new modelo.clsVenta(idObtenido, comentarios, idUsuario);
                    lstVentas.Add(venta);
                }
                return lstVentas;
            }

            throw new Exception("Id No encontrado");
        }
    }
}
