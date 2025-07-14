namespace Concesionaria
{
    partial class concesionariaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloVehiculos = new Label();
            lblTituloCliente = new Label();
            lblTituloVentas = new Label();
            dgvClientes = new DataGridView();
            dgvVehiculos = new DataGridView();
            dgvVentas = new DataGridView();
            lblAgregarVehiculo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregarVehiculo = new Button();
            txtMarcaVehiculo = new TextBox();
            txtModeloVehiculo = new TextBox();
            txtAnioVehiculo = new TextBox();
            txtPatenteVehiculo = new TextBox();
            txtKilometrajeVehiculo = new TextBox();
            txtPrecioVehiculo = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            btnRegistrarCliente = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblAgregarCliente = new Label();
            label7 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            btnRealizarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblTituloVehiculos
            // 
            lblTituloVehiculos.AutoSize = true;
            lblTituloVehiculos.Location = new Point(21, 247);
            lblTituloVehiculos.Name = "lblTituloVehiculos";
            lblTituloVehiculos.Size = new Size(104, 15);
            lblTituloVehiculos.TabIndex = 0;
            lblTituloVehiculos.Text = "Vehiculos en stock";
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.AutoSize = true;
            lblTituloCliente.Location = new Point(648, 247);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(110, 15);
            lblTituloCliente.TabIndex = 1;
            lblTituloCliente.Text = "Clientes registrados";
            // 
            // lblTituloVentas
            // 
            lblTituloVentas.AutoSize = true;
            lblTituloVentas.Location = new Point(648, 449);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new Size(95, 15);
            lblTituloVentas.TabIndex = 2;
            lblTituloVentas.Text = "Ventas realizadas";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(648, 265);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(465, 171);
            dgvClientes.TabIndex = 3;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(21, 265);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.Size = new Size(465, 171);
            dgvVehiculos.TabIndex = 4;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(648, 467);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.Size = new Size(465, 182);
            dgvVentas.TabIndex = 5;
            // 
            // lblAgregarVehiculo
            // 
            lblAgregarVehiculo.AutoSize = true;
            lblAgregarVehiculo.Location = new Point(11, 9);
            lblAgregarVehiculo.Name = "lblAgregarVehiculo";
            lblAgregarVehiculo.Size = new Size(133, 15);
            lblAgregarVehiculo.TabIndex = 6;
            lblAgregarVehiculo.Text = "Agregar nuevo vehiculo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 40);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Marca: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Modelo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 9;
            label3.Text = "Año: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "Patente: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 11;
            label5.Text = "Kilometraje: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 186);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 12;
            label6.Text = "Precio: ";
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Location = new Point(130, 218);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(126, 23);
            btnAgregarVehiculo.TabIndex = 13;
            btnAgregarVehiculo.Text = "Agregar Vehiculo";
            btnAgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // txtMarcaVehiculo
            // 
            txtMarcaVehiculo.Location = new Point(156, 32);
            txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            txtMarcaVehiculo.Size = new Size(100, 23);
            txtMarcaVehiculo.TabIndex = 14;
            // 
            // txtModeloVehiculo
            // 
            txtModeloVehiculo.Location = new Point(156, 61);
            txtModeloVehiculo.Name = "txtModeloVehiculo";
            txtModeloVehiculo.Size = new Size(100, 23);
            txtModeloVehiculo.TabIndex = 15;
            // 
            // txtAnioVehiculo
            // 
            txtAnioVehiculo.Location = new Point(156, 90);
            txtAnioVehiculo.Name = "txtAnioVehiculo";
            txtAnioVehiculo.Size = new Size(100, 23);
            txtAnioVehiculo.TabIndex = 16;
            // 
            // txtPatenteVehiculo
            // 
            txtPatenteVehiculo.Location = new Point(156, 119);
            txtPatenteVehiculo.Name = "txtPatenteVehiculo";
            txtPatenteVehiculo.Size = new Size(100, 23);
            txtPatenteVehiculo.TabIndex = 17;
            // 
            // txtKilometrajeVehiculo
            // 
            txtKilometrajeVehiculo.Location = new Point(156, 148);
            txtKilometrajeVehiculo.Name = "txtKilometrajeVehiculo";
            txtKilometrajeVehiculo.Size = new Size(100, 23);
            txtKilometrajeVehiculo.TabIndex = 18;
            // 
            // txtPrecioVehiculo
            // 
            txtPrecioVehiculo.Location = new Point(156, 178);
            txtPrecioVehiculo.Name = "txtPrecioVehiculo";
            txtPrecioVehiculo.Size = new Size(100, 23);
            txtPrecioVehiculo.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(761, 148);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 32;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(761, 119);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 31;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(761, 90);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 30;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(761, 61);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 29;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(761, 32);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 28;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(735, 182);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(126, 23);
            btnRegistrarCliente.TabIndex = 27;
            btnRegistrarCliente.Text = "Registrar cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 151);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 25;
            label8.Text = "Email: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(617, 122);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 24;
            label9.Text = "Telefono: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(617, 93);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 23;
            label10.Text = "DNI: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(616, 64);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 22;
            label11.Text = "Apellido: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(616, 40);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 21;
            label12.Text = "Nombre:";
            // 
            // lblAgregarCliente
            // 
            lblAgregarCliente.AutoSize = true;
            lblAgregarCliente.Location = new Point(616, 9);
            lblAgregarCliente.Name = "lblAgregarCliente";
            lblAgregarCliente.Size = new Size(127, 15);
            lblAgregarCliente.TabIndex = 20;
            lblAgregarCliente.Text = "Registrar nuevo cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 449);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 33;
            label7.Text = "Realizar venta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 483);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 34;
            label13.Text = "Fecha:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 517);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 35;
            label14.Text = "Precio final:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 553);
            label15.Name = "label15";
            label15.Size = new Size(87, 15);
            label15.TabIndex = 36;
            label15.Text = "Observaciones:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(114, 553);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(272, 68);
            richTextBox1.TabIndex = 37;
            richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 483);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 517);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 39;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Location = new Point(260, 627);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(126, 23);
            btnRealizarVenta.TabIndex = 40;
            btnRealizarVenta.Text = "Realizar venta";
            btnRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // concesionariaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 661);
            Controls.Add(btnRealizarVenta);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(textBox12);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(lblAgregarCliente);
            Controls.Add(txtPrecioVehiculo);
            Controls.Add(txtKilometrajeVehiculo);
            Controls.Add(txtPatenteVehiculo);
            Controls.Add(txtAnioVehiculo);
            Controls.Add(txtModeloVehiculo);
            Controls.Add(txtMarcaVehiculo);
            Controls.Add(btnAgregarVehiculo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAgregarVehiculo);
            Controls.Add(dgvVentas);
            Controls.Add(dgvVehiculos);
            Controls.Add(dgvClientes);
            Controls.Add(lblTituloVentas);
            Controls.Add(lblTituloCliente);
            Controls.Add(lblTituloVehiculos);
            MaximumSize = new Size(1141, 700);
            MinimumSize = new Size(1141, 700);
            Name = "concesionariaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Concesionaria de autos";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloVehiculos;
        private Label lblTituloCliente;
        private Label lblTituloVentas;
        private DataGridView dgvClientes;
        private DataGridView dgvVehiculos;
        private DataGridView dgvVentas;
        private Label lblAgregarVehiculo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregarVehiculo;
        private TextBox txtMarcaVehiculo;
        private TextBox txtModeloVehiculo;
        private TextBox txtAnioVehiculo;
        private TextBox txtPatenteVehiculo;
        private TextBox txtKilometrajeVehiculo;
        private TextBox txtPrecioVehiculo;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button btnRegistrarCliente;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblAgregarCliente;
        private Label label7;
        private Label label13;
        private Label label14;
        private Label label15;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button btnRealizarVenta;
    }
}
