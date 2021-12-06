using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{


        #region [ Consultas ]
        public ObservableCollection<AAQ_Categorias> GetListCategoriasPorRegimen_Mdte(int IDREGIMEN)
        {
            try
            {
                return BL_AAQ_Categorias.GetListCategoriasPorRegimen_Mdte(IDREGIMEN);

            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]


        public bool SaveUpdateCategoria_Mdte(ref AAQ_Categorias item)
        {
            try
            {
                return this.BL_AAQ_Categorias.SaveUpdateCategoria_Mdte(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarCategoria_Mdte(int IDREGIMEN, string NOMBRE,int IDCATEGORIA)
        {
            try
            {
                return this.BL_AAQ_Categorias.ValidarCategoria_Mdte(IDREGIMEN,NOMBRE,IDCATEGORIA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
