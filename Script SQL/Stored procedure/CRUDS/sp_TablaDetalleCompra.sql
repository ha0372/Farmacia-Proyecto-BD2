CREATE PROCEDURE sp_InsertDetalleCompra
		
		@Compra_FK int,
		@Producto_FK int,
		@Cantidad int,
		@PrecioCompra money
	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into DetalleCompra(Compra_FK,Producto_FK,Cantidad,PrecioCompra) values (@Compra_FK,@Producto_FK,@Cantidad,@PrecioCompra)
	END
	GO

--************************************************************************************************************************

CREATE PROCEDURE sp_Consulta_DetalleCompra
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleCompra
	END
	GO

--************************************************************************************************************************

CREATE PROCEDURE sp_ConsultarDetalleCompra_Id
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleCompra where  Id_DetalleCompra = @ID
	END
	GO