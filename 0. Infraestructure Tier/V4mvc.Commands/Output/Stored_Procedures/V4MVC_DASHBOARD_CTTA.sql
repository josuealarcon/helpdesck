CREATE PROCEDURE [dbo].[V4MVC_DASHBOARD_CTTA]
(
 @IDEMPRESA		NVARCHAR(10) = NULL
)
AS
BEGIN

	SET NOCOUNT ON

	CREATE TABLE  #TEMP_WORKERS (          
	RUT			NVARCHAR(10)	COLLATE DATABASE_DEFAULT NOT NULL,     
	DIVCOD		NVARCHAR (4)	COLLATE DATABASE_DEFAULT NOT NULL        
	)  

	CREATE TABLE #WORKERS_DATA (          
	AUTOR		NVARCHAR(2)		COLLATE DATABASE_DEFAULT NOT NULL,
	VALIDADO	NVARCHAR(2)		COLLATE DATABASE_DEFAULT NOT NULL,         
	DIVCOD		NVARCHAR (4)	COLLATE DATABASE_DEFAULT NOT NULL           
	) 

	CREATE TABLE #ACREDITADOS (  
	DIVCOD		NVARCHAR(4)		COLLATE DATABASE_DEFAULT NOT NULL,
	SI			INT 
	)  
  
	CREATE TABLE #NO_ACREDITADOS (   
	DIVCOD		NVARCHAR(4)		COLLATE DATABASE_DEFAULT NOT NULL,
	NO			INT  
	)

	CREATE TABLE #DOCS_PENDIENTES(
	DIVISION	NVARCHAR(40)	COLLATE DATABASE_DEFAULT NOT NULL,
	CANTIDAD	INT
	)

	CREATE TABLE #DATA (
	DIVCOD		NVARCHAR(4) COLLATE DATABASE_DEFAULT NOT NULL,
	SI			INT,
	NO			INT,
	TOTAL		INT,
	PROMEDIO	INT
	)

	DECLARE @CONT_A			INT = 1
	DECLARE @CONT_B			INT = 1
	DECLARE @CONT_C			INT = 1
	DECLARE @VAR_SI			INT = 0
	DECLARE @VAR_NO			INT = 0
	DECLARE @TOTAL			INT = 0
	DECLARE @PROMEDIO		INT = 0 
	DECLARE @VAR_DIV1		NVARCHAR(4)
	DECLARE @VAR_DIV2		NVARCHAR(4)
	DECLARE @VAR_DIV3		NVARCHAR(4)

	IF EXISTS(	SELECT D.DIVISION
				FROM DOCS_WORKERS DW INNER JOIN A024_DIVISIONES D ON D.DIVCOD = DW.DIVISION 
				WHERE DW.EMPRESA = @IDEMPRESA 
				AND DW.VALIDADO = 'NO' 
				AND D.ACTIVO = 'SI' 
				GROUP BY D.DIVISION )
	BEGIN
		INSERT INTO #DOCS_PENDIENTES	
		SELECT D.DIVISION, COUNT(DW.RUT) AS CANTIDAD 
		FROM DOCS_WORKERS DW 
		INNER JOIN A024_DIVISIONES D  ON D.DIVCOD	 = DW.DIVISION
		WHERE	DW.EMPRESA = @IDEMPRESA 
		AND		DW.VALIDADO = 'NO' 
		AND		D.ACTIVO = 'SI' 
		GROUP BY D.DIVISION 
		ORDER BY D.DIVISION
	END
	ELSE
	BEGIN
		INSERT INTO #DOCS_PENDIENTES VALUES ('vacio',0)
	END

	SELECT DISTINCT D.DIVCOD, D.DIVISION 
	INTO #OPERACIONES          
	FROM WORKERSLOCAL WL WITH (NOLOCK)          
	INNER JOIN	A024_DIVISIONES D ON WL.DIVISION	= D.DIVCOD
	WHERE		WL.EMPRESA							= @IDEMPRESA  
	AND			D.ACTIVO							= 'SI'  

	SELECT ROW_NUMBER() OVER(ORDER BY DIVCOD ASC) AS ID , * 
	INTO #ROW_OPERACIONES 
	FROM #OPERACIONES 

	WHILE( @CONT_A <= (SELECT MAX(ID) FROM #ROW_OPERACIONES))
	BEGIN

		SET @VAR_DIV1 = (SELECT DIVCOD FROM #ROW_OPERACIONES WHERE ID = @CONT_A)

		INSERT INTO #TEMP_WORKERS           
		SELECT DISTINCT RUT, DIVISION          
		FROM WORKERSLOCAL WITH (NOLOCK)
		WHERE EMPRESA = @IDEMPRESA 
		AND DIVISION = @VAR_DIV1

		SET @CONT_A = @CONT_A + 1
	END

	SELECT ROW_NUMBER() OVER(ORDER BY RUT ASC) AS ID , * INTO #ROW_TEMPWORKERS FROM #TEMP_WORKERS          
       
	WHILE(@CONT_B <= (SELECT MAX(ID) FROM #ROW_TEMPWORKERS))
	BEGIN

		SET @VAR_DIV2 = (SELECT DIVCOD FROM #ROW_TEMPWORKERS WHERE ID = @CONT_B) 
		INSERT INTO #WORKERS_DATA          
		SELECT TOP 1 AUTOR, VALIDADO , DIVISION          
		FROM WORKERSLOCAL   WITH (NOLOCK)        
		WHERE EMPRESA = @IDEMPRESA 
		AND DIVISION = @VAR_DIV2
		AND RUT = (SELECT RUT FROM #ROW_TEMPWORKERS WHERE ID = @CONT_B)
		ORDER BY LOTE  

		SET @CONT_B = @CONT_B + 1
	END

	WHILE( @CONT_C <= (SELECT MAX(ID) FROM #ROW_OPERACIONES))
	BEGIN    

		SET @VAR_DIV3 = (SELECT DIVCOD FROM #ROW_OPERACIONES WHERE ID = @CONT_C) 

		SET @VAR_SI = (SELECT ISNULL(SUM(CANT),0) AS NO FROM (
		SELECT DIVCOD,COUNT(*) AS CANT,AUTOR,VALIDADO
		FROM #WORKERS_DATA
		WHERE DIVCOD=@VAR_DIV3
		GROUP BY DIVCOD,AUTOR,VALIDADO
		HAVING AUTOR='SI' AND VALIDADO='SI' ) AS NO)

		SET @VAR_NO = (SELECT ISNULL(SUM(CANT),0) AS SI FROM (
		SELECT DIVCOD,COUNT(*) AS CANT,AUTOR,VALIDADO
		FROM #WORKERS_DATA
		WHERE DIVCOD=@VAR_DIV3
		GROUP BY DIVCOD,AUTOR,VALIDADO
		HAVING AUTOR!='SI' OR VALIDADO!='SI' ) AS SI)

		SET @TOTAL = (@VAR_SI + @VAR_NO)
		SET @PROMEDIO = (100 * @VAR_SI) / @TOTAL

		INSERT INTO #DATA VALUES (@VAR_DIV3,@VAR_SI,@VAR_NO,@TOTAL,@PROMEDIO)

		SET @CONT_C = @CONT_C + 1
	END

	SELECT STUFF((
			SELECT ',''' + CAST(DIVCOD AS VARCHAR) + ''''
			FROM #DATA
			FOR XML PATH('')
		),1,1,'') AS OPERACIONES,
		STUFF((
			SELECT ',' + CAST(SI AS VARCHAR)
			FROM #DATA
			FOR XML PATH('')
		),1,1,'') AS CANT_ACREDITADOS,
		STUFF((
		SELECT ',' + CAST(NO AS VARCHAR)
		FROM #DATA
		FOR XML PATH('')
		),1,1,'') AS CANT_NOACREDITADOS,
				STUFF((
		SELECT ',' + CAST(PROMEDIO AS VARCHAR)
		FROM #DATA
		FOR XML PATH('')
		),1,1,'') AS PROMEDIO,
		(SELECT SUM(CASE WHEN GETDATE() BETWEEN FINICIO AND FTERMINO THEN 1 ELSE 0 END)
		FROM OSTARBOL   
		WHERE	EMPRESA = @IDEMPRESA OR	MADRE = @IDEMPRESA ) AS DOCS_VIGENTES,
		(SELECT SUM(CASE WHEN GETDATE() NOT BETWEEN FINICIO AND FTERMINO THEN 1 ELSE 0 END) 
		FROM OSTARBOL   
		WHERE EMPRESA = @IDEMPRESA OR MADRE = @IDEMPRESA ) AS DOCS_VENCIDOS,
		(SELECT COUNT(OST)    
		FROM OSTARBOL   
		WHERE (EMPRESA = @IDEMPRESA OR MADRE = @IDEMPRESA) AND FTERMINO <= DATEADD(d,30,GETDATE()) AND FTERMINO >= GETDATE()) AS VENCIMIENTO_OST,
		(SELECT COUNT(DISTINCT PATENTE)   
		FROM V_DOCS_FEC_VEH   
		WHERE EMPRESA = @IDEMPRESA AND FECHA >= GETDATE() AND FECHA <= DATEADD(d,30,GETDATE())) AS VENCIMIENTO_VEH,
		(SELECT COUNT(DISTINCT RUT)  
		FROM V_DOCS_FEC_WORK   
		WHERE EMPRESA = @IDEMPRESA AND FECHA >= CONVERT(VARCHAR(8),GETDATE(),112) AND FECHA <= CONVERT(VARCHAR(8),DATEADD(d,30,GETDATE()),112)) AS VENCIMIENTO_WORK,
		STUFF((
		SELECT ',{name:''' + CAST(DIVISION AS VARCHAR) + '''' + ',y:' + CAST(CANTIDAD AS VARCHAR) + '}' 
		FROM #DOCS_PENDIENTES
		FOR XML PATH('')
		),1,1,'') AS CANT_PENDIENTES

END