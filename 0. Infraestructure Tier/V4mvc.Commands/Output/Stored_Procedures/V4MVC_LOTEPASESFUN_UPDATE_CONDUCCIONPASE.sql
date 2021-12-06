CREATE PROCEDURE [dbo].[V4MVC_LOTEPASESFUN_UPDATE_CONDUCCIONPASE]
( @RUT				nvarchar(10) = NULL
, @IDEMPRESA        nvarchar(10) = NULL
, @DIVCOD			nvarchar(30) = NULL
, @LICONDLT			nvarchar(2) = NULL
) AS 
BEGIN
	DECLARE @LICONDLT_INVERSO NVARCHAR(2) = CASE WHEN @LICONDLT = 'SI' THEN 'NO' ELSE 'SI' END
	IF(@LICONDLT = 'NO')
		BEGIN
			UPDATE LOTEPASESFUN 
			SET LICONDLT = 'NO' 
			WHERE RUTLOTE = @RUT AND 
			NLOTEPROC IN ( SELECT  L.LOTENUM 
							FROM LOTEPASES AS L 
							INNER JOIN LOTEPASESFUN AS LF ON L.LOTENUM = LF.NLOTEPROC 
							WHERE (L.DIVISION = @DIVCOD) AND 
							(LF.RUTLOTE = @RUT) AND 
							(L.LOTEFINICIO <= [dbo].HOY(GETDATE())) AND 
							(L.LOTEFFINAL >= [dbo].HOY(GETDATE())) AND 
							LF.EMPRESALT = @IDEMPRESA AND 
							(LF.LICONDLT = 'SI'))
		END
	ELSE
		BEGIN
			UPDATE LOTEPASESFUN SET LICONDLT='SI' 
							WHERE RUTLOTE = @RUT AND 
							NLOTEPROC IN (SELECT LOTE FROM WORKERSLOCAL WHERE (RUT = @RUT) 
							AND (DIVISION = @DIVCOD) 
							AND (FFINPASE >= DBO.HOY(GETDATE())) AND (AUTOR IN ('SI','NO')))
		END

END


