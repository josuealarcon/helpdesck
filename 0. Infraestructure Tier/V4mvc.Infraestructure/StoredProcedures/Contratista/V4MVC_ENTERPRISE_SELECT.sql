CREATE PROCEDURE [dbo].[V4MVC_ENTERPRISE_SELECT]  
( @IDEMPRESA      nvarchar(11) = NULL ) AS  
BEGIN  
  
   SELECT IDEMPRESA     , CLAVE      , ACRONIMO      , NOMBRE         
        , RUBRO         , DIRECCCION , CIUDAD        , REGION         
        , TELEFONO      , FAX        , NRELEGAL      , RELEGAL        
        , EMAIL         , UBIFAENA   , FONOFAENA     , ADMINNOM       
        , ADMINRUT      , ADMINEMAIL , ADMINFONO     , BLOQUEOCASINO  
        , FECHABLOQUEO  , OST        , FECAUDIT      , TIPOEMP        
        , RINTERNO      , CPARITARIO , AUTOR         , FINANZAS       
        , RRHH          , SICEP      , DICOM         , PROPIO         
        , LEGAL         , CONTRATOS  , TAUDIT        , SEGURITO       
        , EMAILSEGURITO , MUTUAL     , CODIGOMUTUAL  , SERNAGEOMIN    
        , CODIGOSERNA   , FECHAMOD   , HORAMOD       , GRABO          
        , MAILLICITA    , BALANCE    , ANTERIOR      , ELYPSE         
        , PAIS          , RUTHOTEL   , CONTACTOHOTEL , TLFHOTEL       
        , EMAILHOTEL     
     FROM ENTERPRISE  
    WHERE IDEMPRESA = ISNULL( @IDEMPRESA, IDEMPRESA )  
  
END  
  
