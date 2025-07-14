namespace Entity
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal PrecioFinal { get; set; }
        public string? Observacion { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }

        public Venta() { }

        public Venta(Vehiculo vehiculo, Cliente cliente, DateTime fechaVenta, decimal precioFinal, string? observacion)
        {
            Vehiculo = vehiculo;
            Cliente = cliente;
            FechaVenta = fechaVenta;
            PrecioFinal = precioFinal;
            Observacion = observacion;
        }
    }
}
