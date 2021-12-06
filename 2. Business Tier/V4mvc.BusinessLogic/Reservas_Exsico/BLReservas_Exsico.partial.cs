using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLReservas_Exsico
	{

		#region [ Consultas ]

		public ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoCtta(string FECHARES)
		{
			try
			{
				return this.Repository.GetAllReservas_ExsicoCtta(FECHARES);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoEnterpriseCtta(string IDEMPRESA, string FECHARES)
		{
			try
			{
				return this.Repository.GetAllReservas_ExsicoEnterpriseCtta(IDEMPRESA, FECHARES);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Reservas_Exsico> GetAllTurnosExsicoCtta(string FECHARES)
		{
			try
			{
				return this.Repository.GetAllTurnosExsicoCtta(FECHARES);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public bool EliminarReservasExsicoCtta(string USUARIO, string LIST_ID)
		{
			try
			{
				return this.Repository.EliminarReservasExsicoCtta(USUARIO, LIST_ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}