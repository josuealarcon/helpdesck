CREATE PROCEDURE [dbo].[V4MVC_WORKERS_UPDATE_LABORALES_CTTA]
( @RUT                nvarchar(10) = NULL
, @CCOSTO            nvarchar(14) = NULL
, @GSANGRE          nvarchar(10) = NULL
, @ROL				nvarchar(50) = NULL
 ) AS 
BEGIN

	UPDATE WORKERS SET CCOSTO = @CCOSTO
					,  ROL	= @ROL
					,  GSANGRE = @GSANGRE  
	WHERE (RUT = @RUT)

END

