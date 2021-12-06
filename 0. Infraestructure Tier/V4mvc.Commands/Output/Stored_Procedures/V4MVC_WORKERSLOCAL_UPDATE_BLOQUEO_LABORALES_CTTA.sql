CREATE PROCEDURE [dbo].[V4MVC_WORKERSLOCAL_UPDATE_BLOQUEO_LABORALES_CTTA]
( @RUT                nvarchar(10) = NULL
, @USUARIO            nvarchar(20) = NULL
, @DIVISION			  nvarchar(4) = NULL
, @LOTE			      int = NULL) AS 
BEGIN
	UPDATE WORKERSLOCAL SET AUTOR = 'BL'
						  , QUIEN = @USUARIO
						  , VALIDADO = 'NO'
						  , FECHAMOD = [dbo].[hoy](GETDATE())
						  , HORAMOD = [dbo].[ahora](GETDATE())
	WHERE (RUT = @RUT) AND 
		  (LOTE = @LOTE) AND 
		  (DIVISION = @DIVISION)
END

