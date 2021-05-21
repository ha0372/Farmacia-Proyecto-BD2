use FarmaciaBD
go
CREATE PROCEDURE sp_InsertarLinea	
		@nombreLinea varchar(50)
	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Linea(nombre) values (@nombreLinea)
	END
	GO

--********************************************************************************
CREATE PROCEDURE sp_ConsultarLinea 
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Linea
	END
	GO

--*********************************************************************************
CREATE PROCEDURE sp_ConsultarLineaId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Linea where  Id_Linea = @ID
	END
	GO

--*************************************************************************************
CREATE PROCEDURE sp_InsertarProducto	
		@Nombre varchar(50),
		@Precio money,
		@Cantidad int
	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Producto(nombre,Precio,Cantidad) values (@nombre,@Precio,@Cantidad)
	END
	GO
--******************************************************************************************
CREATE PROCEDURE sp_ConsultarProducto
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Producto
	END
	GO
--**********************************************************************************************
CREATE PROCEDURE sp_ConsultarProductoId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Producto where  Id_Producto = @ID
	END
	GO