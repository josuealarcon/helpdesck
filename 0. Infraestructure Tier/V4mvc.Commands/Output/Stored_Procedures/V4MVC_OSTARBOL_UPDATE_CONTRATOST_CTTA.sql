CREATE PROCEDURE [dbo].[V4MVC_OSTARBOL_UPDATE_CONTRATOST_CTTA]   
(
  @ID_DOC			INT
 ,@EXT				NVARCHAR(10)
 ,@NROOST			NVARCHAR(50)
 ,@MADRE			NVARCHAR(10)
 ,@IDEMPRESA		NVARCHAR(10)
 ,@NIVEL			SMALLINT
 ,@EXISTE_QUERY		INT OUTPUT
) AS           
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	SET @EXISTE_QUERY = 0 
	IF(EXISTS(
		SELECT DOCS_EXT.ID_DOC_EXT
		FROM DOCS_FORMATO, DOCS_EXT
		WHERE
			(DOCS_FORMATO.ID_DOC = @ID_DOC) AND
			(DOCS_EXT.EXTENSION = @EXT) AND
			(DOCS_FORMATO.ID_DOC_EXT = DOCS_EXT.ID_DOC_EXT)
	))
		BEGIN
			SET @EXISTE_QUERY = 1
			IF(EXISTS(
				SELECT ID_DOC
				FROM DOCS_OST2
				WHERE
					(OST = @NROOST) AND
					(MADRE = @MADRE) AND
					(EMPRESA = @IDEMPRESA) AND
					(NIVEL = @NIVEL)
			))
				BEGIN
					UPDATE OSTARBOL
					SET
						FINICERT = @CURR_FECHA
					WHERE
						(OST = @NROOST) AND
						(MADRE = @MADRE) AND
						(EMPRESA = @IDEMPRESA) AND
						(NIVEL = @NIVEL)
				END

			UPDATE OSTARBOL
			SET
				FFINCERT = '', 
				FENTDOCS = '',
				FFINVALIDA = '',
				FFINVALIDA_ADMIN = ''
			WHERE
				(OST = @NROOST) AND
				(MADRE = @MADRE) AND
				(EMPRESA = @IDEMPRESA) AND
				(NIVEL = @NIVEL)
		END
END
