CREATE PROCEDURE [dbo].[V4MVC_TURNOS_SELECT_ONE]
(@IDTURNO int = NULL) AS 
BEGIN

SELECT [EMPRESA]
      ,[TURNO]
      ,[LOCAL]
      ,[DIATRABAJO]
      ,[DIADESCANSO]
      ,[DDIURNO]
      ,[DNOCHE]
      ,[DDIURNO2]
      ,[DNOCHE2]
      ,[FECINICIO]
      ,[TURDESCR]
      ,[DOTTURNO]
      ,[CLASETUR]
      ,[ESTADOTUR]
      ,[OBSERVTUR]
      ,[TIENEHE]
      ,[HMAXDIANOR]
      ,[HMAXDIAHE]
      ,[HSEMANA]
      ,[HEXTRAS]
      ,[HINGRESO]
      ,[HINDESDE]
      ,[HINHASTA]
      ,[HOUTDESDE]
      ,[HOUTHASTA]
      ,[HALIMI]
      ,[HALIMS]
      ,[FECHAMOD]
      ,[HORAMOD]
      ,[GRABO]
      ,[TIENEFERIADO]
      ,[HSALIDA]
      ,[IDTURNO]
      ,[USUARIOMOD]
      ,[VISIBLE]
      ,[TIPO]
      ,[HINGRESON]
      ,[HINDESDEN]
      ,[HINHASTAN]
      ,[HSALIDAN]
      ,[HOUTDESDEN]
      ,[HOUTHASTAN]
      ,[HALIMIN]
      ,[HALIMSN]
      ,[HSAL_ULIMODIA]
      ,[FVIGENCIA]
      ,[EMPIEZANOCHEA]
      ,[EMPIEZANOCHEB]
      ,[EMPIEZA]
      ,[OST]
      ,[ID]
      ,[VALIDADO]
      ,[USRSUBE]
      ,[FECSUBE]
      ,[HORASUBE]
      ,[CERTUSUARIO]
      ,[CERTFECHA]
      ,[CERTHORA]
      ,[OBS_RECHAZO]
      ,[HSAL_ULIMONOCHE]
  FROM [dbo].[TURNOS]
  WHERE IDTURNO =@IDTURNO

END


