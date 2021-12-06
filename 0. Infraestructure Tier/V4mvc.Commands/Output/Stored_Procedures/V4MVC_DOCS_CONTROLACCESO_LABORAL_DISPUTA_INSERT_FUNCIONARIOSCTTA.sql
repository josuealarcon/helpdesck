CREATE PROCEDURE [dbo].[V4MVC_DOCS_CONTROLACCESO_LABORAL_DISPUTA_INSERT_FUNCIONARIOSCTTA]
(@RUT		    NVARCHAR(10) = NULL 
,@FECHA_INI		NVARCHAR(8) = NULL 
,@FECHA_FIN	    NVARCHAR(8) = NULL 
,@ID_DOC	INT = NULL
,@OBSERVACION	NVARCHAR(1000) = NULL
,@USUARIO	NVARCHAR(10) = NULL) AS
BEGIN

INSERT INTO DOCS_CONTROLACCESO_LABORAL_DISPUTA(ID_DOC,  RUT,  FECHA_INI,  FECHA_FIN,  EMPRESA, OBSERVACION,  USUARIO,  FECHA                 , HORA                   ,  ID         ,CERTUSUARIO  ,CERTFECHA  ,CERTHORA, ESTADO, VALIDADO)
									   SELECT @ID_DOC,  @RUT, @FECHA_INI, @FECHA_FIN, EMPRESA, @OBSERVACION, @USUARIO, [dbo].[hoy](GETDATE()), [dbo].[ahora](GETDATE()), ID_ARCHIVO ,CERTUSUARIO  ,CERTFECHA  ,CERTHORA, 'NO'  , VALIDADO 
										FROM DOCS_CONTROLACCESO_LABORAL 
WHERE RUT = @RUT AND FECHA_INI = @FECHA_INI AND FECHA_FIN = @FECHA_FIN AND ID_DOC = @ID_DOC
END
