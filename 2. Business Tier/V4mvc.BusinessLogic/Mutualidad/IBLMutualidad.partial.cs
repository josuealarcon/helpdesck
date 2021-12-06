using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLMutualidad
	{

        #region [ Consultas ]

        ObservableCollection<Mutualidad> GetMutualidadDocumentacionCtta(int ID_DOC);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
