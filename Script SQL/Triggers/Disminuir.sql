use FarmaciaBD

go

create procedure sp_DisminuirExistencias
	@cantidad int, @id int
as
begin
	Update Producto set ExistenciasProductos = ExistenciasProductos - @cantidad where Id_Producto=@id
end
GO

--***************************************************************************************************



Create TRIGGER DisminuirProducto

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