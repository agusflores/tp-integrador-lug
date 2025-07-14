namespace Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public Cliente() { }

        public Cliente(string nombre, string apellido, string dni, string? telefono, string? email)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Email = email;
        }
    }
}
