using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLTalleresVeh
	{
        #region [ Consultas ]
        public ObservableCollection<TalleresVeh> GetListTalleresVeh_Ctta(string MARCA)
        {

            try
            {
                return this.Repository.GetListTalleresVeh_Ctta(MARCA);
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Metodos ]

        #endregion
    }
}
