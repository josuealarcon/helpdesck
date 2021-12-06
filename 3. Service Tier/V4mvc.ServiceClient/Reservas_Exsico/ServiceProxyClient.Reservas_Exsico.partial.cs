using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoCtta(string FECHARES)
		{
            try
            {
                return this.BL_Reservas_Exsico.GetAllReservas_ExsicoCtta(FECHARES);
            }
            catch (Exception ex)
            { throw ex; }

		}

		public ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoEnterpriseCtta(string IDEMPRESA, string FECHARES)
		{
			try
			{
				return this.BL_Reservas_Exsico.GetAllReservas_ExsicoEnterpriseCtta(IDEMPRESA, FECHARES);
			}
			catch (Exception ex)
			{ throw ex; }

		}

		public ObservableCollection<Reservas_Exsico> GetAllTurnosExsicoCtta(string FECHARES)
		{
			try
			{
				return this.BL_Reservas_Exsico.GetAllTurnosExsicoCtta(FECHARES);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean EliminarReservasExsicoCtta(string USUARIO, string LIST_ID)
		{
			try
			{
				return this.BL_Reservas_Exsico.EliminarReservasExsicoCtta(USUARIO, LIST_ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}