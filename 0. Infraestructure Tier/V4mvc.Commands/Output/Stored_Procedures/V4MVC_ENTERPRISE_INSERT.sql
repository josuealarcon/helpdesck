CREATE PROCEDURE [dbo].[V4MVC_ENTERPRISE_INSERT]
(
 @IDEMPRESA NVARCHAR(11) = NULL
,@CLAVE NVARCHAR(10) = NULL
,@ACRONIMO NVARCHAR(50) = NULL
,@NOMBRE NVARCHAR(50) = NULL
,@RUBRO NVARCHAR(50) = NULL
,@DIRECCCION NVARCHAR(50) = NULL
,@CIUDAD NVARCHAR(50) = NULL
,@REGION NVARCHAR(5) = NULL
,@TELEFONO NVARCHAR(50) = NULL
,@FAX NVARCHAR(50) = NULL
,@NRELEGAL NVARCHAR(50) = NULL
,@RELEGAL NVARCHAR(10) = NULL
,@EMAIL NVARCHAR(150) = NULL
,@UBIFAENA NVARCHAR(50) = NULL
,@FONOFAENA NVARCHAR(50) = NULL
,@ADMINNOM NVARCHAR(50) = NULL
,@ADMINRUT NVARCHAR(10) = NULL
,@ADMINEMAIL NVARCHAR(150) = NULL
,@ADMINFONO NVARCHAR(50) = NULL
,@BLOQUEOCASINO NVARCHAR(2) = NULL
,@FECHABLOQUEO NVARCHAR(8) = NULL
,@OST NVARCHAR(2) = NULL
,@FECAUDIT NVARCHAR(6) = NULL
,@TIPOEMP NVARCHAR(2) = NULL
,@RINTERNO NVARCHAR(2) = NULL
,@CPARITARIO NVARCHAR(2) = NULL
,@AUTOR NVARCHAR(2) = NULL
,@FINANZAS NVARCHAR(1) = NULL
,@RRHH NVARCHAR(1) = NULL
,@SICEP NVARCHAR(1) = NULL
,@DICOM NVARCHAR(1) = NULL
,@PROPIO NVARCHAR(1) = NULL
,@LEGAL NVARCHAR(1) = NULL
,@CONTRATOS NVARCHAR(1) = NULL
,@TAUDIT NVARCHAR(2) = NULL
,@SEGURITO NVARCHAR(10) = NULL
,@EMAILSEGURITO NVARCHAR(50) = NULL
,@MUTUAL NVARCHAR(20) = NULL
,@CODIGOMUTUAL NVARCHAR(20) = NULL
,@SERNAGEOMIN NVARCHAR(2) = NULL
,@CODIGOSERNA NVARCHAR(20) = NULL
,@FECHAMOD NVARCHAR(8) = NULL
,@HORAMOD NVARCHAR(8) = NULL
,@GRABO NVARCHAR(1) = NULL
,@MAILLICITA NVARCHAR(150) = NULL
,@BALANCE NVARCHAR(1) = NULL
,@ANTERIOR NVARCHAR(1) = NULL
,@ELYPSE NVARCHAR(10) = NULL
,@PAIS NVARCHAR(50) = NULL
,@RUTHOTEL NVARCHAR(10) = NULL
,@CONTACTOHOTEL NVARCHAR(100) = NULL
,@TLFHOTEL NVARCHAR(50) = NULL
,@EMAILHOTEL NVARCHAR(50) = NULL
) AS

BEGIN

	INSERT INTO [ENTERPRISE]
	(
		 IDEMPRESA			,CLAVE				,ACRONIMO				,NOMBRE				,RUBRO
		,DIRECCCION			,CIUDAD				,REGION					,TELEFONO			,FAX
		,NRELEGAL			,RELEGAL			,EMAIL					,UBIFAENA			,FONOFAENA
		,ADMINNOM			,ADMINRUT			,ADMINEMAIL				,ADMINFONO			,BLOQUEOCASINO
		,FECHABLOQUEO		,OST				,FECAUDIT				,TIPOEMP			,RINTERNO
		,CPARITARIO			,AUTOR				,FINANZAS				,RRHH				,SICEP
		,DICOM				,PROPIO				,LEGAL					,CONTRATOS			,TAUDIT
		,SEGURITO			,EMAILSEGURITO		,MUTUAL					,CODIGOMUTUAL		,SERNAGEOMIN
		,CODIGOSERNA		,FECHAMOD			,HORAMOD				,GRABO				,MAILLICITA
		,BALANCE			,ANTERIOR			,ELYPSE					,PAIS				,RUTHOTEL
		,CONTACTOHOTEL		,TLFHOTEL			,EMAILHOTEL
	)
	VALUES
	(
		@IDEMPRESA			,@CLAVE				,@ACRONIMO				,@NOMBRE			,@RUBRO
		,@DIRECCCION		,@CIUDAD			,@REGION				,@TELEFONO			,@FAX
		,@NRELEGAL			,@RELEGAL			,@EMAIL					,@UBIFAENA			,@FONOFAENA
		,@ADMINNOM			,@ADMINRUT			,@ADMINEMAIL			,@ADMINFONO			,@BLOQUEOCASINO
		,@FECHABLOQUEO		,@OST				,@FECAUDIT				,@TIPOEMP			,@RINTERNO
		,@CPARITARIO		,@AUTOR				,@FINANZAS				,@RRHH				,@SICEP
		,@DICOM				,@PROPIO			,@LEGAL					,@CONTRATOS			,@TAUDIT
		,@SEGURITO			,@EMAILSEGURITO		,@MUTUAL				,@CODIGOMUTUAL		,@SERNAGEOMIN
		,@CODIGOSERNA		,DBO.HOY(GETDATE()) ,DBO.AHORA(GETDATE())	,@GRABO				,@MAILLICITA
		,@BALANCE			,@ANTERIOR			,@ELYPSE				,@PAIS				,@RUTHOTEL
		,@CONTACTOHOTEL		,@TLFHOTEL			,@EMAILHOTEL
	)

END
