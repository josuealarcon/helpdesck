CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_SELECT_IACREDVEHICULAR_INFORMES_CTTA]
(
  @DIVISION				NVARCHAR(4)
 ,@EMPRESA				NVARCHAR(10)
 ,@PERIODO_DESDE		NVARCHAR(8) = '19000101'
 ,@PATENTE				NVARCHAR(8) = ''
 ,@TIPO_VEH				NVARCHAR(20) = NULL
 ,@COLUMNAS				NVARCHAR(4000) OUTPUT
 ,@REQUISITOS			NVARCHAR(4000) OUTPUT
) AS
BEGIN
	DECLARE @HOY				NVARCHAR(8) = dbo.hoy(getdate())
	DECLARE @ACRONIMO			NVARCHAR(50)
	DECLARE @CAMPOS_DOC			NVARCHAR(500) = ''
	DECLARE @CAMPOS_FEC			NVARCHAR(500) = ''
	DECLARE @FILTRO_EMPRESA		NVARCHAR(100) = ''
	DECLARE @FILTRO_PATENTE		NVARCHAR(100) = ''
	DECLARE @FILTRO_TIPO		NVARCHAR(100) = ''
	DECLARE @CAMPOS				NVARCHAR(500)
	DECLARE @REGISTRO			NVARCHAR(300)
	DECLARE @SEP				NVARCHAR(2)


	DECLARE @SQL1				NVARCHAR(MAX) = ''

	DECLARE @CRS_ID				INT
	DECLARE @CRS_CAMPO			NVARCHAR(30)
	DECLARE @CRS_NOMBRE			NVARCHAR(50)
	DECLARE @CRS_ORDEN			INT
	DECLARE @CRS_TIPO			NVARCHAR(2)

	DECLARE @CRS_TIPOVEH		NVARCHAR(9)
	DECLARE @CRS_ID_DOC			INT
	DECLARE @PREV_CRS_TIPOVEH	NVARCHAR(9) = ''

	SET @FILTRO_EMPRESA = ''
	SET @FILTRO_PATENTE = ''
	SET @FILTRO_TIPO = ''

	IF(@PATENTE <> '')
		BEGIN
			SET @FILTRO_PATENTE = ' AND T.PATENTE = ''' + @PATENTE + ''' '
		END
	IF(@EMPRESA <> '')
		BEGIN
			SET @FILTRO_EMPRESA = ' AND T.EMPRESA = ''' + @EMPRESA + ''' '
		END
	IF(@TIPO_VEH IS NOT NULL AND @TIPO_VEH <> '')
		BEGIN
			SET @FILTRO_TIPO = ' AND TT.IDTIPO = ' + @TIPO_VEH + ' '
		END

	/**********[STR_CAMPOS]***************/

	DECLARE cursorCampos CURSOR
		FOR
	SELECT
		DATOS.ID,
		DATOS.CAMPO,
		DATOS.NOMBRE,
		DATOS.ORDEN,
		DATOS.TIPO 
	FROM
		(SELECT ID_DOC  AS ID, 
				   ( CASE 
					   WHEN ISNULL(CAMPO, '') = '' THEN 'F' + CAST (ID_DOC AS NVARCHAR(5)) 
					   ELSE CAMPO 
					 END ) AS CAMPO, 
				   NOMBRE, 
				   ORDEN, 
				   'D' AS TIPO 
			FROM   DOCS 
			WHERE  ( ID_TIPO_PROPIETARIO = '3' ) 
				   AND ( ACTIVO = 'SI' ) 
				   AND ( SUBEDOC = 'SI' ) 
			UNION 
			SELECT ID_DOC_FEC AS ID, 
				   ( CASE 
					   WHEN ISNULL(CAMPO_BD, '') = '' THEN 'F' + CAST (ID_DOC_FEC AS NVARCHAR(5)) 
					   ELSE CAMPO_BD 
					 END ) AS CAMPO, 
				   NOMBRE, 
				   ORDEN, 
				   'F'  AS TIPO 
			FROM   DOCS_FEC 
			WHERE  ( ID_DOC_DEPEND IN (SELECT ID_DOC 
									   FROM   DOCS 
									   WHERE  ( ID_TIPO_PROPIETARIO = '3' ) 
											  AND ( ACTIVO = 'SI' )) ) AND
					( ACTIVO = 'SI' )
	) DATOS 
	ORDER BY DATOS.ORDEN 
	
	OPEN cursorCampos

	FETCH NEXT FROM cursorCampos INTO 
		@CRS_ID,
		@CRS_CAMPO,
		@CRS_NOMBRE,
		@CRS_ORDEN,
		@CRS_TIPO
	
	SET @COLUMNAS = ''
	SET @SEP = ''

	WHILE @@FETCH_STATUS = 0
		BEGIN

			SET @CRS_CAMPO = REPLACE(REPLACE(REPLACE(REPLACE(@CRS_CAMPO, '"', '\"'), CHAR(10), ''), CHAR(13), ''), CHAR(9), '') 
			SET @CRS_NOMBRE = REPLACE(REPLACE(REPLACE(REPLACE(@CRS_NOMBRE, '"', '\"'), CHAR(10), ''), CHAR(13), ''), CHAR(9), '')
			SET @CRS_TIPO = REPLACE(REPLACE(REPLACE(REPLACE(@CRS_TIPO, '"', '\"'), CHAR(10), ''), CHAR(13), ''), CHAR(9), '')
			
			SET @REGISTRO = ''
			SET @REGISTRO = @REGISTRO + '"I":' + ISNULL(CONVERT(NVARCHAR(20), @CRS_ID), 'null') + ','      /*ID*/
			SET @REGISTRO = @REGISTRO + '"C":' + '"' + ISNULL(@CRS_CAMPO, '') + '"' + ','			       /*CAMPO*/
			SET @REGISTRO = @REGISTRO + '"N":' + '"' + ISNULL(@CRS_NOMBRE, '') + '"' + ','			       /*NOMBRE*/
			SET @REGISTRO = @REGISTRO + '"T":' + '"' + ISNULL(@CRS_TIPO, '') + '"'						   /*TIPO*/

			SET @COLUMNAS = @COLUMNAS + @SEP + '{' + @REGISTRO + '}'
			SET @SEP = ','	
			
			FETCH NEXT FROM cursorCampos INTO 
				@CRS_ID,
				@CRS_CAMPO,
				@CRS_NOMBRE,
				@CRS_ORDEN,
				@CRS_TIPO


		END

	SET @COLUMNAS = '[ ' + @COLUMNAS + ' ]'

	CLOSE cursorCampos

	DEALLOCATE cursorCampos
	
	/**********[STR_REQUISITOS]***************/

	DECLARE cursorRequisitos CURSOR
		FOR
	SELECT
		DISTINCT
			DT.TIPOPASE AS TIPOVEH, 
			DT.ID_DOC 
	FROM   DOCS_TIPOPASE DT 
	INNER JOIN DOCS D 
			ON DT.ID_DOC = D.ID_DOC 
	INNER JOIN TYPETRANS TT 
			ON DT.TIPOPASE = CAST(TT.IDTIPO AS NVARCHAR(10)) 
	WHERE  DIVISION = @DIVISION 
	ORDER BY DT.TIPOPASE ASC, ID_DOC ASC

	OPEN cursorRequisitos

	FETCH NEXT FROM cursorRequisitos INTO 
		@CRS_TIPOVEH,
		@CRS_ID_DOC
	
	SET @REQUISITOS = ''
	SET @REGISTRO = ''

	WHILE @@FETCH_STATUS = 0
		BEGIN

			SET @CRS_TIPOVEH = REPLACE(REPLACE(REPLACE(REPLACE(@CRS_TIPOVEH, '"', '\"'), CHAR(10), ''), CHAR(13), ''), CHAR(9), '')
			
			IF(@PREV_CRS_TIPOVEH <> @CRS_TIPOVEH)
				BEGIN
					IF(@REGISTRO <> '')
						BEGIN
							SET @REGISTRO = @REGISTRO + ']'
							IF(@REQUISITOS <> '')
								BEGIN
									SET @REQUISITOS = @REQUISITOS + ',' + '{' + @REGISTRO + '}'
								END
							ELSE
								BEGIN
									SET @REQUISITOS = '{' + @REGISTRO + '}'
								END
						END

					SET @REGISTRO = ''
					SET @REGISTRO = @REGISTRO + '"T":' + '"' + ISNULL(@CRS_TIPOVEH, '') + '",'					       /*TIPO VEHICULO*/
					SET @REGISTRO = @REGISTRO + '"I": [' + ISNULL(CONVERT(NVARCHAR(20), @CRS_ID_DOC), 'null')	      /*ID_DOC*/

				END
			ELSE
				BEGIN
					SET @REGISTRO = @REGISTRO + ',' + ISNULL(CONVERT(NVARCHAR(20), @CRS_ID_DOC), 'null')	          /*ID_DOC*/
				END

			SET @PREV_CRS_TIPOVEH = @CRS_TIPOVEH
			
			FETCH NEXT FROM cursorRequisitos INTO 
				@CRS_TIPOVEH,
				@CRS_ID_DOC
		END

	IF(@REGISTRO <> '')
		BEGIN
			SET @REGISTRO = @REGISTRO + ']'
			IF(@REQUISITOS <> '')
				BEGIN
					SET @REQUISITOS = @REQUISITOS + ',' + '{' + @REGISTRO + '}'
				END
			ELSE
				BEGIN
					SET @REQUISITOS = '{' + @REGISTRO + '}'
				END
		END

	SET @REQUISITOS = '[ ' + @REQUISITOS + ' ]'

	CLOSE cursorRequisitos

	DEALLOCATE cursorRequisitos

	/**********[CAMPOS]*********/


	SET @CAMPOS = NULL

	SET @CAMPOS_DOC = '[SIN]'

	SET @CAMPOS = STUFF(
							(
								SELECT 
									',' + SS.CAMPO
								FROM
								(
									SELECT
										( 
										  CASE
											WHEN ISNULL(CAMPO,'') = '' THEN 'F' + CAST(ID_DOC AS NVARCHAR(5))
											ELSE CAMPO
										  END ) AS CAMPO
									FROM DOCS
									WHERE
										(ID_TIPO_PROPIETARIO = '3') AND
										(ACTIVO = 'SI') AND
										(SUBEDOC = 'SI')
								) SS
								FOR XML PATH('')
							)
							, 1, 1, ''
						)

	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_DOC = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_DOC = '[SIN]'
		END

	/************/
	
	SET @CAMPOS = NULL

	SET @CAMPOS_FEC = '[SIN]'

	SET @CAMPOS = STUFF(
							(
								SELECT
									',' + SS.CAMPO
								FROM
								(
									SELECT
										(
										  CASE
											WHEN ISNULL(CAMPO_BD,'') = '' THEN  'F' + CAST(ID_DOC_FEC AS NVARCHAR(5))
											ELSE CAMPO_BD
										  END ) AS CAMPO
									FROM DOCS_FEC
									WHERE
										(
										  ID_DOC_DEPEND IN ( SELECT ID_DOC FROM DOCS WHERE (ID_TIPO_PROPIETARIO = '3') AND (ACTIVO = 'SI') )
										 ) AND
										 (ACTIVO = 'SI') 
								) SS
								FOR XML PATH('')
							)
							, 1, 1, ''
						) 

	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_FEC = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_FEC = '[SIN]'
		END


	/************/

	PRINT('@DIVISION:' + @DIVISION)
	PRINT('@EMPRESA:' + @EMPRESA)
	PRINT('@PERIODO_DESDE:' + @PERIODO_DESDE)
	PRINT('@PATENTE:' + @PATENTE)
	PRINT('@TIPO_VEH:' + @TIPO_VEH)
	PRINT('@CAMPOS_FEC:' + @CAMPOS_FEC)
	PRINT('@CAMPOS_DOC:' + @CAMPOS_DOC)
	PRINT('@COLUMNAS:' + @COLUMNAS)
	PRINT('@REQUISITOS:' + @REQUISITOS)
	
	/************/

	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('SELECT PIVOTFECHA.*, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       PIVOTDOCS.* ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('FROM   (SELECT [RUT] AS PATENTE, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               T.[EMPRESA], ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               MAX([FECHA]) AS FECHA, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               ( CASE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                   WHEN ISNULL(CAMPO_BD, '''') = '''' THEN ''F'' + CAST (DFW.ID_DOC_FEC AS NVARCHAR(5)) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                   ELSE CAMPO_BD ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                 END ) AS CAMPO_BD ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        FROM DOCS_FEC_WORKERS AS DFW ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               INNER JOIN TRANSPORT T ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       ON DFW.RUT = T.PATENTE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       ' + @FILTRO_PATENTE + ' ' + @FILTRO_EMPRESA + ' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               INNER JOIN DOCS_FEC DF ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       ON DF.ID_DOC_FEC = DFW.ID_DOC_FEC ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               LEFT OUTER JOIN CTRLVEHICULO CV ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                            ON')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('								T.PATENTE = CV.PATENTE AND')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('								CV.FECHAIN >= ''' + @PERIODO_DESDE + ''' AND')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('								CV.DIVISION = ''' + @DIVISION + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        WHERE  DFW.DIVISION IN ( ''' + @DIVISION + ''', ''AA'' ) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               AND DF.COMUN = 0 ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        GROUP  BY RUT, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  T.EMPRESA, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  DFW.ID_DOC_FEC, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  CAMPO_BD ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        UNION ALL ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        SELECT [RUT] AS PATENTE, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               T.[EMPRESA], ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               MAX([FECHA]) AS FECHA, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               ( CASE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                   WHEN ISNULL(CAMPO_BD, '''') = '''' THEN ''F'' + CAST (DFW.ID_DOC_FEC AS NVARCHAR(5)) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                   ELSE CAMPO_BD ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                 END )  AS CAMPO_BD ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        FROM   DOCS_FEC_WORKERS AS DFW ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               INNER JOIN TRANSPORT T ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       ON DFW.RUT = T.PATENTE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       ' + @FILTRO_PATENTE + ' ' + @FILTRO_EMPRESA + ' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               INNER JOIN DOCS_FEC DF ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       ON DF.ID_DOC_FEC = DFW.ID_DOC_FEC ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               LEFT OUTER JOIN CTRLVEHICULO CV ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                            ON')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('								T.PATENTE = CV.PATENTE AND')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('								CV.FECHAIN >= ''' + @PERIODO_DESDE + ''' AND')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('								CV.DIVISION = ''' + @DIVISION + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        WHERE  DF.COMUN = 1 ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        GROUP  BY RUT, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  T.EMPRESA, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  DFW.ID_DOC_FEC, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  CAMPO_BD) AS FECHAS ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       PIVOT (MAX(FECHA) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('             FOR CAMPO_BD IN (' + @CAMPOS_FEC + ') ) AS PIVOTFECHA ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       INNER JOIN (SELECT DT.PATENTE AS PATENTE2, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          CANTIDAD, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          CAMPO, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          T.MODELO, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          T.ANOFAB, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          T.MARCA, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          T.TIPO, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          E.ACRONIMO, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          TT.DSCTIPOV, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          CV.FECHAIN, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          CV.HORAIN, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          TD.AUTOR, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          T.FECHAMOD, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          T.HORAMOD, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          TD.DIVISION, ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          (SELECT TOP 1 DURACION ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                           FROM   TYPETRANS_DIV TD2 ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                           WHERE  TD2.TIPO = T.TIPO ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  AND TD2.DIVISION = ''' + @DIVISION + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  AND TD2.ACTIVO = ''SI'') AS DURACION ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                   FROM   DOCS_TRANSPORT AS DT ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          INNER JOIN TRANSPORT T ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ON DT.PATENTE = T.PATENTE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ' + @FILTRO_PATENTE + ' ' + @FILTRO_EMPRESA + ' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          INNER JOIN DOCS D ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ON DT.ID_DOC = D.ID_DOC ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          INNER JOIN ENTERPRISE E ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ON T.EMPRESA = E.IDEMPRESA ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          INNER JOIN TYPETRANS TT ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ON T.TIPO = TT.IDTIPO ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ' + @FILTRO_TIPO + ' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          LEFT OUTER JOIN CTRLVEHICULO CV ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       ON T.PATENTE = CV.PATENTE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                          AND CV.FECHAIN >= ''' + @PERIODO_DESDE + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                          AND CV.DIVISION = ''' + @DIVISION + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          INNER JOIN TRANSPORT_DIVISION TD ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                  ON T.PATENTE = TD.PATENTE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     AND TD.DIVISION = ''' + @DIVISION + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                   WHERE  ( DT.DIVISION = ( CASE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                              WHEN D.COMUN_DIV = ''SI'' THEN DT.DIVISION ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                              ELSE ''' + @DIVISION + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                            END ) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                             OR ISNULL(DT.DIVISION, ''AA'') = (')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('																CASE ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('																	WHEN D.COMUN_DIV = ''SI'' THEN DT.DIVISION ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('																	ELSE ''AA'' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('																END ) ) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                          AND DT.VALIDADO = ''SI'') AS DOCSVEH ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                  PIVOT (SUM(CANTIDAD) ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FOR CAMPO IN (' + @CAMPOS_DOC + ') ) AS PIVOTDOCS ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               ON PIVOTFECHA.PATENTE = PIVOTDOCS.PATENTE2 ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('WHERE  ISNULL(FECHAIN, '''') >= ''' + @PERIODO_DESDE + ''' ')) + ' '
	SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('ORDER  BY PIVOTFECHA.PATENTE '))

	EXEC(@SQL1)
END
