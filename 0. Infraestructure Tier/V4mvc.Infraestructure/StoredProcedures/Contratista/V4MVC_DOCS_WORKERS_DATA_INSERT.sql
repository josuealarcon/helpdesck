CREATE PROCEDURE [dbo].[V4MVC_DOCS_WORKERS_DATA_INSERT]
( @ID            int = NULL
, @ID_DOC        uniqueidentifier = NULL
, @SALARIO       nvarchar(50) = NULL
, @CARGO         int = NULL
, @TURNO         nvarchar(50) = NULL
, @OST           nvarchar(20) = NULL
, @TIPOCONTRATO  nvarchar(50) = NULL
, @SUELDO_BASE   nvarchar(50) = NULL ) AS 
BEGIN

   INSERT INTO [DOCS_WORKERS_DATA]
        ( ID_DOC , SALARIO , CARGO        , TURNO
        , OST   , TIPOCONTRATO , SUELDO_BASE  )
   VALUES
        ( @ID_DOC , @SALARIO , @CARGO        , @TURNO
        , @OST   , @TIPOCONTRATO , @SUELDO_BASE  )


END


