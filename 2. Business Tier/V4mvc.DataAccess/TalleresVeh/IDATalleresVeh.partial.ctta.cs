using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATalleresVeh
	{
        #region [ Consultas ]
        ObservableCollection<TalleresVeh> GetListTalleresVeh_Ctta(string MARCA);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
