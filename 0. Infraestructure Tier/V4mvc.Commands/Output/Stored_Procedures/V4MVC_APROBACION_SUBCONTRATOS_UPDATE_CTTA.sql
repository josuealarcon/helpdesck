CREATE PROCEDURE [dbo].[V4MVC_APROBACION_SUBCONTRATOS_UPDATE_CTTA]
(
@ID					INT =NULL
,@MADRE				NVARCHAR(30) = NULL
,@OST				NVARCHAR(100) = NULL
,@EMPRESA			NVARCHAR(30) = NULL
,@DOTACION			INT = NULL
,@DOTACION_VEHI		INT = NULL
,@FINICIO			NVARCHAR(16) = NULL
,@FTERMINO			NVARCHAR(16) = NULL
,@MONTO				INT = NULL
,@NIVEL				INT = NULL
,@ADMIN_CTTA		NVARCHAR(20) = NULL
,@CORREO_ADM_CTTA	NVARCHAR(100) =  NULL
,@TELEFONO			NVARCHAR(30) = NULL
,@ID_ARCHIVO		uniqueidentifier
,@LICITACION		CHAR(2)=NULL
,@USR_SOLICITA		NVARCHAR(30)=NULL 
)
AS
BEGIN
	BEGIN TRANSACTION TRANSACCION
	BEGIN TRY

		
		UPDATE ENTERPRISE SET AUTOR = 'SI' WHERE IDEMPRESA =@EMPRESA
	

		IF NOT EXISTS(SELECT Rut FROM COLAB_USUARIO WHERE RUT = @ADMIN_CTTA AND IDEMPRESA=@EMPRESA AND ACTIVO='SI')
		BEGIN	
			INSERT INTO COLAB_USUARIO(IDEMPRESA,	RUT,	CLAVE,	Correo_Electronico,
										TipoUsuario,	Activo,	Fecha_Creacion) 
									VALUES(@EMPRESA,	@ADMIN_CTTA,	@ADMIN_CTTA,	@CORREO_ADM_CTTA, 
										'ADMIN',	'SI',	 GETDATE() )
		END
		ELSE
		BEGIN
			UPDATE COLAB_USUARIO SET Correo_Electronico=@CORREO_ADM_CTTA WHERE IDEMPRESA = @EMPRESA AND RUT = @ADMIN_CTTA
		END
			
		UPDATE APROBACION_SUBCONTRATOS
		SET 
		FINICIO				=@FINICIO
		,FTERMINO			=@FTERMINO
		,MONTO				=@MONTO
		,DOTACION			=@DOTACION
		,DOTACION_VEHI		=@DOTACION_VEHI
		,ADMIN_CTTA			=@ADMIN_CTTA
		,ID_ARCHIVO			=@ID_ARCHIVO
		,CORREO_ADM_CTTA	=@CORREO_ADM_CTTA
		,TELEFONO			=@TELEFONO
		,LICITACION			=@LICITACION
		WHERE ID = @ID								

		INSERT INTO APROBACION_SUBCONTRATOS_LOG 
			([ID]					,[MADRE]				,[EMPRESA]					,[OST]					,[NIVEL]
			,[FINICIO]				,[FTERMINO]				,[MONTO]					,[DOTACION]				,[DOTACION_VEHI]
			,[ADMIN_CTTA]			,[CORREO_ADM_CTTA]		,[TELEFONO]					,[ID_ARCHIVO]			,[LICITACION]
			,[VALIDADO]				,[USR_SOLICITA]			,[FEC_SOLICITA]				,[HORA_SOLICITA]		,[ADM_VALIDA_ESTADO]
			,[ADM_VALIDA]			,[FEC_ADM_VALIDA]		,[HORA_ADM_VALIDA]			,[OBS_ADM_VALIDA]		,[ADM_SUPCHAIN_ESTADO]
			,[ADM_SUPCHAIN_VALIDA]	,[FEC_SUPCHAIN_VALIDA]	,[HORA_SUPCHAIN_VALIDA]		,[OBS_SUPCHAIN_VALIDA]	,[ADM_GSEGURIDAD_ESTADO]
			,[ADM_GSEGURIDAD_VALIDA],[FEC_GSEGURIDAD_VALIDA],[HORA_GSEGURIDAD_VALIDA]	,[OBS_GSEGURIDAD_VALIDA],[USRMOD]
			,[FECMOD]				,[HORAMOD]				,[ACCION]) 
			SELECT	
			[ID]					,[MADRE]				,[EMPRESA]					,[OST]						,[NIVEL]					
			,[FINICIO]				,[FTERMINO]				,[MONTO]					,[DOTACION]					,[DOTACION_VEHI]			
			,[ADMIN_CTTA]			,[CORREO_ADM_CTTA]		,[TELEFONO]					,[ID_ARCHIVO]				,[LICITACION]				
			,[VALIDADO]				,[USR_SOLICITA]			,[FEC_SOLICITA]				,[HORA_SOLICITA]			,[ADM_VALIDA_ESTADO]		
			,[ADM_VALIDA]			,[FEC_ADM_VALIDA]		,[HORA_ADM_VALIDA]			,[OBS_ADM_VALIDA]			,[ADM_SUPCHAIN_ESTADO]		
			,[ADM_SUPCHAIN_VALIDA]	,[FEC_SUPCHAIN_VALIDA]	,[HORA_SUPCHAIN_VALIDA]		,[OBS_SUPCHAIN_VALIDA]		,[ADM_GSEGURIDAD_ESTADO]	
			,[ADM_GSEGURIDAD_VALIDA],[FEC_GSEGURIDAD_VALIDA],[HORA_GSEGURIDAD_VALIDA]	,[OBS_GSEGURIDAD_VALIDA]	,@USR_SOLICITA				
			,DBO.HOY(GETDATE())		,DBO.AHORA(GETDATE())	,'EDICION'
			FROM APROBACION_SUBCONTRATOS
			WHERE ID = @ID

	COMMIT TRANSACTION TRANSACCION
	END TRY
	BEGIN CATCH	
			ROLLBACK TRANSACTION TRANSACCION
	END CATCH
									 
END
  


