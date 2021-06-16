Create PROCEDURE [dbo].[sp_ConsultarLaboratorio]
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Laboratorio
	END

	select *from Venta

--********************************************************************************

	CREATE PROCEDURE sp_InsertarLaboratorio	
		@NombreLaboratorio varchar(50)
	AS
	BEGIN
		SET NOCOUNT ON;
		Insert into Laboratorio(NombreLaboratorio) values (@NombreLaboratorio)
	END
	GO
	--********************************************************************************

	CREATE PROCEDURE sp_ConsultarLaboratorioId
		@ID int
	AS
	BEGIN
		SET NOCOUNT ON;
		Select * from  Laboratorio where  Id_Laboratorio = @ID
	END
	GO
	


--*********************************************************************************************************************
CREATE PROCEDURE sp_DeleteLaboratorio
		
		@IdLaboratorio  int
	AS
	BEGIN
		SET NOCOUNT ON;
		Delete from  Laboratorio where  Id_Laboratorio=@IdLaboratorio
	END
	GO

--***********************************************************************************
CREATE PROCEDURE sp_UpdateLaboratorio
		
		@NombreLaboratorio varchar(50),
		@IdLaboratorio  int
	AS
	BEGIN
		SET NOCOUNT ON;
		Update Laboratorio set NombreLaboratorio=@NombreLaboratorio where Id_Laboratorio=@IdLaboratorio
	END
	GO

--**************************************************************************************

SELECT TOP(1) Id_Laboratorio
FROM "Laboratorio"
ORDER BY Id_Laboratorio /*ASC*/DESC;

select * from Laboratorio

CREATE PROCEDURE sp_UltimoLaboratorio
		
	AS
	BEGIN
		SET NOCOUNT ON;
		SELECT TOP(1) Id_Laboratorio
FROM "Laboratorio"
ORDER BY Id_Laboratorio /*ASC*/DESC;
	END
	GO

	exec sp_UltimoLaboratorio

--**************************************************************************************
