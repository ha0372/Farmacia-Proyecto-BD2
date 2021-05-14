use master
go
drop database if exists FarmaciaBD
go
create database FarmaciaBD
go
use FarmaciaBD
go

--TABLAS INDEPENDIENTES
create table Venta (
    Id_Venta  int not null identity primary key,
	Precio money,
	nombre varchar(50),
	fecha date
);

create table Compra(
Id_Compra int not null identity primary key,
FormaPago money,
Facturacion int,
fecha date
);

create table historial(
Id_Historial int not null identity primary key,
Cantidad int,
Nombre varchar(100),
Fecha date
);

create table Linea(
Id_Linea int not null identity primary key,
Nombre varchar (50)

);

--TABLAS DEPENDIENTES 

create table Producto(
Id_Producto int not null identity primary key,
Nombre varchar(100),
Precio money,
Cantidad int,
Linea_FK int references Linea(Id_Linea)

);

create table DetalleVenta(

Id_DetalleVenta int not null identity primary key,
Venta_FK int references Venta(Id_Venta),
Producto_FK int references Producto(Id_Producto),
Cantidad int,
PrecioVenta money,
);
create table DetalleCompra(

Id_DetalleCompra int not null identity primary key,
Producto_FK int references Producto(Id_Producto),
Compra_FK int references Compra (Id_Compra),
Cantidad int,
PrecioCompra money,
);
