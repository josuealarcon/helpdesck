CREATE PROCEDURE [dbo].[V4MVC_WORKERS_ENTERPRISE_CTTA]
(
 @IDEMPRESA NVARCHAR(10)
)
AS
BEGIN

	SELECT DISTINCT W.RUT, W.NOMBRES, W.APELLIDOS, WL.EMPRESA, E.ACRONIMO 
	FROM WORKERS W 
	INNER JOIN WORKERSLOCAL WL ON WL.RUT = W.RUT 
	INNER JOIN ENTERPRISE E ON E.IDEMPRESA = WL.EMPRESA 
	WHERE WL.EMPRESA = @IDEMPRESA AND (WL.AUTOR IN ('SI','NO') OR WL.AUTOR IS NULL)
	ORDER BY W.APELLIDOS ASC, W.NOMBRES ASC

END
