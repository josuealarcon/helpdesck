CREATE PROCEDURE [dbo].[V4MVC_DASHBOARD_MDTE]
(
 @ADMRUT	NVARCHAR(10) = NULL
)
AS
BEGIN

	DECLARE @CTRLINGMES						NVARCHAR(12)	= 'CTRLING' +  SUBSTRING(DBO.HOY(GETDATE()),5,2)
	DECLARE @CASINOMES						NVARCHAR(12)	= 'CASINO' +  SUBSTRING(DBO.HOY(GETDATE()),5,2)
	DECLARE @FECHA							NVARCHAR(8)		= DBO.HOY(GETDATE())   
	DECLARE @LIST_SERVICIOS					NVARCHAR(MAX)	= ''
	DECLARE @VAR_IN_PERSONAS				NVARCHAR(200)	= '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Personas' + '''' + ',data:[]},'
	DECLARE @VAR_OUT_PERSONAS				NVARCHAR(200)	= '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Personas Salidas' + '''' + ',data:[],color:' + '''' + '#ffff00' +'''' + '},'
	DECLARE @VAR_IN_VEHICULOS				NVARCHAR(200)	= '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Vehiculos Ingresos' + '''' + ',data:[],color:' + '''' + '#0000ff' +'''' + '},'
	DECLARE @VAR_OUT_VEHICULOS				NVARCHAR(200)	= '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Vehiculos Salidas' + '''' + ',data:[],color:' + '''' + '#422B39' +'''' + '}'
	DECLARE @VAR_DATA_CASINO				NVARCHAR(200)	= '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Sin Servicios' + '''' + ',data:[0]}'
	DECLARE @VAR_SERIE						NVARCHAR(MAX)	= '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Sin Movimientos' + '''' + ',data:[]}'
	DECLARE @CONTADOR						INT				= 1
	DECLARE @CONTADOR2						INT				= 1
	DECLARE @DATO							NVARCHAR(30)  
	DECLARE @DATO2							NVARCHAR(30)  
	DECLARE @STRING_SQL						NVARCHAR(MAX)	=''	
	DECLARE @STRING_SQL_CONVERT				NVARCHAR(MAX)	=''
	DECLARE @STRING_SQL_SUBSTRING			NVARCHAR(MAX)	=''
	DECLARE @STRING_SQL_CONVERT_SUBSTRING	NVARCHAR(MAX)

	CREATE TABLE #TEMP_DATA(
	TIPO					NVARCHAR(20)	COLLATE DATABASE_DEFAULT NOT NULL,
	DATA					NVARCHAR(MAX)	COLLATE DATABASE_DEFAULT NOT NULL
	) 

	CREATE TABLE #SERVICIOS(
	SERVICIO				NVARCHAR(12)	COLLATE DATABASE_DEFAULT NOT NULL,
	)

	CREATE TABLE #SERVICIOS_DATA(
	DIVCOD					NVARCHAR(4)		COLLATE DATABASE_DEFAULT NOT NULL,
	DATA					NVARCHAR(MAX)	COLLATE DATABASE_DEFAULT NOT NULL
	)

	CREATE TABLE #CTRL(
	INOUT					NVARCHAR(5)		COLLATE DATABASE_DEFAULT NOT NULL,
	TIPO					NVARCHAR(20)	COLLATE DATABASE_DEFAULT NOT NULL,
	DATA					NVARCHAR(MAX)	COLLATE DATABASE_DEFAULT NOT NULL
	)

	DECLARE @DIVISIONES NVARCHAR(MAX)      
	SET @DIVISIONES = (
		SELECT STUFF((
			SELECT ',' + CAST(S.value AS VARCHAR)
			FROM string_split(( SELECT REPLACE(REPLACE(ADMDIVISION,'''',''),' ','') 
						FROM ADMIN WHERE ADMRUT	= @ADMRUT)  ,',') S
						INNER JOIN A024_DIVISIONES D ON S.value = D.DIVCOD
						ORDER BY DIVCOD ASC
			FOR XML PATH('')
		),1,1,'') AS DIVISIONES
	)

	INSERT INTO #SERVICIOS
	EXEC ('SELECT DISTINCT SERVICIO' + ' ' +      
	  'FROM' + ' ' + @CASINOMES + ' ' +      
	  'WHERE FECHA =' + N'''' +@FECHA + N'''' +' ' +       
	  'AND ISNULL(ERROR,'+ N'''' + N'''' +')'+ '=' + N'''' + N'''' + ' '+          
	  'AND ISNULL(SERVICIO,'+ N'''' + N'''' +')'+ '<>' + N'''' + N'''' + ' ' +
	  'ORDER BY SERVICIO ASC;'
	  )   
	  
	IF EXISTS(SELECT SERVICIO FROM #SERVICIOS)
	BEGIN

		SET @LIST_SERVICIOS = (SELECT STUFF((
			SELECT ',''' + CAST(SERVICIO AS VARCHAR) + ''''
			FROM #SERVICIOS
			FOR XML PATH('')
		),1,1,'') AS CASINO_CATEGORIAS)

		SELECT  ROW_NUMBER() OVER(ORDER BY SERVICIO ASC) AS ID , * INTO #ROW_SERVICIOS FROM #SERVICIOS

		WHILE ( @CONTADOR <= (SELECT MAX(ID) FROM #ROW_SERVICIOS ) )               
		BEGIN               
			SELECT @DATO =[SERVICIO] FROM #ROW_SERVICIOS              
			WHERE ID = @CONTADOR              
              
			SET @STRING_SQL +='['+ @DATO + '],';   
			SET @STRING_SQL_CONVERT  += 'CONVERT(VARCHAR,[' + @DATO + '])+' + N''''+',' +N''''+'+';    
              
			SET @CONTADOR = @CONTADOR +1               
		END 

		SET @STRING_SQL_SUBSTRING = SUBSTRING(@STRING_SQL, 0, LEN(@STRING_SQL))    
		SET @STRING_SQL_CONVERT_SUBSTRING =SUBSTRING(@STRING_SQL_CONVERT, 0, LEN(@STRING_SQL_CONVERT)-4) 

		INSERT INTO #SERVICIOS_DATA
		EXEC (    
		'SELECT DIVISION,' + @STRING_SQL_SUBSTRING + ' '+' INTO #TEMP_DATA' + ' ' +  
		'FROM (' + ' ' +  
		'SELECT RUT,DIVISION,SERVICIO FROM (SELECT DISTINCT RUT,DIVISION,SERVICIO, HORA' + ' '+  
		'FROM' +' '+ @CASINOMES + ' ' +        
		'WHERE FECHA =' + N'''' +@FECHA + N'''' +' ' +     
		'AND ISNULL(ERROR,'+ N'''' + N'''' +')'+ '=' + N'''' + N'''' + ')'+ ' ' +'AS CC' + ' ' +       
		') src' +' '+        
		'pivot' +        
		'(' +        
		'COUNT(RUT) for [SERVICIO] in (' + @STRING_SQL_SUBSTRING + ')' +        
		') AS PIV' + ' '+  
		'SELECT DIVISION,('+ @STRING_SQL_CONVERT_SUBSTRING +') AS DATA_GRAFIC FROM #TEMP_DATA ORDER BY DIVISION ASC' + ' '   
		) 

		SET @VAR_DATA_CASINO = (SELECT STUFF((
			SELECT ',{type:''' + 'column' + '''' + ',name:' + '''' + CAST(DIVCOD AS VARCHAR) + '''' + ',data:[' + CAST(DATA AS VARCHAR) + ']}' 
			FROM #SERVICIOS_DATA
			FOR XML PATH('')
		),1,1,'') AS DATA_CASINO)

	END

	SELECT value AS DIVCOD INTO #TEMP_SPLIT_A    
	FROM string_split(@DIVISIONES,',')    
    
	SELECT  ROW_NUMBER() OVER(ORDER BY DIVCOD ASC) AS ID , * INTO #TEMP_SPLIT_B FROM #TEMP_SPLIT_A    
                   
	DECLARE @STRING				NVARCHAR(MAX)   =''
	DECLARE @STRING_FINAL		NVARCHAR(MAX)    
                       
	WHILE ( @CONTADOR2 <= (SELECT MAX(ID) FROM #TEMP_SPLIT_B) )                 
	BEGIN                          
                
		SELECT @DATO2 = DIVCOD FROM #TEMP_SPLIT_B            
		WHERE ID = @CONTADOR2                
		SET @STRING  += 'CONVERT(VARCHAR,' + @DATO2 + ')+' + N''''+',' +N''''+'+';  
                
		SET @CONTADOR2 = @CONTADOR2 +1    
		
	END    
    
	SET @STRING_FINAL = SUBSTRING(@STRING, 0, LEN(@STRING)-4)    

	INSERT INTO #CTRL
	EXEC ('SELECT INOUT,TIPOPASE,' + @DIVISIONES +' '+'INTO #TEMPORAL_DATA' + ' ' +      
	'FROM' +        
	'(' +         
	'SELECT INOUT, DIVISION,RUTINGRESO,' + N'''' +'PERSONA' +N'''' +' '+ 'AS TIPOPASE FROM' +' '+ @CTRLINGMES + ' ' +        
	'WHERE ISNULL(RUTINGRESO,'+ N'''' + N'''' +')'+ '<>' + N'''' + N'''' + ' '+        
	'AND FECHA =' + N'''' +@FECHA + N'''' +' ' +         
	'AND ISNULL(ERROR,'+ N'''' + N'''' +')'+ '=' + N'''' + N'''' + ' '+        
	'UNION ALL' + ' ' +        
	'SELECT DISTINCT INOUT, DIVISION,PATENTE AS RUTINGRESO,' + N'''' +'VEHICULO' +N'''' +' '+ 'AS TIPOPASE FROM' +' '+ @CTRLINGMES + ' ' +        
	'WHERE ISNULL(PATENTE,'+N'''' + N'''' +')' + '<>' + N'''' + N'''' + ' '+        
	'AND ISNULL(RUTINGRESO,'+N'''' + N'''' + ')' + '<>' + N'''' + N'''' + ' '+        
	'AND ISNULL(ERROR,'+ N'''' + N'''' +')'+ '=' + N'''' + N'''' + ' '+        
	'AND FECHA =' + N'''' +@FECHA + N'''' +' ' +         
	'AND ISNULL(VEHICULO,'+ N'''' + N'''' +')'+ '=' + N'''' +'S'+ N'''' + ' '+        
	') src' +' '+        
	'pivot' +        
	'(' +        
	'COUNT(RUTINGRESO) for [DIVISION] in (' + @DIVISIONES + ')' +        
	') AS PIV' + ' '+      
	'SELECT INOUT,TIPOPASE,('+ @STRING_FINAL +') AS DATA_GRAFIC FROM #TEMPORAL_DATA' + ' '    
	) 


	INSERT INTO #TEMP_DATA
	EXEC (
		'SELECT' + ' '+ N'''' +'Mandante' + N'''' + ' ' + 'as TIPO,'+ @DIVISIONES + ' ' +'INTO #TEMPORAL_DATA'+ ' ' +
 		'FROM (' + ' ' +
  		'SELECT RUT, DIVISION' + ' ' +
  		'FROM ('+ ' ' +
	 		'SELECT DISTINCT CU.RUT, CU.DIVISION' + ' ' +
			',ISNULL(WLP.EMPRESA,' + N'''' + '108' + N'''' + ') AS EMPRESA' + ' ' +  
	 		'FROM (SELECT RUT, DIVISION, LOCALIN AS LOCAL ' + ' '+
		     		', FECHAIN, HORAIN, FECHACASINO, HORACASINO, FECHAOUT, HORAOUT'	+ ' '+	    
		     		'FROM  dbo.CTRLULTIMO ' + ' ' +  
		     		'WHERE (FECHAIN + HORAIN > FECHAOUT + HORAOUT OR  FECHACASINO + HORACASINO > FECHAOUT + HORAOUT) ' + ' ' +  
		      		') AS CU ' + ' ' +  
	 		'INNER JOIN WORKERS AS W ON CU.RUT = W.RUT  ' + ' ' +  
	 		'LEFT JOIN (SELECT WP1.RUT, WP1.DIVISION, WP1.LOTE, MAX(WP2.EMPRESA) AS EMPRESA ' + ' ' +   
		    		'FROM ' + ' ' +  
		    		'(SELECT RUT,  DIVISION , MAX(LOTE) AS LOTE ' + ' ' +    
		    		'FROM WORKERSLOCAL  ' + ' ' +  
		    		'GROUP BY RUT, DIVISION) WP1  ' + ' ' +   
		    		'INNER JOIN WORKERSLOCAL WP2 ON WP1.LOTE = WP2.LOTE AND  WP1.RUT = WP2.RUT AND WP1.DIVISION = WP2.DIVISION  ' + ' ' +  
		    		'GROUP BY WP1.RUT, WP1.DIVISION, WP1.LOTE) WLP ON CU.RUT = WLP.RUT AND CU.DIVISION = WLP.DIVISION  ' + ' ' +  
			') D  ' + ' ' +  
			'WHERE D.EMPRESA IN (SELECT MANDANTE FROM A027_MANDANTES M WHERE M.ACTIVO = ' + N'''' +'SI' + N'''' + '))' + ' ' +  
			'src pivot ( COUNT(RUT) for [DIVISION] in (' + @DIVISIONES + ') ) AS PIV' +' '+
		'UNION' + ' ' + 
		'SELECT' + ' '+ N'''' +'Contratista' + N'''' + ' ' + 'as TIPO,'+ @DIVISIONES + ' ' +
 		'FROM (' + ' ' +
  		'SELECT RUT, DIVISION' + ' ' +
  		'FROM ('+ ' ' +
	 		'SELECT DISTINCT CU.RUT, CU.DIVISION' + ' ' +
			',ISNULL(WLP.EMPRESA,' + N'''' + '108' + N'''' + ') AS EMPRESA' + ' ' +  
	 		'FROM (SELECT RUT, DIVISION, LOCALIN AS LOCAL ' + ' '+
		     		', FECHAIN, HORAIN, FECHACASINO, HORACASINO, FECHAOUT, HORAOUT'	+ ' '+	    
		     		'FROM  dbo.CTRLULTIMO ' + ' ' +  
		     		'WHERE (FECHAIN + HORAIN > FECHAOUT + HORAOUT OR  FECHACASINO + HORACASINO > FECHAOUT + HORAOUT) ' + ' ' +  
		      		') AS CU ' + ' ' +  
	 		'INNER JOIN WORKERS AS W ON CU.RUT = W.RUT  ' + ' ' +  
	 		'LEFT JOIN (SELECT WP1.RUT, WP1.DIVISION, WP1.LOTE, MAX(WP2.EMPRESA) AS EMPRESA ' + ' ' +   
		    		'FROM ' + ' ' +  
		    		'(SELECT RUT,  DIVISION , MAX(LOTE) AS LOTE ' + ' ' +    
		    		'FROM WORKERSLOCAL  ' + ' ' +  
		    		'GROUP BY RUT, DIVISION) WP1  ' + ' ' +   
		    		'INNER JOIN WORKERSLOCAL WP2 ON WP1.LOTE = WP2.LOTE AND  WP1.RUT = WP2.RUT AND WP1.DIVISION = WP2.DIVISION  ' + ' ' +  
		    		'GROUP BY WP1.RUT, WP1.DIVISION, WP1.LOTE) WLP ON CU.RUT = WLP.RUT AND CU.DIVISION = WLP.DIVISION  ' + ' ' +  
			') D  ' + ' ' +  
			'WHERE D.EMPRESA NOT IN (SELECT MANDANTE FROM A027_MANDANTES M WHERE M.ACTIVO = ' + N'''' +'SI' + N'''' + '))' + ' ' +  
			'src pivot ( COUNT(RUT) for [DIVISION] in (' + @DIVISIONES + ') ) AS PIV' + ' ' +
			'SELECT TIPO,('+ @STRING_FINAL +') AS DATA_GRAFIC FROM #TEMPORAL_DATA' + ' ORDER BY TIPO ASC' + ' '  
			)

		IF EXISTS(SELECT DATA FROM #CTRL)
		BEGIN
			IF EXISTS(SELECT DATA FROM #CTRL WHERE INOUT='IN' AND TIPO = 'PERSONA')
			BEGIN
					SET @VAR_IN_PERSONAS = (SELECT '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Personas' + '''' + ',data:[' + DATA + ']},'
											FROM #CTRL
											WHERE INOUT='IN' AND TIPO = 'PERSONA')
			END

			IF EXISTS(SELECT DATA FROM #CTRL WHERE INOUT='OUT' AND TIPO = 'PERSONA')
			BEGIN
					SET @VAR_OUT_PERSONAS = (SELECT '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Personas Salidas' + '''' + ',data:[' + DATA + '],color: ' + '''' + '#ffff00' + '''' + '},'
											FROM #CTRL
											WHERE INOUT='OUT' AND TIPO = 'PERSONA')
			END

			IF EXISTS(SELECT DATA FROM #CTRL WHERE INOUT='IN' AND TIPO = 'VEHICULO')
			BEGIN
					SET @VAR_IN_VEHICULOS = (SELECT '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Vehiculos Ingresos' + '''' + ',data:[' + DATA + '],color: ' + '''' + '#0000ff' + '''' + '},'
											FROM #CTRL
											WHERE INOUT='IN' AND TIPO = 'VEHICULO')
			END

			IF EXISTS(SELECT DATA FROM #CTRL WHERE INOUT='OUT' AND TIPO = 'VEHICULO')
			BEGIN
					SET @VAR_OUT_VEHICULOS = (SELECT '{type:' + '''' + 'column' + '''' + ',name:' + '''' + 'Vehiculos Salidas' + '''' + ',data:[' + DATA + '],color: ' + '''' + '#422B39' + '''' + '}'
											FROM #CTRL
											WHERE INOUT='OUT' AND TIPO = 'VEHICULO')
			END

			SET @VAR_SERIE = @VAR_IN_PERSONAS + @VAR_OUT_PERSONAS + @VAR_IN_VEHICULOS + @VAR_OUT_VEHICULOS
		END

		SELECT STUFF((
			SELECT ',''' + CAST(S.value AS VARCHAR) + ''''
			FROM string_split(( SELECT REPLACE(REPLACE(ADMDIVISION,'''',''),' ','') 
						FROM ADMIN WHERE ADMRUT	= @ADMRUT)  ,',') S
						INNER JOIN A024_DIVISIONES D ON S.value = D.DIVCOD
						ORDER BY DIVCOD ASC
			FOR XML PATH('')
		),1,1,'') AS OPERACIONES,
		STUFF((
		SELECT ',{name:''' + CAST(TIPO AS VARCHAR) + '''' + ',data:[' + CAST(DATA AS VARCHAR) + ']}' 
		FROM #TEMP_DATA
		FOR XML PATH('')
		),1,1,'') AS DATA_FAENA,
		@LIST_SERVICIOS AS CASINO_CATEGORIAS,
		@VAR_DATA_CASINO AS DATA_CASINO,
		@VAR_SERIE AS DATA_MOVIMIENTOS

END
