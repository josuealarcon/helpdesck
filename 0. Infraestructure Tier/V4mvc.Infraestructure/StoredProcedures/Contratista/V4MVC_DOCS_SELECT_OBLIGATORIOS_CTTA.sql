CREATE PROCEDURE [dbo].[V4MVC_DOCS_SELECT_OBLIGATORIOS_CTTA]
(@DIVCOD	NVARCHAR(50) = NULL
,@ID_DOC	INT = NULL
) AS
BEGIN
	SELECT DISTINCT DT.TIPOPASE 
	FROM DOCS_TIPOPASE AS DT 
	INNER JOIN DOCS AS D ON DT.ID_DOC = D.ID_DOC 
	WHERE (DT.DIVISION = @DIVCOD) AND 
	(D.ID_DOC_OPCION = 0) AND 
	(D.ID_DOC = @ID_DOC) AND 
	(D.SUBEDOC = 'SI') AND 
	(DT.TIPOPASE <> 'OPCIONAL')
END

