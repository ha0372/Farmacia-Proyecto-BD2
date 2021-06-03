use FarmaciaBD

go

create procedure sp_IncrementarExistencias
	@cantidad int, @id int
as
begin
	Update Producto set ExistenciasProductos = ExistenciasProductos + @cantidad where Id_Producto=@id
end
GO
--*******************************************************************************************************************

Create TRIGGER IncrementarExistencias
   ON  Compra
   AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @id varchar(4), @estado varchar(4), @estadon int;
	select @id=i.Id_Compra,@estado=i.EstadoCompra,@estadon=i.EstadoCompra from inserted i;

	if	@estadon=2
	    begin	

			Declare @Cantidad int, @IdProducto int
			Declare IncrementoProductos Cursor for Select CantidadCProducto, Producto_FK from DetalleCompra where Compra_FK=@id

			Open IncrementoProductos

			FETCH NEXT FROM IncrementoProductos INTO @Cantidad,@IdProducto

			WHILE @@FETCH_STATUS = 0 
			begin	
				exec sp_IncrementarExistencias @Cantidad, @IdProducto

			 FETCH NEXT FROM IncrementoProductos INTO @Cantidad,@IdProducto
			end

			CLOSE IncrementoProductos;  

			DEALLOCATE IncrementoProductos;  
		end
END
GO



