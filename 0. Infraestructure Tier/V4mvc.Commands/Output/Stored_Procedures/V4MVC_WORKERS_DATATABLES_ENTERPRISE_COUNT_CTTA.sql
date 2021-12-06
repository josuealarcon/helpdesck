CREATE PROCEDURE [dbo].[V4MVC_WORKERS_DATATABLES_ENTERPRISE_COUNT_CTTA]      
(      
@IDEMPRESA		NVARCHAR(10) = NULL,
@RUT			NVARCHAR(10) = NULL,  
@NOMBRES		NVARCHAR(50) = NULL,  
@APELLIDOS		NVARCHAR(50) = NULL
)      
AS      
BEGIN      
     
	 DECLARE @QUERY NVARCHAR(MAX)
	SET @QUERY  = 'SELECT COUNT(DISTINCT W.RUT) AS COUNT_WORKERS
	FROM WORKERS W
	INNER JOIN WORKERSLOCAL WL ON WL.RUT = W.RUT
	INNER JOIN ENTERPRISE E ON E.IDEMPRESA = WL.EMPRESA 
	WHERE WL.EMPRESA = ''' + @IDEMPRESA +''' AND (WL.AUTOR IN (''SI'',''NO'') OR WL.AUTOR IS NULL)'

	IF @RUT IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND W.RUT LIKE ' + '''%' + @RUT + '%''' END
	IF @NOMBRES IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND W.NOMBRES LIKE ' + '''%' + @NOMBRES + '%''' END
	IF @APELLIDOS IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND W.APELLIDOS LIKE ' + '''%' + @APELLIDOS + '%''' END
	EXEC(@QUERY)
     
END  
