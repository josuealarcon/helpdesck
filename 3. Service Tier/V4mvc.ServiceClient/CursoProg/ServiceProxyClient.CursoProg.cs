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
		public IBLCursoProg BL_CursoProg { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCursoProg BL_CursoProg)
        {
            this.BL_CursoProg = BL_CursoProg;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<CursoProg> GetAllCursoProg()
		{
			try
			{
				return this.BL_CursoProg.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public CursoProg GetOneCursoProg(Int32 CODIGO)
		{
			try
			{
				return this.BL_CursoProg.GetOne(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveCursoProg(ref CursoProg Item)
		{
			try
			{
				return this.BL_CursoProg.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveCursoProg(ref ObservableCollection<CursoProg> Items)
		{
			try
			{
				return this.BL_CursoProg.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
