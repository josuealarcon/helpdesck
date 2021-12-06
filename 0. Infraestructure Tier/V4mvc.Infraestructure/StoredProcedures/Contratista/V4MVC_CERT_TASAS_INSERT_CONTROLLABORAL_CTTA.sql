CREATE PROCEDURE [dbo].[V4MVC_CERT_TASAS_INSERT_CONTROLLABORAL_CTTA]
(
  @PERIODO				NVARCHAR(6)
 ,@IDEMPRESA			NVARCHAR(10)
 ,@FOLIO				BIGINT
 ,@NRO_ACCIDENTES		INT
 ,@DIAS_ACCIDENTES		INT
 ,@DIAS_ENFERMEDAD		INT
 ,@NRO_ENFERMEDAD		INT
 ,@DIAS_INCAPACIDAD		INT
 ,@DIAS_FATALES			INT
 ,@TOTAL_PERDIDOS		INT
 ,@RET_CODE				INT OUTPUT
) AS
BEGIN
	
	SET @RET_CODE = -1

	IF(EXISTS(
			SELECT
				PERIODO
			FROM CERT_TASAS
			WHERE
				EMPRESA = @IDEMPRESA AND
				PERIODO = @PERIODO
	))
		BEGIN
			SET @RET_CODE = 1  /*ERROR LOGICO; YA EXISTE*/
			RETURN
		END
	INSERT INTO CERT_TASAS
		(
			PERIODO,
			EMPRESA,
			FOLIO,
			NRO_ACCIDENTES,
			DIAS_ACCIDENTES,
			DIAS_ENFERMEDAD,
			NRO_ENFERMEDAD,
			DIAS_INCAPACIDAD,
			DIAS_FATALES,
			TOTAL_PERDIDOS
		)
	VALUES
		(
			@PERIODO,
			@IDEMPRESA,
			@FOLIO,
			@NRO_ACCIDENTES,
			@DIAS_ACCIDENTES,
			@DIAS_ENFERMEDAD,
			@NRO_ENFERMEDAD,
			@DIAS_INCAPACIDAD,
			@DIAS_FATALES,
			@TOTAL_PERDIDOS
		)
END
