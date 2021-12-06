using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAAAQ_Categorias
	{
        #region [ Consultas ]
        ObservableCollection<AAQ_Categorias> GetListCategorias_Mdte(ref AAQ_Categorias item);     

		AAQ_Categorias GetOneCategorias_Mdte(int IDCATEGORIA);

        #endregion

        #region [ Metodos ]

        bool SaveCategorias_Mdte(ref AAQ_Categorias item);

		bool DeleteCategorias_Mdte(string IDCATEGORIA);    





        #endregion
    }
}
