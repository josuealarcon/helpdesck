CREATE PROCEDURE [dbo].[V4MVC_TURNO_SELECT_ONE_DISPUTA_TURNOS_CTTA]
(
  @ID_TURNO INT = NULL
, @ID_DISPUTA INT = NULL
) AS 
BEGIN
	DECLARE @EMPRESA NVARCHAR(20) = ''
	DECLARE @TURNO NVARCHAR(20) = ''
	DECLARE @OST NVARCHAR(14) = ''
	DECLARE @DIATRABAJO INT = 0
	DECLARE @DIADESCANSO INT = 0
	DECLARE @CLASETUR NVARCHAR(14) = ''
	DECLARE @ID UNIQUEIDENTIFIER = NULL
	DECLARE @VALIDADO NVARCHAR(2) = ''
	DECLARE @OBS_RECHAZO NVARCHAR(MAX) = ''
	DECLARE @OBSERVACION_REVAL NVARCHAR(1000) = ''
	DECLARE @ESTADO NVARCHAR(2) = ''
	DECLARE @OBSERVACION NVARCHAR(1000) = ''
	DECLARE @IDTURNO INT = -1
	DECLARE @ACRONIMO NVARCHAR(50) = ''
	DECLARE @NUEVA BIT = 1

	IF(@ID_DISPUTA < 0)
		BEGIN
			SET @IDTURNO = @ID_TURNO
			SELECT 
				@EMPRESA = T.EMPRESA,
				@ACRONIMO = COALESCE((SELECT TOP 1 E.ACRONIMO FROM ENTERPRISE E WHERE E.IDEMPRESA = T.EMPRESA), ''),
				@TURNO = T.TURNO,
				@OST = T.OST,
				@DIATRABAJO = T.DIATRABAJO,
				@DIADESCANSO = T.DIADESCANSO,
				@CLASETUR = T.CLASETUR,
				@ID = T.ID,
				@VALIDADO = T.VALIDADO,
				@OBS_RECHAZO = T.OBS_RECHAZO
			FROM TURNOS T
			WHERE T.IDTURNO = @ID_TURNO
		END
	ELSE
		BEGIN
			SELECT 
				@EMPRESA = T.EMPRESA,
				@ACRONIMO = COALESCE((SELECT TOP 1 E.ACRONIMO FROM ENTERPRISE E WHERE E.IDEMPRESA = T.EMPRESA), ''),
				@TURNO = T.TURNO,
				@OST = T.OST,
				@DIATRABAJO = T.DIATRABAJO,
				@DIADESCANSO = T.DIADESCANSO,
				@CLASETUR = T.CLASETUR,
				@ID = TD.ID,
				@VALIDADO = T.VALIDADO,
				@OBS_RECHAZO = T.OBS_RECHAZO,
				@OBSERVACION_REVAL = TD.OBSERVACION_REVAL,
				@ESTADO = TD.ESTADO,
				@OBSERVACION = TD.OBSERVACION,
				@IDTURNO = T.IDTURNO,
				@NUEVA = 0
			FROM TURNOS_DISPUTA TD
			INNER JOIN TURNOS T
				ON TD.IDTURNO = T.IDTURNO
			WHERE TD.ID_DISPUTA = @ID_DISPUTA
		END
	
	SELECT
		@EMPRESA AS EMPRESA,
		@ACRONIMO AS ACRONIMO,
		@TURNO AS TURNO,
		@OST AS OST,
		@DIATRABAJO AS DIATRABAJO,
		@DIADESCANSO AS DIADESCANSO,
		@CLASETUR AS CLASETUR,
		@ID AS ID,
		@VALIDADO AS VALIDADO,
		@OBS_RECHAZO AS OBS_RECHAZO,
		@OBSERVACION_REVAL AS OBSERVACION_REVAL,
		@ESTADO AS ESTADO,
		@OBSERVACION AS OBSERVACION,
		@IDTURNO AS IDTURNO,
		@NUEVA AS NUEVA
END
/****** Object:  StoredProcedure [dbo].[V4MVC_TURNO_DISPUTA_INSERT_TURNOS_CTTA]    Script Date: 1/11/2020 16:20:02 ******/
SET ANSI_NULLS ON
