using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_Mdte(string NROOST, string MANDANTE, string EMPRESA);

        #endregion

        #region [ Metodos ]

        bool SaveOstDivLocalOST_Mdte(ref OSTDivLocal Item);
        bool SaveOstDivLocalOST_Mdte(ObservableCollection<OSTDivLocal> Items);

        #endregion

    }
}
