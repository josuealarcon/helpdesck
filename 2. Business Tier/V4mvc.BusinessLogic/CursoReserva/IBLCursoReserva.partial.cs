using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCursoReserva
	{

		#region [ Consultas ]

		CursoReserva ValidateReserva(ref CursoReserva model);

		#endregion

		#region [ Metodos ]
		ObservableCollection<CursoReserva> GetListFuncionariosInscritos_CargarCurso(int codigo);
		bool ActualizarListaCargarCursoReserva(ObservableCollection<CursoReserva> listaReservas);
		#endregion

	}
}
