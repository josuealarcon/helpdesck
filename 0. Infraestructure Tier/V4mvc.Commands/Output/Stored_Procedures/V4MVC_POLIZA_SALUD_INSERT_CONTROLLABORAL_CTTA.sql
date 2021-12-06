CREATE PROCEDURE [dbo].[V4MVC_POLIZA_SALUD_INSERT_CONTROLLABORAL_CTTA]
(
  @PERIODO		NVARCHAR(6)
 ,@IDEMPRESA	NVARCHAR(10)
 ,@RET_CODE		INT OUTPUT
) AS
BEGIN
	
	SET @RET_CODE = -1

	IF(EXISTS(
			SELECT
				PERIODO
			FROM POLIZA_SALUD
			WHERE
				EMPRESA = @IDEMPRESA AND
				PERIODO = @PERIODO
	))
		BEGIN
			SET @RET_CODE = 1  /*ERROR LOGICO; YA EXISTE*/
			RETURN
		END
	INSERT INTO POLIZA_SALUD(PERIODO, EMPRESA)
	VALUES (@PERIODO, @IDEMPRESA)
END
