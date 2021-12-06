using System;
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
		public IBLTurnos BL_Turnos { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTurnos BL_Turnos)
        {
            this.BL_Turnos = BL_Turnos;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Turnos> GetAllTurnos()
		{
			try
			{
				return this.BL_Turnos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Turnos GetOneTurnos(int IDTURNO)
		{
			try
			{
				return this.BL_Turnos.GetOne(IDTURNO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTurnos(ref Turnos Item)
		{
			try
			{
				return this.BL_Turnos.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTurnos(ref ObservableCollection<Turnos> Items)
		{
			try
			{
				return this.BL_Turnos.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
