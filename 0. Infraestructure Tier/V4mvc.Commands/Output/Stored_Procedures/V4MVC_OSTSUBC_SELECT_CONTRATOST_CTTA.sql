CREATE PROCEDURE [dbo].[V4MVC_OSTSUBC_SELECT_CONTRATOST_CTTA]
(
 @IDEMPRESA  NVARCHAR(10)
) AS
BEGIN
	SELECT
		OST AS NROOST,
		NIVEL,
		EMPRESA AS IDEMPRESA,
		MADRE,
		ACRONIMOMADRE,
		ACRONIMO,
		FINICIO AS FECINICIO,
		IIF(FINICIO IS NULL OR FINICIO = '19000101', 0, 1) AS TIENE_FINICIO,
		FTERMINO AS FECTERM,
		IIF(FTERMINO IS NULL OR FTERMINO = '19000101', 0, 1) AS TIENE_FTERMINO
	FROM OSTSUBC
	WHERE
		(EMPRESA = @IDEMPRESA) OR
		(MADRE = @IDEMPRESA)
	ORDER BY OST ASC
END
