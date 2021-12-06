CREATE PROCEDURE [dbo].[V4MVC_PLANILLA_COTIZACION_INSERT_CONTROLLABORAL_CTTA]
(
  @PERIODO		NVARCHAR(6)
 ,@IDEMPRESA	NVARCHAR(10)
 ,@DIVISION		NVARCHAR(4)
 ,@OST			NVARCHAR(20)
 ,@MONTOIMP		INT
 ,@CANTFUNC		INT
 ,@RET_CODE		INT OUTPUT
) AS
BEGIN
	SET @RET_CODE = -1

	IF(EXISTS(
			SELECT
				PERIODO
			FROM PLANILLA_COTIZACION
			WHERE
				EMPRESA = @IDEMPRESA AND
				PERIODO = @PERIODO AND
				DIVISION = @DIVISION AND
				OST = @OST
	))
		BEGIN
			SET @RET_CODE = 1  /*ERROR LOGICO; YA EXISTE*/
			RETURN
		END
	INSERT INTO PLANILLA_COTIZACION(PERIODO, EMPRESA, DIVISION, OST, CANTFUNC, MONTOIMP)
	VALUES (@PERIODO, @IDEMPRESA, @DIVISION, @OST, @CANTFUNC, @MONTOIMP)
END
