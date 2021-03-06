CREATE PROCEDURE [dbo].[V4MVC_DOCS_SELECT_MIXED_EMPRESA_CTTA]
(@ID_DOC		INT = NULL) AS
BEGIN

   SELECT D.ID_DOC            ,D.NOMBRE               ,D.RUTA                ,D.CAMPO                    
        ,D.ACTIVO             ,D.ID_DOC_OPCION        ,D.ID_TIPO_PROPIETARIO ,D.CONFIDENCIAL             
        ,D.IDENTIFICADOR_FOTO ,D.SUBEDOC              ,D.WHOUPDATE           ,D.SHORT                    
        ,D.ORDEN              ,D.COMUN                ,D.ESPECIFICO          ,D.URL_ESPECIFICO           
        ,D.URL_CTRLLABORAL    ,D.COMUN_DIV            ,D.URLDONDE            ,D.URLCOMO                  
        ,D.PORCENTAJE_AUDIT   ,D.VALIDAMANDANTE       ,D.ESPECIFICO_VER_OST  ,D.ESPECIFICO_VER_RESOLUCION
        ,D.ID_TIPO_ESPECIFICO ,D.VALIDASUBCONTRATISTA ,D.TIPODOC_AUDIT
		,STUFF(
			(
				SELECT ' ' + DOCS_EXT.EXTENSION
				FROM DOCS_FORMATO, DOCS_EXT
				WHERE DOCS_FORMATO.ID_DOC = D.ID_DOC AND DOCS_FORMATO.ID_DOC_EXT = DOCS_EXT.ID_DOC_EXT
				FOR XML PATH('')
			), 1, 1, '') AS EXTENSIONES
    FROM DOCS D
	WHERE D.ID_DOC = @ID_DOC

END

