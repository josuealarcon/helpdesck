CREATE PROCEDURE [dbo].[V4MVC_DOCS_TRANSPORT_HISTORICOCTTA]
(@IDEMPRESA		NVARCHAR(10) = NULL
,@PATENTE		NVARCHAR(6) = NULL
,@COMUN			INT = NULL
,@ID_DOC		INT = NULL
,@COMUN_DIV		NVARCHAR(2) =NULL
,@DIVCOD		NVARCHAR(4) = NULL) AS
BEGIN
	IF @COMUN = 0
		BEGIN
			SELECT DT.PATENTE		, DT.FECHA_MOD	, DT.HORA_MOD , DT.USUARIO
				 , DT.ID			, DT.ID_DOC		, DT.VALIDADO , DT.CERTUSUARIO
				 , DT.CERTFECHA		, DT.CERTHORA   , (SELECT VALOR1 FROM PARAMETROS WHERE ID_PARAMETRO=7) AS VALOR
				 , W.NOMBRES		, W.APELLIDOS   , DT.ID_DOCS_VEH, @DIVCOD DIVCOD
			FROM DOCS_TRANSPORT AS DT
			INNER JOIN WORKERS AS W ON W.RUT = DT.USUARIO
			WHERE (DT.PATENTE = @PATENTE) AND 
			(DT.ID_DOC = @ID_DOC) AND 
			(DT.DIVISION = (CASE WHEN @COMUN_DIV = 'SI' THEN DT.DIVISION ELSE @DIVCOD END)) AND 
			(DT.EMPRESA = @IDEMPRESA) 
			ORDER BY DT.FECHA_MOD DESC, DT.HORA_MOD DESC
		END
	ELSE
		BEGIN
			SELECT DT.PATENTE	 , DT.FECHA_MOD	, DT.HORA_MOD	, DT.USUARIO
				 , DT.ID		 , DT.ID_DOC	, DT.VALIDADO	, DT.CERTUSUARIO
				 , DT.CERTFECHA  , DT.CERTHORA  , DT.ID_DOCS_VEH , (SELECT VALOR1 FROM PARAMETROS WHERE ID_PARAMETRO=7) AS VALOR
				 , W.NOMBRES	 , W.APELLIDOS  , @DIVCOD DIVCOD , (SELECT T.TIPO_RECHAZO FROM DOCS_TRANSPORT_RECHAZO D INNER JOIN DOCS_TIPO_RECHAZO T ON T.ID_TIPO_RECHAZO = D.ID_TIPO_RECHAZO WHERE D.ID = DT.ID) MOTIVO_RECHAZO
			FROM DOCS_TRANSPORT AS DT
			INNER JOIN WORKERS AS W ON W.RUT = DT.USUARIO
			WHERE (DT.PATENTE = @PATENTE) AND 
			(DT.ID_DOC = @ID_DOC) AND 
			(DT.DIVISION = (CASE WHEN @COMUN_DIV = 'SI' THEN DT.DIVISION ELSE @DIVCOD END)) 
			ORDER BY DT.FECHA_MOD DESC, DT.HORA_MOD DESC
		END
END



--EXEC V4MVC_DOCS_TRANSPORT_HISTORICOCTTA '761264907','AAA111',1,57,'NO','CH'
