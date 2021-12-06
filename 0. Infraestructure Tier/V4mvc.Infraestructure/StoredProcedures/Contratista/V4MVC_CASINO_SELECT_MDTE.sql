CREATE PROCEDURE [dbo].[V4MVC_CASINO_SELECT_MDTE]          
AS          
BEGIN          
    
	DECLARE @CASINOMES NVARCHAR(12)    
	DECLARE @FECHA NVARCHAR(8)    
          
	SET @CASINOMES = 'CASINO' +  SUBSTRING(DBO.HOY(GETDATE()),5,2)
	SET @FECHA = DBO.HOY(GETDATE())       
    
	EXEC ('SELECT DISTINCT SERVICIO' + ' ' +      
	  'FROM' + ' ' + @CASINOMES + ' ' +      
	  'WHERE FECHA =' + N'''' +@FECHA + N'''' +' ' +       
	  'AND ISNULL(ERROR,'+ N'''' + N'''' +')'+ '=' + N'''' + N'''' + ' '+          
	  'AND ISNULL(SERVICIO,'+ N'''' + N'''' +')'+ '<>' + N'''' + N'''' + ' ' +
	  'ORDER BY SERVICIO ASC;'
	  )     
        
END

--EXEC [V4MVC_CASINO_SELECT_MDTE]