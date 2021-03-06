CREATE PROCEDURE [dbo].[V4MVC_CAL_TURNO_SELECT_CALENDARIO_TURNOS_CTTA]
(
  @IDTURNO			INT				= NULL 
, @IDEMPRESA		NVARCHAR(11)	= NULL 
, @TURNO			NVARCHAR(20)    = NULL 
, @ANIO				NVARCHAR(4)		= NULL 
, @MES				NVARCHAR(2)		= NULL 
)AS

BEGIN

	DECLARE @PRIMER_DIA_MES				NVARCHAR(8)		= @ANIO	+ @MES + '01'
	DECLARE @FORMATO_PRIMER_DIA			NVARCHAR(10)	= @ANIO+'-'+@MES+'-'+'01'
	DECLARE @ULTIMO_DIA_MES				DATETIME		= (SELECT EOMONTH(@FORMATO_PRIMER_DIA))
	DECLARE @FECHA_FIN					NVARCHAR(8)
	DECLARE @FECHAINI_MENOS_DIAS		DATETIME
	DECLARE @FECHAFIN_MAS_DIAS			DATETIME

	SET @FECHA_FIN = (SELECT CONVERT(NVARCHAR(8),@ULTIMO_DIA_MES,112))

	SET @FECHAINI_MENOS_DIAS = (SELECT DATEADD(DAY,-3,@PRIMER_DIA_MES))
	SET @FECHAFIN_MAS_DIAS = (SELECT DATEADD(DAY,3,@FECHA_FIN))

	IF EXISTS (SELECT ID_CALTURNO FROM CAL_TURNO WHERE IDTURNO = @IDTURNO AND EMPRESA = @IDEMPRESA)
		BEGIN 
			SELECT CASE WHEN TIPO = 'D' THEN 'D' WHEN TIPO = 'N' THEN 'N' ELSE ''  END AS TIPO  
			, FECHA , CASE WHEN TIPO = 'D' THEN '#FFCC00' WHEN TIPO = 'N' THEN '#000000' ELSE '' END AS COLOR  
			FROM CAL_TURNO WHERE IDTURNO = @IDTURNO AND EMPRESA = @IDEMPRESA AND FECHA BETWEEN @FECHAINI_MENOS_DIAS AND @FECHAFIN_MAS_DIAS ORDER BY FECHA;
		END 
	ELSE 
		BEGIN 
			SELECT CASE WHEN TIPO = 'D' THEN 'D' WHEN TIPO = 'N' THEN 'N' ELSE ''  END AS TIPO  
			, FECHA , CASE WHEN TIPO = 'D' THEN '#FFCC00' WHEN TIPO = 'N' THEN '#000000' ELSE '' END AS COLOR  
			FROM CAL_TURNO WHERE TURNO = @TURNO AND EMPRESA = @IDEMPRESA AND FECHA BETWEEN @FECHAINI_MENOS_DIAS AND @FECHAFIN_MAS_DIAS AND IDTURNO IS NULL ORDER BY FECHA; 
	END 
END
