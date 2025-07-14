namespace Mapper
{
    using Entity;
    using System.Data;
    public static class VehiculoMapper
    {
        public static List<Vehiculo> Map(DataSet ds)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Vehiculo vehiculo = new Vehiculo()
                {
                    Id = Convert.ToInt32(dr["Id"].ToString()),
                    Marca = dr["Marca"].ToString(),
                    Modelo = dr["Modelo"].ToString(),
                    Anio = Convert.ToInt32(dr["Anio"].ToString()),
                    Kilometraje = Convert.ToInt32(dr["Kilometraje"].ToString()),
                    Precio = Convert.ToDecimal(dr["Precio"].ToString()),
                    Patente = dr["Patente"].ToString()
                };

                vehiculos.Add(vehiculo);
            }

            return vehiculos;
        }

    }
}
