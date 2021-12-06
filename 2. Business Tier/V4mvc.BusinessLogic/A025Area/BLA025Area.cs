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
	public partial class BLA025Area : IBLA025Area
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAA025Area Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLA025Area(IDAA025Area x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<A025Area> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public A025Area GetOne(Int32 ID_AREA)
		{
			try
			{
				return this.Repository.GetOne(ID_AREA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref A025Area item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref A025Area item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<A025Area> items)
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
