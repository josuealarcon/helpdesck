using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACursoReserva
	{

		#region [ Consultas ]
		ObservableCollection<CursoReserva> GetList_A142_RESERVAS_Mdte(int CODIGO);
		ObservableCollection<CursoReserva> GetList_A142_RESULTADOS_Mdte(int CODIGO);
		string ValidarReserva_Mdte(int CURSO, string RUT, int CODIGO);	
		#endregion

		#region [ Metodos ]
		bool SaveCursoReserva_Mdte( CursoReserva item);
        bool SaveParticipanteCursoRsultado_Mdte( CursoReserva item);
        #endregion
    }
}
