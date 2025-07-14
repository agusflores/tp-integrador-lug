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
    }
}
