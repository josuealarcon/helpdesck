using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCheckDetail
	{
        #region [ Consultas ]

        public ObservableCollection<CheckDetail> GetPreguntasListadoEncuestas_Ctta(int ID_CHECKINGHEAD)
        {
            try
            {
                return this.Repository.GetPreguntasListadoEncuestas_Ctta(ID_CHECKINGHEAD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
