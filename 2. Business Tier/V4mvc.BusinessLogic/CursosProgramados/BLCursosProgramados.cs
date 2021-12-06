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
	public partial class BLCursosProgramados : IBLCursosProgramados
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDACursosProgramados Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLCursosProgramados(IDACursosProgramados x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CursosProgramados> GetAll(ref CursosProgramados cursosProgramados)
		{
			try
			{
				return this.Repository.GetAll(ref cursosProgramados);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CursosProgramados GetOne(Int32 CODIGO)
		{
			try
			{
				return this.Repository.GetOne(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref CursosProgramados item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref CursosProgramados item)
		{
			try
			{
				return this.Repository.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<CursosProgramados> items)
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
