CREATE PROCEDURE [dbo].[V4MVC_DOCS_WORKERS_DATA_SELECT_DISPUTA]
(@ID			UNIQUEIDENTIFIER = NULL) AS
BEGIN

	SELECT SALARIO,TURNO,OST,T.DESCRIPCION,R.ROL
	FROM DOCS_WORKERS_DATA D 
	LEFT JOIN TAB_TIPOCONTRATO T ON T.TIPOCONTRATO = D.TIPOCONTRATO 
	LEFT JOIN ROL R ON R.ID_ROL = D.CARGO 
 	WHERE ID_DOC = @ID
END

