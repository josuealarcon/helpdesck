CREATE PROCEDURE [dbo].[V4MVC_ARCHIVOS_SELECT_FOTOFUNCIONARIO]
( @ID           nvarchar(11) = NULL) AS
BEGIN

	SELECT TOP 1 ARCHIVOS.ARCHIVO, ARCHIVOS.TIPOCONTENIDO 
	FROM ARCHIVOS 
	INNER JOIN DOCS_WORKERS ON ARCHIVOS.ID = DOCS_WORKERS.ID 
	WHERE ( dbo.DOCS_WORKERS.RUT = @ID) AND 
	(dbo.DOCS_WORKERS.ID_DOC = 16) ORDER BY DOCS_WORKERS.FECHA_MOD DESC

END

