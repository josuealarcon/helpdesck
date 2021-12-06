CREATE PROCEDURE [dbo].[V4MVC_A056_FORM301_UPDATE_CONTROLLABORAL_CTTA]
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
 ,@ID_CERTIFICADO	INT
 ,@RET_CODE			INT OUTPUT
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	
	SET @RET_CODE = -1

	IF(NOT EXISTS(
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
			SET @RET_CODE = 2  /*ERROR LOGICO; NO EXISTE*/
			RETURN
		END

	UPDATE A056_FORM301
	SET
		REGION = @REGION,
		INSPECCION = @INSPECCION,
		ANIO = @ANIO,
		CERTIFICADO = @CERTIFICADO,
		CLAVE = @CLAVE,
		PERIODO_INI = @PERIODO_INI,
		PERIODO_FIN = @PERIODO_FIN,
		TRA_DECL = @TRA_DECL,
		TRA_DESV = @TRA_DESV,
		TRA_VIGE = @TRA_VIGE,
		COT_PAG = @COT_PAG,
		COT_NPAG = @COT_NPAG,
		ADJ_NOM = IIF(@ADJ_NOM = 'S', 'N', 'S'),
		IND_AP_P = @IND_AP_P,
		IND_AP_MTO = @IND_AP_MTO,
		IND_AP_NP = @IND_AP_NP,
		IND_AS_P = @IND_AS_P,
		IND_AS_MTO = @IND_AS_MTO,
		IND_AS_NP = @IND_AS_NP,
		QUIEN = @EMPRESA,
		VALIDADO = 'NO',
		FECHAMOD = @CURR_FECHA,
		HORAMOD = @CURR_TIEMPOFULL,
		PERIODO = @PERIODO,
		OST = @OST,
		DIVISION = @DIVISION
	WHERE 
		(EMPRESA = @EMPRESA) AND
		(ID_CERTIFICADO = @ID_CERTIFICADO) AND
		(DIVISION = @DIVISION) AND
		(OST = @OST) AND
		(PERIODO = @PERIODO)

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
