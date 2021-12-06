using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCursoAmbitos
	{
		#region [ Consultas ]
		public ObservableCollection<CursoAmbitos> GetAllCursosAmbitos_Mdte()
        {
			try
			{
				return this.Repository.GetAllCursosAmbitos_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
