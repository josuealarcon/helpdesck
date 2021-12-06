using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLAAQ_Categorias
	{
        #region [ Consultas ]

        public ObservableCollection<AAQ_Categorias> GetListCategoriasPorRegimen_Mdte(int IDREGIMEN)
        {
            try
            {
                return this.Repository.GetListCategoriasPorRegimen_Mdte(IDREGIMEN);
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
                return this.Repository.SaveUpdateCategoria_Mdte(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }
       public bool ValidarCategoria_Mdte(int IDREGIMEN, string NOMBRE, int IDCATEGORIA)
        {

            try
            {
                return this.Repository.ValidarCategoria_Mdte(IDREGIMEN, NOMBRE,IDCATEGORIA);
            }
            catch (Exception ex)
            { throw ex; }

        }
        #endregion
    }
}
