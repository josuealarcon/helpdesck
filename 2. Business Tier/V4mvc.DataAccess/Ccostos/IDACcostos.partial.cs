using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACcostos
	{

		#region [ Consultas ]

		ObservableCollection<Ccostos> GetAllCcostosEnterpriseCtta(string EMPRESA);
		Ccostos GetOneCcostoEnterpriseCtta(string EMPRESA, string CCOSTO);
		ObservableCollection<Ccostos> GetCCostosSearcherCtta(ref Ccostos model);

		#endregion

		#region [ Métodos ]

		bool SaveCcostoEntepriseCtta(ref Ccostos Item);
		bool ValidateCcosto_Ctta(string IDEMPRESA, string CCOSTO);

		#endregion

	}
}
