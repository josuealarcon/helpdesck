CREATE PROCEDURE [dbo].[V4MVC_DOCS_CONTROLACCESO_LABORAL_DISPUTA_SELECT_ESTADONO]
(@ID_DISPUTA	INT= NULL) AS
BEGIN
SELECT [ID_DISPUTA]
      ,[ID_DOC]
      ,[RUT]
      ,[FECHA_INI]
      ,[FECHA_FIN]
      ,[PERIODO]
      ,[EMPRESA]
      ,[ID]
      ,[USUARIO]
      ,[FECHA]
      ,[HORA]
      ,[OBSERVACION]
      ,[CERTUSUARIO]
      ,[CERTFECHA]
      ,[CERTHORA]
      ,[VALIDADO]
      ,[ESTADO]
      ,[REVALUSUARIO]
      ,[REVALFECHA]
      ,[REVALHORA]
      ,[OBSERVACION_REVAL]
  FROM [dbo].[DOCS_CONTROLACCESO_LABORAL_DISPUTA]
  WHERE @ID_DISPUTA = @ID_DISPUTA AND ESTADO = 'NO'
END
