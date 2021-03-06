CREATE PROCEDURE [dbo].[V4MVC_RESERVAS_REVISION_VEHICULAR_DELETE_ACREDITACIONVEHICULAR_CTTA]
(@USUARIOSOL  NVARCHAR(10) = NULL
,@ID  INT = NULL) AS
BEGIN
      INSERT INTO LOG_RESERVA_VEHICULAR(EMPRESA,				 PATENTE		,FECHARES,		 HORAINICIO
	                                   ,HORATERMINO				,MINUTOS		,ASISTIO		,MOTIVO
									   ,FECHASOL				,HORASOL		,USUARIOSOL		,FECHAMOD
									   ,HORAMOD					,USUARIOMOD		,TIPOMOD) 
								 SELECT EMPRESA					,PATENTE		,FECHARES		,HORAINICIO
									   ,HORATERMINO				,MINUTOS		,ASISTIO		,MOTIVO
									   ,FECHASOL				,HORASOL		,USUARIOSOL		,[dbo].[hoy](GETDATE()) 
									   ,[dbo].[ahora](GETDATE()),@USUARIOSOL    ,'DEL' FROM RESERVAS_REVISION_VEHICULAR WHERE ID = @ID
      DELETE FROM RESERVAS_REVISION_VEHICULAR WHERE ID = @ID

END
