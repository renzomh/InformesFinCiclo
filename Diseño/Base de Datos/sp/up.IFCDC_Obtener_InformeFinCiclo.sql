USE [SSIA2012-1]
GO
/****** Object:  StoredProcedure [dbo].[up.IFCDC_Obtener_InformeFinCiclo]    Script Date: 09/15/2013 00:34:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Renzo Martinez
-- Create date: 25/06/2013
-- Description:	Este sp nos permite registrar u obtener un nuevo Informe de Fin de Ciclo
-- =============================================
CREATE PROCEDURE [dbo].[up.IFCDC_Obtener_InformeFinCiclo]
(
	@PersonaId varchar(50),
	@CursoId int,
	@PeriodoId int
)
AS
BEGIN
	DECLARE @numInformes int
	SET @numInformes = 0

	SELECT @numInformes = COUNT(*) FROM IFCDC.InformeFinCiclo i WHERE i.PersonaId = @PersonaId and i.CursoId = @CursoId and i.PeriodoId = @PeriodoId

	IF(@numInformes <= 0)
		BEGIN
			INSERT INTO [IFCDC].InformeFinCiclo
				([PersonaId]
				,[CursoId]
				,[PeriodoId]
				,[UltimaActualizacion])
			VALUES
				(@PersonaId
				,@CursoId
				,@PeriodoId
				,GETDATE())
		END

	SELECT	*
	FROM	[IFCDC].InformeFinCiclo i
	WHERE	i.PersonaId = @PersonaId AND i.CursoId = @CursoId AND i.PeriodoId = @PeriodoId
END
