CREATE PROCEDURE [dbo].[V4MVC_WORKERS_SELECT_INFORMECONSULTARAPIDA_CTTA]
(
  @RUT	NVARCHAR(10)
) AS 
BEGIN

	SELECT   W.RUT      ,W.NOMBRES ,W.APELLIDOS 
	FROM WORKERS W 
	WHERE (W.RUT LIKE '%'+@RUT+'%')  
	ORDER BY W.RUT, W.NOMBRES, W.APELLIDOS 

END
