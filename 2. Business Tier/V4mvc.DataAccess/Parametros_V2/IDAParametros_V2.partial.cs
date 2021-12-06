
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAParametros_V2
    {
        #region [ Consultas ]
        Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(int Id_Parametro);
        Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(string DESCRIPCION);
        Parametros_V2 GetParametros_SubidaDocsCtta(int ID_DOC, string DIVCOD, string RUT, string IDEMPRESA);
        #endregion

        #region [ Metodos ]

        #endregion

        #region [ func_getdatos V3 ]

        Parametros_V2 GetParametrov2Descripcion(string DESCRIPCION);

        #endregion
    }
}
	