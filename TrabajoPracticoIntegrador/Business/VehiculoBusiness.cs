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
                    //ValidateFields(entity);
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
                    //ValidateFields(student);
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
    }
}