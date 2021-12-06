using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTalleresVeh
	{
        #region [ Consultas ]
        ObservableCollection<TalleresVeh> GetListTalleresVeh_Ctta(string MARCA);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
