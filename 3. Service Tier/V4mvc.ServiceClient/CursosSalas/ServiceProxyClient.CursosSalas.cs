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
		public IBLCursosSalas BL_CursosSalas { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCursosSalas BL_CursosSalas)
        {
            this.BL_CursosSalas = BL_CursosSalas;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<CursosSalas> GetAllCursosSalas()
		{
			try
			{
				return this.BL_CursosSalas.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public CursosSalas GetOneCursosSalas()
		{
			try
			{
                return null;// this.BL_CursosSalas.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveCursosSalas(ref CursosSalas Item)
		{
			try
			{
				return this.BL_CursosSalas.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveCursosSalas(ref ObservableCollection<CursosSalas> Items)
		{
			try
			{
				return this.BL_CursosSalas.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
