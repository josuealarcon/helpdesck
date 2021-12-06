using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLRol
	{
		
		#region [ Consultas ]
		public ObservableCollection<Rol> GetRolesSearcherCtta(ref Rol model)
		{
			try
			{
				return this.Repository.GetRolesSearcherCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
