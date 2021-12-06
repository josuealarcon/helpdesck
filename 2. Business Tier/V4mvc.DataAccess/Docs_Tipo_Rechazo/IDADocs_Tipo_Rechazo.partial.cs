using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Tipo_Rechazo
	{

        #region [ Consultas ]

        ObservableCollection<Docs_Tipo_Rechazo> GetDocsTipoRechazoDisputa(string DIVCOD, string COMUN_DIV, string ID);
        ObservableCollection<Docs_Tipo_Rechazo> GetDocsTipoRechazoDisputaFuncionariosCtta(string FECHA_INI, string FECHA_FIN, string RUT, Guid ID_ARCHIVO);
        ObservableCollection<Docs_Tipo_Rechazo> GetDocsTipoRechazoLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
