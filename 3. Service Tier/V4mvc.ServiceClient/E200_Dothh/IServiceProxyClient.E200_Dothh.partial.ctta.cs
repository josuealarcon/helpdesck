using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<E200_Dothh> GetSubContratistasE200Dot_Ctta(string OST);
		ObservableCollection<E200_Dothh> GetAllE200_Datos_Dothh_SubcontratistaCtta(Guid ID);
		#endregion

		#region [ Metodos ]
		bool Save_E200_Dothh_Ctta(ref ObservableCollection<E200_Dothh> items);

		#endregion

	}
}
