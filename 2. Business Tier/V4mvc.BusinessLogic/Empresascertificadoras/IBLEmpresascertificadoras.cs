using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLEmpresascertificadoras
	{
		#region [ Consultas ]

		ObservableCollection<Empresascertificadoras> GetAll();

		Empresascertificadoras GetOne(Int32 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref Empresascertificadoras item);

		bool Delete(ref Empresascertificadoras item);

		bool Save(ref ObservableCollection<Empresascertificadoras> items);

		#endregion
	}
}
