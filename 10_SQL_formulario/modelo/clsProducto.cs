namespace _10_SQL_formulario.modelo
{
    internal class clsProducto
    {
        int id;
        string descripciones;
        decimal costo;
        decimal precioVenta;
        int stock;
        int idUsuario;


        public clsProducto() 
        {
            this.id = 0;
            this.descripciones=string.Empty;
            this.costo = 0;
            this.precioVenta = 0;
            this.stock = 0;
            this.idUsuario = 0;
        }
        public clsProducto(string descripciones, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
        public clsProducto(int id, string descripciones, decimal costo, decimal precioVenta, int stock, int idUsuario):
            this(descripciones,costo,precioVenta,stock,idUsuario) 
        {
            this.id = id;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Descripciones { get { return this.descripciones; } set { this.descripciones = value; } }
        public decimal Costo { get { return this.costo; } set { this.costo = value; } }
        public decimal PrecioVenta { get { return this.precioVenta; } set { this.precioVenta = value; } }
        public int Stock { get { return this.stock; } set { this.stock = value; } }
        public int IdUsuario { get { return this.idUsuario; }set { this.idUsuario = value; } }
    }
}
