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
	public partial class BLE200_Datos : IBLE200_Datos
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAE200_Datos Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLE200_Datos(IDAE200_Datos x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<E200_Datos> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public E200_Datos GetOne(Guid? ID)
		{
			try
			{
				return this.Repository.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref E200_Datos item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref E200_Datos item)
		{
			try
			{
				return this.Repository.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<E200_Datos> items)
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
