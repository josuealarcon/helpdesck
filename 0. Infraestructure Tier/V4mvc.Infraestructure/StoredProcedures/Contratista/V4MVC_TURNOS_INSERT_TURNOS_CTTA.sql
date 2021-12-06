CREATE PROCEDURE [dbo].[V4MVC_TURNOS_INSERT_TURNOS_CTTA]
( @IDTURNO int = NULL
, @EMPRESA nvarchar(10) = NULL
, @TURNO nvarchar(20) = NULL
, @LOCAL nvarchar(50) = NULL
, @DIATRABAJO int = NULL
, @DIADESCANSO int = NULL
, @DDIURNO nvarchar(10) = NULL
, @DNOCHE nvarchar(10) = NULL
, @DDIURNO2 nvarchar(10) = NULL
, @DNOCHE2 nvarchar(10) = NULL
, @FECINICIO nvarchar(8) = NULL
, @TURDESCR nvarchar(100) = NULL
, @DOTTURNO int = NULL
, @CLASETUR nvarchar(15) = NULL
, @ESTADOTUR nvarchar(10) = NULL
, @OBSERVTUR nvarchar(100) = NULL
, @TIENEHE nvarchar(2) = NULL
, @HMAXDIANOR smallmoney = NULL
, @HMAXDIAHE smallmoney = NULL
, @HSEMANA smallmoney = NULL
, @HEXTRAS smallmoney = NULL
, @HINGRESO nvarchar(8) = NULL
, @HINDESDE nvarchar(8) = NULL
, @HINHASTA nvarchar(8) = NULL
, @HOUTDESDE nvarchar(8) = NULL
, @HOUTHASTA nvarchar(8) = NULL
, @HALIMI nvarchar(8) = NULL
, @HALIMS nvarchar(8) = NULL
, @FECHAMOD nvarchar(8) = NULL
, @HORAMOD nvarchar(8) = NULL
, @GRABO nvarchar(1) = NULL
, @TIENEFERIADO nvarchar(2) = NULL
, @HSALIDA nvarchar(8) = NULL
, @USUARIOMOD nvarchar(10) = NULL
, @VISIBLE nvarchar(2) = NULL
, @TIPO nvarchar(1) = NULL
, @HINGRESON nvarchar(8) = NULL
, @HINDESDEN nvarchar(8) = NULL
, @HINHASTAN nvarchar(8) = NULL
, @HSALIDAN nvarchar(8) = NULL
, @HOUTDESDEN nvarchar(8) = NULL
, @HOUTHASTAN nvarchar(8) = NULL
, @HALIMIN nvarchar(8) = NULL
, @HALIMSN nvarchar(8) = NULL
, @HSAL_ULIMODIA nvarchar(8) = NULL
, @FVIGENCIA nvarchar(8) = NULL
, @VALIDADO nvarchar(2) = NULL
, @EMPIEZANOCHEA nvarchar(10) = NULL
, @EMPIEZANOCHEB nvarchar(10) = NULL
, @EMPIEZA nvarchar(10) = NULL
, @OST nvarchar(14) = NULL
, @ID uniqueidentifier = NULL
, @USRSUBE nvarchar(10) = NULL
, @CERTUSUARIO nvarchar(20) = NULL
, @CERTFECHA nvarchar(8) = NULL
, @CERTHORA nvarchar(8) = NULL
, @OBS_RECHAZO text = NULL
, @HSAL_ULIMONOCHE nvarchar(8) = NULL) AS 
BEGIN

INSERT INTO [dbo].[TURNOS]
           ([EMPRESA]				,[TURNO]					,[LOCAL]			,[DIATRABAJO]
           ,[DIADESCANSO]			,[DDIURNO]					,[DNOCHE]			,[DDIURNO2]
           ,[DNOCHE2]				,[FECINICIO]				,[TURDESCR]			,[DOTTURNO]
           ,[CLASETUR]				,[ESTADOTUR]				,[OBSERVTUR]		,[TIENEHE]
           ,[HMAXDIANOR]			,[HMAXDIAHE]				,[HSEMANA]			,[HEXTRAS]
           ,[HINGRESO]				,[HINDESDE]					,[HINHASTA]			,[HOUTDESDE]
           ,[HOUTHASTA]				,[HALIMI]					,[HALIMS]			,[FECHAMOD]
           ,[HORAMOD]				,[GRABO]					,[TIENEFERIADO]		,[HSALIDA]
           ,[USUARIOMOD]			,[VISIBLE]					,[TIPO]				,[HINGRESON]
           ,[HINDESDEN]				,[HINHASTAN]				,[HSALIDAN]			,[HOUTDESDEN]
           ,[HOUTHASTAN]			,[HALIMIN]					,[HALIMSN]			,[HSAL_ULIMODIA]
           ,[FVIGENCIA]				,[EMPIEZANOCHEA]			,[EMPIEZANOCHEB]	,[EMPIEZA]
           ,[OST]					,[ID]						,[VALIDADO]			,[USRSUBE]
           ,[FECSUBE]				,[HORASUBE]					,[CERTUSUARIO]		,[CERTFECHA]
           ,[CERTHORA]				,[OBS_RECHAZO]				,[HSAL_ULIMONOCHE])
     VALUES
           (@EMPRESA				,@TURNO						,@LOCAL				,@DIATRABAJO
           ,@DIADESCANSO			,@DDIURNO					,@DNOCHE			,@DDIURNO2
           ,@DNOCHE2				,@FECINICIO					,@TURDESCR			,@DOTTURNO
           ,@CLASETUR				,@ESTADOTUR					,@OBSERVTUR			,@TIENEHE
           ,@HMAXDIANOR				,@HMAXDIAHE					,@HSEMANA			,@HEXTRAS
           ,@HINGRESO				,@HINDESDE					,@HINHASTA			,@HOUTDESDE
           ,@HOUTHASTA				,@HALIMI					,@HALIMS			,[dbo].[hoy](GETDATE())
           ,[dbo].[ahora](GETDATE()),@GRABO						,@TIENEFERIADO		,@HSALIDA
           ,@USUARIOMOD				,'SI'						,@TIPO				,@HINGRESON
           ,@HINDESDEN				,@HINHASTAN					,@HSALIDAN			,@HOUTDESDEN
           ,@HOUTHASTAN				,@HALIMIN					,@HALIMSN			,@HSAL_ULIMODIA
           ,@FVIGENCIA				,@EMPIEZANOCHEA				,@EMPIEZANOCHEB		,@EMPIEZA
           ,@OST					,@ID						,'NO'				,@USRSUBE
           ,[dbo].[hoy](GETDATE())	,[dbo].[ahora](GETDATE())	,@CERTUSUARIO		,[dbo].[hoy](GETDATE())
           ,[dbo].[ahora](GETDATE()),@OBS_RECHAZO				,@HSAL_ULIMONOCHE)

END
/****** Object:  StoredProcedure [dbo].[V4MVC_TURNOS_UPDATE]    Script Date: 1/11/2020 12:34:20 ******/
SET ANSI_NULLS ON
