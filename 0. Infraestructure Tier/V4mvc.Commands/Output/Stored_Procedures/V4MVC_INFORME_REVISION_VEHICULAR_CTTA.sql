CREATE PROCEDURE [dbo].[V4MVC_INFORME_REVISION_VEHICULAR_CTTA]
(
 @EMPRESA	NVARCHAR(10)	= NULL
,@FECHAINI	NVARCHAR(8)		= NULL
,@FECHAFIN	NVARCHAR(8)		= NULL
,@PATENTE	NVARCHAR(8)		= NULL
,@ESTADO	NVARCHAR(20)	= NULL
,@DIVISION	NVARCHAR(50)	= NULL
)
AS
BEGIN

	IF(ISNULL(@DIVISION,'')='')
	BEGIN

		SELECT		T1.EMPRESA		,T1.PATENTE		,T1.MARCA			,T1.MODELO
				   ,T1.TIPOV		,T1.FECHARES	,T1.HORAINICIO		,T1.HORATERMINO
				   ,T1.ESTADO		,T1.MOTIVO		,T1.USUARIOSOL		,T1.FECHASOL
				   ,T1.HORASOL		,T1.DIVISION	,T2.NOMBRES			,T2.APELLIDOS
		FROM		LISTADO_REVISION_VEHICULAR T1
		INNER JOIN	WORKERS T2 ON T1.USUARIOSOL = T2.RUT
		WHERE		T1.EMPRESA		=		@EMPRESA
		AND			T1.FECHARES	BETWEEN ISNULL(@FECHAINI,T1.FECHARES) AND  ISNULL(@FECHAFIN,T1.FECHARES)
		AND			T1.PATENTE = ISNULL(@PATENTE,T1.PATENTE)
		AND			T1.ESTADO = ISNULL(@ESTADO,T1.ESTADO)
		ORDER BY	T1.FECHARES	,T1.HORAINICIO

	END
	ELSE
	BEGIN
		SELECT		T1.EMPRESA		,T1.PATENTE		,T1.MARCA			,T1.MODELO
				   ,T1.TIPOV		,T1.FECHARES	,T1.HORAINICIO		,T1.HORATERMINO
				   ,T1.ESTADO		,T1.MOTIVO		,T1.USUARIOSOL		,T1.FECHASOL
				   ,T1.HORASOL		,T1.DIVISION	,T2.NOMBRES			,T2.APELLIDOS
		FROM		LISTADO_REVISION_VEHICULAR T1
		INNER JOIN	WORKERS T2 ON T1.USUARIOSOL = T2.RUT
		WHERE		T1.EMPRESA		=		@EMPRESA
		AND			T1.FECHARES	BETWEEN ISNULL(@FECHAINI,T1.FECHARES) AND  ISNULL(@FECHAFIN,T1.FECHARES)
		AND			T1.PATENTE = ISNULL(@PATENTE,T1.PATENTE)
		AND			T1.ESTADO = ISNULL(@ESTADO,T1.ESTADO)
		AND			T1.DIVISION IN (@DIVISION)
		ORDER BY	T1.FECHARES	,T1.HORAINICIO
	END

END


--exec V4MVC_INFORME_REVISION_VEHICULAR_CTTA '761264907','20190101','20201111',NULL,NULL,'LB,LT'
