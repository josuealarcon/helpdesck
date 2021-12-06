using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLCursoReserva
	{

		#region [ Consultas ]

		public CursoReserva ValidateReserva(ref CursoReserva model)
		{
			try
			{
				return this.Repository.ValidateReserva(ref model);
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
				return this.Repository.GetListFuncionariosInscritos_CargarCurso(codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarListaCargarCursoReserva(ObservableCollection<CursoReserva> listaReservas)
		{
			try
			{
				var options = new TransactionOptions();
				options.IsolationLevel = IsolationLevel.Serializable;
				using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Required, options))
				{
					var curso = listaReservas.First();
					if (curso.FINALIZAR == "SI" && listaReservas.Count() == 1)
					{
						this.Repository.ActualizarCursoProgramadoCargarCurso(curso.CODIGO);
					}
					else
					{
						if (curso.FINALIZAR == "SI")
						{
							this.Repository.ActualizarCursoProgramadoCargarCurso(curso.CODIGO);
							listaReservas.RemoveAt(0);
						}
						listaReservas.ToList().ForEach(reserva =>
						{
							if (reserva.ESTADO == "NEW")
							{
								this.Repository.CrearFuncionarioListaCargarCurso(reserva);

							}
							else if (reserva.ESTADO == "DELETE")
							{
								this.Repository.EliminarFuncionarioListaCargarCurso(reserva);
							}
							else
							{
								this.Repository.ActualizarFuncionarioListaCargarCurso(reserva);
							}
						});
					}
					tran.Complete();
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
