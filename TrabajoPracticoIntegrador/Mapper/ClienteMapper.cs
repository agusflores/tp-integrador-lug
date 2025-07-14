namespace Mapper
{
    using Entity;
    using System.Data;

    public class ClienteMapper
    {
        public static List<Cliente> Map(DataSet ds)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente cliente = new Cliente()
                {
                    Id = Convert.ToInt32(dr["Id"].ToString()),
                    Nombre = dr["Nombre"].ToString(),
                    Apellido = dr["Apellido"].ToString(),
                    DNI = dr["DNI"].ToString(),
                    Telefono = dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : null,
                    Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : null
                };

                clientes.Add(cliente);
            }

            return clientes;
        }
    }
}
