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
	public partial class BLCursoClasificaciones : IBLCursoClasificaciones
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDACursoClasificaciones Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLCursoClasificaciones(IDACursoClasificaciones x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CursoClasificaciones> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CursoClasificaciones GetOne(Int32 ID)
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

		public bool Save(ref CursoClasificaciones item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref CursoClasificaciones item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<CursoClasificaciones> items)
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
