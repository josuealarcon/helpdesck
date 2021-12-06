CREATE PROCEDURE [dbo].[V4MVC_A056_FORM301_INSERT_CONTROLLABORAL_CTTA]
(
  @PERIODO			NVARCHAR(6)
 ,@EMPRESA			NVARCHAR(10)
 ,@DIVISION			NVARCHAR(4)
 ,@OST				NVARCHAR(50)
 ,@USUARIO			NVARCHAR(10)
 ,@CLAVE			NVARCHAR(50)
 ,@REGION			NVARCHAR(5)
 ,@INSPECCION		NVARCHAR(4)
 ,@ANIO				INT
 ,@CERTIFICADO		BIGINT
 ,@PERIODO_INI		NVARCHAR(6)
 ,@PERIODO_FIN		NVARCHAR(6)
 ,@TRA_DECL			INT
 ,@TRA_DESV			INT
 ,@TRA_VIGE			INT
 ,@COT_PAG			NVARCHAR(1)
 ,@COT_NPAG			NVARCHAR(1)
 ,@ADJ_NOM			NVARCHAR(1)
 ,@IND_AP_P			INT
 ,@IND_AP_MTO		INT
 ,@IND_AP_NP		INT
 ,@IND_AS_P			INT
 ,@IND_AS_MTO		INT
 ,@IND_AS_NP		INT
 ,@TIPO				NVARCHAR(10)
 ,@ID_CERTIFICADO	INT
 ,@RET_CODE			INT OUTPUT
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	SET @RET_CODE = -1

	IF(EXISTS(
			SELECT
				REGION
			FROM A056_FORM301
			WHERE
				EMPRESA = @EMPRESA AND
				DIVISION = @DIVISION AND
				OST = @OST AND
				PERIODO = @PERIODO
	))
		BEGIN
			SET @RET_CODE = 1  /*ERROR LOGICO; YA EXISTE*/
			RETURN
		END
	
	INSERT INTO  A056_FORM301
				(
					EMPRESA,
					CLAVE,
					REGION,
					INSPECCION,
					ANIO,
					CERTIFICADO,
					PERIODO_INI,
					PERIODO_FIN,
					TRA_DECL,
					TRA_DESV,
					TRA_VIGE,
					COT_PAG,
					COT_NPAG,
					ADJ_NOM,
					IND_AP_P,
					IND_AP_MTO,
					IND_AP_NP,
					IND_AS_P,
					IND_AS_MTO,
					IND_AS_NP,
					FECHAMOD,
					HORAMOD,
					QUIEN,
					VALIDADO,
					PERIODO,
					OST,
					TIPO, 
					DIVISION
				)
				VALUES
				(
					@EMPRESA,
					@CLAVE,
					@REGION,
					@INSPECCION,
					@ANIO,
					@CERTIFICADO,
					@PERIODO_INI,
					@PERIODO_FIN,
					@TRA_DECL,
					@TRA_DESV,
					@TRA_VIGE,
					@COT_PAG,
					@COT_NPAG,
					IIF(@ADJ_NOM = 'S', 'N', 'S'),
					@IND_AP_P,
					@IND_AP_MTO,
					@IND_AP_NP,
					@IND_AS_P,
					@IND_AS_MTO,
					@IND_AS_NP,
					@CURR_FECHA,
					@CURR_TIEMPOFULL,
					@EMPRESA,
					'NO',
					@PERIODO,
					@OST,
					@TIPO,
					@DIVISION
				)

		IF(@ID_CERTIFICADO = 0)
			BEGIN
				SELECT
					TOP 1
					@ID_CERTIFICADO = ID_CERTIFICADO
				FROM A056_FORM301
				WHERE
					(EMPRESA = @EMPRESA) AND
					(DIVISION = @DIVISION) AND
					(OST = @OST) AND
					(PERIODO = @PERIODO)
			END

		DELETE
		FROM A056_FORM301_DET
		WHERE
			(EMPRESA = @EMPRESA) AND
			(ID_CERTIFICADO = @ID_CERTIFICADO)

END
