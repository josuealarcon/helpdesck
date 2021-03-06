CREATE PROCEDURE [dbo].[V4MVC_WC3_VISTA_CLABORAL_DC_SELECT_ONE_CONTROLLABORAL_CTTA]
(
  @PERIODO		NVARCHAR(6)
 ,@EMPRESA		NVARCHAR(10)
) AS
BEGIN
	SELECT
		EMPRESA,
		PERIODO,
		COUNT(TIPO) AS CANT
	FROM WC3_VISTA_CLABORAL_DC
	WHERE
		TIPO IN ('F30','F301') AND
		PERIODO = @PERIODO AND
		EMPRESA = @EMPRESA
	GROUP BY EMPRESA, PERIODO
END
