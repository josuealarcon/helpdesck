CREATE PROCEDURE [dbo].[V4MVC_DOCS_SELECT]
(@ID_DOC		INT = NULL) AS
BEGIN

   SELECT ID_DOC             , NOMBRE               , RUTA                , CAMPO                    
        , ACTIVO             , ID_DOC_OPCION        , ID_TIPO_PROPIETARIO , CONFIDENCIAL             
        , IDENTIFICADOR_FOTO , SUBEDOC              , WHOUPDATE           , SHORT                    
        , ORDEN              , COMUN                , ESPECIFICO          , URL_ESPECIFICO           
        , URL_CTRLLABORAL    , COMUN_DIV            , URLDONDE            , URLCOMO                  
        , PORCENTAJE_AUDIT   , VALIDAMANDANTE       , ESPECIFICO_VER_OST  , ESPECIFICO_VER_RESOLUCION
        , ID_TIPO_ESPECIFICO , VALIDASUBCONTRATISTA , TIPODOC_AUDIT      
     FROM DOCS
	WHERE ID_DOC = @ID_DOC

END

