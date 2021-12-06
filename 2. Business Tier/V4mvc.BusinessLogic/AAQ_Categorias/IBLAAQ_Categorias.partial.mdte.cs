using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLAAQ_Categorias
	{
        #region [ Consultas ]
        ObservableCollection<AAQ_Categorias> GetListCategoriasPorRegimen_Mdte(int IDREGIMEN);

        #endregion

        #region [ Metodos ]
        bool SaveUpdateCategoria_Mdte(ref AAQ_Categorias item);
        bool ValidarCategoria_Mdte(int IDREGIMEN, string NOMBRE, int IDCATEGORIA);

        #endregion
    }
}
