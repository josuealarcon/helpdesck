using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAArchivos
	{

        #region [ Consultas ]
        Archivos GetFotoFuncionario(string ID);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
