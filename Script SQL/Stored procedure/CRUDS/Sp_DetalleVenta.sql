create PROCEDURE sp_InsertDetalleVenta
		
		@Venta_Fk int,
		@Producto_fk int,
		@CantidadVProducto int,
		@TotalVenta money

	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into DetalleVenta(Venta_FK,Producto_FK,CantidadVProducto,TotalVenta) values (@Venta_Fk,@Producto_fk,@CantidadVProducto,@TotalVenta)
	END
	GO

CREATE PROCEDURE sp_ConsultarDetalleVenta
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleVenta
	END
	GO