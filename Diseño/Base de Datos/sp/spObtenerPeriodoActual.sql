USE [SSIA2012-1]
GO
/****** Object:  StoredProcedure [IFC-DC].[spObtenerPeriodoActual]    Script Date: 09/11/2013 13:07:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [IFC-DC].[spObtenerPeriodoActual]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		p.PeriodoId, p.Descripcion, CONVERT(varchar,p.FechaInicio,103) AS FechaInicio, CONVERT(varchar,p.FechaFin,103) AS FechaFin
	
	FROM 
		Periodo p
	
	WHERE
		p.EsActual = 1  

END