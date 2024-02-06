using _10_SQL_formulario.modelo;
using System.Data.SqlClient;


namespace _10_SQL_formulario.db
{
class ProductoVendidoData
    {
        static string stringConnection;

         static ProductoVendidoData()
        {
            ProductoVendidoData.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
        public static modelo.clsProductoVendido ObtenerProductoVendidoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ProductoVendidoData.stringConnection))
            {
                string query = "SELECT * FROM ProductoVendido WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id); // binding para evitar el SQL Injection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    int stock = Convert.ToInt32(reader[1]);
                    int idProducto = Convert.ToInt32(reader[2]);
                    int idVenta = Convert.ToInt32(reader[3]);

                    modelo.clsProductoVendido productoVendido = new modelo.clsProductoVendido(id, stock, idProducto, idVenta);

                    return productoVendido;
                }
                throw new Exception("Id No encontrado");
            }
        }
        public static bool AgregarProductoVendido(modelo.clsProductoVendido productoVendido)
        {
                using (SqlConnection connection = new SqlConnection(ProductoVendidoData.stringConnection))
                {
                    string query = "INSERT INTO ProductoVendido (stock, idProducto, idVenta)  values" +
                        " (@stock, @idProducto, @idVenta)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("stock", Convert.ToInt32(productoVendido.Stock));
                    command.Parameters.AddWithValue("idProducto", Convert.ToInt32(productoVendido.IdProducto));
                    command.Parameters.AddWithValue("idVenta", Convert.ToInt32(productoVendido.IdVenta));
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
        }

        public static bool BorraProductoVendidoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ProductoVendidoData.stringConnection))
            {
                string query = "DELETE FROM ProductoVendido WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Producto Vendido no encontrado");
        }

        public static bool UpdateProductoVendidoPorId(int id, modelo.clsProductoVendido productoVendido)
        {
            using (SqlConnection connection = new SqlConnection(ProductoVendidoData.stringConnection))
            {
                string query = "UPDATE productoVendido SET  Stock=@stock, IdProducto=@idProducto, IdVenta=@idVenta WHERE id=@id"; 
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("stock", productoVendido.Stock);
                command.Parameters.AddWithValue("idProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("idVenta", productoVendido.IdVenta);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Producto Vendido Actualizado");
        }
        public static List<modelo.clsProductoVendido> ListarProductoVendido()
        {
            List<modelo.clsProductoVendido> lstProductoVendido = new List<modelo.clsProductoVendido>();
            using (SqlConnection connection = new SqlConnection(ProductoVendidoData.stringConnection))
            {
                string query = "SELECT * FROM productoVendido";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    int stock = Convert.ToInt32(reader[1]);
                    int idProducto = Convert.ToInt32(reader[2]);
                    int idVenta = Convert.ToInt32(reader[3]);

                    modelo.clsProductoVendido productoVendido = new modelo.clsProductoVendido(idObtenido, stock, idProducto, idVenta);
                    lstProductoVendido.Add(productoVendido);
                }
                return lstProductoVendido;
            }

            throw new Exception("Id No encontrado");
        }
    }
}
