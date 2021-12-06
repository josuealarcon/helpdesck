CREATE PROCEDURE [dbo].[V4MVC_WORKERSLOCAL_SELECT_IFECHAFUNCDIVISIONOST_INFORMES_CTTA]
(
  @DIVISION				NVARCHAR(4)
 ,@EMPRESA				NVARCHAR(10)
 ,@OST					NVARCHAR(14)
 ,@ESTADO				NVARCHAR(2) = '' /*CERT*/
 ,@CAMPOS_REPORT		NVARCHAR(500) OUTPUT
 ,@CAMPOS_CONDUCCION	NVARCHAR(500) OUTPUT
 ,@CAMPOS_DOC			NVARCHAR(500) OUTPUT
 ,@CAMPOS_FEC			NVARCHAR(500) OUTPUT
) AS
BEGIN
	DECLARE @HOY NVARCHAR(8) = dbo.hoy(getdate())
	DECLARE @CAMPOS_PVT_DOC		NVARCHAR(500) = ''
	DECLARE @CAMPOS_PVT_FEC		NVARCHAR(500) = ''
	DECLARE @CAMPOS				NVARCHAR(500)
	
	DECLARE @SQL1 NVARCHAR(MAX) = ''

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


	SET @CAMPOS_REPORT = ''
	SET @CAMPOS_CONDUCCION = ''
	SET @CAMPOS_DOC = ''
	SET @CAMPOS_FEC = ''


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
	FROM DOCS_TIPOPASE AS DT
	INNER JOIN DOCS AS D
		ON DT.ID_DOC = D.ID_DOC
	LEFT OUTER JOIN DOCS_FEC AS DF
		ON D.ID_DOC = DF.ID_DOC_DEPEND AND (DF.ACTIVO = N'SI')
	LEFT OUTER JOIN DOCS_FEC_TIPOPASE AS DFT
		ON DF.ID_DOC_FEC = DFT.ID_DOC_FEC AND (DFT.DIVISION =  @DIVISION)
	WHERE
		(D.ACTIVO = N'SI') AND
		(D.ID_TIPO_PROPIETARIO = 1) AND
		(DFT.TIPOPASE = N'TRABAJO' OR D.ID_DOC=64 OR D.ID_DOC = 62)  AND
		(DT.DIVISION =  @DIVISION) AND
		(DT.TIPOPASE = N'TRABAJO' OR DT.TIPOPASE = N'OPCIONAL')
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
					IF(@CRS_CAMPO_BD IS NOT NULL)
						BEGIN
							SET @CAMPOS_REPORT = @CAMPOS_REPORT + ',' + @CRS_CAMPO_BD

							IF(@CRS_ID_DOC_OPCION = 1)
								BEGIN
									SET @CAMPOS_CONDUCCION = @CAMPOS_CONDUCCION + ',' + @CRS_CAMPO_BD
								END
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
		DISTINCT D.CAMPO
	FROM DOCS D
	INNER JOIN DOCS_TIPOPASE DT
		ON D.ID_DOC = DT.ID_DOC
	WHERE 
		((DT.TIPOPASE = 'TRABAJO') OR (DT.TIPOPASE = 'OPCIONAL')) AND
		(DT.DIVISION = @DIVISION) AND
		(D.ACTIVO = 'SI') AND
		(D.ID_TIPO_PROPIETARIO = 1 )
	ORDER BY D.CAMPO 
	
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
		DISTINCT DF.CAMPO_BD
	FROM  DOCS_FEC DF
	INNER JOIN DOCS_FEC_TIPOPASE DFT
		ON DF.ID_DOC_FEC = DFT.ID_DOC_FEC
	WHERE
		(DFT.TIPOPASE = 'TRABAJO') AND
		(DFT.DIVISION = @DIVISION)
	ORDER BY DF.CAMPO_BD 
	
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

	SET @CAMPOS_PVT_DOC = '[SIN]'

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
									(D.ID_TIPO_PROPIETARIO = 1)
								FOR XML PATH('')
							), 1, 1, ''
					)
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_PVT_DOC = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_PVT_DOC = '[SIN]'
		END

	/************/
	
	SET @CAMPOS = NULL

	SET @CAMPOS_PVT_FEC = '[SIN]'

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
									(DOCS_FEC_TIPOPASE.DIVISION = @DIVISION)
							FOR XML PATH('')
						), 1, 1, ''
				) 
	
	IF(@CAMPOS IS NOT NULL)
		BEGIN
			SET @CAMPOS_PVT_FEC = '[' + REPLACE(@CAMPOS, ',', '], [') + ']'
		END
	ELSE
		BEGIN
			SET @CAMPOS_PVT_FEC = '[SIN]'
		END

	/************/
	--PRINT('@DIVISION:' + @DIVISION)
	--PRINT('@EMPRESA:' + @EMPRESA)
	--PRINT('@ESTADO:' + @ESTADO)
	--PRINT('@OST:' + @OST)
	--PRINT('@CAMPOS_PVT_DOC:' + @CAMPOS_PVT_DOC)
	--PRINT('@CAMPOS_PVT_FEC:' + @CAMPOS_PVT_FEC)
	
	--PRINT('@CAMPOS_REPORT:' + @CAMPOS_REPORT)
	--PRINT('@CAMPOS_CONDUCCION:' + @CAMPOS_CONDUCCION)
	--PRINT('@CAMPOS_DOC:' + @CAMPOS_DOC)
	--PRINT('@CAMPOS_FEC:' + @CAMPOS_FEC)

	/************/

	IF(@ESTADO = 'BL')
		BEGIN
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('SELECT TABLITA.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       W.ROL, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       COALESCE((SELECT TOP 1 [dbo].[fn_WL_Conductor] (W.RUT, ''' + @DIVISION + ''', ''' + @HOY + ''') FROM TAB_TIPOPASE_DIVISION), -1) AS CERT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('FROM   (SELECT WL.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               DOCS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               FECHAS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               ISNULL((SELECT TOP 1 LPF.LICONDLT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       FROM   LOTEPASESFUN AS LPF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              INNER JOIN LOTEPASES AS LP ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                      ON LPF.NLOTEPROC = LP.LOTENUM ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                       WHERE  ( LPF.SINOLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              AND ( LP.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              AND ( LPF.RUTLOTE = WL.RUT ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              AND ( LPF.LICONDLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              AND ''' + @HOY + ''' BETWEEN LOTEFINICIO AND LOTEFFINAL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      ), ''NO'') ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               AS PASECONDUC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        FROM   VW_WL_BLOQ WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   (SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               INNER JOIN VW_WL_BLOQ WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                       ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          AND ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               WL.EMPRESA = F.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          AND ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        WHERE  F.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                                    WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                                    ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                                  END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( ( F.COMUN = 0 AND F.TIPOPASE = ''TRABAJO'' ) OR ( F.TIPOPASE = ''OPCIONAL'' AND F.ID_DOC = 62 ) ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               INNER JOIN VW_WL_BLOQ WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                       ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          AND ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('    AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                                    WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                                    ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                                  END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND F.COMUN = 1 ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( F.TIPOPASE = ''TRABAJO'' OR F.ID_DOC = 62 )) PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       PIVOT ( COUNT(ID_DOC) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                             FOR [CAMPO] IN (' + @CAMPOS_PVT_DOC + ') ) AS p) AS DOCS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                            ON WL.RUT = DOCS.RUTD ')) + ' '

			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   (SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               INNER JOIN VW_WL_BLOQ WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                       ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('															 AND D.EMPRESA = WL.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        WHERE  D.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( DCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( DFCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                        D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               INNER JOIN VW_WL_BLOQ WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                       ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('															 AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                        WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( DCOMUN = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               AND ( DFCOMUN IN( 1, 0 ) )) AS PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                             FOR [CAMPO_BD] IN (' + @CAMPOS_PVT_FEC + ') ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AS p) AS FECHAS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                            ON WL.RUT = FECHAS.RUTF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('        WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' AND WL.OST= ''' + @OST + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               AND WL.DIVISION = ''' + @DIVISION + ''') AS TABLITA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       INNER JOIN WORKERS W ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               ON W.RUT = TABLITA.RUT '))
		END
	ELSE IF(@ESTADO = 'SI')
		BEGIN
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('SELECT WL.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       DOCS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       FECHAS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       ISNULL((SELECT TOP 1 LPF.LICONDLT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               FROM   LOTEPASESFUN AS LPF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      INNER JOIN LOTEPASES AS LP ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              ON LPF.NLOTEPROC = LP.LOTENUM ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               WHERE  ( LPF.SINOLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LP.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LPF.RUTLOTE = WL.RUT ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LPF.LICONDLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ''' + @HOY + ''' BETWEEN LOTEFINICIO AND LOTEFFINAL) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       , ''NO'') ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AS PASECONDUC, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       COALESCE((SELECT TOP 1 [dbo].[fn_WL_Conductor] (WL.RUT, ''' + @DIVISION + ''', ''' + @HOY + ''') FROM TAB_TIPOPASE_DIVISION), -1) AS CERT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('FROM   VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                         AND WL.EMPRESA = F.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  F.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND WL.VALIDADO = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( ( F.COMUN = 0 AND F.TIPOPASE = ''TRABAJO'' ) OR ( F.TIPOPASE = ''OPCIONAL'' AND F.ID_DOC = 62 ) ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND WL.VALIDADO = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.DIVISION = ( CASE')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('															WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.COMUN = 1 ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( F.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                              OR F.ID_DOC = 62 )) PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                               PIVOT ( COUNT(ID_DOC) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO] IN (' + @CAMPOS_PVT_DOC + ') ) AS p) AS DOCS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                    ON WL.RUT = DOCS.RUTD ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('      FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.EMPRESA = WL.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  D.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND WL.VALIDADO = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DFCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND WL.VALIDADO = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DCOMUN = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DFCOMUN IN( 1, 0 ) )) AS PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                               PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO_BD] IN (' + @CAMPOS_PVT_FEC + ') ) AS p) AS FECHAS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                    ON WL.RUT = FECHAS.RUTF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' AND WL.OST= ''' + @OST + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AND WL.VALIDADO = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AND WL.AUTOR = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AND WL.DIVISION = ''' + @DIVISION + ''' '))
		END
	ELSE IF(@ESTADO = 'NO')
		BEGIN
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('SELECT WL.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       DOCS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       FECHAS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       ISNULL((SELECT TOP 1 LPF.LICONDLT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               FROM   LOTEPASESFUN AS LPF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      INNER JOIN LOTEPASES AS LP ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              ON LPF.NLOTEPROC = LP.LOTENUM ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               WHERE  ( LPF.SINOLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LP.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LPF.RUTLOTE = WL.RUT ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LPF.LICONDLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ''' + @HOY + ''' BETWEEN LOTEFINICIO AND LOTEFFINAL) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       , ''NO'') ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AS PASECONDUC, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       COALESCE((SELECT TOP 1 [dbo].[fn_WL_Conductor] (WL.RUT, ''' + @DIVISION + ''', ''' + @HOY + ''') FROM TAB_TIPOPASE_DIVISION), -1) AS CERT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('FROM   VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.EMPRESA = F.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  F.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( ( F.COMUN = 0 AND F.TIPOPASE = ''TRABAJO'' ) OR ( F.TIPOPASE = ''OPCIONAL'' AND F.ID_DOC = 62 ) ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('  INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.COMUN = 1 ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( F.TIPOPASE = ''TRABAJO'' OR F.ID_DOC = 62 )) PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                               PIVOT ( COUNT(ID_DOC) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO] IN (' + @CAMPOS_PVT_DOC + ') ) AS p) AS DOCS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                    ON WL.RUT = DOCS.RUTD ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.EMPRESA = WL.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  D.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DFCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DCOMUN = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DFCOMUN IN( 1, 0 ) )) AS PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                               PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO_BD] IN (' + @CAMPOS_PVT_FEC + ') ) AS p) AS FECHAS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                    ON WL.RUT = FECHAS.RUTF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' AND WL.OST= ''' + @OST + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AND WL.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AND WL.VALIDADO = ''NO'' ')) + ' '
		END
	ELSE /* @ESTADO = '' */
		BEGIN
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('SELECT WL.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       DOCS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       FECHAS.*, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       ISNULL((SELECT TOP 1 LPF.LICONDLT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               FROM   LOTEPASESFUN AS LPF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      INNER JOIN LOTEPASES AS LP ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                              ON LPF.NLOTEPROC = LP.LOTENUM ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('               WHERE  ( LPF.SINOLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LP.DIVISION = ''' + @DIVISION + ''' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LPF.RUTLOTE = WL.RUT ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ( LPF.LICONDLT = ''SI'' ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                      AND ''' + @HOY + ''' BETWEEN LOTEFINICIO AND LOTEFFINAL) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       , ''NO'') ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AS PASECONDUC, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       COALESCE((SELECT TOP 1 [dbo].[fn_WL_Conductor] (WL.RUT, ''' + @DIVISION + ''', ''' + @HOY + ''') FROM TAB_TIPOPASE_DIVISION), -1) AS CERT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('FROM   VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.EMPRESA = F.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  F.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            WHEN ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                           F.COMUN_DIV = ''SI'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( ( F.COMUN = 0 AND F.TIPOPASE = ''TRABAJO'' ) OR ( F.TIPOPASE = ''OPCIONAL'' AND F.ID_DOC = 62 ) ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                SELECT DISTINCT F.RUT AS RUTD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.CAMPO, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                F.ID_DOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_DOC_EMP F ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = F.RUTDOC ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND WL.DIVISION = F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.DIVISION = ( CASE ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            WHEN F.COMUN_DIV = ''SI'' THEN F.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                            ELSE ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                          END ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND F.COMUN = 1 ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( F.TIPOPASE = ''TRABAJO'' OR F.ID_DOC = 62 )) PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                               PIVOT ( COUNT(ID_DOC) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO] IN (' + @CAMPOS_PVT_DOC + ') ) AS p) AS DOCS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                    ON WL.RUT = DOCS.RUTD ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       LEFT OUTER JOIN (SELECT * ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                        FROM   (SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.EMPRESA = WL.EMPRESA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  D.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DFCOMUN = 0 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                UNION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                SELECT DISTINCT D.CAMPO_BD, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.RUT AS RUTF, ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                D.FECHA ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                FROM   VW_FEC_DIV AS D ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       INNER JOIN VW_WL_NOMINA WL ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                               ON WL.RUT = D.RUT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                                  AND D.DIVISION = WL.DIVISION ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.DIVISION = ''' + @DIVISION + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND D.TIPOPASE = ''TRABAJO'' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( D.ID_TIPO_PROPIETARIO = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DCOMUN = 1 ) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                       AND ( DFCOMUN IN( 1, 0 ) )) AS PVT ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                               PIVOT ( MAX(FECHA) ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                                     FOR [CAMPO_BD] IN (' + @CAMPOS_PVT_FEC + ') ) AS p) AS FECHAS ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('                    ON WL.RUT = FECHAS.RUTF ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('WHERE  WL.EMPRESA = ''' + @EMPRESA + ''' AND WL.OST= ''' + @OST + ''' ')) + ' '
			SET @SQL1 = @SQL1 + ' ' + LTRIM(RTRIM('       AND WL.DIVISION = ''' + @DIVISION + ''' ')) + ' '
		END

	EXEC(@SQL1)

END
