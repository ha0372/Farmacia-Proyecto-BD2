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

exec sp_InsertVenta 'Maria54'
exec sp_DeleteVenta 2
exec sp_UpdateVenta 'maria',1
exec sp_ConsultarVenta
exec sp_ConsultarVentaId 4

select * from Venta