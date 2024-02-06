
using System.Data.SqlClient;


namespace _10_SQL_formulario.db
{
   class ProductoData
    {
        private static string stringConnection;

        static ProductoData()
        {
            ProductoData.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
        public static modelo.clsProducto ObtenerProductoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ProductoData.stringConnection))
            {
                string query = "SELECT * FROM Producto WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id); // binding para evitar el SQL Injection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string descripciones = reader.GetString(1);
                    decimal costo = Convert.ToDecimal(reader[2]);
                    decimal precioVenta = Convert.ToDecimal(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUsuario = Convert.ToInt32(reader[5]);

                    modelo.clsProducto producto = new modelo.clsProducto(id, descripciones, costo, precioVenta, stock, idUsuario);

                    return producto;
                }
                throw new Exception("Id No encontrado");
            }
        }
        public static bool AgregarProducto(modelo.clsProducto producto)
        {
            using (SqlConnection connection = new SqlConnection(ProductoData.stringConnection))
            {
                string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)  values" +
                    " (@descripciones,@costo,@precioVenta,@stock,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("descripciones", producto.Descripciones);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool BorraProductoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ProductoData.stringConnection))
            {
                string query = "DELETE FROM Producto WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Producto no encontrado");
        }

        public static bool UpdateProductoPorId(int id, modelo.clsProducto producto)
        {
            using (SqlConnection connection = new SqlConnection(ProductoData.stringConnection))
            {
                string query = "UPDATE Producto SET  Descripciones=@descripciones,Costo=@costo,PrecioVenta=@precioVenta,Stock=@stock,IdUsuario=@idUsuario WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("descripciones", producto.Descripciones);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Producto Actualizado");
        }
        public static List<modelo.clsProducto> ListarProductos()
        {
            List<modelo.clsProducto> productos = new List<modelo.clsProducto>();
            using (SqlConnection connection = new SqlConnection(ProductoData.stringConnection))
            {
                string query = "SELECT * FROM Producto";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string descripciones = reader.GetString(1);
                    decimal costo = Convert.ToDecimal(reader[2]);
                    decimal precioVenta = Convert.ToDecimal(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUsuario = Convert.ToInt32(reader[5]);

                    modelo.clsProducto producto = new modelo.clsProducto(idObtenido, descripciones, costo, precioVenta, stock, idUsuario);
                    productos.Add(producto);
                }
                return productos;
            }

            throw new Exception("Id No encontrado");
        }
    }
}
