namespace Business
{
    using Data;
    using Entity;
    using System.Transactions;

    public class VehiculoBusiness
    {
        private VehiculoDAO vehiculoDAO = new VehiculoDAO();

        public List<Vehiculo> GetAll()
        {
            try
            {
                return vehiculoDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Vehiculo GetById(int id)
        {
            try
            {
                return vehiculoDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(Vehiculo vehiculo)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    validateCreateVehicleFields(vehiculo);
                    vehiculoDAO.Create(vehiculo);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Vehiculo vehiculo)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    validateCreateVehicleFields(vehiculo);
                    vehiculoDAO.Update(vehiculo);
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
                    vehiculoDAO.Delete(id);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void validateCreateVehicleFields(Vehiculo vehiculo)
        {
            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
            {
                throw new Exception("El campo 'Marca' es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
            {
                throw new Exception("El campo 'Modelo' es obligatorio.");
            }

            if (vehiculo.Anio <= 0)
            {
                throw new Exception("El campo 'Año' debe ser un número válido y mayor a cero.");
            }

            if (vehiculo.Kilometraje < 0)
            {
                throw new Exception("El campo 'Kilometraje' no puede ser negativo.");
            }

            if (vehiculo.Precio <= 0)
            {
                throw new Exception("El campo 'Precio' debe ser mayor a cero.");
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Patente))
            {
                throw new Exception("El campo 'Patente' es obligatorio.");
            }
        }
    }
}