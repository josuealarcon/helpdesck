CREATE PROCEDURE [dbo].[V4MVC_DOCS_TRANSPORT_NEW]
( @PATENTE nvarchar(10)= NULL
 ,@NOMBRE_ARCHIVO nvarchar(50)= NULL
 ,@TIPO_CONTENIDO nvarchar(20)= NULL
 ,@EMPRESA nvarchar(20)= NULL
 ,@DIVISION nvarchar(4)= NULL
 ,@ID_DOC int= NULL
 ,@USUARIO nvarchar(10)= NULL
 ,@ID uniqueidentifier= NULL
 ,@VALIDADO nvarchar(2)= NULL) AS
BEGIN
INSERT INTO [dbo].[DOCS_TRANSPORT]
           ([PATENTE]
           ,[ID_DOC]
           ,[NOMBRE_ARCHIVO]
           ,[FECHA_MOD]
           ,[HORA_MOD]
           ,[TIPO_CONTENIDO]
           ,[USUARIO]
           ,[ID]
           ,[VALIDADO]
           ,[DIVISION]
           ,[EMPRESA]
           ,[FECHASUBE]
           ,[HORASUBE])
     VALUES
           (@PATENTE
           ,@ID_DOC
           ,@NOMBRE_ARCHIVO
           ,[dbo].[hoy](GETDATE())
           ,[dbo].[ahora](GETDATE())
           ,@TIPO_CONTENIDO
           ,@USUARIO
           ,@ID
           ,@VALIDADO
           ,@DIVISION
           ,@EMPRESA
           ,[dbo].[hoy](GETDATE())
           ,[dbo].[ahora](GETDATE()))
END

