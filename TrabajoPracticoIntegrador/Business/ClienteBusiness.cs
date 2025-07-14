namespace Business
{
    using Data;
    using Entity;
    using System.Transactions;
    public class ClienteBusiness
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public List<Cliente> GetAll()
        {
            try
            {
                return clienteDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cliente GetById(int id)
        {
            try
            {
                return clienteDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(Cliente cliente)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    clienteDAO.Create(cliente);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Cliente cliente)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    clienteDAO.Update(cliente);
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
                    clienteDAO.Delete(id);
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
