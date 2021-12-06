CREATE PROCEDURE [dbo].[V4MVC_WORKERS_SELECT]
( @RUT		nvarchar(10) = NULL ) AS
BEGIN

   SELECT W.RUT               , W.NOMBRES       , W.APELLIDOS      , W.FECHNACIM       
        , W.EMPRESA           , W.CASTIGO       , W.POLICLIN       , W.FECHARLA        
        , W.CONTRATO          , W.CEDULA        , W.EXPREOCUP      , W.CERTANTEC       
        , W.FECEXPIREX        , W.LICCONDUC     , W.FECEXPIRALIC   , W.CLASE           
        , W.PARTES            , W.ROL           , W.STAFF          , W.PIEZA           
        , W.AUTOR             , W.CCOSTO        , W.AUTCASINO      , W.GRUPO           
        , W.ZONA              , W.CLAVE         , W.AUTORVISITA    , W.CASINODES       
        , W.CASINOALM         , W.CASINOCEN     , W.CASINOCEN2     , W.CASINOOTR       
        , W.CASINOPERM1       , W.TIPOPASE      , W.TURNO          , W.GRUPOTURN       
        , W.OST               , W.FECHABLOQUEO  , W.SEXO           , W.FINIPASE        
        , W.FFINPASE          , W.FECEXPLICINT  , W.COOL           , W.EMAIL           
        , W.DEFECHA           , W.VIP           , W.CARGO          , W.DOC_DAS         
        , W.DOC_REGINT        , W.DOC_PSICOTEC  , W.TIPOVEHIC      , W.SICOFECHA       
        , W.FECHAMOD          , W.HORAMOD       , W.CONTRATOFEC    , W.CONTRATOTIP     
        , W.DOC_HVIDA         , W.NACIONALIDAD  , W.GRABO          , W.LOTE            
        , W.FINGRESO          , W.FINIQUITO     , W.MOTIVO         , W.DOC_FINIQUITO   
        , W.DIVISION          , W.DOC_FOTO      , W.AUTOR_EXT      , W.FECMEDICO       
        , W.OKMEDICO          , W.DOC_MANEJO    , W.FEC_DAS        , W.VALIDADO        
        , W.QUIEN             , W.FINIQUITO2    , W.DOC_FINIQUITO2 , W.ALTURAEX        
        , W.ID_AREA           , W.GSANGRE       , W.AUT_COND_MAND  , W.TDOC            
        , W.IDGERENCIA        , W.IDUNIDAD      , W.FUNCION        , W.SAP             
        , W.FISCALIZADO       , W.UBIGEO        , W.CODCONSTCIVIL  , W.RESIDENTE       
        , W.CALIFICADO        , W.MANOOBRALOCAL , W.GINSTRUCCION   , W.COD_HABILITACION
        , W.ROL_AAQ           , W.SALARIO       , W.FECINICASINO   , W.FECFINCASINO    
        , W.LOCAL_TRABAJO_AAQ , W.IDSYNC        , W.RESTCREDENCIAL , W.OBSCREDENCIAL
		, W.TIPOSEGURO		  , W.SEGURO		, W.OCUPACION	   , W.TIPODOC
		, DBO.HOY(GETDATE()) AS FECHAHOY        ,D.CELULAR         

		, E.ACRONIMO
     FROM WORKERS AS W
	 INNER JOIN ENTERPRISE AS E ON E.IDEMPRESA = W.EMPRESA
	 LEFT JOIN DIRECCION AS D ON D.RUT = W.RUT
    WHERE W.RUT = @RUT

END
