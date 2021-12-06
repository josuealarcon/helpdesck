CREATE PROCEDURE [dbo].[V4MVC_LOTEPASESFUN_SELECT_PASES_CTTA]
(
  @IDPASE		INT
 ,@DIVCOD		NVARCHAR(4) = ''
 ,@ID_EMPRESA	NVARCHAR(10)
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
		SS.RUT AS RUTLOTE,
		SS.NOMBRES AS NOMBRESLT,
		SS.APELLIDOS AS APELLIDOSLT,
		SS.EMPRESA_FUNC,
		COALESCE(
					(
						SELECT
							TOP 1
							E.ACRONIMO
						FROM ENTERPRISE E
						WHERE E.IDEMPRESA = SS.EMPRESA_FUNC
					), ''
				 ) AS NOMBRE_EMPRESA_FUNC,
		SS.AUTOR,
		SS.PUEDE_PEDIR_PASE,
		SS.CUENTA_VISITAS,
		SS.CONDUCE_TXT,
		SS.CONDUCE,
		SS.HOTEL,
		SS.HOTEL_TXT,
		SS.CASINOLT,
		SS.CASINO,
		SS.SINOLT,
		SS.PERIODO,
		SS.LIMITEPASESV,
		SS.EXAMEN,
		SS.CERTT,
		(CASE 
			WHEN SS.EXAMEN = 'SI' THEN (
										CASE
										WHEN @COMUN = 'SI' THEN COALESCE((
																			SELECT
																				TOP 1
																				DW3.VALIDADO
																			FROM DOCS_WORKERS DW3
																			WHERE
																				(DW3.RUT = SS.RUT) AND
																				(DW3.ID_DOC IN (@ID_DOC_52)) AND
																				(DW3.DIVISION = @DIVCOD)
																			ORDER BY DW3.ID_DOCS_WORKERS DESC
																			), '')
										WHEN @COMUN = 'NO' THEN COALESCE((
																			SELECT
																				TOP 1
																				DW4.VALIDADO
																			FROM DOCS_WORKERS DW4
																			WHERE
																				(DW4.RUT = SS.RUT) AND
																				(DW4.ID_DOC IN (@ID_DOC_52)) AND
																				(DW4.DIVISION = @DIVCOD) AND
																				(DW4.EMPRESA = @ID_EMPRESA)
																			ORDER BY DW4.ID_DOCS_WORKERS DESC
																			), '')
										ELSE '' END
									)
			ELSE 'NO' END) AS VALIDADO,
		SS.PASES_ACTIVOS,
		SS.COMUN,
		SS.EMPRESA_FINIQ,
		COALESCE(
					(
						SELECT
							TOP 1
							E2.ACRONIMO
						FROM ENTERPRISE E2
						WHERE E2.IDEMPRESA = SS.EMPRESA_FINIQ
					), '') AS NOMBRE_EMPRESA_FINIQ,
		SS.EMPRESA_NOMINA,
		COALESCE(
					(
						SELECT
							TOP 1
							E3.ACRONIMO
						FROM ENTERPRISE E3
						WHERE E3.IDEMPRESA = SS.EMPRESA_NOMINA
					), '') AS NOMBRE_EMPRESA_NOMINA,
		SS.EMPRESA_NOMINA,
		COALESCE(
					(
						SELECT
							TOP 1
							E4.ACRONIMO
						FROM ENTERPRISE E4
						WHERE E4.IDEMPRESA = SS.EMPRESA_NOMINA
					), '') AS NOMBRE_EMPRESA_FINIQ_NOMINA,		
		SS.SEXO AS SEXOLT,
		SS.FECNACIM,
		SS.CODCATEGORIA AS IDCATEGORIACTTA,
		SS.CODSUBCATEGORIA AS IDSUBCATEGORIACCTTA,
		COALESCE(
			(
				SELECT
					TOP 1
					C3.CATEGORIA
				FROM CATEGORIACONTRATISTA C3
				WHERE C3.Id = SS.CODCATEGORIA
			), '') AS CATEGORIA_TXT,
		COALESCE(
			(
				SELECT
					TOP 1
					S2.CATEGORIA
				FROM SUB_CATEGORIACONTRATISTA S2
				WHERE S2.Id = SS.CODSUBCATEGORIA
			), '') AS SUBCATEGORIA_TXT
	FROM
	(
		SELECT
			LPF.RUTLOTE AS RUT,
			ISNULL(LPF.NOMBRESLT, '') AS NOMBRES,
			ISNULL(LPF.APELLIDOSLT, '') AS APELLIDOS,
			ISNULL(LPF.EMPRESALT, '') AS EMPRESA_FUNC,
			ISNULL(LPF.SINOLT, '') AS AUTOR,
			(CASE 
				WHEN LPF.SINOLT = 'XX' THEN 0
				ELSE 1 END) AS PUEDE_PEDIR_PASE,
			(CASE
				WHEN @TIPO_PASE = 'VISITA' THEN (
												  CASE 
													WHEN @DIVCOD = '' THEN (
																			CASE 
																				WHEN @MAX_NUM_VISITAS > -1 THEN
																										   (
																											SELECT COUNT(LPF1.RUTLOTE)
																											FROM LOTEPASESFUN LPF1
																											INNER JOIN LOTEPASES LP1 
																												ON LPF1.NLOTEPROC = LP1.LOTENUM
																											WHERE
																												(LPF1.TIPORUT = 'FUNCIONARIO') AND
																												(LPF1.SINOLT = 'SI') AND
																												(LPF1.TIPOLT = N'VISITA' OR LPF1.TIPOLT = N'VISITATEC') AND
																												(LP1.LOTEESTADO = 'SI') AND
																												(LPF1.RUTLOTE = LPF.RUTLOTE) AND
																												(LP1.LOTEFINICIO LIKE @FILTRO_VISITA_PERIODO + '%') AND
																												(ISNULL(LPF1.UTILIZOLT, 'SI') = 'SI')
																											GROUP BY LPF1.RUTLOTE
																											)
																				ELSE -1 END
																			)
													ELSE (
															CASE 
																WHEN @MAX_NUM_VISITAS > -1 THEN
																						   (
																							SELECT COUNT(LPF2.RUTLOTE)
																							FROM LOTEPASESFUN LPF2
																							INNER JOIN LOTEPASES LP2 
																								ON LPF2.NLOTEPROC = LP2.LOTENUM
																							WHERE
																								(LPF2.TIPORUT = 'FUNCIONARIO') AND
																								(LPF2.SINOLT = 'SI') AND
																								(LPF2.TIPOLT = N'VISITA' OR LPF2.TIPOLT = N'VISITATEC') AND
																								(LP2.LOTEESTADO = 'SI') AND
																								(LPF2.RUTLOTE = LPF.RUTLOTE) AND
																								(LP2.LOTEFINICIO LIKE @FILTRO_VISITA_PERIODO + '%') AND
																								(LP2.DIVISION = @DIVCOD) AND (ISNULL(LPF2.UTILIZOLT, 'SI') = 'SI')
																							GROUP BY LPF2.RUTLOTE 						
																							)
																ELSE -1 END
													) END)
				  ELSE -1 END
			) AS CUENTA_VISITAS,
			(CASE WHEN LPF.LICONDLT IS NULL OR LPF.LICONDLT = 'NO' THEN 0 ELSE 1 END) AS CONDUCE,
			ISNULL(LPF.LICONDLT, 'NO') AS CONDUCE_TXT,
			ISNULL(LPF.ALOJAMIENTOLT, 'NO') AS HOTEL_TXT,
			(CASE WHEN LPF.ALOJAMIENTOLT IS NULL OR LPF.ALOJAMIENTOLT = 'NO' THEN 0 ELSE 1 END) AS HOTEL,
			'SI' AS CASINOLT,
			1 AS CASINO,
			'SI' AS SINOLT,
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
															DW1.RUT = LPF.RUTLOTE) THEN
																				   [dbo].[V4MVC_FGET_FECHA_ES_VIGENTE](
																								[dbo].[V4MVC_FGET_FECHA_WORKER_LOCAL](
																														@ID_DOC_FEC,
																														LPF.RUTLOTE,
																														@DIVCOD,
																														@ID_EMPRESA,
																														0),
																								@CURR_FECHA)
											ELSE 'NO' END
											)
				WHEN @COMUN = 'NO' THEN ( CASE
											WHEN EXISTS(
														SELECT
															TOP 1
															DW2.RUT
														FROM DOCS_WORKERS DW2
														WHERE
															DW2.RUT = LPF.RUTLOTE AND
															DW2.EMPRESA = @ID_EMPRESA) THEN
																					   [dbo].[V4MVC_FGET_FECHA_ES_VIGENTE](
																								[dbo].[V4MVC_FGET_FECHA_WORKER_LOCAL](
																														@ID_DOC_FEC,
																														LPF.RUTLOTE,
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
				   (WL.RUT = LPF.RUTLOTE) AND
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
					WL1.EMPRESA
				FROM WORKERSLOCAL WL1
				WHERE
					(dbo.hoy(GETDATE()) BETWEEN WL1.FINIPASE AND WL1.FFINPASE) AND
					(WL1.AUTOR IN ('SI','NO')) AND
					(WL1.RUT = LPF.RUTLOTE) AND
					(WL1.DIVISION = @DIVCOD)
			), 'SinEmpresa') AS EMPRESA_FINIQ,
			(CASE 
				WHEN ISNULL(LPF.SEXOLT, '') = '' THEN (SELECT W1.SEXO FROM WORKERS W1 WHERE W1.RUT = LPF.RUTLOTE)
				ELSE LPF.SEXOLT END) AS SEXO,
			(CASE
				WHEN LPF.FNACIMLT = '19000101' OR LPF.FNACIMLT IS NULL THEN (
																			CASE
																				WHEN (
																						SELECT
																							TOP 1
																							W2.FECHNACIM
																						FROM WORKERS W2
																						WHERE W2.RUT = LPF.RUTLOTE) = '19000101' THEN ''
																				ELSE ISNULL(
																							(
																							  SELECT
																								TOP 1
																								W3.FECHNACIM
																							  FROM WORKERS W3
																							  WHERE W3.RUT = LPF.RUTLOTE
																							 ), '') END
																			 )
				ELSE ISNULL(LPF.FNACIMLT, '') END) AS FECNACIM,
			LPF.CODCATEGORIA,
			LPF.CODSUBCATEGORIA,
			COALESCE(
			 (
				SELECT 
					TOP 1
					WL3.EMPRESA
				FROM WORKERSLOCAL WL3
				WHERE
					(dbo.hoy(GETDATE()) BETWEEN WL3.FINIPASE AND WL3.FFINPASE) AND
					(WL3.AUTOR IN ('SI','NO')) AND
					(WL3.RUT = LPF.RUTLOTE) AND
					(WL3.EMPRESA = @ID_EMPRESA)
				ORDER BY WL3.LOTE DESC
			 ), '') AS EMPRESA_NOMINA,
			 [dbo].[fn_WL_Certificado](LPF.RUTLOTE, @ID_EMPRESA, @TIPO_PASE, @DIVCOD, @CURR_FECHA) AS CERTT

		FROM LOTEPASESFUN LPF
		WHERE
			LPF.NLOTEPROC = @IDPASE AND
			LPF.TIPORUT = 'FUNCIONARIO'
		ORDER BY LPF.RUTLOTE ASC
		OFFSET 0 ROWS
	) SS
END


