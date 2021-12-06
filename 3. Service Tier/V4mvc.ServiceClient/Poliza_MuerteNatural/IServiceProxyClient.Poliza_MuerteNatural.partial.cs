
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
		ObservableCollection<Poliza_MuerteNatural> GetAllPolizaMuerteNatural_ControlLaboralCtta(string IDEMPRESA);

		Poliza_MuerteNatural GetOnePolizaMuerteNat_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

		Poliza_MuerteNatural GetOnePolizaMuerteNat_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

		Poliza_MuerteNatural GetOnePolizaMuerteNat_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
		#endregion

		#region [ Metodos ]
		bool SavePolizaMuerteNat_ControlLaboralCtta(ref Archivos archivo, Poliza_MuerteNatural model, out int RET_CODE);

		bool DelPolizaMuerteNatDispFile_ControlLaboralCtta(ref Poliza_MuerteNatural modelo);

		bool DelPolizaMuerteNat_ControlLaboralCtta(ref Poliza_MuerteNatural modelo);
		#endregion

	}
}
	