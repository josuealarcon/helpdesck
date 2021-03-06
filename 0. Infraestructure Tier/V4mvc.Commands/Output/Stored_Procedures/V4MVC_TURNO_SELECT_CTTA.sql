CREATE PROCEDURE [dbo].[V4MVC_TURNO_SELECT_CTTA]
(
  @IDEMPRESA	NVARCHAR(10) = NULL
 ,@OST			NVARCHAR(14) = NULL
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	SELECT
		DISTINCT
		TURNO
	FROM TURNOS
	WHERE
		EMPRESA = @IDEMPRESA AND
		OST = @OST AND
		VALIDADO = 'SI' AND
		FVIGENCIA >= @CURR_FECHA
	ORDER BY TURNO
END

