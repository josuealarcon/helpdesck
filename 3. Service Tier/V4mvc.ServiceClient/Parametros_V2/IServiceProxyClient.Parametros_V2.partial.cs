
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]
		Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(int Id_Parametro);

		Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(string DESCRIPCION);
        #endregion

        #region [ Metodos ]

        #endregion

        #region [ func_getdatos V3 ]

        Parametros_V2 GetParametrov2Descripcion(string DESCRIPCION);

        #endregion

    }
}
	