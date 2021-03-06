CREATE PROCEDURE [dbo].[V4MVC_DOCS_SELECT_ONE_V2_CONTROLLABORAL_CTTA]
(
  @ID_TIPO_PROPIETARIO		INT
 ,@ID_DOC_OPCION			INT
 ,@ID_DOC					INT
) AS
BEGIN
	SELECT
		TOP 1
		NOMBRE,
		ID_DOC
	FROM DOCS
	WHERE
		ACTIVO = 'SI' AND
		ID_TIPO_PROPIETARIO = @ID_TIPO_PROPIETARIO AND
		ID_DOC_OPCION = @ID_DOC_OPCION AND
		ID_DOC = @ID_DOC
	ORDER BY NOMBRE
END
