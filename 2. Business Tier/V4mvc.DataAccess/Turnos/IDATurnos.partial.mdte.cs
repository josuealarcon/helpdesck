using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATurnos
	{

        #region [ Consultas ]
        ObservableCollection<Turnos> GetTurnos_Mdte(ref Turnos model);
        Turnos GetOneTurno_Mdte(int IDTURNO);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
