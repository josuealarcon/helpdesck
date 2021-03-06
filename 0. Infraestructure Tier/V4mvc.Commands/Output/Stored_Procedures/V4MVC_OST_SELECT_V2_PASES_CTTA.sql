CREATE PROCEDURE [dbo].[V4MVC_OST_SELECT_V2_PASES_CTTA]
(
  @IDISPLAYSTART		INT           
 ,@IDISPLAYLENGTH		INT
 ,@IDEMPRESA			NVARCHAR(10)
 ,@SEARCH_NROOST		NVARCHAR(14) = ''
 ,@SEARCH_DESCRIPOST	NVARCHAR(100) = ''
 ,@SORT_COLUMN			NVARCHAR(4) = NULL  
 ,@SORT_DIRECTION		NVARCHAR(4) = NULL
 ,@TOTAL_COUNT			INT OUTPUT
) AS
BEGIN
	SELECT
		@TOTAL_COUNT = COUNT(*)
	FROM
	(
		SELECT 
			DISTINCT
			O.NROOST,
			O.DESCRIPOST,
			O.FECINICIO,
			O.FECTERM
		FROM OST O
		INNER JOIN OSTARBOL OA
			ON OA.OST = O.NROOST
		WHERE
			(OA.EMPRESA = @IDEMPRESA OR OA.MADRE = @IDEMPRESA) AND
			(O.FECTERM >= CONVERT(VARCHAR(8),GETDATE(),112)) AND
			(
			  ( O.NROOST IS NOT NULL AND
			    O.NROOST <> '' AND
				O.NROOST LIKE CONCAT('%', @SEARCH_NROOST, '%')
			  ) OR
			  (O.NROOST IS NULL OR O.NROOST = '')
			) AND
			(
			  (
			   O.DESCRIPOST IS NOT NULL AND
			   O.DESCRIPOST <> '' AND
			   O.DESCRIPOST LIKE CONCAT('%', @SEARCH_DESCRIPOST, '%')
			  ) OR
			  (O.DESCRIPOST IS NULL OR O.DESCRIPOST = '')
			)
	) Y

	IF(@SORT_DIRECTION = 'ASC')
		BEGIN
			SELECT
				X.NROOST,
				X.DESCRIPOST,
				[dbo].[V4MVC_FGET_FEC_USER](X.FECINICIO) AS FECINICIO,
				[dbo].[V4MVC_FGET_FEC_USER](X.FECTERM) AS FECTERM
			FROM
			(
				SELECT 
					DISTINCT
					O.NROOST,
					O.DESCRIPOST,
					O.FECINICIO,
					O.FECTERM
				FROM OST O
				INNER JOIN OSTARBOL OA
					ON OA.OST = O.NROOST
				WHERE
					(OA.EMPRESA = @IDEMPRESA OR OA.MADRE = @IDEMPRESA) AND
					(O.FECTERM >= CONVERT(VARCHAR(8),GETDATE(),112)) AND
					(
					  (
					    O.NROOST IS NOT NULL AND
						O.NROOST <> '' AND
						O.NROOST LIKE CONCAT('%', @SEARCH_NROOST, '%')
					   ) OR 
					   (O.NROOST IS NULL OR O.NROOST = '')
					 ) AND
					(
					 (
					   O.DESCRIPOST IS NOT NULL AND
					   O.DESCRIPOST <> '' AND
					   O.DESCRIPOST LIKE CONCAT('%', @SEARCH_DESCRIPOST, '%')
					 ) OR
					 (O.DESCRIPOST IS NULL OR O.DESCRIPOST = '')
					)
			) X
			ORDER BY 
				CASE WHEN @SORT_COLUMN = '0' THEN X.NROOST END ASC,
				CASE WHEN @SORT_COLUMN = '1' THEN X.DESCRIPOST END ASC,
				CASE WHEN @SORT_COLUMN = '2' THEN X.FECINICIO END ASC,
				CASE WHEN @SORT_COLUMN = '3' THEN X.FECTERM END ASC
			OFFSET @IDISPLAYSTART ROWS FETCH NEXT @IDISPLAYLENGTH ROWS ONLY
		END
	ELSE
		BEGIN
			SELECT
				X.NROOST,
				X.DESCRIPOST,
				[dbo].[V4MVC_FGET_FEC_USER](X.FECINICIO) AS FECINICIO,
				[dbo].[V4MVC_FGET_FEC_USER](X.FECTERM) AS FECTERM
			FROM
			(
				SELECT 
					DISTINCT
					O.NROOST,
					O.DESCRIPOST,
					O.FECINICIO,
					O.FECTERM
				FROM OST O
				INNER JOIN OSTARBOL OA
					ON OA.OST = O.NROOST
				WHERE
					(OA.EMPRESA = @IDEMPRESA OR OA.MADRE = @IDEMPRESA) AND
					(O.FECTERM >= CONVERT(VARCHAR(8),GETDATE(),112)) AND
					(
					  (
					    O.NROOST IS NOT NULL AND
						O.NROOST <> '' AND
						O.NROOST LIKE CONCAT('%', @SEARCH_NROOST, '%')
					  ) OR
					  (O.NROOST IS NULL OR O.NROOST = '')
					) AND
					(
					  (
					    O.DESCRIPOST IS NOT NULL AND
						O.DESCRIPOST <> '' AND
						O.DESCRIPOST LIKE CONCAT('%', @SEARCH_DESCRIPOST, '%')
					  ) OR
					  (O.DESCRIPOST IS NULL OR O.DESCRIPOST = '')
					)
			) X
			ORDER BY 
				CASE WHEN @SORT_COLUMN = '0' THEN X.NROOST END DESC,
				CASE WHEN @SORT_COLUMN = '1' THEN X.DESCRIPOST END DESC,
				CASE WHEN @SORT_COLUMN = '2' THEN X.FECINICIO END DESC,
				CASE WHEN @SORT_COLUMN = '3' THEN X.FECTERM END DESC
			OFFSET @IDISPLAYSTART ROWS FETCH NEXT @IDISPLAYLENGTH ROWS ONLY
		END

		PRINT(@TOTAL_COUNT)
END