using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]
        ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionValidadaChecked_Mdte(Guid? ID, string RUT);
        ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoVehiculosChecked_Mdte(Guid ID, int ID_DOC, string PATENTE);
        ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoChecked_Mdte(Guid ID, int ID_DOC, string RUT);
        ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionChecked_Mdte(Guid? ID);
        ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoControlAccesoChecked_Mdte(Guid ID, int ID_DOC);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
