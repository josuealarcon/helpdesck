CREATE PROCEDURE [dbo].[V4MVC_LOTEPASES_INSERT_PASES_CTTA]
(
  @INS_OST		NVARCHAR(14)
 ,@INS_EMP		NVARCHAR(10)
 ,@INS_DIVCOD	NVARCHAR(2)
 ,@INS_FINICIO	NVARCHAR(8)
 ,@INS_FFINAL	NVARCHAR(8)
 ,@INS_TPASE	NVARCHAR(9) = ''
 ,@INS_DESCRIP	NVARCHAR(50)
 ,@IDEMPRESA	NVARCHAR(10)
 ,@USUARIO		NVARCHAR(10)
 ,@NEW_ID		INT OUTPUT
) AS
BEGIN

	DECLARE @ADMEMAIL NVARCHAR(50) = ''
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @ACRONIMO NVARCHAR(50) = ''

	SET @NEW_ID = -1

	SELECT
	   TOP 1
	   @ADMEMAIL = A.ADMEMAIL
	FROM OSTDIVLOCAL OA, ADMIN A
	WHERE
		OA.OST = @INS_OST AND
		OA.DIVISION = @INS_DIVCOD AND
		A.ADMRUT = OA.ADMINOST

	INSERT INTO LOTEPASES
		(
		  LOTEFECHA, LOTEESTADO, LOTEFINICIO, LOTEFFINAL, LOTEEMPRESA,
		  LOTEEMAIL, LOTEGLOSA, LOTEEMPMADRE, DIVISION, LOTEUSUARIO)
	VALUES
	   (
	      @CURR_FECHA, 'NO', @INS_FINICIO, @INS_FFINAL, @IDEMPRESA,
		  @ADMEMAIL, @INS_DESCRIP, @IDEMPRESA, @INS_DIVCOD, @USUARIO)

	SET @NEW_ID = SCOPE_IDENTITY()

	IF(@INS_TPASE = '')
		BEGIN
			SET @INS_TPASE = 'TRABAJO'
		END

	SELECT
		TOP 1
		@ACRONIMO = ACRONIMO
	FROM  ENTERPRISE
	WHERE IDEMPRESA = @INS_EMP

	INSERT INTO LOTEPASESFUN
		(
		  NLOTEPROC, RUTLOTE, TIPORUT, APELLIDOSLT,
		  NOMBRESLT, TIPOLT, FNACIMLT, OSTLT)
		VALUES
		(
		  @NEW_ID, @INS_EMP, 'EMPRESA', @ACRONIMO, @ACRONIMO,
		  @INS_TPASE, @CURR_FECHA, @INS_OST)

	UPDATE LOTEPASESFUN
	SET
		EMPRESALT = @INS_EMP
	WHERE
		NLOTEPROC = @NEW_ID AND
		(EMPRESALT NOT IN (
							SELECT
								RUTLOTE
							FROM LOTEPASESFUN
							WHERE NLOTEPROC = @NEW_ID AND TIPORUT = 'EMPRESA'
						  ))
END

