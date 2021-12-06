CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_UPDATE]
( 
 @PATENTE nvarchar(10)= NULL
,@TIPO int= NULL
,@COLOR nvarchar(30)= NULL
,@EMPRESA  nvarchar(10)= NULL
,@ANOFAB  nvarchar(4)= NULL
,@PERMISOCIRC  nvarchar(8)= NULL
,@FECSEGURO  nvarchar(8)= NULL
,@REVTEC nvarchar(8)= NULL
,@CAPACIDAD  smallint= NULL
,@OPERINVIER  nvarchar(2)= NULL
,@NRO  smallint= NULL
,@AUTOR  nvarchar(2)= NULL
,@MARCA  nvarchar(50)= NULL
,@MODELO  nvarchar(50)= NULL
,@CODMOP  nvarchar(3)= NULL
,@FECHAMOD  nvarchar(8)= NULL
,@HORAMOD  nvarchar(8)= NULL
,@GRABO  nvarchar(1)= NULL
,@FECCHECK  nvarchar(8)= NULL
,@FECMINERA  nvarchar(8)= NULL
,@LABEL  nvarchar(2)= NULL
,@OBS  nvarchar(100)= NULL
,@TIENEWISE  nvarchar(2)= NULL
,@FUNCACARGO  nvarchar(50)= NULL
,@FUNCNOM  nvarchar(50)= NULL
,@AREA  nvarchar(50)= NULL
,@NUMINT  nvarchar(50)= NULL
,@TIPO_PROPIETARIO  nvarchar(1)= NULL
,@RUT_PROPIETARIO  nvarchar(10)= NULL
,@USUARIO  nvarchar(10)= NULL
,@COMBUSTIBLE  int= NULL
,@TRACCION  int= NULL
,@CILINDRADA  nvarchar(50)= NULL
,@POTENCIA nvarchar(50)= NULL
,@TURNO  nvarchar(50)= NULL
,@SERVICIO  nvarchar(50)= NULL
,@MONITOREADO nvarchar(2)= NULL
,@EQUIPOADAS  nvarchar(2)= NULL
 ) AS
BEGIN
UPDATE [dbo].[TRANSPORT]
   SET 
        [TIPO] = @TIPO  
       ,[COLOR] = @COLOR        
       ,[EMPRESA] = @EMPRESA        
       ,[ANOFAB] = @ANOFAB        
       ,[PERMISOCIRC] = @PERMISOCIRC        
       ,[FECSEGURO] = @FECSEGURO        
       ,[REVTEC] = @REVTEC        
       ,[CAPACIDAD] = @CAPACIDAD     
       ,[OPERINVIER] = @OPERINVIER        
       ,[NRO] = @NRO     
       ,[AUTOR] = @AUTOR        
       ,[MARCA] = @MARCA        
       ,[MODELO] = @MODELO        
       ,[CODMOP] = @CODMOP        
       ,[FECHAMOD] = @FECHAMOD        
       ,[HORAMOD] = @HORAMOD        
       ,[GRABO] = @GRABO        
       ,[FECCHECK] = @FECCHECK        
       ,[FECMINERA] = @FECMINERA        
       ,[LABEL] = @LABEL        
       ,[OBS] = @OBS         
       ,[TIENEWISE] = @TIENEWISE        
       ,[FUNCACARGO] = @FUNCACARGO        
       ,[FUNCNOM] = @FUNCNOM        
       ,[AREA] = @AREA        
       ,[NUMINT] = @NUMINT        
       ,[TIPO_PROPIETARIO] = @TIPO_PROPIETARIO        
       ,[RUT_PROPIETARIO] = @RUT_PROPIETARIO        
       ,[USUARIO] = @USUARIO        
       ,[COMBUSTIBLE] = @COMBUSTIBLE   
       ,[TRACCION] = @TRACCION    
       ,[CILINDRADA] = @CILINDRADA        
       ,[POTENCIA] = @POTENCIA        
       ,[TURNO] = @TURNO        
       ,[SERVICIO] = @SERVICIO        
       ,[MONITOREADO] = @MONITOREADO        
       ,[EQUIPOADAS] = @EQUIPOADAS        
 WHERE [PATENTE] = @PATENTE     
END

