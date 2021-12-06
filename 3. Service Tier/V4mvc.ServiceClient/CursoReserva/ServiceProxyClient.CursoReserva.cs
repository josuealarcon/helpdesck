using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{
		
		#region [ Propiedades ]
		[Dependency]
		public IBLCursoReserva BL_CursoReserva { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCursoReserva BL_CursoReserva)
        {
            this.BL_CursoReserva = BL_CursoReserva;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<CursoReserva> GetAllCursoReserva(Int32 CODIGO)
		{
			try
			{
				return this.BL_CursoReserva.GetAll(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public CursoReserva GetOneCursoReserva(Int32 CODIGO, String RUT)
		{
			try
			{
				return this.BL_CursoReserva.GetOne(CODIGO, RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveCursoReserva(ref CursoReserva Item)
		{
			try
			{
				return this.BL_CursoReserva.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveCursoReserva(ref ObservableCollection<CursoReserva> Items)
		{
			try
			{
				return this.BL_CursoReserva.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
