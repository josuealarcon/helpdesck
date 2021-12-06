using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTurnos
	{

		#region [ Consultas ]
		ObservableCollection<Turnos> GetTurnosByEmpOST_Ctta(string ID_EMPRESA, string OST);
        ObservableCollection<Turnos> GetAllTurnosCtta(string IDEMPRESA);
        ObservableCollection<Turnos> GetAllCalendarioTurnosCtta(int IDTURNO, string IDEMPRESA, string TURNO, string ANIO, string MES);
        Turnos GetTurnoEdit_TurnosCtta(int IDTURNO);
        bool SaveTurno_TurnosCtta(Turnos Item);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
