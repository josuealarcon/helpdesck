using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]

		OSTArbol GetOneOSTArbol(string OST, string MADRE, string EMPRESA, Int16 NIVEL);
		OSTArbol GetOstArbolReferencia_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL);
		ObservableCollection<OSTArbol> GetAllOstArbolTurnos_Mdte(string EMPRESA);

		#endregion

		#region [ Metodos ]

		bool SaveOstArbol_Mdte(ref OSTArbol Item);
		OSTArbol SaveOstArbolOST_Mdte(ref OSTArbol Item);

		#endregion

	}
}
