
CREATE PROCEDURE [dbo].[V4MVC_APROBACION_SUBCONTRATOS_DELETE_CTTA]  
(  
 @ID				INT = NULL
 ,@USR_SOLICITA		NVARCHAR(30)=NULL 
)  
AS  
BEGIN
	BEGIN TRY
		BEGIN TRAN 

		

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
			,DBO.HOY(GETDATE())		,DBO.AHORA(GETDATE())	,'ELIMINA'
			FROM APROBACION_SUBCONTRATOS
			WHERE ID = @ID


			DELETE APROBACION_SUBCONTRATOS
			WHERE ID = @ID
		
			COMMIT TRAN
 
		END TRY
	BEGIN CATCH 
		ROLLBACK 
END CATCH		
END  
