namespace Concesionaria
{
    using Business;
    using Entity
    public partial class concesionariaForm : Form
    {
        private VehiculoBusiness vehiculoBusiness = new VehiculoBusiness();
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private VentaBusiness ventaBusiness = new VentaBusiness();

        int selectedVehicleID = 0;

        public concesionariaForm()
        {
            InitializeComponent();
        }

        private void concesionariaForm_Load(object sender, EventArgs e)
        {
            showClientesCmb(cmbClientes);
            showVehiculosCmb(cmbVehiculos);
            updateVehiculosDatagridView();
            updateClientesDatagridView();
            updateVentasDatagridView();
        }
        private void updateVehiculosDatagridView()
        {
            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = vehiculoBusiness.GetAll();
        }

        private void updateClientesDatagridView()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteBusiness.GetAll();
        }
        private void updateVentasDatagridView()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventaBusiness.GetAll();
        }

        private void showClientesCmb(ComboBox comboBox)
        {
            comboBox.DataSource = null;
            comboBox.DataSource = clienteBusiness.GetAll();
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "Id";
        }

        private void showVehiculosCmb(ComboBox comboBox)
        {
            comboBox.DataSource = null;
            comboBox.DataSource = clienteBusiness.GetAll();
            comboBox.DisplayMember = "Patente";
            comboBox.ValueMember = "Id";
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo nuevoVehiculo = new Vehiculo()
                {
                    Marca = txtMarcaVehiculo.Text,
                    Modelo = txtModeloVehiculo.Text,
                    Anio = Convert.ToInt32(txtAnioVehiculo.Text),
                    Kilometraje = Convert.ToInt32(txtKilometrajeVehiculo.Text),
                    Patente = txtPatenteVehiculo.Text,
                    Precio = Convert.ToDouble(txtPrecioVehiculo.Text),
                };

                vehiculoBusiness.Create(nuevoVehiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                cleanVehicleFields();
                updateVehiculosDatagridView();
            }
        }

        private void btnMostrarDatosVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                int vehiculoID = Convert.ToInt32(txtIDModificarVehiculo.Text);
                Vehiculo selectedVehicle = vehiculoBusiness.GetById(vehiculoID);

                if (selectedVehicle == null)
                {
                    throw new Exception($"El vehiculo con el ID {vehiculoID} no existe.");
                }

                fillVehicleFields(selectedVehicle);
                selectedVehicleID = selectedVehicle.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedVehicleID == 0)
                {
                    throw new Exception("Debe ingresar un ID de un Vehiculo válido y mostrar los datos antes de modificar.");
                }

                Vehiculo vehiculoAModificar = new Vehiculo()
                {
                    Id = selectedVehicleID,
                    Marca = txtMarcaVehiculo.Text,
                    Modelo = txtModeloVehiculo.Text,
                    Anio = Convert.ToInt32(txtAnioVehiculo.Text),
                    Kilometraje = Convert.ToInt32(txtKilometrajeVehiculo.Text),
                    Patente = txtPatenteVehiculo.Text,
                    Precio = Convert.ToDouble(txtPrecioVehiculo.Text),

                };
                vehiculoBusiness.Update(vehiculoAModificar);
                selectedVehicleID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                cleanVehicleFields();
                updateVehiculosDatagridView();
            }
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEliminarVehiculo.Text == string.Empty)
                {
                    throw new Exception("Debe ingresar un ID de un Vehiculo válido antes de eliminar.");
                }
                int vehiculoID = Convert.ToInt32(txtIDEliminarVehiculo.Text);
                Vehiculo selectedVehicle = vehiculoBusiness.GetById(vehiculoID);

                vehiculoBusiness.Delete(selectedVehicle.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                updateVehiculosDatagridView();
            }
        }

        private void cleanVehicleFields()
        {
            txtMarcaVehiculo.Text = string.Empty;
            txtModeloVehiculo.Text = string.Empty;
            txtAnioVehiculo.Text = string.Empty;
            txtKilometrajeVehiculo.Text = string.Empty;
            txtPatenteVehiculo.Text = string.Empty;
            txtPrecioVehiculo.Text = string.Empty;
        }

        private void fillVehicleFields(Vehiculo selectedVehicle)
        {
            txtMarcaVehiculo.Text = selectedVehicle.Marca;
            txtModeloVehiculo.Text = selectedVehicle.Modelo;
            txtAnioVehiculo.Text = selectedVehicle.Anio.ToString();
            txtKilometrajeVehiculo.Text = selectedVehicle.Kilometraje.ToString();
            txtPatenteVehiculo.Text = selectedVehicle.Patente;
            txtPrecioVehiculo.Text = selectedVehicle.Precio.ToString();
        }
    }
}
