using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.Entities;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
	public partial class BLAAQ_Regimen : IBLAAQ_Regimen
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAAAQ_Regimen Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLAAQ_Regimen(IDAAAQ_Regimen x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<AAQ_Regimen> GetListAAQ_Regimens_Mdte()
		{
			try
			{
				return this.Repository.GetListAAQ_Regimens_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public AAQ_Regimen GetOne(Int32 IDREGIMEN)
		{
			try
			{
				return this.Repository.GetOne(IDREGIMEN);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref AAQ_Regimen item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref AAQ_Regimen item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<AAQ_Regimen> items)
		{
			try
			{
				for (int i = 0; i < items.Count; ++i)
				{
					var item = items.ElementAt(i);
					this.Repository.Save(ref item);
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
