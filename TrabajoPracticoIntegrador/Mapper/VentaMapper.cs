using Entity;
using System.Data;

namespace Mapper
{
    public class VentaMapper
    {
        public static List<Venta> Map(
           DataSet ds,
           Func<int, Vehiculo> getVehiculoById,
           Func<int, Cliente> getClienteById)
        {
            List<Venta> ventas = new List<Venta>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int vehiculoId = Convert.ToInt32(dr["IdVehiculo"]);
                Vehiculo vehiculo = getVehiculoById(vehiculoId);

                int clienteId = Convert.ToInt32(dr["IdCliente"]);
                Cliente cliente = getClienteById(clienteId);

                Venta venta = new Venta()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    FechaVenta = Convert.ToDateTime(dr["FechaVenta"]),
                    PrecioFinal = Convert.ToDecimal(dr["PrecioFinal"]),
                    Observacion = dr["Observacion"] != DBNull.Value ? dr["Observacion"].ToString() : null,
                    Vehiculo = vehiculo,
                    Cliente = cliente
                };

                ventas.Add(venta);
            }

            return ventas;
        }

        public static Venta MapDTOToEntity(VentaDTO dto)
        {
            return new Venta(dto.Vehiculo, dto.Cliente, dto.FechaVenta, dto.PrecioFinal, dto.Observacion);
        }

        public static VentaDTO MapEntityToDTO(Venta entity)
        {
            return new VentaDTO(entity);
        }
    }
}