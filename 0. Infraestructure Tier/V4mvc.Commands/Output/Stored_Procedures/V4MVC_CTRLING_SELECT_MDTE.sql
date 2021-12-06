CREATE PROCEDURE [dbo].[V4MVC_CTRLING_SELECT_MDTE]        
(           
 @DIVISIONES	NVARCHAR(30) = NULL
)      
AS        
BEGIN      

	DECLARE @MAXIMO				INT                   
	DECLARE @CONTADOR			INT					= 1    
	DECLARE @DATO				VARCHAR(10)      
	DECLARE @STRING				NVARCHAR(MAX)		=''     
	DECLARE @STRING1			NVARCHAR(MAX)    
	DECLARE @STRING_FINAL		NVARCHAR(MAX)
	DECLARE @CTRLINGMES			NVARCHAR(12)
	DECLARE @FECHA				NVARCHAR(8)
      
	SELECT VALUE AS DIVCOD INTO #TEMP_SPLIT_A      
	FROM string_split(@DIVISIONES,',')      
      
	SELECT  ROW_NUMBER() OVER(ORDER BY DIVCOD ASC) AS ID , * INTO #TEMP_SPLIT_B from                   
	#TEMP_SPLIT_A      
            
	SET @CTRLINGMES = 'CTRLING' +  SUBSTRING(DBO.HOY(GETDATE()),5,2)
	SET @FECHA =DBO.HOY(GETDATE())

	--SET @CTRLINGMES = 'CTRLING04'
	--SET @FECHA ='20200401'
                           
	WHILE ( @CONTADOR <= (SELECT MAX(ID) FROM #TEMP_SPLIT_B) )                   
	BEGIN                            
                  
		SELECT @DATO = DIVCOD FROM #TEMP_SPLIT_B              
		WHERE ID = @CONTADOR                    
		SET @STRING  += 'CONVERT(VARCHAR,' + @DATO + ')+' + N''''+',' +N''''+'+';    
                  
		SET @CONTADOR = @CONTADOR +1   
		
	END      
      
	SET @STRING_FINAL = SUBSTRING(@STRING, 0, LEN(@STRING)-4)     
	

	PRINT(@STRING_FINAL)
      
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
      
END


--exec [V4MVC_CTRLING_SELECT_MDTE] 'CH,ES,LB,LM,LT,QV,ST'