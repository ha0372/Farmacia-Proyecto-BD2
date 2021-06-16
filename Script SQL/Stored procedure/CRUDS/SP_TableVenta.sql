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

SELECT TOP(1) Id_Venta
FROM "Venta"
ORDER BY Id_Venta /*ASC*/DESC;

select * from Venta

CREATE PROCEDURE sp_UltimaVenta
		
	AS
	BEGIN
		SET NOCOUNT ON;
		SELECT TOP(1) Id_Venta
FROM "Venta"
ORDER BY Id_Venta /*ASC*/DESC;
	END
	GO

	exec sp_UltimaVenta

--**************************************************************************************
CREATE PROCEDURE sp_ConsultarVenta
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Venta
	END
	GO
--****************************
CREATE PROCEDURE sp_ConsultarVentaId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Venta where  Id_Venta = @ID
	END
	GO


--***************************************************************************************
exec sp_InsertVenta 'Alex Perez'
exec sp_InsertDetalleVenta 7,1,500,50


select * from Producto
select * from Venta


exec sp_DeleteVenta 2
exec sp_UpdateVenta 'maria',1
exec sp_ConsultarVenta
exec sp_ConsultarVentaId 4

select * from Venta
go

Insert into Venta(Cliente)  values('Alex')
Insert into DetalleVenta(Venta_FK, Producto_FK,CantidadVProducto,TotalVenta)  values(1,1,500,750)

select * from Producto
select * from Venta

	SELECT distinct TOP 1 Id_Venta FROM  Venta ORDER BY Id_Venta DESC

--***************************************************************************************