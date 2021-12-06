CREATE PROCEDURE [dbo].[V4MVC_DOCS_CONTROLACCESO_LABORAL_NEW]
(@ID int= NULL
,@ID_DOC int= NULL
,@RUT nvarchar(10)= NULL
,@EMPRESA nvarchar(10)= NULL
,@NOMBRE_ARCHIVO nvarchar(50)= NULL
,@TIPO_CONTENIDO nvarchar(20)= NULL
,@FECHASUBE nvarchar(8)= NULL
,@HORASUBE nvarchar(8)= NULL
,@USUARIO nvarchar(10)= NULL
,@VALIDADO nvarchar(2)= NULL
,@CERTUSUARIO nvarchar(10)= NULL
,@CERTFECHA nvarchar(8)= NULL
,@CERTHORA nvarchar(8)= NULL
,@IDRECHAZO uniqueidentifier= NULL
,@OBSCERTIFICACION nvarchar(max)= NULL
,@ID_ARCHIVO uniqueidentifier= NULL
,@FECHA_INI nvarchar(8)= NULL
,@FECHA_FIN nvarchar(8)= NULL
,@CANTDIAS int) AS
BEGIN
INSERT INTO [dbo].[DOCS_CONTROLACCESO_LABORAL]
           ([ID_DOC]
           ,[RUT]
           ,[EMPRESA]
           ,[NOMBRE_ARCHIVO]
           ,[TIPO_CONTENIDO]
           ,[FECHASUBE]
           ,[HORASUBE]
           ,[USUARIO]
           ,[VALIDADO]
           ,[CERTUSUARIO]
           ,[CERTFECHA]
           ,[CERTHORA]
           ,[IDRECHAZO]
           ,[OBSCERTIFICACION]
           ,[ID_ARCHIVO]
           ,[FECHA_INI]
           ,[FECHA_FIN]
           ,[CANTDIAS])
     VALUES
           (@ID_DOC 
           ,@RUT
           ,@EMPRESA
           ,@NOMBRE_ARCHIVO
           ,@TIPO_CONTENIDO
           ,[dbo].[hoy](GETDATE())
           ,[dbo].[ahora](GETDATE())
           ,@USUARIO
           ,@VALIDADO
           ,@CERTUSUARIO
           ,[dbo].[hoy](GETDATE())
           ,[dbo].[ahora](GETDATE())
           ,@IDRECHAZO
           ,@OBSCERTIFICACION
           ,@ID_ARCHIVO
           ,@FECHA_INI
           ,@FECHA_FIN
           ,@CANTDIAS)
END

