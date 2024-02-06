
namespace _10_SQL_formulario.modelo
{
    internal class clsUsuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string password;
        private string email;

        //public Usuario() { }
        public clsUsuario(string nombre, string apellido, string nombreUsuario, string password, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.email = email;
        }
        public clsUsuario(int id, string nombre, string apellido, string nombreUsuario, string password, string email) :
            this(nombre, apellido, nombreUsuario, password, email)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Apellido: {this.Apellido}, Nombre Usuario: {this.NombreUsuario}, email: {this.Email}";
        }
    }
}
