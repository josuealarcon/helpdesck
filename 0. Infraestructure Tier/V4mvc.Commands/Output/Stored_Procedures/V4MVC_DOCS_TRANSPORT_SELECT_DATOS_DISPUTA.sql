CREATE PROCEDURE [dbo].[V4MVC_DOCS_TRANSPORT_SELECT_DATOS_DISPUTA]
(@ID			UNIQUEIDENTIFIER= NULL
,@DIVCOD		NVARCHAR(50) = NULL
--,@PATENTE		NVARCHAR(10) = NULL
--,@ID_DOC		INT = NULL
,@ID_DISPUTA	INT = NULL) AS
BEGIN
	IF @ID_DISPUTA <= 0
		BEGIN
			SELECT DT.PATENTE, T.MARCA, T.MODELO, D.NOMBRE
			,(CASE WHEN DI.DIVISION IS NOT NULL AND DI.DIVISION <> '' THEN  (CASE WHEN D.COMUN_DIV = 'SI' THEN 'TODAS' ELSE DI.DIVISION END)
										  ELSE (CASE WHEN D.COMUN_DIV = 'SI' THEN 'TODAS' ELSE '' END) END) AS DIVISION
			, DT.VALIDADO, DT.ID, DT.ID_DOC,DD.ESTADO, DD.OBSERVACION, DD.OBSERVACION_REVAL, DD.EMPRESA
			, @DIVCOD AS DIVCOD
			FROM DOCS_TRANSPORT DT 
			INNER JOIN TRANSPORT T ON T.PATENTE = DT.PATENTE 
			INNER JOIN DOCS D ON D.ID_DOC = DT.ID_DOC 
			LEFT OUTER JOIN DOCS_DISPUTA_TRANS DD ON DD.ID = DT.ID AND DD.PATENTE = DT.PATENTE AND DD.ID_DOC = DT.ID_DOC 
			LEFT JOIN A024_DIVISIONES AS DI ON DI.DIVCOD = @DIVCOD
			WHERE DT.ID = @ID
		END
	ELSE
		BEGIN
			SELECT DT.PATENTE, T.MARCA, T.MODELO, D.NOMBRE
			, CASE WHEN DD.DIVISION <> 'TODAS' THEN 
												(CASE WHEN DI.DIVCOD IS NOT NULL THEN 
																				 (CASE WHEN D.COMUN_DIV = 'SI' THEN 'TODAS' ELSE DI.DIVISION END)
																				 ELSE (CASE WHEN D.COMUN_DIV = 'SI' THEN 'TODAS' ELSE '' END) END)
												ELSE DD.DIVISION END AS DIVISION
			--, CASE WHEN DD.DIVISION IS NULL OR DD.DIVISION = '' THEN 'TODAS' ELSE DD.DIVISION  END AS DIVISION
			, DT.VALIDADO, DT.ID, DT.ID_DOC,DD.ESTADO, DD.OBSERVACION, DD.OBSERVACION_REVAL, DD.EMPRESA
			, D.COMUN_DIV , @ID_DISPUTA AS ID_DISPUTA
			, @DIVCOD AS DIVCOD
			FROM DOCS_TRANSPORT DT 
			INNER JOIN TRANSPORT T ON T.PATENTE = DT.PATENTE 
			INNER JOIN DOCS D ON D.ID_DOC = DT.ID_DOC 
			LEFT OUTER JOIN DOCS_DISPUTA_TRANS DD ON DD.ID = DT.ID AND DD.PATENTE = DT.PATENTE AND DD.ID_DOC = DT.ID_DOC 
			LEFT JOIN A024_DIVISIONES AS DI ON DI.DIVCOD = DD.DIVISION
			WHERE DD.ID_DISPUTA = @ID_DISPUTA
		END
END
