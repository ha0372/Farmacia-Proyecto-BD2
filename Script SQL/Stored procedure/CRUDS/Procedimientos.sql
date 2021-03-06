use FarmaciaBD
go

CREATE PROCEDURE sp_InsertarProducto	
		@Nombre varchar(50),
		@Precio money,
		@Existencias int

	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Producto(nombre,Precio,) values (@nombre,@Precio,@Existencias)
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