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
		public IBLCharlas BL_Charlas { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCharlas BL_Charlas)
        {
            this.BL_Charlas = BL_Charlas;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Charlas> GetAllCharlas()
		{
			try
			{
				return this.BL_Charlas.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Charlas GetOneCharlas(Int32 IDCHARLA)
		{
			try
			{
				return this.BL_Charlas.GetOne(IDCHARLA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveCharlas(ref Charlas Item)
		{
			try
			{
				return this.BL_Charlas.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveCharlas(ref ObservableCollection<Charlas> Items)
		{
			try
			{
				return this.BL_Charlas.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
