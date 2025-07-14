namespace Concesionaria
{
    using Business;
    using Entity;
    public partial class concesionariaForm : Form
    {
        private VehiculoBusiness vehiculoBusiness = new VehiculoBusiness();
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private VentaBusiness ventaBusiness = new VentaBusiness();

        int selectedVehicleID = 0;
        int selectedClientID = 0;

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
                txtIDModificarVehiculo.Text = string.Empty;
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

                if (selectedVehicle == null)
                {
                    throw new Exception($"El vehiculo con el ID {vehiculoID} no existe.");
                }

                vehiculoBusiness.Delete(selectedVehicle.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                updateVehiculosDatagridView();
                txtIDEliminarVehiculo.Text = string.Empty;
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevoCliente = new Cliente()
                {
                    Nombre = txtNombreCliente.Text,
                    Apellido = txtApellidoCliente.Text,
                    DNI = txtDniCliente.Text,
                    Telefono = txtTelefonoCliente.Text,
                    Email = txtEmailCliente.Text,
                };

                clienteBusiness.Create(nuevoCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                cleanClientFields();
                updateClientesDatagridView();
            }
        }

        private void btnMostrarDatosCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteID = Convert.ToInt32(txtIDModificarCliente.Text);
                Cliente selectedClient = clienteBusiness.GetById(clienteID);

                if (selectedClient == null)
                {
                    throw new Exception($"El cliente con el ID {clienteID} no existe.");
                }

                fillClientFields(selectedClient);
                selectedClientID = selectedClient.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedClientID == 0)
                {
                    throw new Exception("Debe ingresar un ID de un Cliente válido y mostrar los datos antes de modificar.");
                }

                Cliente clienteAModificar = new Cliente()
                {
                    Id = selectedClientID,
                    Nombre = txtNombreCliente.Text,
                    Apellido = txtApellidoCliente.Text,
                    DNI = txtDniCliente.Text,
                    Telefono = txtTelefonoCliente.Text,
                    Email = txtEmailCliente.Text,

                };

                clienteBusiness.Update(clienteAModificar);
                selectedClientID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                cleanClientFields();
                updateClientesDatagridView();
                txtIDModificarCliente.Text = string.Empty;
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEliminarCliente.Text == string.Empty)
                {
                    throw new Exception("Debe ingresar un ID de un Cliente válido antes de eliminar.");
                }

                int clienteID = Convert.ToInt32(txtIDEliminarCliente.Text);
                Cliente selectedClient = clienteBusiness.GetById(clienteID);

                if (selectedClient == null)
                {
                    throw new Exception($"El cliente con el ID {selectedClient} no existe.");
                }

                clienteBusiness.Delete(selectedClient.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                updateClientesDatagridView();
                txtIDEliminarCliente.Text = string.Empty;
            }
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = Convert.ToInt32(cmbClientes.SelectedValue);
                Cliente cliente = clienteBusiness.GetById(clientId);

                int vehicleId = Convert.ToInt32(cmbVehiculos.SelectedValue);
                Vehiculo vehiculo = vehiculoBusiness.GetById(vehicleId);

                Venta nuevaVenta = new Venta()
                {
                    Cliente = cliente,
                    Vehiculo = vehiculo,
                    FechaVenta = dtpFechaVenta.Value,
                    Observacion = txtObservaciones.Text,
                    PrecioFinal = Convert.ToDecimal(txtPrecioFinalVenta.Text)
                };

                ventaBusiness.Create(nuevaVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                cleanVentaFields();
                updateVentasDatagridView();
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

        private void cleanClientFields()
        {
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtDniCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;
        }

        private void cleanVentaFields()
        {
            cmbClientes.SelectedIndex = -1; 
            cmbVehiculos.SelectedIndex = -1;
            txtPrecioFinalVenta.Text = string.Empty;
            dtpFechaVenta.Value = DateTime.Now;
        }

        private void fillClientFields(Cliente selectedClient)
        {
            txtNombreCliente.Text = selectedClient.Nombre;
            txtApellidoCliente.Text = selectedClient.Apellido;
            txtDniCliente.Text = selectedClient.DNI;
            txtTelefonoCliente.Text = selectedClient.Telefono;
            txtEmailCliente.Text = selectedClient.Email;
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
            dgvVentas.DataSource = ventaBusiness.GetAllDTOs();
            dgvVentas.Columns["Vehiculo"].Visible = false;
            dgvVentas.Columns["Cliente"].Visible = false;
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
            comboBox.DataSource = vehiculoBusiness.GetAll();
            comboBox.DisplayMember = "Patente";
            comboBox.ValueMember = "Id";
        }
    }
}