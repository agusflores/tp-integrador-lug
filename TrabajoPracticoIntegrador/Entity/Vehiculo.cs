namespace Entity
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Kilometraje { get; set; }
        public decimal Precio { get; set; }
        public string Patente { get; set; }
        public Vehiculo() { }
        public Vehiculo(string marca, string modelo, int anio, int kilometraje, decimal precio, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Kilometraje = kilometraje;
            Precio = precio;
            Patente = patente;
        }
    }
}