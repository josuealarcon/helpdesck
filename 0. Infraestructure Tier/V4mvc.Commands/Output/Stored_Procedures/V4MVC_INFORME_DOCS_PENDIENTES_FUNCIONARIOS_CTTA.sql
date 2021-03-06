CREATE PROCEDURE [dbo].[V4MVC_INFORME_DOCS_PENDIENTES_FUNCIONARIOS_CTTA]
(
 @FECHAINI	NVARCHAR(8)		= NULL
,@FECHAFIN	NVARCHAR(8)		= NULL
,@RUT		NVARCHAR(10)	= NULL
,@EMPRESA	NVARCHAR(10)	= NULL
)
AS
BEGIN

	SELECT   GLOSA			,EMPRESA		,ACRONIMO		,RUT
			,NOMBRES		,APELLIDOS		,ID_DOC			,NOMBRE
			,FECHASUBE		,HORASUBE
	FROM	 DOCS_PENDIENTE_FUNC 
	WHERE	 EMPRESA = @EMPRESA
	AND		 RUT = ISNULL(@RUT,RUT)
	AND		 FECHASUBE BETWEEN ISNULL(@FECHAINI,FECHASUBE) AND ISNULL(@FECHAFIN,FECHASUBE)
	OR		 ISNULL(@FECHAINI,FECHASUBE) IS NULL AND ISNULL(@FECHAFIN,FECHASUBE) IS NULL

END
