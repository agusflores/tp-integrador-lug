namespace Business
{
    using Data;
    using Entity;
    using Mapper;
    using System.Transactions;

    public class VentaBusiness
    {
        private VentaDAO ventaDAO = new VentaDAO();

        public List<Venta> GetAll()
        {
            try
            {
                return ventaDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VentaDTO> GetAllDTOs()
        {
            try
            {
                List<Venta> ventas = ventaDAO.GetAll();
                List<VentaDTO> ventasDTO = new List<VentaDTO>();
                foreach (Venta venta in ventas)
                {
                    ventasDTO.Add(VentaMapper.MapEntityToDTO(venta));
                }
                return ventasDTO;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Venta GetById(int id)
        {
            try
            {
                return ventaDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(Venta venta)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    validateCreateVentaFields(venta);
                    ventaDAO.Create(venta);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Venta venta)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ventaDAO.Update(venta);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ventaDAO.Delete(id);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void validateCreateVentaFields(Venta venta)
        {
            if (venta.FechaVenta == default(DateTime))
            {
                throw new Exception("El campo 'Fecha de Venta' es obligatorio.");
            }

            if (venta.FechaVenta > DateTime.Now)
            {
                throw new Exception("La 'Fecha de Venta' no puede ser mayor a la fecha actual.");
            }

            if (venta.PrecioFinal <= 0)
            {
                throw new Exception("El campo 'Precio Final' debe ser mayor a cero.");
            }

            if (venta.Vehiculo == null)
            {
                throw new Exception("Debe seleccionar un 'Vehículo' para la venta.");
            }

            if (venta.Cliente == null)
            {
                throw new Exception("Debe seleccionar un 'Cliente' para la venta.");
            }

            if (!string.IsNullOrWhiteSpace(venta.Observacion) && venta.Observacion.Length > 500)
            {
                throw new Exception("El campo 'Observación' no puede tener más de 500 caracteres.");
            }
        }
    }
}
