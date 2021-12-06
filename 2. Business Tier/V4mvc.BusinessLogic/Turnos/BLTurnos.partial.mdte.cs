using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLTurnos
	{

        #region [ Consultas ]

        public ObservableCollection<Turnos> GetTurnos_Mdte(ref Turnos model)
        {
            try
            {
                return this.Repository.GetTurnos_Mdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Turnos GetOneTurno_Mdte(int IDTURNO)
        {
            try
            {
                return this.Repository.GetOneTurno_Mdte(IDTURNO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
