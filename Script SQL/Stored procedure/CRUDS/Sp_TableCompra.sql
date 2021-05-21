use FarmaciaBD
go

--************************************************************************************************************************
CREATE PROCEDURE sp_InsertCompra
		
		@Laboratorio varchar(50)

	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Compra(Laboratorio) values (@Laboratorio)
	END
	GO
--**********************************************************************************************************************

CREATE PROCEDURE sp_ConsultarCompra
		
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Compra
	END
	GO
--************************************
CREATE PROCEDURE sp_ConsultarCompraId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Compra where  Id_Compra = @ID
	END
	GO


--***************************************************************************************

select * from Compra

exec sp_InsertCompra 'Bayern'
exec sp_ConsultarCompra
exec sp_ConsultarCompraId 1