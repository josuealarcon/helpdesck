
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
		ObservableCollection<_F29> GetAllF29_ControlLaboralCtta(string IDEMPRESA);

		_F29 GetOneFormF29_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

		_F29 GetOneFormF29_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

		_F29 GetOneFormF29_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
		#endregion

		#region [ Metodos ]
		bool SaveFormF29_ControlLaboralCtta(ref Archivos archivo, _F29 model, out int RET_CODE);

		bool DelFormF29DispFile_ControlLaboralCtta(ref _F29 modelo);

		bool DelFormF29_ControlLaboralCtta(ref _F29 modelo);
		#endregion

	}
}
	