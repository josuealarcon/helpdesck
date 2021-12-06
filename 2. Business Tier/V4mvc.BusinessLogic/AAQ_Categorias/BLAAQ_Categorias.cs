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
	public partial class BLAAQ_Categorias : IBLAAQ_Categorias
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAAAQ_Categorias Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLAAQ_Categorias(IDAAAQ_Categorias x_container)
		{
			Repository = x_container;
		}
     

        #endregion

        #region [ Consultas ]

        public ObservableCollection<AAQ_Categorias> GetListCategorias_Mdte(ref AAQ_Categorias item)
		{
			try
			{
				return this.Repository.GetListCategorias_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
    

        public AAQ_Categorias GetOneCategorias_Mdte(int IDCATEGORIA)
		{
			try
			{
				return this.Repository.GetOneCategorias_Mdte(IDCATEGORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool SaveCategorias_Mdte(ref AAQ_Categorias item)
		{
			try
			{
				return this.Repository.SaveCategorias_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCategorias_Mdte(string IDCATEGORIA)
		{
			try
			{
				return this.Repository.DeleteCategorias_Mdte(IDCATEGORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCategorias_Mdte(ref ObservableCollection<AAQ_Categorias> items)
		{
			try
			{
				for (int i = 0; i < items.Count; ++i)
				{
					var item = items.ElementAt(i);
					this.Repository.SaveCategorias_Mdte(ref item);
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
