
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
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
		public Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(int Id_Parametro)
        {
            try
            {
                return this.BL_Parametros_V2.GetOneParametros_V2_ControlLaboralCtta(Id_Parametro);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(string DESCRIPCION)
        {
            try
            {
                return this.BL_Parametros_V2.GetOneParametros_V2_ControlLaboralCtta(DESCRIPCION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

        #region [ func_getdatos V3 ]

        public Parametros_V2 GetParametrov2Descripcion(string DESCRIPCION)
        {
            try
            {
                return this.BL_Parametros_V2.GetParametrov2Descripcion(DESCRIPCION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
	