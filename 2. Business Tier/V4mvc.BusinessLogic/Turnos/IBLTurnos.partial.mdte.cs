using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTurnos
	{

        #region [ Consultas ]

        ObservableCollection<Turnos> GetTurnos_Mdte(ref Turnos model);
        Turnos GetOneTurno_Mdte(int IDTURNO);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
