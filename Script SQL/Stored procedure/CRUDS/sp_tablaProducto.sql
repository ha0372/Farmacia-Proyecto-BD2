
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_DeleteProducto
	@idProducto int
AS
BEGIN

	SET NOCOUNT ON;
	Delete from Producto where Id_Producto = @idProducto
END
GO

CREATE PROCEDURE sp_ActualizarProducto 
	@nombreProducto varchar(75),
	@existencias int
AS
BEGIN
	SET NOCOUNT ON;
	Update Producto set NombreProducto=@nombreProducto where ExistenciasProductos=@existencias
END
GO