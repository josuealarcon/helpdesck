
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
		Docs_Disputa_CLaboral GetOneDocsDisputaCLab_ControlLaboralCtta(int DISPUTA_ID);
		#endregion

		#region [ Metodos ]
		bool SaveDocDisputaCLab_ControlLaboralCtta(ref Docs_Disputa_CLaboral instance);
		#endregion

	}
}
	