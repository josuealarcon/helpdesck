using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]
		
		ObservableCollection<OSTSubc> GetListContratOST_Mdte(ref OSTSubc model);
		OSTSubc GetOST_Empresa_Mdte(ref OSTSubc model);
		OSTSubc GetOstSubcOST_Mdte(string OST, string EMPRESA, Int16 NIVEL);

		#endregion

		#region [ Metodos ]

		bool SaveOST_Mdte(OSTSubc item);
		bool SaveOSTEmpresa_Mdte(OSTSubc item);

		#endregion

	}
}
