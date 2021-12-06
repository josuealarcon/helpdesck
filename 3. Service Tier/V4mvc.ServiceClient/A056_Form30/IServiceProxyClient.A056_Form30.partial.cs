
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
		ObservableCollection<A056_Form30> GetAllFormF30_ControlLaboralCtta(string IDEMPRESA);

		A056_Form30 GetOneFormF30_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO);

		A056_Form30 GetOneFormF30_v2_ControlLaboralCtta(int ID_CERTIFICADO);

		A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(Guid ID);

		A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int CERTIFICADO_ID);
		#endregion

		#region [ Metodos ]
		bool SaveFormF30_ControlLaboralCtta(ref Archivos archivo, A056_Form30 model, out int RET_CODE);

		bool DelFormF30DispFile_ControlLaboralCtta(ref A056_Form30 modelo);

		bool DelFormF30_ControlLaboralCtta(ref A056_Form30 modelo);
		#endregion

	}
}
	