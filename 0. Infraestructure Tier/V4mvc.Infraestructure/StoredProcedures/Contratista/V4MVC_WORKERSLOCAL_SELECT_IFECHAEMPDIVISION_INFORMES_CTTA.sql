CREATE PROCEDURE [dbo].[V4MVC_WORKERSLOCAL_SELECT_IFECHAEMPDIVISION_INFORMES_CTTA]
(
  @DIVISION				NVARCHAR(4)
 ,@EMPRESA				NVARCHAR(10)
 ,@ESTADO				NVARCHAR(2) = '' /*CERT*/
 ,@TEMP					NVARCHAR(1) = ''
 ,@CAMPOS_REPORT		NVARCHAR(500) OUTPUT
 ,@CAMPOS_CONDUCCION	NVARCHAR(500) OUTPUT
 ,@CAMPOS_DOC			NVARCHAR(500) OUTPUT
 ,@CAMPOS_FEC			NVARCHAR(500) OUTPUT
) AS
BEGIN
	DECLARE @HOY NVARCHAR(8) = dbo.hoy(getdate())
	DECLARE @ACRONIMO			NVARCHAR(50)
	DECLARE @CAMPOS_NCOM		NVARCHAR(500) = ''
	DECLARE @CAMPOS_COM			NVARCHAR(500) = ''
	DECLARE @CAMPOS_FEC_NCOM	NVARCHAR(500) = ''
	DECLARE @CAMPOS_FEC_COM		NVARCHAR(500) = ''
	DECLARE @CAMPOS_DCFEC_COM	NVARCHAR(500) = ''
	DECLARE @STR_ESTADO			NVARCHAR(100) = ''
	DECLARE @STR_CERT			NVARCHAR(100) = ''
	DECLARE @CAMPOS				NVARCHAR(500)
	DECLARE @VALIDADO			NVARCHAR(2)
	
	DECLARE @SQL1 NVARCHAR(MAX) = ''
	DECLARE @SQL2 NVARCHAR(MAX) = ''
	DECLARE @SQL3 NVARCHAR(MAX) = ''
	DECLARE @SQL4 NVARCHAR(MAX) = ''
	DECLARE @SQL5 NVARCHAR(MAX) = ''
	DECLARE @SQL6 NVARCHAR(MAX) = ''

	DECLARE @CRS_CAMPO NVARCHAR(30)
	DECLARE @CRS_CAMPO_BD NVARCHAR(30)
	DECLARE @CRS_ID_DOC_FEC INT
	DECLARE @CRS_ID_DOC INT
	DECLARE @CRS_TIPOPASE NVARCHAR(9)
	DECLARE @CRS_SUBEDOC NVARCHAR(2)
	DECLARE @CRS_TIPOPASEDOC NVARCHAR(9)
	DECLARE @CRS_ID_DOC_OPCION INT

	DECLARE @DISTINTO_C BIT
	DECLARE @TXT_CAMPOC NVARCHAR(50)

	SET @STR_ESTADO = ''
	SET @STR_CERT = ''
	SET @VALIDADO = NULL

	SET @CAMPOS_REPORT = ''
	SET @CAMPOS_CONDUCCION = ''
	SET @CAMPOS_DOC = ''
	SET @CAMPOS_FEC = ''

	IF(@ESTADO = 'SI')
		BEGIN
			SET @STR_ESTADO = ' AND WL.VALIDADO = ''SI'' '
			SET @STR_CERT = ' AND WL.AUTOR IN (''SI'',''NO'') '
			SET @VALIDADO = 'SI'
		END
	ELSE IF(@ESTADO = 'NO')
		BEGIN
			SET @STR_ESTADO = ' AND WL.VALIDADO = ''NO'' '
			SET @STR_CERT = ' AND WL.AUTOR IN (''SI'',''NO'') '
			SET @VALIDADO = 'NO'
		END
	ELSE IF(@ESTADO = 'BL')
		BEGIN
			SET @STR_CERT = ' AND WL.AUTOR = ''BL'' '
		END

	/**********[STR_CAMPOS]***************/

	DECLARE cursorCampos CURSOR
		FOR
	SELECT
		D.CAMPO,
		DF.CAMPO_BD,
		DF.ID_DOC_FEC,
		D.ID_DOC,
		DFT.TIPOPASE,
		D.SUBEDOC,
		DT.TIPOPASE AS TIPOPASEDOC,
		D.ID_DOC_OPCION
	FROM  DOCS_TIPOPASE AS DT
	INNER JOIN DOCS D
		ON DT.ID_DOC = D.ID_DOC
	LEFT OUTER JOIN DOCS_FEC DF
	INNER JOIN DOCS_FEC_TIPOPASE DFT
		ON DF.ID_DOC_FEC = DFT.ID_DOC_FEC
		ON D.ID_DOC = DF.ID_DOC_DEPEND
	WHERE
		(DF.ACTIVO = 'SI' OR D.ID_DOC = 62) AND
		(D.ACTIVO = 'SI' OR D.ID_DOC = 62) AND
		(D.ID_TIPO_PROPIETARIO = 1 OR D.ID_DOC = 62) AND
		(DF.VALIDO_MAYOR_HOY = 1 OR D.ID_DOC = 62) AND
		(DFT.TIPOPASE = 'TRABAJO' OR D.ID_DOC = 62) AND
		(DFT.DIVISION =  @DIVISION OR D.ID_DOC = 62) AND
		(DT.DIVISION =  @DIVISION) AND
		(DT.TIPOPASE = 'TRABAJO' OR DT.TIPOPASE = 'OPCIONAL' OR D.ID_DOC = 62)
	ORDER BY D.ORDEN ASC,  DF.ORDEN ASC
	
	OPEN cursorCampos

	FETCH NEXT FROM cursorCampos INTO 
		@CRS_CAMPO,
		@CRS_CAMPO_BD,
		@CRS_ID_DOC_FEC,
		@CRS_ID_DOC,
		@CRS_TIPOPASE,
		@CRS_SUBEDOC,
		@CRS_TIPOPASEDOC,
		@CRS_ID_DOC_OPCION

	SET @DISTINTO_C = 1
	SET @TXT_CAMPOC = ''

	WHILE @@FETCH_STATUS = 0
		BEGIN
			
			IF(@TXT_CAMPOC <> @CRS_CAMPO)
				BEGIN
					SET @DISTINTO_C = 1
				END
			ELSE
				BEGIN
					SET @DISTINTO_C = 0
				END

			SET @TXT_CAMPOC =  @CRS_CAMPO

			IF((@DISTINTO_C = 1 AND @CRS_SUBEDOC = 'SI' AND @CRS_TIPOPASEDOC = 'TRABAJO') OR (@CRS_ID_DOC = '62'))
				BEGIN

					SET @CAMPOS_REPORT = @CAMPOS_REPORT + ',' + @CRS_CAMPO

					IF(@CRS_ID_DOC_OPCION = 1)
						BEGIN
							SET @CAMPOS_CONDUCCION = @CAMPOS_CONDUCCION + ',' + @CRS_CAMPO
						END

					IF(@CRS_CAMPO_BD IS NOT NULL)
						BEGIN
							SET @CAMPOS_REPORT = @CAMPOS_REPORT + ',' + @CRS_CAMPO_BD

							IF(@CRS_ID_DOC_OPCION = 1)
								BEGIN
									SET @CAMPOS_CONDUCCION = @CAMPOS_CONDUCCION + ',' + @CRS_CAMPO_BD
								END
						END

				END
			ELSE
				BEGIN
					SET @CAMPOS_REPORT = @CAMPOS_REPORT + ',' + @CRS_CAMPO_BD

					IF(@CRS_ID_DOC_OPCION = 1)
						BEGIN
							SET @CAMPOS_CONDUCCION = @CAMPOS_CONDUCCION + ',' + @CRS_CAMPO_BD
						END
				END


			
			FETCH NEXT FROM cursorCampos INTO 
				@CRS_CAMPO,
				@CRS_CAMPO_BD,
				@CRS_ID_DOC_FEC,
				@CRS_ID_DOC,
				@CRS_TIPOPASE,
				@CRS_SUBEDOC,
				@CRS_TIPOPASEDOC,
				@CRS_ID_DOC_OPCION
		END

	CLOSE cursorCampos

	DEALLOCATE cursorCampos

	DECLARE cursorDocs CURSOR
		FOR
	SELECT
		D.CAMPO
	FROM DOCS D
	INNER JOIN DOCS_TIPOPASE DT
		ON D.ID_DOC = DT.ID_DOC
	WHERE (
				(DT.TIPOPASE = 'TRABAJO') OR
				(DT.TIPOPASE = 'OPCIONAL')
		  ) AND
		  (DT.DIVISION = @DIVISION) AND
		  (D.ACTIVO = 'SI') AND
		  (D.ID_TIPO_PROPIETARIO = 1 )
	ORDER BY CAMPO 
	
	OPEN cursorDocs

	FETCH NEXT FROM cursorDocs INTO 
		@CRS_CAMPO

	WHILE @@FETCH_STATUS = 0
		BEGIN
			
			SET @CAMPOS_DOC = @CAMPOS_DOC + ',' + @CRS_CAMPO		
			
			FETCH NEXT FROM cursorDocs INTO 
				@CRS_CAMPO
		END

	CLOSE cursorDocs

	DEALLOCATE cursorDocs


	DECLARE cursorFecs CURSOR
		FOR
	SELECT
		DF.CAMPO_BD
	FROM  DOCS_FEC DF
	INNER JOIN DOCS_FEC_TIPOPASE DFT
		ON DF.ID_DOC_FEC = DFT.ID_DOC_FEC
	WHERE
		(DFT.TIPOPASE = 'TRABAJO') AND
		(DFT.DIVISION = @DIVISION) AND
		(DF.VALIDO_MAYOR_HOY = 1)
	ORDER BY CAMPO_BD 
	
	OPEN cursorFecs

	FETCH NEXT FROM cursorFecs INTO 
		@CRS_CAMPO

	WHILE @@FETCH_STATUS = 0
		BEGIN
			
			SET @CAMPOS_FEC = @CAMPOS_FEC + ',' + @CRS_CAMPO		
			
			FETCH NEXT FROM cursorFecs INTO 
				@CRS_CAMPO
		END

	CLOSE cursorFecs

	DEALLOCATE cursorFecs

	/**********[CAMPOS]*********/
	
	SET @CAMPOS = NULL

	SET @CAMPOS_NCOM = '[SIN]'

	SET @CAMPOS = STUFF(
							(
								SELECT
									DISTINCT
										',' + D.CAMPO
								FROM DOCS D
								INNER JOIN	DOCS_TIPOPASE DT
									ON D.ID_DOC = DT.ID_DOC
								WHERE
									(DT.TIPOPASE = 'TRABAJO') AND
									(DT.DIVISION = @DIVISION) AND
									(D.ACTIVO = 'SI') AND
									(D.SUBEDOC = 'SI') AND
									(D.ID_TIPO_PROPIETARIO = 1) AND
									(D.COMUN = 0)
								FOR XML PATH('')
							), 1, 1, ''
					)
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_NCOM = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_NCOM = '[SIN]'
		END

	/************/

	SET @CAMPOS = NULL

	SET @CAMPOS_COM = '[SIN]'

	SET @CAMPOS = STUFF(
							(
								SELECT
									DISTINCT
										',' + D.CAMPO
								FROM DOCS D
								INNER JOIN	DOCS_TIPOPASE DT
									ON D.ID_DOC = DT.ID_DOC
								WHERE
									(DT.TIPOPASE = 'TRABAJO' OR (DT.TIPOPASE = 'OPCIONAL' AND D.ID_DOC = 62)) AND
									(DT.DIVISION = @DIVISION) AND
									(D.ACTIVO = 'SI') AND
									(D.SUBEDOC = 'SI') AND
									(D.ID_TIPO_PROPIETARIO = 1) AND
									(D.COMUN = 1)
								FOR XML PATH('')
							), 1, 1, ''
					)
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_COM = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_COM = '[SIN]'
		END

	/************/
	
	SET @CAMPOS = NULL

	SET @CAMPOS_FEC_NCOM = '[SIN]'

	SET @CAMPOS = STUFF(
						(
							SELECT
								DISTINCT
									',' + DOCS_FEC.CAMPO_BD
								FROM DOCS D
								INNER JOIN DOCS_TIPOPASE DT
									ON D.ID_DOC = DT.ID_DOC
								INNER JOIN DOCS_FEC
									ON DT.ID_DOC = DOCS_FEC.ID_DOC_DEPEND
								INNER JOIN DOCS_FEC_TIPOPASE
									ON DOCS_FEC.ID_DOC_FEC = DOCS_FEC_TIPOPASE.ID_DOC_FEC
								WHERE
									(D.ID_TIPO_PROPIETARIO = 1) AND
									(D.ACTIVO = 'SI') AND
									(DT.DIVISION = @DIVISION) AND
									(DOCS_FEC_TIPOPASE.DIVISION = @DIVISION) AND
									(D.COMUN = 0) AND
									(DOCS_FEC.COMUN = 0) 
							FOR XML PATH('')
						), 1, 1, ''
				) 
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_FEC_NCOM = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_FEC_NCOM = '[SIN]'
		END

	/************/

	SET @CAMPOS = NULL

	SET @CAMPOS_FEC_COM = '[SIN]'
				
	SET @CAMPOS = STUFF(
						(
							SELECT
								DISTINCT
									',' + DOCS_FEC.CAMPO_BD
								FROM DOCS D
								INNER JOIN DOCS_TIPOPASE DT
									ON D.ID_DOC = DT.ID_DOC
								INNER JOIN DOCS_FEC
									ON DT.ID_DOC = DOCS_FEC.ID_DOC_DEPEND
								INNER JOIN DOCS_FEC_TIPOPASE
									ON DOCS_FEC.ID_DOC_FEC = DOCS_FEC_TIPOPASE.ID_DOC_FEC
								WHERE
									(D.ID_TIPO_PROPIETARIO = 1) AND
									(D.ACTIVO = 'SI') AND
									(DT.DIVISION = @DIVISION) AND
									(DOCS_FEC_TIPOPASE.DIVISION = @DIVISION) AND
									(D.COMUN = 1) AND
									(DOCS_FEC.COMUN = 0)
							FOR XML PATH('')
						), 1, 1, ''
				)
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_FEC_COM = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_FEC_COM = '[SIN]'
		END
	/************/

	SET @CAMPOS = NULL

	SET @CAMPOS_DCFEC_COM = '[SIN]'

	SET @CAMPOS = STUFF(
						(
							SELECT
								DISTINCT
									',' + DOCS_FEC.CAMPO_BD
								FROM DOCS D
								INNER JOIN DOCS_TIPOPASE DT
									ON D.ID_DOC = DT.ID_DOC
								INNER JOIN DOCS_FEC
									ON DT.ID_DOC = DOCS_FEC.ID_DOC_DEPEND
								INNER JOIN DOCS_FEC_TIPOPASE
									ON DOCS_FEC.ID_DOC_FEC = DOCS_FEC_TIPOPASE.ID_DOC_FEC
								WHERE
									(D.ID_TIPO_PROPIETARIO = 1) AND
									(D.ACTIVO = 'SI') AND
									(DT.DIVISION = @DIVISION) AND
									(DOCS_FEC_TIPOPASE.DIVISION = @DIVISION) AND
									(D.COMUN = 1) AND
									(DOCS_FEC.COMUN = 1)
							FOR XML PATH('')
						), 1, 1, ''
				)
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_DCFEC_COM = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_DCFEC_COM = '[SIN]'
		END

	/************/

	DECLARE crsCabecera CURSOR FOR
		SELECT
			WL.EMPRESA,
			ACRONIMO
		FROM
			WORKERSLOCAL WL,
			ENTERPRISE
		WHERE
			DIVISION = @DIVISION AND
			WL.EMPRESA = IDEMPRESA AND
			WL.EMPRESA = @EMPRESA AND
			(
				(@TEMP = 'C' AND (EMPRESA NOT IN (SELECT MA7.MANDANTE FROM A027_MANDANTES AS MA7 WHERE MA7.ACTIVO = 'SI'))) OR
				(@TEMP = 'M' AND (EMPRESA  IN (SELECT MA7.MANDANTE FROM A027_MANDANTES AS MA7 WHERE MA7.ACTIVO = 'SI'))) OR
				(@TEMP = '')
				
			) AND
			(@VALIDADO IS NULL OR (WL.VALIDADO = @VALIDADO)) AND
			WL.AUTOR IN ('SI','NO')
		GROUP BY WL.EMPRESA, ACRONIMO
		ORDER BY ACRONIMO
	
	OPEN crsCabecera

	FETCH NEXT FROM crsCabecera
	INTO @EMPRESA, @ACRONIMO

	WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @SQL1 = ''
			SET @SQL2 = ''
			SET @SQL3 = ''
			SET @SQL4 = ''
			SET @SQL5 = ''
			SET @SQL6 = ''
			
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('SELECT DISTINCT TOP 100 WL.RUT, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        ''' + @EMPRESA + ''' AS EMPRESA, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        ''' + @ACRONIMO + ''' AS ACRONIMO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        WD.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        WDC.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        DFW.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        DFWC.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        DCFWC.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        W.NOMBRES, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        W.APELLIDOS, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        ISNULL((SELECT TOP 1 LPF.LICONDLT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   LOTEPASESFUN AS LPF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN LOTEPASES AS LP ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON LPF.NLOTEPROC = LP.LOTENUM ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  ( LPF.SINOLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( LP.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( LPF.RUTLOTE = W.RUT ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( LPF.LICONDLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ''' + @HOY + ''' BETWEEN ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                           LOTEFINICIO AND LOTEFFINAL), ''NO'') ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        AS PASECONDUC, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        WL.VALIDADO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        WL.CONDUCTOR ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('FROM   WORKERSLOCAL AS WL ')) + ' '

			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT DW.RUT AS RUTDOC, ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                D.CAMPO, ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                DW.ID_DOC ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                FROM   DOCS AS D ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_TIPOPASE AS DT ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DT.ID_DOC ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_WORKERS AS DW ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DW.ID_DOC ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       INNER JOIN WORKERSLOCAL AS WL ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                               ON DW.RUT = WL.RUT ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                  AND WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                  AND DT.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                  AND ''' + @HOY + ''' BETWEEN ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                      WL.FINIPASE AND ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                      WL.FFINPASE ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                  AND AUTOR IN ( ''SI'', ''NO'' ) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                                  AND DT.TIPOPASE = WL.TIPOPASE ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                WHERE  ( DT.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                          OR D.ID_DOC = 62 ) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                          ' + @STR_ESTADO)) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       AND ( DT.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       AND ( D.ACTIVO = ''SI'' ) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       AND ( D.SUBEDOC = ''SI'' ) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       AND ( DW.EMPRESA = ''' + @EMPRESA + ''' ) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                       AND ( D.COMUN = 0 )) PVT ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                               PIVOT ( COUNT(ID_DOC) ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO] IN (' + @CAMPOS_NCOM +') ) AS P) AS WD ')) + ' '
			SET @SQL2 = @SQL2 + ' ' + LTRIM(RTRIM('                    ON WD.RUTDOC = WL.RUT ')) + ' '

			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT DW.RUT AS RUTDOC_COM, ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                D.CAMPO, ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                DW.ID_DOC ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                FROM   DOCS AS D ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_TIPOPASE AS DT ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DT.ID_DOC ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_WORKERS AS DW ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DW.ID_DOC ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       INNER JOIN WORKERSLOCAL AS WL ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                               ON DW.RUT = WL.RUT ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                  AND WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                  AND DT.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                  AND ''' + @HOY + ''' BETWEEN ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                      WL.FINIPASE AND ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                      WL.FFINPASE ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                  AND AUTOR IN ( ''SI'', ''NO'' ) ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                                  AND DT.TIPOPASE = WL.TIPOPASE ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                WHERE  ( DT.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                          OR D.ID_DOC = 62 ) ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                          ' + @STR_ESTADO)) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       AND ( DT.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       AND ( D.ACTIVO = ''SI'' ) ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       AND ( D.SUBEDOC = ''SI'' ) ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                       AND ( D.COMUN = 1 )) PVT ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                               PIVOT ( COUNT(ID_DOC) ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO] IN (' + @CAMPOS_COM +') ) AS P) AS WDC ')) + ' '
			SET @SQL3 = @SQL3 + ' ' + LTRIM(RTRIM('              ON WDC.RUTDOC_COM = WL.RUT ')) + ' '

			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DOCS_FEC.CAMPO_BD, ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       DFW.RUT AS RUTDFW, ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       DFW.FECHA ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                FROM   DOCS AS D ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_TIPOPASE AS DT ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DT.ID_DOC ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                               ON DT.ID_DOC = ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC.ID_DOC_DEPEND ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC_TIPOPASE ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                               ON DOCS_FEC.ID_DOC_FEC = ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC_TIPOPASE.ID_DOC_FEC ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC_WORKERS AS DFW ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                               ON DFW.ID_DOC_FEC = ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC.ID_DOC_FEC ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND DFW.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND DFW.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       INNER JOIN WORKERSLOCAL AS WL ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                               ON DFW.RUT = WL.RUT ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND DFW.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND ''' + @HOY + ''' BETWEEN ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                      WL.FINIPASE AND ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                      WL.FFINPASE ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND AUTOR IN ( ''SI'', ''NO'' ) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                  AND DOCS_FEC_TIPOPASE.TIPOPASE ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                      = ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                                      WL.TIPOPASE ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                WHERE  ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       AND ( D.ACTIVO = N''SI'' ) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       AND ( DT.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       AND ( DOCS_FEC_TIPOPASE.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       AND ( D.COMUN = 0 ) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                          ' + @STR_ESTADO)) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                       AND ( DOCS_FEC.COMUN = 0 )) AS PVT ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                               PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO_BD] IN (' + @CAMPOS_FEC_NCOM +') ) AS P) AS ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                       DFW ')) + ' '
			SET @SQL4 = @SQL4 + ' ' + LTRIM(RTRIM('                    ON DFW.RUTDFW = WL.RUT ')) + ' '

			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DOCS_FEC.CAMPO_BD, ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       DFW.RUT AS RUT_DFWC, ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       DFW.FECHA ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                FROM   DOCS AS D ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_TIPOPASE AS DT ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DT.ID_DOC ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                               ON DT.ID_DOC = ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC.ID_DOC_DEPEND ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC_TIPOPASE ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                               ON DOCS_FEC.ID_DOC_FEC = ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC_TIPOPASE.ID_DOC_FEC ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC_WORKERS AS DFW ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                               ON DFW.ID_DOC_FEC = ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC.ID_DOC_FEC ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  AND DFW.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       INNER JOIN WORKERSLOCAL AS WL ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                               ON DFW.RUT = WL.RUT ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  AND WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  AND DFW.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  AND ''' + @HOY + ''' BETWEEN ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                      WL.FINIPASE AND ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                      WL.FFINPASE ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                  AND AUTOR IN ( ''SI'', ''NO'' ) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('              AND DOCS_FEC_TIPOPASE.TIPOPASE ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                      = ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                      WL.TIPOPASE ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                WHERE  ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                          ' + @STR_ESTADO)) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       AND ( D.ACTIVO = N''SI'' ) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       AND ( DT.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       AND ( DOCS_FEC_TIPOPASE.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       AND ( D.COMUN = 1 ) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                       AND ( DOCS_FEC.COMUN = 0 )) AS PVT ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                               PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO_BD] IN (' + @CAMPOS_FEC_COM +') ) AS ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                               p) AS ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                                                           DFWC ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('                    ON DFWC.RUT_DFWC = WL.RUT ')) + ' '
			SET @SQL5 = @SQL5 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '

			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DOCS_FEC.CAMPO_BD, ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       DFW.RUT AS RUTDCFWC, ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       DFW.FECHA ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                FROM   DOCS AS D ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_TIPOPASE AS DT ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                               ON D.ID_DOC = DT.ID_DOC ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                               ON DT.ID_DOC = ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC.ID_DOC_DEPEND ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC_TIPOPASE ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                               ON DOCS_FEC.ID_DOC_FEC = ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC_TIPOPASE.ID_DOC_FEC ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       INNER JOIN DOCS_FEC_WORKERS AS DFW ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                               ON DFW.ID_DOC_FEC = ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  DOCS_FEC.ID_DOC_FEC ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  AND DFW.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       INNER JOIN WORKERSLOCAL AS WL ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                               ON DFW.RUT = WL.RUT ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                 AND WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  AND DFW.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  AND ''' + @HOY + ''' BETWEEN ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                      WL.FINIPASE AND ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                      WL.FFINPASE ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  AND AUTOR IN ( ''SI'', ''NO'' ) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                                  AND DOCS_FEC_TIPOPASE.TIPOPASE = WL.TIPOPASE ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                WHERE  ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       AND ( D.ACTIVO = N''SI'' ) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       AND ( DT.DIVISION = N''LB'' ) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       AND ( DOCS_FEC_TIPOPASE.DIVISION = N''LB'' ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                           ) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       AND ( D.COMUN = 1 ) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                          ' + @STR_ESTADO)) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                       AND ( DOCS_FEC.COMUN = 1 )) AS PVT ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                               PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO_BD] IN (' + @CAMPOS_DCFEC_COM +') ) AS P) AS DCFWC ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('                    ON DCFWC.RUTDCFWC = WL.RUT ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('       INNER JOIN WORKERS AS W ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('               ON W.RUT = WL.RUT ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('       AND WL.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('       AND ''' + @HOY + ''' BETWEEN WL.FINIPASE AND WL.FFINPASE')) + ' '
			SET @SQL6 = @SQL6 + ' ' + LTRIM(RTRIM('       ' + @STR_CERT + ' ' + @STR_ESTADO))
			EXEC(@SQL1 + @SQL2 + @SQL3 + @SQL4 + @SQL5 + @SQL6)
						

			FETCH NEXT FROM crsCabecera
			INTO @EMPRESA, @ACRONIMO
		END
	
	CLOSE crsCabecera
	DEALLOCATE crsCabecera

END
