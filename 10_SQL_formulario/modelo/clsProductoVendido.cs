namespace _10_SQL_formulario.modelo
{
    internal class clsProductoVendido
    {
        int id;
        int stock;
        int idProducto;
        int idVenta;

        public clsProductoVendido()
        {
            this.id = 0;
            this.stock = 0;
            this.idProducto = 0;
            this.idVenta = 0;

        }
        public clsProductoVendido(int stock, int idProducto,  int idVenta)
        {
            this.stock = stock;
            this.idProducto = idProducto;
            this.idVenta = idVenta;
        }
        public clsProductoVendido(int id, int stock, int idProducto,  int idVenta) :
            this(stock, idProducto,idVenta)
        {
            this.id = id;
        }
        public int Id{get{return this.id;} set { this.id = value; } }
        public int Stock {get { return this.stock; }set{ this.stock = value; } }
        public int IdProducto{get{return this.idProducto;} set { this.idProducto = value; } }
        public int IdVenta { get { return this.idVenta; } set { this.idVenta = value; } }

    }
}
