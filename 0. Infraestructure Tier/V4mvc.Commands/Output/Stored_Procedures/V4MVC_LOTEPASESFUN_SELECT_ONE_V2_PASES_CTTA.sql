CREATE PROCEDURE [dbo].[V4MVC_LOTEPASESFUN_SELECT_ONE_V2_PASES_CTTA]
(
  @OST			    NVARCHAR(14)
 ,@CONT_RUT_HOTEL	INT
 ,@LOTENUM			INT
 ,@FEC_INI			NVARCHAR(8)
 ,@FEC_FIN			NVARCHAR(8)
 ,@ESALIDA			INT OUTPUT
 ,@RET				BIT OUTPUT
) AS 
BEGIN
	DECLARE @DOTALOJA INT = 0
	DECLARE @CANT INT = 0
	DECLARE @CANT_ACTUAL INT = 0
	DECLARE @ALOJA NVARCHAR(2) = 'NO'
	DECLARE @RUTLOTE NVARCHAR(10)
	DECLARE @OSTLT NVARCHAR(14)
	DECLARE @LOTE INT = 0
	
	SET @RET = 1
	SET @ESALIDA = -1

	IF(@CONT_RUT_HOTEL >= 0)
		BEGIN
			SELECT
				TOP 1
				@ALOJA = ALOJA,
				@DOTALOJA = DOTALOJA
			FROM OST
			WHERE NROOST = @OST 

			IF(@ALOJA = 'SI' AND @DOTALOJA <> 0)
				BEGIN
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
							L.ALOJAMIENTOLT ='SI' AND
							L.SINOLT NOT IN ('BL','NO') AND
							L.TIPORUT = 'FUNCIONARIO' AND
							LP.LOTENUM <> @LOTENUM

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
								WHERE
									WL.RUT = @RUTLOTE AND
									WL.FINIPASE <= @FEC_FIN AND
									WL.FFINPASE >= @FEC_FIN AND
									WL.OST = @OSTLT AND
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

					IF(@CANT <= @DOTALOJA)
						BEGIN
							SET @LOTE = @CANT
						END
					ELSE
						BEGIN
							SET @LOTE = @CANT
						END

					IF(@ALOJA = 'NO')
						BEGIN
							SET @RET = 0
							SET @ESALIDA = 0
							/*El contrato no tiene ninguna dotacion asignada*/
						END
					ELSE
						BEGIN
							SET @CANT_ACTUAL = @CONT_RUT_HOTEL + @LOTE
							IF(@DOTALOJA < @CANT_ACTUAL)
								BEGIN
									SET @RET = 0
									SET @ESALIDA = 1
									/*Usted supero la dotacion de Hoteleria*/
								END
						END
				END
		END
END


