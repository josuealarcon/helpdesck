CREATE PROCEDURE [dbo].[V4MVC_POLIZAS_NOMINA_INSERT_POLIZAS_CTTA]
(
  @IDDOC INT              = NULL
, @NROPOLIZA NVARCHAR(50) = NULL
, @RUT NVARCHAR(10)       = NULL
) AS
BEGIN

		INSERT INTO POLIZAS_NOMINA(RUT		,NROPOLIZA		,IDDOC		,VALIDADO)
						   VALUES (@RUT		,@NROPOLIZA		,@IDDOC		,'NO')

END
/****** Object:  StoredProcedure [dbo].[V4MVC_POLIZAS_NOMINA_SELECT_DATATABLE_POLIZAS_CTTA]    Script Date: 9/11/2020 14:50:45 ******/
SET ANSI_NULLS ON
