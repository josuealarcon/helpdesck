
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADivAprobacionMedico
    {
        #region [ Consultas ]
        DivAprobacionMedico GetOneDivAprobacionMedico_PasesCtta(string DIVCOD);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	