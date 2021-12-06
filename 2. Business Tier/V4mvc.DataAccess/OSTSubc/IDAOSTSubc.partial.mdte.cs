using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAOSTSubc
    {

        #region [ Consultas ]    
        
        ObservableCollection<OSTSubc> GetListContratOST_Mdte(ref OSTSubc model);
        OSTSubc GetOST_Empresa_Mdte(ref OSTSubc ostSubc);
        OSTSubc GetOstSubcOST_Mdte(string OST, string EMPRESA, Int16 NIVEL);

        #endregion

        #region[ Metodos ]

        bool SaveOST_Mdte(OSTSubc model);
        bool SaveOSTEmpresa_Mdte(OSTSubc ostSubc);

        #endregion

    }
}
