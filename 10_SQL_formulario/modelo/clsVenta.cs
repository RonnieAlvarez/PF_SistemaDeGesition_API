namespace _10_SQL_formulario.modelo
{
    internal class clsVenta
    {
        int id;
        string comentarios;
        int idUsuario;

        public clsVenta()
        {
            this.id = 0;
            this.comentarios = string.Empty;
            this.idUsuario = 0;
        }
        public clsVenta(string comentarios, int idUsuario)
        {
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
        public clsVenta(int id, string comentarios, int idUsuario) :
            this(comentarios, idUsuario)
        {
            this.id = id;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Comentarios { get { return this.comentarios; } set { this.comentarios = value; } }
        public int IdUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
    }
}
