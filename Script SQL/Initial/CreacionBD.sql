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
	Cliente varchar(75),
	FechaVenta datetime NOT NULL DEFAULT GETDATE(),
	--EstadoVenta int not null default 1
);

create table Compra(
Id_Compra int not null identity primary key,
FechaCompra datetime NOT NULL DEFAULT GETDATE(),
EstadoCompra int not null default 1
);


create table Historial(
Id_Historial int not null identity primary key,
Descripcion varchar(100),
FechaSuceso datetime NOT NULL DEFAULT GETDATE()
);

create table Linea(
Id_Linea int not null identity primary key,
NombreLinea varchar (50)
);

create table Laboratorio(
Id_Laboratorio int not null identity primary key,
NombreLaboratorio varchar(75),
--ContactoLaboratorio varchar(25)
);

--TABLAS DEPENDIENTES 

create table Producto(
Id_Producto int not null identity primary key,
Linea_FK int references Linea(Id_Linea),
Laboratorio_FK int references Laboratorio(Id_Laboratorio),
NombreProducto varchar(100),
PrecioProducto money,
ExistenciasProductos int,
);

create table DetalleVenta(
Id_DetalleVenta int not null identity primary key,
Venta_FK int references Venta(Id_Venta),
Producto_FK int references Producto(Id_Producto),
CantidadVProducto int,
TotalVenta money,
);

create table DetalleCompra(

Id_DetalleCompra int not null identity primary key,
Compra_FK int references Compra (Id_Compra),
Producto_FK int references Producto(Id_Producto),
CantidadCProducto int,
TotalCompra money,
);
