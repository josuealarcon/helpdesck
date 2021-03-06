CREATE PROCEDURE [dbo].[V4MVC_INFORME_CAPACITACIONES_HISTORIAL_CTTA]
(
 @EMPRESA	NVARCHAR(10)	= NULL
,@DIVISION	NVARCHAR(4)		= NULL
,@IDCHARLA	INT				= NULL
,@RUT		NVARCHAR(10)	= NULL
,@FECHAINI	NVARCHAR(8)		= NULL
,@FECHAFIN	NVARCHAR(8)		= NULL
)
AS
BEGIN

	IF(@IDCHARLA = 0)
	BEGIN
		SET @IDCHARLA = NULL
	END

	SELECT		E.ACRONIMO		,W.NOMBRES		,W.APELLIDOS		,D.DIVISION
				,CHH.RUT		,CHH.FECHA		,CH.CHARLA			,CHH.EMPRESA
				,CHH.TEORICO	,CHH.PRACTICO 
	FROM CHARLHIST AS CHH 
	INNER JOIN WORKERS AS W			ON CHH.RUT = W.RUT 
	INNER JOIN CHARLAS AS CH		ON CHH.IDCHARLA = CH.IDCHARLA 
	INNER JOIN A024_DIVISIONES AS D ON CHH.DIVISION = D.DIVCOD 
	INNER JOIN ENTERPRISE AS E		ON CHH.EMPRESA = E.IDEMPRESA 
	WHERE 1 = 1
	AND CHH.EMPRESA			=	ISNULL(@EMPRESA,CHH.EMPRESA)
	AND CHH.DIVISION		=	ISNULL(@DIVISION, CHH.DIVISION)
	AND CHH.FECHA BETWEEN	ISNULL(@FECHAINI, CHH.FECHA) AND ISNULL(@FECHAFIN, CHH.FECHA)
	AND CHH.IDCHARLA		= ISNULL(@IDCHARLA,CHH.IDCHARLA)
	AND CHH.RUT				= ISNULL(@RUT, CHH.RUT)
	ORDER BY CH.CHARLA, CHH.FECHA, W.NOMBRES, W.APELLIDOS

END
