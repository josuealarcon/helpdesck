CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_SELECT_DATATABLES_CTTA]
(
 @IDEMPRESA				NVARCHAR(10)	= NULL
,@IDISPLAYSTART			INT				= NULL
,@IDISPLAYLENGTH		INT				= NULL
,@SEARCH_PATENTE		NVARCHAR(10)	= NULL
,@SEARCH_MARCA			NVARCHAR(50)	= NULL
,@SEARCH_MODELO			NVARCHAR(50)	= NULL
,@SORT_COLUMN			NVARCHAR(4)		= NULL
,@SORT_DIRECTION		NVARCHAR(4)		= NULL
,@TOTAL_COUNT			INT	OUTPUT
)
AS
BEGIN

   	DECLARE @VALOR1 NVARCHAR(2)
	DECLARE @QUERY	NVARCHAR(MAX)

	SELECT @VALOR1 = ISNULL(VALOR1,'') FROM PARAMETROS_V2 WHERE DESCRIPCION = 'Pases Vehiculares'
	SET @QUERY = ''

	IF(@VALOR1 = '1')
		BEGIN

			SELECT @TOTAL_COUNT = COUNT(*) FROM (
				SELECT DISTINCT D.PATENTE, D.ACRONIMO, D.MARCA, D.MODELO, D.TIPO FROM ( 
					SELECT T.PATENTE, E.ACRONIMO, T.MARCA, T.MODELO, T.TIPO FROM TRANSPORT_DIVISION_PASES TD 
					INNER JOIN TRANSPORT T ON TD.PATENTE = T.PATENTE 
					INNER JOIN ENTERPRISE E ON TD.EMPRESA = E.IDEMPRESA 
				WHERE (T.EMPRESA = @IDEMPRESA
				AND T.PATENTE LIKE CONCAT('%', @SEARCH_PATENTE , '%')
				AND T.MARCA LIKE CONCAT('%', @SEARCH_MARCA , '%')
				AND T.MODELO LIKE CONCAT('%', @SEARCH_MODELO , '%')
				)
				UNION ALL  
				SELECT T.PATENTE, E.ACRONIMO, T.MARCA, T.MODELO, T.TIPO FROM TRANSPORT T 
				INNER JOIN ENTERPRISE E ON T.EMPRESA = E.IDEMPRESA
				WHERE (T.EMPRESA = @IDEMPRESA
				AND T.PATENTE LIKE CONCAT('%', @SEARCH_PATENTE , '%')
				AND T.MARCA LIKE CONCAT('%', @SEARCH_MARCA , '%')
				AND T.MODELO LIKE CONCAT('%', @SEARCH_MODELO , '%')
				)) D ) E 

			SET @QUERY = @QUERY + '
				SELECT DISTINCT D.PATENTE, D.ACRONIMO, D.MARCA, D.MODELO, D.TIPO FROM ( 
					SELECT T.PATENTE, E.ACRONIMO, T.MARCA, T.MODELO, T.TIPO FROM TRANSPORT_DIVISION_PASES TD 
					INNER JOIN TRANSPORT T ON TD.PATENTE = T.PATENTE 
					INNER JOIN ENTERPRISE E ON TD.EMPRESA = E.IDEMPRESA 
				WHERE (T.EMPRESA = ' + '''' + @IDEMPRESA + ''''
				IF @SEARCH_PATENTE IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.PATENTE LIKE ' + '''%' + @SEARCH_PATENTE + '%''' END
				IF @SEARCH_MARCA IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.MARCA LIKE ' + '''%' + @SEARCH_MARCA + '%''' END
				IF @SEARCH_MODELO IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.MODELO LIKE ' + '''%' + @SEARCH_MODELO + '%''' END
				SET @QUERY = @QUERY +')'	   
				SET @QUERY = @QUERY + 'UNION ALL  
				SELECT T.PATENTE, E.ACRONIMO, T.MARCA, T.MODELO, T.TIPO FROM TRANSPORT T 
				INNER JOIN ENTERPRISE E ON T.EMPRESA = E.IDEMPRESA
				WHERE (T.EMPRESA = ' + '''' + @IDEMPRESA + '''' 
				IF @SEARCH_PATENTE IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.PATENTE LIKE ' + '''%' + @SEARCH_PATENTE + '%''' END
				IF @SEARCH_MARCA IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.MARCA LIKE ' + '''%' + @SEARCH_MARCA + '%''' END
				IF @SEARCH_MODELO IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.MODELO LIKE ' + '''%' + @SEARCH_MODELO + '%''' END
				SET @QUERY = @QUERY + ')) D'
		END
	ELSE
		BEGIN
			SELECT @TOTAL_COUNT = COUNT(*) FROM (
			SELECT DISTINCT D.PATENTE, D.ACRONIMO, D.MARCA, D.MODELO, D.TIPO FROM ( 
				SELECT T.PATENTE, E.ACRONIMO, T.MARCA, T.MODELO, T.TIPO FROM TRANSPORT_DIVISION_PASES TD 
				INNER JOIN TRANSPORT T ON TD.PATENTE = T.PATENTE 
				INNER JOIN ENTERPRISE E ON TD.EMPRESA = E.IDEMPRESA 
			WHERE (T.EMPRESA = @IDEMPRESA
			AND T.PATENTE LIKE CONCAT('%', @SEARCH_PATENTE , '%')
			AND T.MARCA LIKE CONCAT('%', @SEARCH_MARCA , '%')
			AND T.MODELO LIKE CONCAT('%', @SEARCH_MODELO , '%')
			)) D ) E 

			SET @QUERY = @QUERY + '
				SELECT DISTINCT D.PATENTE, D.ACRONIMO, D.MARCA, D.MODELO, D.TIPO FROM ( 
				SELECT T.PATENTE, E.ACRONIMO, T.MARCA, T.MODELO, T.TIPO FROM TRANSPORT_DIVISION_PASES TD 
				INNER JOIN TRANSPORT T ON TD.PATENTE = T.PATENTE 
				INNER JOIN ENTERPRISE E ON TD.EMPRESA = E.IDEMPRESA
				WHERE (T.EMPRESA = ' + '''' + @IDEMPRESA + ''''
				IF @SEARCH_PATENTE IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.PATENTE LIKE ' + '''%' + @SEARCH_PATENTE + '%''' END
				IF @SEARCH_MARCA IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.MARCA LIKE ' + '''%' + @SEARCH_MARCA + '%''' END
				IF @SEARCH_MODELO IS NOT NULL BEGIN SET @QUERY = @QUERY + ' AND T.MODELO LIKE ' + '''%' + @SEARCH_MODELO + '%''' END
				SET @QUERY = @QUERY + ')) D'
		END

	IF @SORT_COLUMN='0' BEGIN SET @QUERY = @QUERY + ' ORDER BY D.PATENTE ' +  @SORT_DIRECTION END   
	IF @SORT_COLUMN='1' BEGIN SET @QUERY = @QUERY + ' ORDER BY D.MARCA ' + @SORT_DIRECTION END   
	IF @SORT_COLUMN='2' BEGIN SET @QUERY = @QUERY + ' ORDER BY D.MODELO '  + @SORT_DIRECTION END 

	SET @QUERY = @QUERY + ' OFFSET ' + CAST(@IDISPLAYSTART AS VARCHAR) + ' ROWS FETCH NEXT ' + CAST(@IDISPLAYLENGTH AS VARCHAR) + ' ROWS ONLY'
	EXEC(@QUERY)

END

