# Concesionaria de Autos - Proyecto .NET
Descripción

Este proyecto es una aplicación backend desarrollada en C# para gestionar una concesionaria de autos. 
Permite administrar vehículos, clientes y ventas, facilitando el control integral de la operación de venta de automóviles.

# Modelo de Negocio

La concesionaria se basa en tres entidades principales:

* Vehículo: Representa un auto disponible para la venta, con sus características básicas como marca, modelo, año, kilometraje, precio y patente única.
* Cliente: Representa a una persona interesada en comprar un vehículo, con datos personales como nombre, apellido, DNI, teléfono y email.
* Venta: Representa una transacción de compra de un vehículo por un cliente, incluyendo fecha de venta, precio final y observaciones.

# Funcionalidades principales

* Gestión de Vehículos: CRUD completo para vehículos, incluyendo búsqueda y listado.
* Gestión de Clientes: CRUD completo para clientes.
* Gestión de Ventas: Registrar ventas asociadas a un vehículo y cliente, actualizar y eliminar ventas existentes.
* Integridad referencial: Las ventas están vinculadas a vehículos y clientes mediante claves foráneas, garantizando consistencia de datos.

# Arquitectura

* Capa Entidades (Entity): Define las clases de negocio Vehiculo, Cliente y Venta.
* Capa Datos (Data): Contiene los DAO para acceso a base de datos SQL Server usando ADO.NET con consultas parametrizadas para prevenir SQL injection.
* Capa Negocio (Business): Contiene la lógica para operaciones de negocio, controlando transacciones y validaciones.
* Mapeadores (Mapper): Transforman los resultados de consultas SQL (DataSet) a objetos C#.
* Capa Presentacion (UI): Contiene formularios y presentacion de datos. 

# Tecnologías

* .NET 8
* C#
* SQL Server
* ADO.NET
* Transacciones con TransactionScope

# ¿Cómo usar?

* Configurar cadena de conexión en DbConnectionString.
* Ejecutar métodos CRUD a través de la capa Business para gestionar la concesionaria.
* Adaptar o ampliar según necesidades específicas (e.g., interfaz gráfica o API REST).