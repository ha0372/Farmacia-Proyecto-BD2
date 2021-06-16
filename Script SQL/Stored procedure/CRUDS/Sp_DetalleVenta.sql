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
--****************************************************************************************************

CREATE PROCEDURE sp_ConsultarDetalleVenta
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleVenta
	END
	GO

--****************************************************************************************************

CREATE PROCEDURE sp_ConsultarDetalleVentaId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  DetalleVenta where  Id_DetalleVenta = @ID
	END
	GO
	


--*********************************************************************************************************************
CREATE PROCEDURE sp_DeleteDetalleVenta
		
		@Id_DetalleVenta  int
	AS
	BEGIN
		SET NOCOUNT ON;
		Delete from  DetalleVenta where  Id_DetalleVenta=@Id_DetalleVenta
	END
	GO

--***********************************************************************************
CREATE PROCEDURE sp_UpdateDetalleVenta
		
		@Venta_Fk int,
		@IdDetalleVenta  int,
		@Producto_Fk int,
		@CantidadVProducto int,
		@TotalVenta int
	AS
	BEGIN
		SET NOCOUNT ON;
		Update DetalleVenta set Venta_FK=@Venta_Fk,@Producto_Fk =@Producto_Fk,
		CantidadVProducto=@CantidadVProducto,TotalVenta=@TotalVenta where Id_DetalleVenta=@IdDetalleVenta
	END
	GO

--**************************************************************************************