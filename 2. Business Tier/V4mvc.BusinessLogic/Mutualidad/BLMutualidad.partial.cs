using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLMutualidad
	{

        #region [ Consultas ]

        public ObservableCollection<Mutualidad> GetMutualidadDocumentacionCtta(int ID_DOC)
        {
            try
            {
                return this.Repository.GetMutualidadDocumentacionCtta(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
