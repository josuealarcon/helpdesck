CREATE PROCEDURE [dbo].[V4MVC_DOCS_WORKERS_SELECT_DEPENDENCIA_VALIDADO_CTTA]
(@RUT		NVARCHAR(10) = NULL
,@ID_DOC	INT = NULL
,@DIVCOD	NVARCHAR(50) = NULL
,@COMUN_DIV	NVARCHAR(2) = NULL
,@COMUN		INT = NULL
,@IDEMPRESA	NVARCHAR(10) = NULL) AS
BEGIN
	IF @COMUN = 0
		BEGIN
			SELECT TOP 1 VALIDADO 
			FROM DOCS_WORKERS 
			WHERE (RUT = @RUT) 
			AND (ID_DOC = @ID_DOC) 
			AND (DIVISION = (CASE WHEN @COMUN_DIV = 'SI' THEN DIVISION ELSE @DIVCOD END )) 
			AND (EMPRESA = @IDEMPRESA)
			ORDER BY FECHASUBE DESC, HORASUBE DESC
		END
	ELSE
		BEGIN 
			SELECT TOP 1 VALIDADO 
			FROM DOCS_WORKERS 
			WHERE (RUT = @RUT) 
			AND (ID_DOC = @ID_DOC) 
			AND (DIVISION = (CASE WHEN @COMUN_DIV = 'SI' THEN DIVISION ELSE @DIVCOD END )) 
			ORDER BY FECHASUBE DESC, HORASUBE DESC
		END
END

