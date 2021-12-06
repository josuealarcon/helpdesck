CREATE PROCEDURE [dbo].[V4MVC_FAENADIVISION_SELECT_MDTE]
(
 @DIVISIONES NVARCHAR(100)
)
AS
BEGIN  
    
	DECLARE @STRING_DATA VARCHAR(200)      
	SET @STRING_DATA = @DIVISIONES;    

	SELECT value AS DIVCOD INTO #TEMP_SPLIT_A    
	FROM string_split(@STRING_DATA,',')    
    
	select  ROW_NUMBER() OVER(ORDER BY DIVCOD ASC) AS ID , * INTO #TEMP_SPLIT_B from                 
	#TEMP_SPLIT_A    
    
	DECLARE @MAXIMO INT                 
	DECLARE @CONTADOR INT                 
	DECLARE @DATO VARCHAR(10)    
	DECLARE @STRING NVARCHAR(MAX)    
	DECLARE @STRING1 NVARCHAR(MAX)  
	DECLARE @STRING_FINAL NVARCHAR(MAX)    
    
	SET @CONTADOR = 1      
	SET @STRING = '';    
                
	SELECT @MAXIMO = MAX(ID) FROM  #TEMP_SPLIT_B               
                           
	WHILE ( @CONTADOR <= @MAXIMO )                 
	BEGIN                          
                
		SELECT @DATO = DIVCOD FROM #TEMP_SPLIT_B            
		WHERE ID = @CONTADOR                
		SET @STRING  += 'CONVERT(VARCHAR,' + @DATO + ')+' + N''''+',' +N''''+'+';  
                
		SET @CONTADOR = @CONTADOR +1    
		
	END    
    
	SET @STRING_FINAL = SUBSTRING(@STRING, 0, LEN(@STRING)-4)    

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

END


--exec [V4MVC_FAENADIVISION_SELECT_MDTE] 'CH,ES,LB,LM,LT,QV,ST'