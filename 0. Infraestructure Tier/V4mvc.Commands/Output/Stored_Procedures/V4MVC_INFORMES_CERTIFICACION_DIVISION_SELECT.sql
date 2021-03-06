CREATE PROCEDURE [dbo].[V4MVC_INFORMES_CERTIFICACION_DIVISION_SELECT]
(
@DIVCOD NVARCHAR(4)
)
AS
BEGIN

SELECT * FROM (SELECT  RUT,  EMPRESA, ACRONIMO, VALIDADO , (SELECT COUNT(MANDANTE) FROM A027_MANDANTES WHERE MANDANTE = EMPRESA AND MANDANTE <> '108') AS MANDANTE 
		FROM VW_WL_ACREDITADO 
		WHERE DIVISION = @DIVCOD
		UNION 
		SELECT  RUT,  EMPRESA, ACRONIMO, VALIDADO , (SELECT COUNT(MANDANTE) FROM A027_MANDANTES WHERE MANDANTE = EMPRESA AND MANDANTE <> '108') AS MANDANTE 
		FROM VW_WL_NOMINA 
		WHERE DIVISION = @DIVCOD
		UNION 
		SELECT  RUT,  EMPRESA, ACRONIMO, 'BL', (SELECT COUNT(MANDANTE) FROM A027_MANDANTES WHERE MANDANTE = EMPRESA AND MANDANTE <> '108') AS MANDANTE 
		FROM VW_WL_BLOQ
		WHERE DIVISION = @DIVCOD
		) PVT PIVOT ( COUNT(RUT) FOR [VALIDADO] IN ([SI],[NO],[BL]) ) AS P  ORDER BY ACRONIMO

END
