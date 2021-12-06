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
		
		CursoReserva ValidateReserva(ref CursoReserva model);

		#endregion

		#region [ Metodos ]
		ObservableCollection<CursoReserva> GetListFuncionariosInscritos_CargarCurso(int codigo);
		bool CrearFuncionarioListaCargarCurso(CursoReserva cursoReserva);
		bool EliminarFuncionarioListaCargarCurso(CursoReserva cursoReserva);
		bool ActualizarFuncionarioListaCargarCurso(CursoReserva cursoReserva);
		bool ActualizarCursoProgramadoCargarCurso(int codigo);
		#endregion
	}
}
