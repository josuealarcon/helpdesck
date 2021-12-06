CREATE PROCEDURE [dbo].[V4MVC_GET_WC3_VISTA_CTRLING_INFORME_ACCESOSZONASCONTROLADAS_DIARESUMEN]
(
@LOCAL  NVARCHAR(12)         = NULL,
@FECHA  NVARCHAR(8)       = NULL,
@DIVCOD  NVARCHAR(4)         = NULL,
@EMPRESA  NVARCHAR(10)       = NULL
) AS
BEGIN


	DECLARE @strSQL as nvarchar(MAX)

					SET @strSQL='SELECT SUM(C.INGRESO) AS ING, SUM(C.SALIDA) AS SAL, SUM(C.ERRIN) AS ERRIN, SUM(C.ERROUT) AS ERROUT, 
					             SUM(C.VEHIN) AS VEHIN, SUM(C.VEHOUT) AS VEHOUT, SUBSTRING(C.HORA, 1,2) AS PERIODO 
								 FROM WC3_VISTA_CTRLING AS C 
								 WHERE  (C.DIVISION = ''' + @DIVCOD + ''')   
								 AND (C.EMPRESA = ''' + @EMPRESA + ''')'

		            IF @LOCAL <> ''
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.[LOCAL] IN ( ''' + @LOCAL + '''))'
		            END
                 					
		            IF @FECHA <> ''
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.FECHA = ''' + @FECHA + ''')'
		            END									

					Set @strSQL = @strSQL + N' GROUP BY C.DIVISION, C.FECHA, SUBSTRING(C.HORA, 1,2)'	
					Set @strSQL = @strSQL + N' ORDER BY C.FECHA, SUBSTRING(C.HORA, 1,2)'	
					exec sp_executesql @strSQL  

END	
