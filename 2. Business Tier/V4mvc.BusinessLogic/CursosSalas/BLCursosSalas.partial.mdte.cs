using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLCursosSalas
    {

        #region [ Consultas ]

        public ObservableCollection<CursosSalas> GetSalasMdteSearcherMdte(ref CursosSalas model)
        {
            try
            {
                return this.Repository.GetSalasMdteSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
