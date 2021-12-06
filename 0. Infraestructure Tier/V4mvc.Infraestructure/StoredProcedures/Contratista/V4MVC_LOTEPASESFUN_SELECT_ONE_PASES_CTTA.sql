CREATE PROCEDURE [dbo].[V4MVC_LOTEPASESFUN_SELECT_ONE_PASES_CTTA]
(
  @OST			    NVARCHAR(10)
 ,@TIPO             INT
 ,@CONT_DOTACION	INT
 ,@LOTENUM			INT
 ,@FEC_INI			NVARCHAR(8)
 ,@FEC_FIN			NVARCHAR(8)
 ,@RET				BIT OUTPUT
) AS 
BEGIN
	DECLARE @DOTALOJA INT = 0
	DECLARE @OST_EXISTS BIT = 0
	DECLARE @DOTACION_ESPO_ACCESO INT = -1
	DECLARE @DOTACION_PERM_ACCESO INT = -1
	DECLARE @DOTACION_ESPO_ACCESO_MESES INT = -1
	DECLARE @CODIGO NVARCHAR(20) = ''
	DECLARE @RUTLOTE NVARCHAR(10)
	DECLARE @OSTLT NVARCHAR(14)
	DECLARE @CANT INT = 0
	DECLARE @CANT_ACTUAL INT = 0

	SET @RET = 1

	IF(@CONT_DOTACION >= 0)
		BEGIN

			SELECT
				@OST_EXISTS = 1,
				@DOTACION_ESPO_ACCESO = DOTACION_ESPO_ACCESO,
				@DOTACION_PERM_ACCESO = DOTACION_PERM_ACCESO,
				@DOTACION_ESPO_ACCESO_MESES = DOTACION_ESPO_ACCESO_MESES
			FROM OST
			WHERE NROOST = @OST
	
			IF(@OST_EXISTS = 1)
				BEGIN
					SELECT
						@CODIGO = CODIGO
					FROM SUB_CATEGORIACONTRATISTA
					WHERE
						ACTIVO = 'SI' AND
						Id = @TIPO

					IF(@CODIGO <> '')
						BEGIN
							IF(@CODIGO = 'P')
								BEGIN
									SET @DOTALOJA = @DOTACION_PERM_ACCESO 
								END
							ELSE IF(@CODIGO = 'E')
								BEGIN
									SET @DOTALOJA = @DOTACION_ESPO_ACCESO
								END
							ELSE IF(@CODIGO = 'EM')
								BEGIN
									SET @DOTALOJA = @DOTACION_ESPO_ACCESO_MESES
								END
						END

			END

			DECLARE cursor_pases CURSOR
			FOR SELECT
					L.RUTLOTE, L.OSTLT
				FROM LOTEPASESFUN L
				INNER JOIN LOTEPASES LP
					ON LP.LOTENUM = L.NLOTEPROC
				WHERE
					L.OSTLT = @OST AND 
					LP.LOTEFINICIO <= @FEC_FIN AND
					LP.LOTEFFINAL >= @FEC_INI AND
					L.SINOLT NOT IN ('BL','NO') AND
					L.CODSUBCATEGORIA = @TIPO AND
					L.TIPORUT = 'FUNCIONARIO'
					AND LP.LOTENUM <> @LOTENUM

			OPEN cursor_pases

			FETCH NEXT FROM cursor_pases INTO 
				@RUTLOTE, 
				@OSTLT

			WHILE @@FETCH_STATUS = 0
				BEGIN
					SET @CANT = @CANT + 1
					IF(EXISTS(
						SELECT *
						FROM WORKERSLOCAL WL
						INNER JOIN WORKERSCATEGORIA WR
							ON WR.RUT = WL.RUT AND WR.DIVISION = WL.DIVISION
						WHERE
							WR.RUT = @RUTLOTE AND
							WL.FINIPASE <= @FEC_FIN AND
							WL.FFINPASE >= @FEC_FIN AND
							WL.OST = @OSTLT AND
							WR.CODSUBCATEGORIA = @TIPO AND
							(WL.AUTOR = 'BL' OR WL.AUTOR = 'XX')
							))
						BEGIN
							SET @CANT = @CANT - 1
						END

					FETCH NEXT FROM cursor_pases INTO 
						@RUTLOTE, 
						@OSTLT
				END

			CLOSE cursor_pases

			DEALLOCATE cursor_pases

			SET @CANT_ACTUAL = @CONT_DOTACION + @CANT

			IF(@DOTALOJA >= @CANT_ACTUAL)
				BEGIN
					SET @RET = 1
				END
			ELSE
				BEGIN
					SET @RET = 0
				END
		END
END


