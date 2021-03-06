CREATE PROCEDURE [dbo].[V4MVC_DOCS_TIPO_RECHAZO_SELECT_DISPUTA_FUNCIONARIOSCCTA]
(@FECHA_INI		NVARCHAR(8)= NULL
,@FECHA_FIN	    NVARCHAR(8)= NULL
,@RUT			NVARCHAR(10)= NULL
,@ID_ARCHIVO	    uniqueidentifier= NULL) AS
BEGIN
SELECT tr.TIPO_RECHAZO 
FROM DOCS_WORKERS_RECHAZO dw INNER JOIN DOCS_TIPO_RECHAZO tr ON tr.ID_TIPO_RECHAZO = dw.ID_TIPO_RECHAZO 
                             INNER JOIN DOCS_CONTROLACCESO_LABORAL l ON l.ID_ARCHIVO = dw.ID
 WHERE l.FECHA_INI = @FECHA_INI AND 
 l.FECHA_FIN = @FECHA_FIN AND 
 l.RUT = @RUT AND 
 l.ID_ARCHIVO = @ID_ARCHIVO

END
