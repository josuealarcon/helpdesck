using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_TipoContrato
	{

        #region [ Consultas ]

        ObservableCollection<Tab_TipoContrato> GetTiposContratoDocumentacionCtta(string RUT, string DIVCOD, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
