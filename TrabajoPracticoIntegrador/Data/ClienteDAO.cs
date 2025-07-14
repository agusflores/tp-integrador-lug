namespace Data
{
    using Entity;
    using System.Data.SqlClient;
    using System.Data;
    using Mapper;
    public class ClienteDAO
    {
        public List<Cliente> GetAll()
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    using (adapter)
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        List<Cliente> clientes = ClienteMapper.Map(dataSet);
                        return clientes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los clientes: " + ex.Message);
            }
        }

        public Cliente GetById(int id)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Clientes WHERE Id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    List<Cliente> clientes = ClienteMapper.Map(dataSet);
                    return clientes.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener cliente con ID {id}: " + ex.Message);
            }
        }

        public void Create(Cliente cliente)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Clientes (Nombre, Apellido, DNI, Telefono, Email) " +
                        "VALUES (@nombre, @apellido, @dni, @telefono, @email)", conn);

                    command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@dni", cliente.DNI);
                    command.Parameters.AddWithValue("@telefono", (object?)cliente.Telefono ?? DBNull.Value);
                    command.Parameters.AddWithValue("@email", (object?)cliente.Email ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear cliente: " + ex.Message);
            }
        }

        public void Update(Cliente cliente)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(
                        "UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, DNI = @dni, " +
                        "Telefono = @telefono, Email = @email WHERE Id = @id", conn);

                    command.Parameters.AddWithValue("@id", cliente.Id);
                    command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@dni", cliente.DNI);
                    command.Parameters.AddWithValue("@telefono", (object?)cliente.Telefono ?? DBNull.Value);
                    command.Parameters.AddWithValue("@email", (object?)cliente.Email ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Clientes WHERE Id = @id", conn);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }
    }
}
