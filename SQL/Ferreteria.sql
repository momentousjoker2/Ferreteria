
USE master;
DROP DATABASE  IF EXISTS ferreteria;

CREATE DATABASE ferreteria;

USE ferreteria;

CREATE TABLE Categoria(
	id int identity (1,1) PRIMARY KEY,
	Descripcion varchar (40)
);

CREATE TABLE Cliente(
	id int identity (1,1) PRIMARY KEY,
	nombre varchar (40),
	rfc varchar(10),
	domicilio varchar(20),
	colonia varchar (20),
	cp varchar(5),
	ciudad varchar(20),
	telefono varchar(20),
	email varchar(20)
);

CREATE TABLE Provedor(
	id int identity (1,1) PRIMARY KEY,
	nombre varchar (40),
	Domicilio varchar (20),
	Colonia varchar (20),
	Cp varchar (5),
	Ciudad varchar(20),
	Telefono varchar (20),
	Contacto varchar (20),
	Email varchar(20),
	saldoProv money
);

CREATE TABLE Productos(
	id varchar(15) PRIMARY KEY,
	idCategoria int,
	Descripcion varchar (40),
	Existencias int,
	unidadDMedida varchar(15),
	precioCosto money ,
	precioVenta money ,
	maximo float,
	minimo float
);

CREATE TABLE Venta(
	id int identity (1,1) PRIMARY KEY,
	idCliente int,
	fecha DATETIME,
	subTotal money ,
	descuento money ,
	iva money,
	total money,
	status bit
);

CREATE TABLE DetallesVenta(
	id int,
	idProducto varchar(15) ,
	cantidad money ,
	precioVenta money,
	primary key (id,idProducto)
);

CREATE TABLE Compras(
	id int identity (1,1) PRIMARY KEY,
	idProvedor int ,
	factura int ,
	fecha DATETIME ,
	fechaVenc DATETIME ,
	condiciones bit,
	subTotal money ,
	descuento money ,
	iva money ,
	total money,
	saldoFacura money
);

CREATE TABLE DetallesCompra(
	id int,
	idProducto varchar(15) ,
	cantidad money,
	precioCompra money,
	primary key (id,idProducto)
);


CREATE TABLE Devoluciones(
	id int identity (1,1) PRIMARY KEY,
	idVenta int  ,
	fecha DATETIME ,
	motivo varchar (60)
	  );


	CREATE TABLE Pagos(
		id int identity (1,1) PRIMARY KEY,
		idCompra int  ,
		fecha DATETIME ,
		importe money 
		);
