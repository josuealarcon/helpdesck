using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]
     
        ObservableCollection<AAQ_Categorias> GetListCategorias_Mdte(ref AAQ_Categorias item);

		AAQ_Categorias GetOneCategorias_Mdte(int IDCATEGORIA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveCategorias_Mdte(ref AAQ_Categorias item);
		
		bool DeleteCategorias_Mdte(string IDCATEGORIA);
		
		bool SaveCategorias_Mdte(ref ObservableCollection<AAQ_Categorias> items);
		
		#endregion

	}
}
