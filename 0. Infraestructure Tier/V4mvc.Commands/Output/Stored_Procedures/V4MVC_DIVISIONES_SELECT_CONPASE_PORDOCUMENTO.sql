CREATE PROCEDURE [dbo].[V4MVC_DIVISIONES_SELECT_CONPASE_PORDOCUMENTO]
( @ID_DOC           INT = NULL ) AS
BEGIN

	SELECT DIVISION, DIVCOD , PAIS  FROM A024_DIVISIONES
	WHERE (ACTIVO = N'SI')  AND 
	DIVCOD IN (SELECT DIVISION FROM DOCS_TIPOPASE WHERE ID_DOC = @ID_DOC)
	ORDER BY DIVCOD

END

