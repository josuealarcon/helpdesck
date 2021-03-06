CREATE PROCEDURE [dbo].[V4MVC_CASINO_SERVICIO_LOCAL_CTTA]
(
 @EMPRESA	NVARCHAR(10)
,@LOCALES	NVARCHAR(MAX)
,@DIVCOD	NVARCHAR(4)
,@FECHAINI	NVARCHAR(8)
,@FECHAFIN	NVARCHAR(8)
)
AS
BEGIN

	CREATE TABLE #LOCALES
	(
		LOCAL	NVARCHAR(50)  COLLATE DATABASE_DEFAULT NOT NULL
	)

	SELECT VALUE AS LOCAL INTO #TEMP_SPLIT_LOCALES
	FROM STRING_SPLIT(@LOCALES,',')

	SELECT DISTINCT LOCAL,SERVICIO FROM WC3_VISTA_CASINO
	WHERE EMPRESA = @EMPRESA
	AND FECHA BETWEEN @FECHAINI AND @FECHAFIN
	AND DIVISION = @DIVCOD
	AND ISNULL(ERROR,'') = ''
	AND LOCAL IN (SELECT LOCAL FROM #TEMP_SPLIT_LOCALES)
	ORDER BY LOCAL

END