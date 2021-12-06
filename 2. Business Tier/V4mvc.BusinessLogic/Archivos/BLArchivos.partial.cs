using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLArchivos
	{

        #region [ Consultas ]
        public Archivos GetFotoFuncionario(string ID)
        {
            try
            {
                return this.Repository.GetFotoFuncionario(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
