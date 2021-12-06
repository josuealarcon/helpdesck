using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLProgBus
    {

        #region [ Consultas ]
        public ObservableCollection<ProgBus> GetListBusesProgramacion_mdte(ProgBus ProgBus)
        {
            try
            {
                var response = Repository.GetListBusesProgramacion_mdte(ProgBus);
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
