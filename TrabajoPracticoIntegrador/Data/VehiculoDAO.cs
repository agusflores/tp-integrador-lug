namespace Data
{
    using System.Data.SqlClient;
    using System.Data;
    using Entity;
    using Mapper;

    public class VehiculoDAO
    {
        public List<Vehiculo> GetAll()
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                SqlConnection conn = new SqlConnection(dbConnString);
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM Vehiculos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    using (adapter)
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        List<Vehiculo> vehiculos = VehiculoMapper.Map(dataSet);

                        return vehiculos;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los vehiculos: " + ex.Message);
            }
        }

        public Vehiculo GetById(int id)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Vehiculos WHERE ID = @id";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        List<Vehiculo> vehiculos = VehiculoMapper.Map(dataSet);

                        return vehiculos.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el vehiculo con ID {id}: " + ex.Message);
            }
        }
        public void Create(Vehiculo vehiculo)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO VEHICULOS (Marca, Modelo, Anio, Kilometraje, Precio, Patente) " +
                        "VALUES (@marca, @modelo, @anio, @kilometraje, @precio, @patente)", conn);

                    command.Parameters.AddWithValue("@marca", vehiculo.Marca);
                    command.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                    command.Parameters.AddWithValue("@anio", vehiculo.Anio);
                    command.Parameters.AddWithValue("@kilometraje", vehiculo.Kilometraje);
                    command.Parameters.AddWithValue("@precio", vehiculo.Precio);
                    command.Parameters.AddWithValue("@patente", vehiculo.Patente);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear vehículo: " + ex.Message);
            }
        }

        public void Update(Vehiculo vehiculo)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(dbConnString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(
                        "UPDATE VEHICULOS SET Marca = @marca, Modelo = @modelo, Anio = @anio, " +
                        "Kilometraje = @kilometraje, Precio = @precio, Patente = @patente " +
                        "WHERE Id = @id", conn);

                    command.Parameters.AddWithValue("@id", vehiculo.Id);
                    command.Parameters.AddWithValue("@marca", vehiculo.Marca);
                    command.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                    command.Parameters.AddWithValue("@anio", vehiculo.Anio);
                    command.Parameters.AddWithValue("@kilometraje", vehiculo.Kilometraje);
                    command.Parameters.AddWithValue("@precio", vehiculo.Precio);
                    command.Parameters.AddWithValue("@patente", vehiculo.Patente);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar vehículo: " + ex.Message);
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
                    SqlCommand command = new SqlCommand("DELETE FROM VEHICULOS WHERE Id = @id", conn);

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar vehículo: " + ex.Message);
            }
        }
    }
}
