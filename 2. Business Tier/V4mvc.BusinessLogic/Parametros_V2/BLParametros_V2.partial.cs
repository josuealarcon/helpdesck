
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLParametros_V2
    {
        #region [ Consultas ]
        public Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(int Id_Parametro)
        {
            try
            {
                return Repository.GetOneParametros_V2_ControlLaboralCtta(Id_Parametro);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(string DESCRIPCION)
        {
            try
            {
                return Repository.GetOneParametros_V2_ControlLaboralCtta(DESCRIPCION);
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
                return Repository.GetParametrov2Descripcion(DESCRIPCION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
	