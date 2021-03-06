CREATE PROCEDURE [dbo].[V4MVC_A024_DIVISIONES_SELECT_INFORMECONSULTARAPIDA_CTTA]
(
 @PATENTE NVARCHAR(8) 
) AS 
BEGIN
DECLARE @TIPO INT
DECLARE @IDEMPRESA NVARCHAR(11)
SELECT @IDEMPRESA = E.IDEMPRESA, @TIPO = T.TIPO
	   FROM  TRANSPORT T LEFT OUTER JOIN TYPETRANS TP ON T.TIPO=TP.IDTIPO 
						 LEFT OUTER JOIN ENTERPRISE E ON E.IDEMPRESA=T.EMPRESA 
	   WHERE PATENTE=@PATENTE

 SELECT DISTINCT 
   D.DIVCOD
 , D.DIVISION 
 , CASE WHEN (SELECT COUNT(*) FROM A024_DIVISIONES WHERE ISNULL(PASES_VEHICULARES,'NO') = 'SI' AND DIVCOD =  D.DIVCOD) > 0 THEN (SELECT TD.EMPRESA FROM TRANSPORT_DIVISION_PASES AS TD  WHERE (TD.PATENTE = @PATENTE) AND (TD.DIVISION = D.DIVCOD)  AND (dbo.hoy(GETDATE()) BETWEEN FINIPASE AND FFINPASE) AND (AUTOR IN ('SI','NO')))  ELSE @IDEMPRESA END AS EMPRESA
 , (SELECT [dbo].[fn_cert_veh2] (@PATENTE , @IDEMPRESA , @TIPO, D.DIVCOD , dbo.hoy(getdate()))) AS CERT
 FROM TRANSPORT_DIVISION TD  INNER JOIN A024_DIVISIONES D ON TD.DIVISION = D.DIVCOD  
 WHERE ACTIVO = 'SI' AND PATENTE=@PATENTE
END
