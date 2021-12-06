CREATE PROCEDURE [dbo].[V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_INFORME_CHECKLIST_CTTA]
(
@PATENTE  NVARCHAR(50) = NULL,
@TIPOVEHICULO INT = NULL,
@ID_CHECK INT = NULL,
@FECHAINI  NVARCHAR(8)       = NULL,
@FECHAFIN  NVARCHAR(8)       = NULL,
@EMPRESA  NVARCHAR(10)       = NULL
) AS
BEGIN

DECLARE @strSQL as nvarchar(MAX)

 SET @strSQL='SELECT 
  COUNT(CHKNGH.ID_CHECKINGHEAD) OVER() TOTALREGISTROS,
  ROW_NUMBER() OVER(ORDER BY CHKNGH.FECCREA DESC) ROWNUMBER,	
  CHKNGH.ID_CHECKINGHEAD
 ,CHKNGH.ID_TIPO
 ,TP.NOMBRE AS TIPO
 ,CHKNGH.ID_CHECKING
 ,CHKNGH.ID_CHECK
 ,CHK.NOMBRE AS CHECKLIST
 ,CHKNGH.IDENTIFICADOR
 ,TR.TIPO AS TIPOVEHICULO
 ,TY.DSCTIPOV AS NOMBRE_IDENTIFICADOR
 ,TR.EMPRESA
 ,CHKNGH.FECHA
 ,ISNULL(CHKNGH.CORRECTO,''NO'') AS CORRECTO
 ,ISNULL(CHKNGH.VALIDADO,'''') AS VALIDADO
 ,(SELECT TOP 1 ID_ARCHIVO FROM CHECK_CARGA_DOCS WHERE ID_TIPO=CHKNGH.ID_TIPO AND ID_CHECK=CHKNGH.ID_CHECK
 AND ID_CHECKING=CHKNGH.ID_CHECKING AND ID_CHECKINGHEAD=CHKNGH.ID_CHECKINGHEAD ORDER BY ID DESC) AS ID_ARCHIVO
 ,(SELECT MIN(HORA) + ''  - '' + MAX(HORA) FROM [CHECK_CHECKINGDETAIL] WHERE ID_TIPO = CHKNGH.ID_TIPO AND ID_CHECK = CHKNGH.ID_CHECK AND ID_CHECKING = CHKNGH.ID_CHECKING AND ID_CHECKINGHEAD = CHKNGH.ID_CHECKINGHEAD ) AS HORA 
  ,(SELECT TOP 1 NOMBRE FROM CHECK_CARGA_DOCS WHERE ID_TIPO=CHKNGH.ID_TIPO AND ID_CHECK=CHKNGH.ID_CHECK
 AND ID_CHECKING=CHKNGH.ID_CHECKING AND ID_CHECKINGHEAD=CHKNGH.ID_CHECKINGHEAD ORDER BY ID DESC) AS NOMBREARCHIVO
 FROM CHECK_CHECKINGINGHEAD CHKNGH INNER JOIN [CHECK] CHK 	ON CHKNGH.ID_TIPO = CHK.ID_TIPO AND CHKNGH.ID_CHECK = CHK.ID_CHECK  
                                   INNER JOIN CHECK_TIPO TP ON CHK.ID_TIPO = TP.ID_TIPO 	
								   INNER JOIN TRANSPORT TR  ON CHKNGH.IDENTIFICADOR = TR.PATENTE 	
								   INNER JOIN TYPETRANS TY  ON TR.TIPO = TY.IDTIPO 	
WHERE CHKNGH.ID_TIPO=''VEH''' 


		            IF @PATENTE <> '' OR @PATENTE <> NULL
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND IDENTIFICADOR = ''' + @PATENTE + ''''
		            END		
		            IF @TIPOVEHICULO <> '' OR @TIPOVEHICULO <> NULL
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND TR.TIPO = ''' + CONVERT(NVARCHAR(10),@TIPOVEHICULO) + ''''
		            END							
		            IF @ID_CHECK <> '' OR @ID_CHECK <> NULL
		            BEGIN
		            	Set @strSQL = @strSQL + N' AND CHKNGH.ID_CHECK = ''' + CONVERT(NVARCHAR(10),@ID_CHECK)  + ''''
		            END	

					Set @strSQL = @strSQL + N' AND (FECHA  BETWEEN ''' + @FECHAINI + ''' AND ''' +  @FECHAFIN + ''')'	
					Set @strSQL = @strSQL + N' AND TR.EMPRESA = ''' + @EMPRESA + ''''	

					exec sp_executesql @strSQL  
					PRINT @strSQL

 
END	
