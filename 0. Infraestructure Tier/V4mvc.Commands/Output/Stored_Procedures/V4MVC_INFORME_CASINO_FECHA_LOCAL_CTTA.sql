CREATE PROCEDURE [dbo].[V4MVC_INFORME_CASINO_FECHA_LOCAL_CTTA]
(
 @FECHAINI		NVARCHAR(8)		= NULL
,@FECHAFIN		NVARCHAR(8)		= NULL
,@DIVCOD		NVARCHAR(4)		= NULL
,@LOCALES		NVARCHAR(MAX)	= NULL
,@IDEMPRESA		NVARCHAR(10)	= NULL
)
AS 
BEGIN

	DECLARE @FECHA_INI							DATE
	DECLARE @FECHA_FIN							DATE
	DECLARE	@Nro  INT
	DECLARE @CONTADOR							INT
	DECLARE @LOCAL								NVARCHAR(50)
	DECLARE	@Servicio_Fecha NVARCHAR(MAX)
	DECLARE	@Servicio_Fecha_Sum  NVARCHAR(MAX)
	DECLARE	@Servicio_Fecha_Sum_Resumen  NVARCHAR(MAX)
	DECLARE	@Servicio_Fecha_Sum_ResumenTotal  NVARCHAR(MAX)
	DECLARE @strSQL								NVARCHAR(MAX)
	DECLARE @strSQL_EXEC						NVARCHAR(MAX)

	SET @Servicio_Fecha = ''
	SET @Servicio_Fecha_Sum = ''
	SET @Servicio_Fecha_Sum_Resumen = ''
	SET @Servicio_Fecha_Sum_ResumenTotal = ''
	SET @Nro = -1
	SET @FECHA_INI								=	@FECHAINI
	SET @FECHA_FIN								=	@FECHAFIN
	SET @strSQL_EXEC = ''

	SELECT VALUE AS LOCAL INTO #TEMP_SPLIT_LOCALES
	FROM STRING_SPLIT(@LOCALES,',')

	SELECT ROW_NUMBER() OVER (ORDER BY LOCAL ASC) AS ID,* INTO #TEMP_LOCALES
	FROM #TEMP_SPLIT_LOCALES

	WHILE DATEDIFF(DAY, @FECHA_INI, @FECHA_FIN) > -1
	BEGIN  
		SET	@Nro = @Nro + 1
			If @Servicio_Fecha = '' 
			BEGIN
				SET @Servicio_Fecha = '[' + CONVERT(VARCHAR(8),@FECHA_INI,112) + ']'
				SET @Servicio_Fecha_Sum = ' CASE WHEN [' + CONVERT(VARCHAR(8),@FECHA_INI,112) +'] > 0 THEN ['+CONVERT(VARCHAR(8),@FECHA_INI,112)+'] ELSE 0 END AS [' +CONVERT(VARCHAR(8),@FECHA_INI,112)  +']'
				SET @Servicio_Fecha_Sum_Resumen = 'SUM([' +CONVERT(VARCHAR(8),@FECHA_INI,112)  + ']) AS [' + CONVERT(VARCHAR(8),@FECHA_INI,112)  + ']'
				SET @Servicio_Fecha_Sum_ResumenTotal = 'SUM([' +CONVERT(VARCHAR(8),@FECHA_INI,112)  + '])'
			END
			ELSE
			BEGIN
				SET @Servicio_Fecha = @Servicio_Fecha +  ',[' + CONVERT(VARCHAR(8),@FECHA_INI,112)  + ']'
				SET @Servicio_Fecha_Sum = @Servicio_Fecha_Sum + ',CASE WHEN [' +CONVERT(VARCHAR(8),@FECHA_INI,112)  + '] > 0 THEN ['+CONVERT(VARCHAR(8),@FECHA_INI,112)+'] ELSE 0 END AS [' +CONVERT(VARCHAR(8),@FECHA_INI,112)  + ']'
				SET @Servicio_Fecha_Sum_Resumen = @Servicio_Fecha_Sum_Resumen +',SUM([' + CONVERT(VARCHAR(8),@FECHA_INI,112)  + ']) AS [' + CONVERT(VARCHAR(8),@FECHA_INI,112)  + ']'
				SET @Servicio_Fecha_Sum_ResumenTotal = @Servicio_Fecha_Sum_ResumenTotal +'+SUM([' + CONVERT(VARCHAR(8),@FECHA_INI,112)  + '])'
			END		
		
			SET @FECHA_INI = (SELECT DATEADD(DAY, 1, @FECHA_INI))
	END  

	SET @CONTADOR	=	1
	WHILE(@CONTADOR <= (SELECT COUNT(*) FROM #TEMP_SPLIT_LOCALES))
	BEGIN

		SELECT @LOCAL = LOCAL FROM #TEMP_LOCALES
		WHERE ID = @CONTADOR

		IF(EXISTS(SELECT FECHA FROM WC3_VISTA_CASINO WHERE EMPRESA=@IDEMPRESA AND DIVISION=@DIVCOD AND LOCAL = @LOCAL AND FECHA BETWEEN @FECHAINI AND @FECHAFIN AND ISNULL(ERROR,'') = ''))
		BEGIN

			SET @strSQL = '(SELECT  D.LOCAL,D.SERVICIO,'
			SET @strSQL = @strSQL + @Servicio_Fecha_Sum_Resumen  
			SET @strSQL = @strSQL + N',('
			SET @strSQL = @strSQL + @Servicio_Fecha_Sum_ResumenTotal  
			SET @strSQL = @strSQL + N') TOTAL'
			SET @strSQL = @strSQL + N' FROM ( '
			SET @strSQL = @strSQL + N' SELECT pvt.LOCAL, pvt.SERVICIO, '
			SET @strSQL = @strSQL + @Servicio_Fecha_Sum  
			SET @strSQL = @strSQL + N' FROM ( '
			SET @strSQL = @strSQL + N' SELECT FECHA, LOCAL, SERVICIO, SUM(CANTIDAD) CANT '
			SET @strSQL = @strSQL + N' FROM WC3_VISTA_CASINO' 
			SET @strSQL = @strSQL + N' WHERE (FECHA  BETWEEN ''' + @FECHAINI + ''' AND ''' + @FECHAFIN + ''') '
			SET @strSQL = @strSQL + N' AND (DIVISION = ''' + @DIVCOD + ''') '
			SET @strSQL = @strSQL + N' AND (ISNULL(ERROR, '''') = '''') '
			SET @strSQL = @strSQL + N' AND (LOCAL = ''' + @LOCAL + ''') '
			SET @strSQL = @strSQL + N' AND (EMPRESA = ''' + @IDEMPRESA + ''') '
			SET @strSQL = @strSQL + N' GROUP BY LOCAL, FECHA, SERVICIO ) '
			SET @strSQL = @strSQL + N' datatable PIVOT ( SUM(CANT) FOR [FECHA] IN ('
			SET @strSQL = @strSQL + @Servicio_Fecha + ')) as pvt ) D'
			SET @strSQL = @strSQL + N' GROUP BY  D.LOCAL, D.SERVICIO'
			Set @strSQL = @strSQL + N') UNION ALL ('
			Set @strSQL = @strSQL + N'SELECT ''' + @LOCAL + ''',  ''SUBTOTAL'', ' 
			SET @strSQL = @strSQL + @Servicio_Fecha_Sum_Resumen  
			SET @strSQL = @strSQL + N', ('
			SET @strSQL = @strSQL + @Servicio_Fecha_Sum_ResumenTotal  
			SET @strSQL = @strSQL + N') TOTAL'
			SET @strSQL = @strSQL + N' FROM ( '
			SET @strSQL = @strSQL + N' SELECT pvt.LOCAL, pvt.SERVICIO, '
			SET @strSQL = @strSQL + @Servicio_Fecha_Sum  
			SET @strSQL = @strSQL + N' FROM ( '
			SET @strSQL = @strSQL + N' SELECT FECHA, LOCAL, SERVICIO, SUM(CANTIDAD) CANT '
			SET @strSQL = @strSQL + N' FROM WC3_VISTA_CASINO' 
			SET @strSQL = @strSQL + N' WHERE (FECHA  BETWEEN ''' + @FECHAINI + ''' AND ''' + @FECHAFIN + ''') '
			SET @strSQL = @strSQL + N' AND (DIVISION = ''' + @DIVCOD + ''') '
			SET @strSQL = @strSQL + N' AND (ISNULL(ERROR, '''') = '''') '
			SET @strSQL = @strSQL + N' AND (LOCAL = ''' + @LOCAL + ''') '
			SET @strSQL = @strSQL + N' AND (EMPRESA = ''' + @IDEMPRESA + ''') '
			SET @strSQL = @strSQL + N' GROUP BY LOCAL, FECHA, SERVICIO ) '
			SET @strSQL = @strSQL + N' datatable PIVOT ( SUM(CANT) FOR [FECHA] IN ('
			SET @strSQL = @strSQL + @Servicio_Fecha + ')) as pvt ) D )'
			SET @strSQL = @strSQL + N' UNION ALL '

			SET @strSQL_EXEC = @strSQL_EXEC +' '+ @strSQL

		END

		SET	@CONTADOR = @CONTADOR +	1

	END

		Set @strSQL_EXEC = @strSQL_EXEC + N' (SELECT ''TOTAL'',  '''', ' 
		SET @strSQL_EXEC = @strSQL_EXEC + @Servicio_Fecha_Sum_Resumen  
		SET @strSQL_EXEC = @strSQL_EXEC + N', ('
		SET @strSQL_EXEC = @strSQL_EXEC + @Servicio_Fecha_Sum_ResumenTotal  
		SET @strSQL_EXEC = @strSQL_EXEC + N') TOTAL'
		SET @strSQL_EXEC = @strSQL_EXEC + N' FROM ( '
		SET @strSQL_EXEC = @strSQL_EXEC + N' SELECT pvt.LOCAL, pvt.SERVICIO, '
		SET @strSQL_EXEC = @strSQL_EXEC + @Servicio_Fecha_Sum  
		SET @strSQL_EXEC = @strSQL_EXEC + N' FROM ( '
		SET @strSQL_EXEC = @strSQL_EXEC + N' SELECT FECHA, LOCAL, SERVICIO, SUM(CANTIDAD) CANT '
		SET @strSQL_EXEC = @strSQL_EXEC + N' FROM WC3_VISTA_CASINO' 
		SET @strSQL_EXEC = @strSQL_EXEC + N' WHERE (FECHA  BETWEEN ''' + @FECHAINI + ''' AND ''' + @FECHAFIN + ''') '
		SET @strSQL_EXEC = @strSQL_EXEC + N' AND (DIVISION = ''' + @DIVCOD + ''') '
		SET @strSQL_EXEC = @strSQL_EXEC + N' AND (ISNULL(ERROR, '''') = '''') '
		SET @strSQL_EXEC = @strSQL_EXEC + N' AND (LOCAL IN (SELECT LOCAL FROM #TEMP_SPLIT_LOCALES ))'
		SET @strSQL_EXEC = @strSQL_EXEC + N' AND (EMPRESA = ''' + @IDEMPRESA + ''') '
		SET @strSQL_EXEC = @strSQL_EXEC + N' GROUP BY LOCAL, FECHA, SERVICIO ) '
		SET @strSQL_EXEC = @strSQL_EXEC + N' datatable PIVOT ( SUM(CANT) FOR [FECHA] IN ('
		SET @strSQL_EXEC = @strSQL_EXEC + @Servicio_Fecha + ')) as pvt ) D )'

		print(@strSQL_EXEC)
		--PRINT(LEN(@strSQL_EXEC))
		--EXEC(@strSQL_EXEC)

END

--EXEC V4MVC_INFORME_CASINO_FECHA_LOCAL_CTTA '20190101','20201123','LB','CAS_PCALDERA,CAS_CONFLUEN,cas_vegat','761264907'
