CREATE PROCEDURE [dbo].[V4MVC_INSTALACION_FAENA_SELECT_ONE_CONTRATOST_CTTA]
(
 @NROOST		NVARCHAR(14)
) AS
BEGIN
	DECLARE @NOMBRE NVARCHAR(50) = ''
	DECLARE @A_NOMBRE NVARCHAR(255) = ''
	DECLARE @A_NOMBRE_ARCHIVO NVARCHAR(255) = ''
	DECLARE @FLAG_SUBE_DOCS BIT = 0
	DECLARE @D_NOMBRE NVARCHAR(50) = ''
	DECLARE @D2_NOMBRE NVARCHAR(50) = ''
	DECLARE @D3_NOMBRE NVARCHAR(50) = ''
	DECLARE @D3_EXTS NVARCHAR(MAX) = ''
	DECLARE @D4_NOMBRE NVARCHAR(50) = ''
	DECLARE @D4_EXTS NVARCHAR(MAX) = ''

	SELECT
		TOP 1
			@NOMBRE = ISNULL(I.NOMBRE,'')
	FROM INSTALACION_FAENA I
	INNER JOIN OST O
		ON O.ID_INSTALACION_FAENA = I.ID
	WHERE ACTIVO = 'SI' AND (O.NROOST = @NROOST)

	SELECT
		TOP 1
			@A_NOMBRE = ISNULL(A.NOMBRE, 'Sin Archivo'),
			@A_NOMBRE_ARCHIVO = ISNULL(A2.NOMBRE, 'Sin Archivo')
	FROM OST O
	LEFT JOIN ARCHIVOS A
		ON O.ID_INF_RECEPCION = A.ID
	LEFT JOIN ARCHIVOS A2
		ON O.ID_FORM_RECEPCION = A2.ID
	WHERE (O.NROOST = @NROOST)

	IF(
		EXISTS(
				SELECT *
				FROM A024_DIVISIONES AD
				WHERE AD.DIVCOD IN (
								  SELECT OTD.DIVISION
								  FROM OSTDIVLOCAL OTD
								  WHERE OTD.OST = @NROOST) AND
					  AD.CONTROL_SEGURIDAD = 'SI'
		  )
		)
		BEGIN
			SET @FLAG_SUBE_DOCS = 1
		END

	SELECT
		TOP 1 
			@D_NOMBRE = D.NOMBRE
	FROM DOCS D
	WHERE D.ID_DOC = (
						SELECT TOP 1
									 V2.VALOR1
						FROM PARAMETROS_V2 V2
						WHERE V2.TITULO1 = 'DOC1'
					)
	SELECT
		TOP 1 
			@D2_NOMBRE = D2.NOMBRE
	FROM DOCS D2
	WHERE D2.ID_DOC = (
						SELECT TOP 1
									 V2.VALOR2
						FROM PARAMETROS_V2 V2
						WHERE V2.TITULO2 = 'DOC2'
					)

	SELECT
		TOP 1 
			@D3_NOMBRE = D3.NOMBRE,
			@D3_EXTS = SUBSTRING( 
									(
										SELECT ' ' + DOCS_EXT.EXTENSION
										FROM DOCS_FORMATO, DOCS_EXT
										WHERE
											(DOCS_FORMATO.ID_DOC = D3.ID_DOC) AND
											(DOCS_FORMATO.ID_DOC_EXT = DOCS_EXT.ID_DOC_EXT)
										FOR XML PATH('') 
									), 2, 9999
								 )
	FROM DOCS D3
	WHERE D3.ID_DOC = (
						SELECT TOP 1
									 V2.VALOR1
						FROM PARAMETROS_V2 V2
						WHERE V2.TITULO1 = 'DOC1'
					  )

	SELECT
		TOP 1 
			@D4_NOMBRE = D4.NOMBRE,
			@D4_EXTS = SUBSTRING( 
									(
										SELECT ' ' + DOCS_EXT.EXTENSION
										FROM DOCS_FORMATO, DOCS_EXT
										WHERE
											(DOCS_FORMATO.ID_DOC = D4.ID_DOC) AND
											(DOCS_FORMATO.ID_DOC_EXT = DOCS_EXT.ID_DOC_EXT)
										FOR XML PATH('') 
									), 2, 9999
								 )
	FROM DOCS D4
	WHERE D4.ID_DOC = (
						SELECT TOP 1
									 V2.VALOR2
						FROM PARAMETROS_V2 V2
						WHERE V2.TITULO2 = 'DOC2'
					  )


	/*-------------------------------------*/

	SELECT
		@NOMBRE AS NOMBRE,
		@A_NOMBRE AS A_NOMBRE,
		@A_NOMBRE_ARCHIVO AS A_NOMBRE_ARCHIVO,
		@FLAG_SUBE_DOCS AS FLAG_SUBE_DOCS,
		@D_NOMBRE AS D_NOMBRE,
		@D2_NOMBRE AS D2_NOMBRE,
		@D3_NOMBRE AS D3_NOMBRE,
		@D3_EXTS AS D3_EXTS,
		@D4_NOMBRE AS D4_NOMBRE,
		@D4_EXTS AS D4_EXTS

END

