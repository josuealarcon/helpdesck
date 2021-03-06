CREATE PROCEDURE [dbo].[V4MVC_RESERVA_BUS_SELECT_ASIENTOSRESERVADOS_BUSESRESERVA_CTTA]
( @IDPROG NUMERIC(18,0) = NULL
, @EMPRESA NVARCHAR(10) = NULL) AS
BEGIN

	SELECT ROW_NUMBER() OVER(ORDER BY R.IDPROG ASC) ROWNUMBER				,R.RUT				, W.NOMBRES				, W.APELLIDOS
		 , E.ACRONIMO														, R.EMPRESA			,R.IDPROG 
    FROM RESERVA_BUS R INNER JOIN WORKERS W ON W.RUT = R.RUT 
					   INNER JOIN ENTERPRISE E ON E.IDEMPRESA = R.EMPRESA 
	WHERE R.IDPROG=@IDPROG AND R.EMPRESA = @EMPRESA AND R.ESTADO='SI'
	GROUP BY R.IDPROG,R.RUT,W.NOMBRES, W.APELLIDOS, E.ACRONIMO, R.EMPRESA 																			
END
