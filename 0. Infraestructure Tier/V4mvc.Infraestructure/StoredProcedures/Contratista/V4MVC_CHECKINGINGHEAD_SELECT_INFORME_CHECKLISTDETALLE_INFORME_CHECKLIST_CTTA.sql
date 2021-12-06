CREATE PROCEDURE [dbo].[V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLISTDETALLE_INFORME_CHECKLIST_CTTA]
(
@ID_CHECK INT = NULL,
@ID_CHECKING INT = NULL,
@ID_CHECKINGHEAD INT = NULL
) AS
BEGIN


SELECT 
 ROW_NUMBER() OVER(ORDER BY CHKDET.ID_CHECKDET DESC) ROWNUMBER
,DESCRIPCION
,VALOR
,HORA
,OBSERVACION
FROM CHECK_DETAIL CHKDET 
		  INNER JOIN [CHECK_CHECKINGDETAIL] CHKNGDET ON CHKDET.ID_TIPO = CHKNGDET.ID_TIPO AND CHKDET.ID_CHECK = CHKNGDET.ID_CHECK AND CHKDET.ID_CHECKDET = CHKNGDET.ID_CHECKINGDET 
		  WHERE CHKNGDET.ID_TIPO = 'VEH'
		  AND CHKNGDET.ID_CHECK = @ID_CHECK
		  AND CHKNGDET.ID_CHECKING = @ID_CHECKING
		  AND CHKNGDET.ID_CHECKINGHEAD = @ID_CHECKINGHEAD
 
END	
