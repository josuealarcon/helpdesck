CREATE PROCEDURE [dbo].[V4MVC_DOCS_OST2_INSERT_CONTRATOST_CTTA]   
(
  @ID_ARCHIVO	UNIQUEIDENTIFIER
 ,@ID_DOC		INT
 ,@NROOST		NVARCHAR(50)
 ,@MADRE		NVARCHAR(10)
 ,@IDEMPRESA	NVARCHAR(10)
 ,@NIVEL		SMALLINT
 ,@USUARIO		NVARCHAR(10)
) AS           
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	
	DELETE
	FROM DOCS_OST2
	WHERE
		(OST = @NROOST) AND
		(MADRE = @MADRE) AND
		(EMPRESA = @IDEMPRESA) AND
		(ID_DOC = @ID_DOC) AND
		(NIVEL = @NIVEL)

	INSERT INTO DOCS_OST2
			(
				ID_ARCHIVO,
				OST,
				MADRE,
				EMPRESA,
				NIVEL,
				ID_DOC,
				FECHAMOD,
				HORAMOD,
				FECHASUBE,
				HORASUBE,
				USUARIO,
				VALIDADO,
				TIPO
			)
	VALUES
			(
				@ID_ARCHIVO,
				@NROOST,
				@MADRE,
				@IDEMPRESA,
				@NIVEL,
				@ID_DOC,
				@CURR_FECHA,
				@CURR_TIEMPOFULL,
				@CURR_FECHA,
				@CURR_TIEMPOFULL,
				@USUARIO,
				'NO',
				'OST'
			)
END
