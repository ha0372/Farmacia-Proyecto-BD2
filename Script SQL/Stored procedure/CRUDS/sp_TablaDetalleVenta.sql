
CREATE PROCEDURE sp_InsertDetalleVenta
		
		@Venta_FK int,
		@Producto_FK int,
		@Cantidad int,
		@PrecioVenta money
	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into DetalleVenta(Venta_FK,Producto_FK,Cantidad,PrecioVenta) values (@Venta_FK,@Producto_FK,@Cantidad,@PrecioVenta)
	END
	GO

--*****************************************************************************************************************

CREATE PROCEDURE sp_Consulta_DetalleVenta
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleVenta
	END
	GO

--*****************************************************************************************************************

CREATE PROCEDURE sp_ConsultarDetalleVenta_Id
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleVenta where  Id_DetalleVenta = @ID
	END
	GO