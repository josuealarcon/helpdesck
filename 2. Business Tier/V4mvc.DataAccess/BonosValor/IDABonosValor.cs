using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDABonosValor
	{

		#region [ Consultas ]
		ObservableCollection<BonosValor> GetAll();
		#endregion

		#region [ Metodos ]
		bool Save(ref BonosValor Item);
		#endregion

	}
}
