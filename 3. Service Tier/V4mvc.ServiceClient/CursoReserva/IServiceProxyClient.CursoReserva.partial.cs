using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
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
