namespace Data
{
    using Entity;
    using System.Data.SqlClient;
    using System.Data;
    using Mapper;

    public class VentaDAO
    {
        private VehiculoDAO vehiculoDAO = new VehiculoDAO();
        private ClienteDAO clienteDAO = new ClienteDAO();

        public List<Venta> GetAll()
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using SqlConnection conn = new SqlConnection(dbConnString);
                conn.Open();

                string query = "SELECT * FROM Ventas";
                using SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                List<Venta> ventas = VentaMapper.Map(
                         dataSet,
                         vehiculoId => vehiculoDAO.GetById(vehiculoId),
                         clienteId => clienteDAO.GetById(clienteId)
                     );

                return ventas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todas las ventas: " + ex.Message);
            }
        }

        public Venta GetById(int id)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using SqlConnection conn = new SqlConnection(dbConnString);
                conn.Open();

                string query = "SELECT * FROM Ventas WHERE Id = @id";
                using SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                List<Venta> ventas = VentaMapper.Map(
                    dataSet,
                    vehiculoId => vehiculoDAO.GetById(vehiculoId),
                    clienteId => clienteDAO.GetById(clienteId)
                );
                return ventas.Count > 0 ? ventas[0] : null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener la venta con ID {id}: " + ex.Message);
            }
        }

        public void Create(Venta venta)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using SqlConnection conn = new SqlConnection(dbConnString);
                conn.Open();

                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Ventas (IdVehiculo, IdCliente, FechaVenta, PrecioFinal, Observacion)
                      VALUES (@idVehiculo, @idCliente, @fechaVenta, @precioFinal, @observacion)", conn);

                command.Parameters.AddWithValue("@idVehiculo", venta.Vehiculo.Id);
                command.Parameters.AddWithValue("@idCliente", venta.Cliente.Id);
                command.Parameters.AddWithValue("@fechaVenta", venta.FechaVenta);
                command.Parameters.AddWithValue("@precioFinal", venta.PrecioFinal);
                command.Parameters.AddWithValue("@observacion", (object?)venta.Observacion ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear venta: " + ex.Message);
            }
        }

        public void Update(Venta venta)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using SqlConnection conn = new SqlConnection(dbConnString);
                conn.Open();

                SqlCommand command = new SqlCommand(
                    @"UPDATE Ventas SET 
                        IdVehiculo = @idVehiculo,
                        IdCliente = @idCliente,
                        FechaVenta = @fechaVenta,
                        PrecioFinal = @precioFinal,
                        Observacion = @observacion
                      WHERE Id = @id", conn);

                command.Parameters.AddWithValue("@id", venta.Id);
                command.Parameters.AddWithValue("@idVehiculo", venta.Vehiculo.Id);
                command.Parameters.AddWithValue("@idCliente", venta.Cliente.Id);
                command.Parameters.AddWithValue("@fechaVenta", venta.FechaVenta);
                command.Parameters.AddWithValue("@precioFinal", venta.PrecioFinal);
                command.Parameters.AddWithValue("@observacion", (object?)venta.Observacion ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar venta: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                string dbConnString = DbConnectionString.GetConnectionString();
                using SqlConnection conn = new SqlConnection(dbConnString);
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Ventas WHERE Id = @id", conn);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar venta: " + ex.Message);
            }
        }
    }
}
