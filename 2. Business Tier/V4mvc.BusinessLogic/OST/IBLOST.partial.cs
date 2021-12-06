using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLOST
	{

		#region [ Consultas ]
		ObservableCollection<OST> GetOSTsSearcherCtta(ref OST model);
		ObservableCollection<OST> GetAllOST_PasesCtta(string IDEMPRESA, string DIVISION, out string OST, out int CUENTA_CONTRATOS, out string FEC_INICIO, out string FEC_TERM);

		OST GetOneOST_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL);

		ObservableCollection<OST> GetAllOST_ControlLaboralCtta(string IDEMPRESA, string PERIODO);

		ObservableCollection<OST> GetAllOST_v2_ControlLaboralCtta(string IDEMPRESA, string DIVISION);
		#endregion

		#region [ Metodos ]
		bool SaveOST_ContratOSTCtta(Archivos archivo, int index, string NROOST);
		#endregion

	}
}
