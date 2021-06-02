use FarmaciaBD

go

create procedure sp_DisminuirExistencias
	@cantidad int, @id int
as
begin
	Update Producto set ExistenciasProductos = ExistenciasProductos - @cantidad where Id_Producto=@id
end
GO


--Create TRIGGER DisminuirExistencias
--   ON  Venta
--   AFTER UPDATE
--AS 
--BEGIN
--	SET NOCOUNT ON;
--	Declare @id varchar(4), @estado varchar(4), @estadon int;
--	select @id=i.Id_Venta,@estado=i.EstadoVenta,@estadon=i.EstadoVenta from inserted i;

--	if	@estadon=2
--	    begin	

--			Declare @Cantidad int, @IdProducto int
--			Declare DisminuirProductos Cursor for Select CantidadVProducto, Producto_FK from DetalleVenta where Venta_FK=@id

--			Open DisminuirProductos

--			FETCH NEXT FROM DisminuirProductos INTO @Cantidad,@IdProducto

--			WHILE @@FETCH_STATUS = 0 
--			begin	
--				exec sp_DisminuirExistencias @Cantidad, @IdProducto

--			 FETCH NEXT FROM DisminuirProductos INTO @Cantidad,@IdProducto
--			end

--			CLOSE DisminuirProductos;  

--			DEALLOCATE DisminuirProductos;  
--		end
--END
--GO

USE Venta
go


Alter TRIGGER DisminuirProducto

   ON  DetalleVenta
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;

	Declare @FkProducto int;
	Declare @CantidadVenta int;

	select @FkProducto=i.Producto_FK,@CantidadVenta=i.CantidadVProducto from inserted i;
   
    exec sp_DisminuirExistencias  @CantidadVenta,@FkProducto 

END
GO

--@CantidadVenta
--cast(@CantidadVenta as int)