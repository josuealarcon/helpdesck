CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_SELECT_VALIDA_EXISTENCIA_PATENTE_INFORMECONSULTARAPIDA_CTTA]
(
   @PATENTE NVARCHAR(8) 
 , @EXISTE BIT  OUTPUT
) AS 
BEGIN

 IF EXISTS(SELECT * FROM  TRANSPORT T LEFT OUTER JOIN TYPETRANS TP ON T.TIPO=TP.IDTIPO 
						              LEFT OUTER JOIN ENTERPRISE E ON E.IDEMPRESA=T.EMPRESA 
           WHERE PATENTE=@PATENTE)
 BEGIN
  SET @EXISTE = 1
 END
 ELSE
 BEGIN
  SET @EXISTE = 0
 END

END
