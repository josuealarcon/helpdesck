CREATE PROCEDURE [dbo].[V4MVC_DOCS_SELECT_DIVISION]
(
@DIVCOD NVARCHAR(4)
)
AS
BEGIN

SELECT DISTINCT D.CAMPO FROM DOCS AS D 
			 INNER JOIN DOCS_TIPOPASE AS DT ON D.ID_DOC = DT.ID_DOC  
			 	 WHERE ((DT.TIPOPASE = 'TRABAJO') 
			 	 OR (DT.TIPOPASE = 'OPCIONAL')) 
			    AND (DT.DIVISION = @DIVCOD)  
			 	 AND (D.ACTIVO = 'SI') 
			 	 AND (D.ID_TIPO_PROPIETARIO = 1 ) 
			 	 ORDER BY D.CAMPO 
END
