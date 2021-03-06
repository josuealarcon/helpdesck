CREATE PROCEDURE [dbo].[V4MVC_LIQUIDACION_DISPUTA_SELECT_TOP1]
(@RUT		NVARCHAR(10) = NULL 
,@PERIODO		NVARCHAR(6) = NULL 
,@EMPRESA	NVARCHAR(10) = NULL ) AS
BEGIN
	SELECT TOP 1 ESTADO, ID_DISPUTA,OBSERVACION,OBSERVACION_REVAL 
	FROM LIQUIDACION_DISPUTA 
	WHERE RUT = @RUT AND PERIODO = @PERIODO AND EMPRESA = @EMPRESA AND ESTADO <> 'SI' ORDER BY ID_DISPUTA DESC
END
