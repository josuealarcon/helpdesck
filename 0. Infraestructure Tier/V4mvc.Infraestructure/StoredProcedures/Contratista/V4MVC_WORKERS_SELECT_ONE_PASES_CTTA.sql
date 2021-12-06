CREATE PROCEDURE [dbo].[V4MVC_WORKERS_SELECT_ONE_PASES_CTTA]
(
  @RUT			NVARCHAR(10)
 ,@IDPASE		INT
 ,@DIVCOD		NVARCHAR(4) = ''
 ,@ID_EMPRESA	NVARCHAR(10) = ''
 ,@FEC_INI		NVARCHAR(8) = '19000101'
 ,@FEC_FIN		NVARCHAR(8) = '19000101'
 ,@TIPO_PASE	NVARCHAR(20) = ''
) AS 
BEGIN
	DECLARE @MAX_NUM_VISITAS INT = 4
	DECLARE @FILTRO_VISITA_PERIODO NVARCHAR(8) = ''
	DECLARE @TXT_PERIODO NVARCHAR(8) = ''
	DECLARE @MAXIMO_VISITA INT = -1
	DECLARE @ANIO_ACTUAL NVARCHAR(4) = CONVERT(NVARCHAR(4), YEAR(GETDATE()))
	DECLARE @MES_ACTUAL NVARCHAR(2) = FORMAT(GETDATE(),'MM')
	DECLARE @APRUEBA_MEDICO NVARCHAR(2) = ''
	DECLARE @ID_DOC_52 INT = 52
	DECLARE @COMUN NVARCHAR(2) = ''
	DECLARE @ID_DOC_FEC INT = -1
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */

	SELECT
		TOP 1
		@TXT_PERIODO = PERIODOVISITA,
		@MAXIMO_VISITA = CONVERT(INT, CASE 
										WHEN ISNUMERIC(CANTVISITA) = 1 THEN CANTVISITA
										ELSE '-1' END)
	FROM A024_DIVISIONES WHERE DIVCOD = @DIVCOD

	IF(@TXT_PERIODO = 'MENSUAL')
		BEGIN
			SET @FILTRO_VISITA_PERIODO = CONCAT(@ANIO_ACTUAL, @MES_ACTUAL)
		END
	ELSE IF(@TXT_PERIODO = 'ANUAL')
		BEGIN
			SET @FILTRO_VISITA_PERIODO = @ANIO_ACTUAL
		END	

	SELECT
		TOP 1
		@APRUEBA_MEDICO = APRUEBA_MEDICO
	FROM TAB_TIPOPASE
	WHERE TIPOPASE = @TIPO_PASE

	SELECT
		TOP 1
		@ID_DOC_FEC = DF1.ID_DOC_FEC
	FROM DOCS_FEC DF1
	WHERE (DF1.ID_DOC_DEPEND IN (@ID_DOC_52)) AND (DF1.ACTIVO = 'SI')
	ORDER BY DF1.ORDEN

	SELECT
		@COMUN = D.COMUN
	FROM DOCS_FEC AS DF
	INNER JOIN DOCS AS D
		ON DF.ID_DOC_DEPEND = D.ID_DOC 
	WHERE (DF.ID_DOC_FEC = @ID_DOC_FEC)
	/*------------------------------------------------------*/

	SELECT
		SS.RUT,
		SS.NOMBRES,
		SS.APELLIDOS,
		SS.EMPRESA_FUNC,
		COALESCE(
					(
						SELECT
							TOP 1
							E.ACRONIMO
						FROM ENTERPRISE E
						WHERE E.IDEMPRESA = SS.EMPRESA_FUNC
					),
				'') AS NOMBRE_EMPRESA_FUNC,
		SS.AUTOR,
		SS.PUEDE_PEDIR_PASE,
		COALESCE(SS.CUENTA_VISITAS, -1) AS CUENTA_VISITAS,
		SS.CONDUCE,
		IIF(SS.CONDUCE = 1, 'SI', 'NO') AS CONDUCE_TXT,
		SS.HOTEL,
		SS.HOTEL_TXT,
		SS.CASINO,
		SS.CASINO_TXT,
		SS.SINOLT,
		SS.SINOLT_TXT,
		SS.PERIODO,
		SS.LIMITEPASESV,
		SS.EXAMEN,
		SS.PASES_ACTIVOS,
		SS.CERTT,
		(CASE 
			WHEN SS.EXAMEN = 'SI' THEN (
										CASE
										WHEN @COMUN = 'SI' THEN COALESCE(
																			(
																				SELECT TOP 1 DW3.VALIDADO
																				FROM DOCS_WORKERS DW3
																				WHERE (DW3.RUT = SS.RUT) AND 
																						(DW3.ID_DOC IN (@ID_DOC_52)) AND
																						(DW3.DIVISION = @DIVCOD)
																				ORDER BY DW3.ID_DOCS_WORKERS DESC
																			), '')
										WHEN @COMUN = 'NO' THEN COALESCE(
																			(
																				SELECT TOP 1 DW4.VALIDADO
																				FROM DOCS_WORKERS DW4
																				WHERE (DW4.RUT = SS.RUT) AND
																						(DW4.ID_DOC IN (@ID_DOC_52)) AND
																						(DW4.DIVISION = @DIVCOD) AND
																						(DW4.EMPRESA = @ID_EMPRESA)
																				ORDER BY DW4.ID_DOCS_WORKERS DESC
																			), '')
										ELSE '' END
									)
		ELSE 'NO' END) AS VALIDADO,
		SS.COMUN,
		SS.EMPRESA_FINIQ,
		COALESCE(
					(
						SELECT
							TOP 1
							E2.ACRONIMO
						FROM ENTERPRISE E2
						WHERE E2.IDEMPRESA = SS.EMPRESA_FINIQ
					),
				'') AS NOMBRE_EMPRESA_FINIQ,
		SS.EMPRESA_NOMINA,
		COALESCE(
					(
						SELECT
							TOP 1
							E3.ACRONIMO
						FROM ENTERPRISE E3
						WHERE E3.IDEMPRESA = SS.EMPRESA_NOMINA
					),
				'') AS NOMBRE_EMPRESA_NOMINA,
		SS.EMPRESA_NOMINA AS EMPRESA_FINIQ_NOMINA,
		COALESCE(
					(
						SELECT
							TOP 1
							E4.ACRONIMO
						FROM ENTERPRISE E4
						WHERE E4.IDEMPRESA = SS.EMPRESA_NOMINA
					),
				'') AS NOMBRE_EMPRESA_FINIQ_NOMINA,
		SS.SEXO,
		SS.FECNACIM,
		SS.IDCATEGORIACTTA,
		SS.IDSUBCATEGORIACCTTA,
		COALESCE(
			(
				SELECT TOP 1 C3.CATEGORIA
				FROM CATEGORIACONTRATISTA C3
				WHERE C3.Id = SS.IDCATEGORIACTTA
			), '') AS CATEGORIA_TXT,
		COALESCE(
			(
				SELECT TOP 1 S2.CATEGORIA
				FROM SUB_CATEGORIACONTRATISTA S2
				WHERE S2.Id = SS.IDSUBCATEGORIACCTTA
			), '') AS SUBCATEGORIA_TXT
	FROM
	(
		SELECT
			W.RUT AS RUT,
			ISNULL(W.NOMBRES, '') AS NOMBRES,
			ISNULL(W.APELLIDOS, '') AS APELLIDOS,
			COALESCE(
			 (
				SELECT 
					TOP 1 WL1.EMPRESA
				FROM WORKERSLOCAL WL1
				WHERE
					(dbo.hoy(GETDATE()) BETWEEN WL1.FINIPASE AND WL1.FFINPASE) AND
					(WL1.AUTOR IN ('SI','NO')) AND
					(WL1.RUT = W.RUT) AND
					(WL1.DIVISION = @DIVCOD)
			 ),
			ISNULL(W.EMPRESA, '')) AS EMPRESA_FUNC,
			ISNULL(W.AUTOR, '') AS AUTOR,
			(CASE 
				WHEN W.AUTOR = 'XX' THEN 0
				ELSE 1 END) AS PUEDE_PEDIR_PASE,
			(CASE
				 WHEN @TIPO_PASE = 'VISITA' THEN (
												  CASE 
													WHEN @DIVCOD = '' THEN (
																			CASE 
																				WHEN @MAX_NUM_VISITAS > -1 THEN
																											(
																												SELECT
																													COUNT(W1.RUTLOTE)
																												FROM LOTEPASESFUN W1
																												INNER JOIN LOTEPASES LP1 
																													ON W1.NLOTEPROC = LP1.LOTENUM
																												WHERE (W1.TIPORUT = 'FUNCIONARIO') AND
																														(W1.SINOLT = 'SI') AND
																														(W1.TIPOLT = N'VISITA' OR W1.TIPOLT = N'VISITATEC') AND
																														(LP1.LOTEESTADO = 'SI') AND
																														(W1.RUTLOTE = W.RUT) AND
																														(LP1.LOTEFINICIO LIKE @FILTRO_VISITA_PERIODO + '%') AND
																														(ISNULL(W1.UTILIZOLT, 'SI') = 'SI')
																												GROUP BY W1.RUTLOTE
																											)
																				ELSE -1 END
																			)
													ELSE (
															CASE 
																WHEN @MAX_NUM_VISITAS > -1 THEN
																							(
																								SELECT
																									COUNT(W2.RUTLOTE)
																								FROM LOTEPASESFUN W2
																								INNER JOIN LOTEPASES LP2 
																									ON W2.NLOTEPROC = LP2.LOTENUM
																								WHERE (W2.TIPORUT = 'FUNCIONARIO') AND
																										(W2.SINOLT = 'SI') AND
																										(W2.TIPOLT = N'VISITA' OR W2.TIPOLT = N'VISITATEC') AND
																										(LP2.LOTEESTADO = 'SI') AND
																										(W2.RUTLOTE = W.RUT) AND
																										(LP2.LOTEFINICIO LIKE @FILTRO_VISITA_PERIODO + '%') AND
																										(LP2.DIVISION = @DIVCOD) AND (ISNULL(W2.UTILIZOLT, 'SI') = 'SI')
																								GROUP BY W2.RUTLOTE 						
																							)
																ELSE -1 END				
			
													) END)
				  ELSE -1 END
			) AS CUENTA_VISITAS,
			(CASE
				WHEN @DIVCOD = '' THEN IIF(EXISTS(
												SELECT
													TOP 1
													L1.LOTENUM
												FROM LOTEPASES L1
												INNER JOIN LOTEPASESFUN LF1
													ON L1.LOTENUM = LF1.NLOTEPROC
												WHERE (LF1.RUTLOTE = W.RUT) AND
													  (dbo.hoy(GETDATE()) BETWEEN L1.LOTEFINICIO AND L1.LOTEFFINAL) AND
													  (LF1.SINOLT = 'SI') AND
													  (LF1.LICONDLT = 'SI')
												ORDER BY L1.LOTENUM), 1, 0)
				ELSE IIF(EXISTS(
							SELECT
								TOP 1
								L2.LOTENUM
							FROM LOTEPASES L2
							INNER JOIN LOTEPASESFUN LF2
								ON L2.LOTENUM = LF2.NLOTEPROC
							WHERE (L2.DIVISION = @DIVCOD) AND
								  (LF2.RUTLOTE = W.RUT) AND
								  (dbo.hoy(GETDATE()) BETWEEN L2.LOTEFINICIO AND L2.LOTEFFINAL) AND
								  (LF2.SINOLT = 'SI') AND
								  (LF2.LICONDLT = 'SI')
							ORDER BY L2.LOTENUM
						), 1, 0) END) AS CONDUCE,
			'NO' AS HOTEL_TXT,
			0 AS HOTEL,
			1 AS CASINO,
			'SI' AS CASINO_TXT,
			0 AS SINOLT,
			'SI' AS SINOLT_TXT,
			@TXT_PERIODO AS PERIODO,
			@MAXIMO_VISITA AS LIMITEPASESV,
			(CASE 
				WHEN @COMUN = 'SI' THEN ( CASE 
											WHEN EXISTS(
														SELECT
															TOP 1
															DW1.RUT
														FROM DOCS_WORKERS DW1
														WHERE 
														    DW1.RUT = W.RUT AND
															DW1.DIVISION = @DIVCOD AND
															DW1.ID_DOC IN (@ID_DOC_52)
														ORDER BY DW1.FECHA_MOD DESC, DW1.HORA_MOD DESC
														) THEN
														[dbo].[V4MVC_FGET_FECHA_ES_VIGENTE](
																	[dbo].[V4MVC_FGET_FECHA_WORKER_LOCAL](
																					@ID_DOC_FEC,
																					W.RUT,
																					@DIVCOD,
																					@ID_EMPRESA,
																					0),
																	@CURR_FECHA)
											ELSE 'NO' END
											)
				WHEN @COMUN = 'NO' THEN ( CASE
											WHEN EXISTS(
														SELECT TOP 1 DW2.RUT
														FROM DOCS_WORKERS DW2
														WHERE DW2.RUT = W.RUT AND
															DW2.EMPRESA = @ID_EMPRESA AND
															DW2.DIVISION = @DIVCOD AND
															DW2.ID_DOC IN (@ID_DOC_52)
														ORDER BY DW2.FECHA_MOD DESC, DW2.HORA_MOD DESC
												 ) THEN
													[dbo].[V4MVC_FGET_FECHA_ES_VIGENTE](
																[dbo].[V4MVC_FGET_FECHA_WORKER_LOCAL](
																			@ID_DOC_FEC,
																			W.RUT,
																			@DIVCOD,
																			@ID_EMPRESA,
																			0),
																@CURR_FECHA)
											ELSE 'NO' END
											)
				ELSE '' END) AS EXAMEN,
			(
				SELECT
					COUNT(*)
				FROM WORKERSLOCAL WL
				WHERE
					(WL.RUT = W.RUT) AND
				    (WL.AUTOR = 'SI') AND
				    (WL.DIVISION = @DIVCOD) AND
				    (WL.LOTE <> @IDPASE) AND
				    (
					  (@FEC_INI BETWEEN WL.FINIPASE AND WL.FFINPASE) OR
					  (@FEC_FIN BETWEEN WL.FINIPASE AND WL.FFINPASE) OR
					  (@FEC_INI < WL.FINIPASE AND WL.FFINPASE < @FEC_FIN)
					)
			 ) AS PASES_ACTIVOS,
			@COMUN AS COMUN,
			COALESCE(
			 (
				SELECT 
					TOP 1
					WL2.EMPRESA
				FROM WORKERSLOCAL WL2
				WHERE
					(dbo.hoy(GETDATE()) BETWEEN WL2.FINIPASE AND WL2.FFINPASE) AND
					(WL2.AUTOR IN ('SI','NO')) AND
					(WL2.RUT = W.RUT) AND
					(WL2.DIVISION = @DIVCOD)
			 ), '') AS EMPRESA_FINIQ,
			ISNULL(W.SEXO, '') AS SEXO,
			(CASE
				WHEN W.FECHNACIM = '19000101' THEN ''
				ELSE ISNULL(W.FECHNACIM, '') END) AS FECNACIM,
			COALESCE(
					  (
						SELECT
							TOP 1
							C1.ID
						FROM WORKERSCATEGORIA WC1
						LEFT JOIN CATEGORIACONTRATISTA C1
							ON C1.Id = WC1.CODCATEGORIA
						WHERE
							WC1.RUT = W.RUT AND
							WC1.DIVISION = @DIVCOD
					  ), -1) AS IDCATEGORIACTTA,
			COALESCE(
					  (
						SELECT
							TOP 1
							S.Id
						FROM WORKERSCATEGORIA WC2
						LEFT JOIN CATEGORIACONTRATISTA C2
							ON C2.Id = WC2.CODCATEGORIA
						LEFT JOIN SUB_CATEGORIACONTRATISTA S
							ON S.Id = WC2.CODSUBCATEGORIA
						WHERE
							WC2.RUT = W.RUT AND
							WC2.DIVISION = @DIVCOD
					  ), -1) AS IDSUBCATEGORIACCTTA,
			COALESCE(
			 (SELECT 
				TOP 1
				WL3.EMPRESA
			  FROM WORKERSLOCAL WL3
			  WHERE
				(dbo.hoy(GETDATE()) BETWEEN WL3.FINIPASE AND WL3.FFINPASE) AND
				(WL3.AUTOR IN ('SI','NO')) AND
				(WL3.RUT = W.RUT) AND
				(WL3.EMPRESA = @ID_EMPRESA)
			  ORDER BY WL3.LOTE DESC
			 ), '') AS EMPRESA_NOMINA,
		[dbo].[fn_WL_Certificado](@RUT, @ID_EMPRESA, @TIPO_PASE, @DIVCOD, @CURR_FECHA) AS CERTT
		FROM WORKERS W
		WHERE W.RUT = @RUT
	) SS
END


