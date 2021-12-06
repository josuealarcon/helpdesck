CREATE PROCEDURE [dbo].[V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CTRLACCESORESUMEN_DIATOTAL]
(
@DIVCOD  NVARCHAR(4)       = NULL,
@LOCAL  NVARCHAR(12)         = NULL,
@EMPRESA  NVARCHAR(10)       = NULL,
@FECHAINI  NVARCHAR(8)       = NULL,
@FECHAFIN  NVARCHAR(8)        = NULL,
@CAMPO VARCHAR(10)           = NULL,
@OST VARCHAR(12)             = NULL,
@RUTINGRESO VARCHAR(10)       = NULL,
@PATENTE VARCHAR(10)       = NULL

) AS
BEGIN
	declare @strSQL as nvarchar(MAX)



					SET @strSQL='SELECT 
						COUNT(C.FECHA) OVER() TOTALREGISTROS,
						ROW_NUMBER() OVER(ORDER BY C.FECHA, C.HORA ASC) ROWNUMBER,
						W.ROL, C.RUTINGRESO, C.GERENCIA, W.NOMBRES, W.APELLIDOS, C.SEXO, C.FECHA, C.HORA, C.PATENTE, C.ERROR, C.LOCAL, C.DIVISION, C.INGRESO, C.SALIDA, C.DSCTIPOV, C.ACRONIMO, 
						C.EMPRESA, C.COD_PDA, C.USUARIO, ISNULL(C.VEHICULO, ''N'') AS VEHICULO, INGRESO AS ING, ERRIN,SALIDA AS SAL, ERROUT, VEHIN, VEHOUT, M.MSG_REPORT, ADMINOST, ISNULL(O.EMPRESA,''VISITA'') AS CONTRATISTA, 
						C.OST, W2.NOMBRES + '' '' + W2.APELLIDOS AS ADMINOSTNOM, A.AREA  
						FROM WC3_VISTA_CTRLING  AS C LEFT OUTER JOIN WORKERS AS W ON C.RUTINGRESO = W.RUT  
													 LEFT OUTER JOIN MULTASTTO AS M ON C.ERROR = M.CODMULTA 
													 LEFT OUTER JOIN OSTDIVLOCAL AS O ON C.OST = O.OST AND C.DIVISION = O.DIVISION AND O.MANDANTE IN (SELECT MANDANTE FROM A027_MANDANTES WHERE ACTIVO = ''SI'') 
													 LEFT OUTER JOIN WORKERS AS W2 ON O.ADMINOST = W2.RUT 
													 LEFT OUTER JOIN A025_AREA AS A ON W.ID_AREA = A.ID_AREA
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
					ELSE IF @CAMPO = 'VEHIN'
					BEGIN
					     Set @strSQL = @strSQL + N' AND (VEHIN > 0 )'
					END
					ELSE IF @CAMPO = 'VEHOUT'
					BEGIN
					     Set @strSQL = @strSQL + N' AND (VEHOUT > 0 )'
					END

		            IF @FECHAINI <> '' OR @FECHAFIN <> ''
		            BEGIN
		       		 Set @strSQL = @strSQL + N' AND (C.FECHA  BETWEEN ''' + @FECHAINI + ''' AND ''' +  @FECHAFIN + ''')'
		            END										   
					

					 exec sp_executesql @strSQL  
					 PRINT @strSQL


		
			

END	
