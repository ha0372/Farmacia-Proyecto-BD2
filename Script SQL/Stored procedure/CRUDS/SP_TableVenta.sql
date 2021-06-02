use FarmaciaBD
go

--************************************************************************************************************************
CREATE PROCEDURE sp_InsertVenta
		
		@Cliente varchar(50)

	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Venta(Cliente) values (@Cliente)
	END
	GO
--*********************************************************************************************************************
CREATE PROCEDURE sp_DeleteVenta
		
		@IdVenta  int
	AS
	BEGIN
		SET NOCOUNT ON;
		Delete from  Venta where  Id_Venta=@IdVenta
	END
	GO

--***********************************************************************************
CREATE PROCEDURE sp_UpdateVenta
		
		@Cliente varchar(50),
		@IdVenta  int
	AS
	BEGIN
		SET NOCOUNT ON;
		Update Venta set Cliente=@Cliente where Id_Venta=@IdVenta
	END
	GO

--**************************************************************************************
CREATE PROCEDURE sp_ConsultarVenta
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Venta
	END
	GO
--************************************
CREATE PROCEDURE sp_ConsultarVentaId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Venta where  Id_Venta = @ID
	END
	GO


--***************************************************************************************
alter PROCEDURE sp_InsertDetalleVenta
		
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


exec sp_InsertVenta 'Alex'
exec sp_InsertDetalleVenta 4,1,400,50


select * from Producto
select * from Venta


exec sp_DeleteVenta 2
exec sp_UpdateVenta 'maria',1
exec sp_ConsultarVenta
exec sp_ConsultarVentaId 4

select * from Venta