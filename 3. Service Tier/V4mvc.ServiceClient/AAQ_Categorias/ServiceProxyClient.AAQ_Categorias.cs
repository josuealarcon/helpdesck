using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLAAQ_Categorias BL_AAQ_Categorias { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLAAQ_Categorias BL_AAQ_Categorias)
		{
			this.BL_AAQ_Categorias = BL_AAQ_Categorias;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<AAQ_Categorias> GetListCategorias_Mdte(ref AAQ_Categorias item)
		{
			try
			{
				return this.BL_AAQ_Categorias.GetListCategorias_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public AAQ_Categorias GetOneCategorias_Mdte(int IDCATEGORIA)
        {
			try
			{
				return this.BL_AAQ_Categorias.GetOneCategorias_Mdte(IDCATEGORIA);
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
				return this.BL_AAQ_Categorias.SaveCategorias_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCategorias_Mdte(string IDCATEGORIA)
		{
			try
			{
				return this.BL_AAQ_Categorias.DeleteCategorias_Mdte(IDCATEGORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCategorias_Mdte(ref ObservableCollection<AAQ_Categorias> items)
		{
			try
			{
				return this.BL_AAQ_Categorias.SaveCategorias_Mdte(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
