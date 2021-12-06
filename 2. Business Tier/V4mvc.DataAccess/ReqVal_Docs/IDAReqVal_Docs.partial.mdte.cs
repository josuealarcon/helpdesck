using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAReqVal_Docs
	{

        #region [ Consultas ]

        ObservableCollection<ReqVal_Docs> GetListRequisitos_Mdte(int ID_DOC);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
