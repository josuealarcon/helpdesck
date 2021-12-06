CREATE PROCEDURE [dbo].[V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CTRLACCESORESUMEN_DIARESUMEN]
(
@DIVCOD  NVARCHAR(4)       = NULL,
@LOCAL  NVARCHAR(12)         = NULL,
@EMPRESA  NVARCHAR(10)       = NULL,
@FECHA  NVARCHAR(8)          = NULL,
@OST VARCHAR(12)             = NULL,
@RUTINGRESO VARCHAR(10)       = NULL,
@PATENTE VARCHAR(10)       = NULL
) AS
BEGIN
	declare @strSQL as nvarchar(MAX)



					SET @strSQL='SELECT SUM(C.INGRESO) AS ING, SUM(C.SALIDA) AS SAL, SUM(C.ERRIN) AS ERRIN, SUM(C.ERROUT) AS ERROUT, SUM(C.VEHIN) AS VEHIN,
                                 SUM(C.VEHOUT) AS VEHOUT, C.LOCAL, SUBSTRING(C.HORA, 1,2) AS PERIODO 
	                             FROM WC3_VISTA_CTRLING AS C 
								 WHERE ((C.DIVISION = ''' + @DIVCOD + ''' ) OR ''' + @DIVCOD + ''' IS NULL) 
								 AND ((C.EMPRESA = ''' + @EMPRESA + ''') OR ''' + @EMPRESA + ''' IS NULL)'
								 	 
		            IF @LOCAL <> 'TODOS'
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.[LOCAL] IN ( ''' + @LOCAL + '''))'
		            END

		            IF @OST <> '' OR @OST <> NULL
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.OST = ''' + @OST + ''')'
		            END

		            IF @RUTINGRESO <> '' OR @RUTINGRESO <> NULL
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.RUTINGRESO = ''' + @RUTINGRESO + ''')'
		            END

		            IF @PATENTE <> '' OR @PATENTE <> NULL
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.PATENTE = ''' + @PATENTE + ''')'
		            END

	

		            IF @FECHA <> ''
		            BEGIN
		       		     Set @strSQL = @strSQL + N' AND (C.FECHA  = ''' + @FECHA + ''')'
		            END										   
					
					     Set @strSQL = @strSQL + N' GROUP BY C.DIVISION, C.LOCAL, C.FECHA, SUBSTRING(C.HORA, 1,2)'
					     Set @strSQL = @strSQL + N' ORDER BY C.LOCAL, C.FECHA, SUBSTRING(C.HORA, 1,2)'
					 exec sp_executesql @strSQL  
					 PRINT @strSQL


		
			

END	
