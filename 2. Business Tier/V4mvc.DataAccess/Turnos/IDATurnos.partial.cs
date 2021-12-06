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
		ObservableCollection<Turnos> GetTurnosByEmpOST_Ctta(string ID_EMPRESA, string OST);
        ObservableCollection<Turnos> GetAllTurnosCtta(string IDEMPRESA);
        ObservableCollection<Turnos> GetAllCalendarioTurnosCtta(int IDTURNO, string IDEMPRESA, string TURNO, string ANIO, string MES);
        Turnos UpdateTurnoTurnosCtta(int IDTURNO);
        Turnos GetTurnoPorTurnoOstTurnosCtta(Turnos Item);
        #endregion

        #region [ Metodos ]
        bool UpdateTurnoPorTurnoOstTurnosCtta(Turnos item);
        #endregion
    }
}
