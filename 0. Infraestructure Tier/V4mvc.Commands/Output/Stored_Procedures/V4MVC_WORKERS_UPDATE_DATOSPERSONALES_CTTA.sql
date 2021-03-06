CREATE PROCEDURE [dbo].[V4MVC_WORKERS_UPDATE_DATOSPERSONALES_CTTA]        
(        
 @RUT				NVARCHAR(10) = NULL       
,@EMPRESA			NVARCHAR(10) = NULL    
,@NOMBRES			NVARCHAR(50) = NULL    
,@APELLIDOS			NVARCHAR(50) = NULL    
,@CORREOELECTRONICO NVARCHAR(50) = NULL    
,@CELULAR			NVARCHAR(50) = NULL    
,@FONO				NVARCHAR(50) = NULL    
,@FONOHELP			NVARCHAR(50) = NULL    
,@PAIS				NVARCHAR(50) = NULL    
,@REGION			NVARCHAR(5) = NULL    
,@CIUDAD			NVARCHAR(50) = NULL    
,@COMUNA			NVARCHAR(50) = NULL    
,@ZONA				NVARCHAR(50) = NULL    
,@DIRECCION			NVARCHAR(50) = NULL    
,@EMAILOLD			NVARCHAR(50) = NULL
)        
AS        
BEGIN    
    
	UPDATE COLAB_USUARIO     
			SET Correo_Electronico = @CORREOELECTRONICO    
	WHERE IdEmpresa = @EMPRESA  
	AND Rut = @RUT    
    
	 UPDATE WORKERS     
	 SET NOMBRES	= @NOMBRES
	   , APELLIDOS	= @APELLIDOS
	   , EMAIL		= @CORREOELECTRONICO    
	 WHERE RUT=@RUT    
    
	 IF EXISTS( SELECT * FROM DIRECCION WHERE RUT=@RUT)      
		 BEGIN      
			  UPDATE DIRECCION     
					SET  PAIS		= @PAIS
					   , REGION		= @REGION
					   , COMUNA		= @COMUNA
					   , CIUDAD		= @CIUDAD
					   , ZONA		= @ZONA
					   , DIRECCION	= @DIRECCION
					   , CELULAR	= @CELULAR
					   , FONO		= @FONO
					   , FONOHELP   = @FONOHELP    
			  WHERE RUT=@RUT    
		 END      
	 ELSE      
		BEGIN      
			  INSERT INTO DIRECCION (	RUT			,PAIS		,REGION			,COMUNA
									   ,CIUDAD		,ZONA		,DIRECCION		,CELULAR
									   ,FONO		,FONOHELP
									)   
									   
							VALUES (	@RUT		,@PAIS		,@REGION		,@COMUNA
									   ,@CIUDAD		,@ZONA		,@DIRECCION		,@CELULAR
									   ,@FONO		,@FONOHELP
									)     
		END 

	IF (@CORREOELECTRONICO != @EMAILOLD)
		BEGIN
			UPDATE LOTEPASES
				SET LOTEEMAIL = @CORREOELECTRONICO
			WHERE LOTEEMAIL = @EMAILOLD
		END
END
