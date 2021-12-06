using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public CursoReserva ValidateReserva(ref CursoReserva model)
		{
			try
			{
				return this.BL_CursoReserva.ValidateReserva(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public ObservableCollection<CursoReserva> GetListFuncionariosInscritos_CargarCurso(int codigo)
		{
			try
			{
				return this.BL_CursoReserva.GetListFuncionariosInscritos_CargarCurso(codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarListaCargarCursoReserva(ObservableCollection<CursoReserva> listaReservas)
		{
			try
			{
				return this.BL_CursoReserva.ActualizarListaCargarCursoReserva(listaReservas);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
