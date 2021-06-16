
CREATE PROCEDURE sp_InsertarLinea	
		@nombreLinea varchar(50)
	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Linea(nombre) values (@nombreLinea)
	END
	GO

--********************************************************************************
CREATE PROCEDURE sp_ConsultarLinea 
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Linea
	END
	GO

--*********************************************************************************
CREATE PROCEDURE sp_ConsultarLineaId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Linea where  Id_Linea = @ID
	END
	GO

--*************************************************************************************