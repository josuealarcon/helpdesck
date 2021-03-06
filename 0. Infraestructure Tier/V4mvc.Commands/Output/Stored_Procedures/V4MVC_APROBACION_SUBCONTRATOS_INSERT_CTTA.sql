CREATE PROCEDURE [dbo].[V4MVC_APROBACION_SUBCONTRATOS_INSERT_CTTA]
(
@MADRE				NVARCHAR(30) = NULL
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
,@ACRONIMO			NVARCHAR(100)=NULL
,@ID_ARCHIVO		uniqueidentifier
,@LICITACION		CHAR(2)=NULL
,@USR_SOLICITA		NVARCHAR(30)=NULL 
)
AS
BEGIN
	BEGIN TRANSACTION TRANSACCION
	BEGIN TRY

		IF NOT  EXISTS(SELECT IDEMPRESA FROM ENTERPRISE WHERE IDEMPRESA = @EMPRESA)
		BEGIN
			INSERT INTO ENTERPRISE	(IDEMPRESA,ACRONIMO,NOMBRE,AUTOR) 
			VALUES					(@EMPRESA,@ACRONIMO,@ACRONIMO, 'SI')
		END
		ELSE
		BEGIN
			UPDATE ENTERPRISE SET AUTOR = 'SI' WHERE IDEMPRESA =@EMPRESA
		END

		IF NOT EXISTS(SELECT Rut FROM COLAB_USUARIO WHERE RUT = @ADMIN_CTTA AND IDEMPRESA=@EMPRESA AND ACTIVO='SI')
		BEGIN
			INSERT INTO COLAB_USUARIO(IDEMPRESA			,RUT			,CLAVE			,Correo_Electronico
									  ,TipoUsuario		,Activo			,Fecha_Creacion) 
			VALUES(@EMPRESA			,@ADMIN_CTTA		,@ADMIN_CTTA		,@CORREO_ADM_CTTA
					,'ADMIN'		,'SI'				,GETDATE() )
		END
			
		INSERT INTO APROBACION_SUBCONTRATOS (MADRE,	 EMPRESA,	OST,	NIVEL
											 ,FINICIO,	FTERMINO,	MONTO,	 DOTACION	
											 ,DOTACION_VEHI,		ADMIN_CTTA,		CORREO_ADM_CTTA,	TELEFONO	
											 ,ID_ARCHIVO,	LICITACION,		VALIDADO,		USR_SOLICITA
											 ,FEC_SOLICITA,		HORA_SOLICITA 
											 )
									VALUES  (@MADRE,	@EMPRESA,	@OST,	@NIVEL
											 ,@FINICIO,	@FTERMINO,	@MONTO,	@DOTACION
											 ,@DOTACION_VEHI,	@ADMIN_CTTA,	@CORREO_ADM_CTTA,	@TELEFONO
											 ,@ID_ARCHIVO,		@LICITACION,	'NO',		@USR_SOLICITA 
											 ,DBO.HOY(GETDATE()),	DBO.AHORA(GETDATE()) 
											 )

	COMMIT TRANSACTION TRANSACCION
	END TRY
	BEGIN CATCH	
			ROLLBACK TRANSACTION TRANSACCION
	END CATCH
									 
END
  
