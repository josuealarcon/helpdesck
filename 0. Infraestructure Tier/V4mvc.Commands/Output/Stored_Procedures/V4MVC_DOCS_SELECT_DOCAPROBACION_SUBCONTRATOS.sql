

CREATE PROCEDURE [dbo].[V4MVC_DOCS_SELECT_DOCAPROBACION_SUBCONTRATOS]
AS
BEGIN
	DECLARE @INFORMACION_ARCHIVO NVARCHAR(500)
	DECLARE @ID_DOC				 INT
	SELECT @ID_DOC = Valor1, @INFORMACION_ARCHIVO = Valor2 FROM PARAMETROS_V2 WHERE ID_PARAMETRO = '57'

	SELECT ID_DOC	, NOMBRE , @INFORMACION_ARCHIVO AS INFORMACION_ARCHIVO 
		 , STUFF((SELECT ',' + DX.EXTENSION
				  FROM DOCS_FORMATO DF 
					INNER JOIN DOCS D ON DF.ID_DOC = D.ID_DOC
					INNER JOIN DOCS_EXT DX ON DF.ID_DOC_EXT = DX.ID_DOC_EXT
					WHERE D.ID_DOC = @ID_DOC
				  FOR XML PATH('')),1,1,'') AS EXTENSIONES

	FROM DOCS WHERE ID_DOC = @ID_DOC
END


