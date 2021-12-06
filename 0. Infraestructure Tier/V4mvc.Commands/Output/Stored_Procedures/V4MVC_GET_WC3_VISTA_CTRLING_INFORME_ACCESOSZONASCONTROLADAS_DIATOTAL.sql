CREATE PROCEDURE [dbo].[V4MVC_GET_WC3_VISTA_CTRLING_INFORME_ACCESOSZONASCONTROLADAS_DIATOTAL]
(
@LOCAL  NVARCHAR(12)         = NULL,
@FECHAINI  NVARCHAR(8)       = NULL,
@FECHAFIN  NVARCHAR(8)       = NULL,
@DIVCOD  NVARCHAR(4)         = NULL,
@EMPRESA  NVARCHAR(10)       = NULL,
@CAMPO VARCHAR(10)           = NULL
) AS
BEGIN


	DECLARE @strSQL as nvarchar(MAX)

					SET @strSQL='SELECT 
						COUNT(C.TIPOPASE) OVER() TOTALREGISTROS,
						ROW_NUMBER() OVER(ORDER BY C.FECHA, C.HORA ASC) ROWNUMBER,	
						C.RUTINGRESO, W.NOMBRES, W.APELLIDOS, C.FECHA, C.HORA, C.PATENTE, C.ERROR, C.LOCAL, C.DIVISION, C.INGRESO, C.SALIDA, C.DSCTIPOV, C.ACRONIMO, C.EMPRESA, 
						C.COD_PDA, C.USUARIO, ISNULL(C.VEHICULO, ''N'') AS VEHICULO, INGRESO AS ING, SALIDA AS SAL, ERRIN, ERROUT, VEHIN, VEHOUT, M.MSG_REPORT, C.LOCALD, A.AREA, G.GERENCIA  
						FROM WC3_VISTA_CTRLING  AS C LEFT OUTER JOIN WORKERS AS W ON C.RUTINGRESO = W.RUT  
													 LEFT OUTER JOIN MULTASTTO AS M ON C.ERROR = M.CODMULTA  
													 LEFT OUTER JOIN GERENCIA AS G ON W.IDGERENCIA = G.IDGERENCIA  
													 LEFT OUTER JOIN A025_AREA AS A ON W.ID_AREA = A.ID_AREA 
													 WHERE  (C.DIVISION = ''' + @DIVCOD + ''')   
													 AND (C.EMPRESA = ''' + @EMPRESA + ''')  
													 AND (INGRESO > 0 )'

		            IF @LOCAL <> 'TODOS'
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (C.[LOCAL] IN ( ''' + @LOCAL + '''))'
		            END


                    IF @CAMPO = 'INGRESO'
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND (INGRESO > 0 )'
		            END
					ELSE IF @CAMPO = 'SALIDA'
					BEGIN
					     Set @strSQL = @strSQL + N' AND (SALIDA > 0 )'
					END
					ELSE IF @CAMPO = 'ERRIN'
					BEGIN
					     Set @strSQL = @strSQL + N' AND (ERRIN > 0 )'
					END
					ELSE IF @CAMPO = 'ERROUT'
					BEGIN
					     Set @strSQL = @strSQL + N' AND (ERROUT > 0 )'
					END					


					 Set @strSQL = @strSQL + N' AND (C.FECHA  BETWEEN ''' + @FECHAINI + ''' AND ''' +  @FECHAFIN + ''')'	
					exec sp_executesql @strSQL  




 
END	
