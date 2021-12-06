CREATE PROCEDURE [dbo].[V4MVC_A056_FORM301_DET_INSERT_CONTROLLABORAL_CTTA]
(
  @ID_CERTIFICADO	NVARCHAR(10)
 ,@PERIODO			NVARCHAR(8)
 ,@EMPRESA			NVARCHAR(10)
 ,@NRO_TRAB_PAG		INT
 ,@MONTO_PAGADO		BIGINT
 ,@NRO_TRAB_NOPAG	INT
) AS
BEGIN
	IF(NOT EXISTS(
			SELECT
				ID_CERTIFICADO
			FROM A056_FORM301_DET
			WHERE
				ID_CERTIFICADO = @ID_CERTIFICADO AND
				PERIODO = @PERIODO
	))
		BEGIN
			INSERT INTO A056_FORM301_DET
						(
							EMPRESA,
							ID_CERTIFICADO,
							PERIODO,
							NRO_TRAB_PAG,
							MONTO_PAGADO,
							NRO_TRAB_NOPAG
						) VALUES
						(
							@EMPRESA,
							@ID_CERTIFICADO,
							@PERIODO,
							@NRO_TRAB_PAG,
							@MONTO_PAGADO,
							@NRO_TRAB_NOPAG
						)
		END
END
