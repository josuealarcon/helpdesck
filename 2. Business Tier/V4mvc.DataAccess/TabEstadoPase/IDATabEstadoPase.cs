using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATabEstadoPase
	{
		#region [ Consultas ]

		ObservableCollection<TabEstadoPase> GetAll();

		TabEstadoPase GetOne(string ESTADO_PASE);

		#endregion

		#region [ Metodos ]

		bool Save(ref TabEstadoPase item);

		bool Delete(ref TabEstadoPase item);

		#endregion
	}
}
