CREATE PROCEDURE [dbo].[V4MVC_ADMIN_VALIDAR_LOGIN]
( @ADMRUT         nvarchar(10) = NULL
, @ADMCLAVE		  nvarchar(50) = NULL) AS
BEGIN

   SELECT * , DATEDIFF(d,getdate(), FECHAVENCE) as EXPIRA 
   FROM ADMIN  
   WHERE UPPER(ADMRUT) = Replace(@ADMRUT, '', '''')
   AND (ADMCLAVE = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@ADMCLAVE))), 3, 32) 
		OR ADMCLAVE = @ADMCLAVE)

END

