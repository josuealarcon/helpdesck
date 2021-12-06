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
        ObservableCollection<AAQ_Categorias> GetListCategoriasPorRegimen_Mdte(int IDREGIMEN);
        #endregion

        #region [ Métodos ]

        bool SaveUpdateCategoria_Mdte(ref AAQ_Categorias item);


        bool ValidarCategoria_Mdte(int IDREGIMEN, string NOMBRE,int IDCATEGORIA);
        #endregion

    }
}
