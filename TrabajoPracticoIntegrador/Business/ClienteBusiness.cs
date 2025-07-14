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
                    validateCreateClienteFields(cliente);
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

        private void validateCreateClienteFields(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new Exception("El campo 'Nombre' es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new Exception("El campo 'Apellido' es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(cliente.DNI))
            {
                throw new Exception("El campo 'DNI' es obligatorio.");
            }

            if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
            {
                throw new Exception("El campo 'Email' no tiene un formato válido.");
            }

            if (!string.IsNullOrWhiteSpace(cliente.Telefono) && cliente.Telefono.Length < 6)
            {
                throw new Exception("El campo 'Teléfono' no parece válido.");
            }
        }
    }
}
