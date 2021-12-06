using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLA036_CursoProg_Docs
	{

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        public Boolean Save_A036_CURSOPROG_DOCS_mdte(ref A036_CursoProg_Docs Item)
        {
            try
            {
                return this.Repository.Save_A036_CURSOPROG_DOCS_mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
