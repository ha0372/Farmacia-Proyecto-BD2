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
	Fecha datetime NOT NULL DEFAULT GETDATE()
);

create table Compra(
Id_Compra int not null identity primary key,
Laboratorio varchar(75),
fecha datetime NOT NULL DEFAULT GETDATE()
);


create table Historial(
Id_Historial int not null identity primary key,
Descripcion varchar(100),
Fecha datetime NOT NULL DEFAULT GETDATE()
);

create table Linea(
Id_Linea int not null identity primary key,
Nombre varchar (50)

);

--TABLAS DEPENDIENTES 

create table Producto(
Id_Producto int not null identity primary key,
Linea_FK int references Linea(Id_Linea),
Nombre varchar(100),
Precio money,
Existencias int,

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
Compra_FK int references Compra (Id_Compra),
Producto_FK int references Producto(Id_Producto),
Cantidad int,
PrecioCompra money,
);
