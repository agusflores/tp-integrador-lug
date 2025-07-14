using Entity;

namespace Mapper
{
    public class VentaDTO
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal PrecioFinal { get; set; }
        public string? Observacion { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public string VehiculoPatente { get; set; }
        public Cliente Cliente { get; set; } 
        public string ClienteDNI { get; set; }

        public VentaDTO() { }
        public VentaDTO(Venta v)
        {
            Id = v.Id;
            FechaVenta = v.FechaVenta;
            PrecioFinal = v.PrecioFinal;
            Observacion = v.Observacion;
            Vehiculo = v.Vehiculo;
            VehiculoPatente = v.Vehiculo.Patente;
            Cliente = v.Cliente;
            ClienteDNI = v.Cliente.DNI;
        }
    }
}
