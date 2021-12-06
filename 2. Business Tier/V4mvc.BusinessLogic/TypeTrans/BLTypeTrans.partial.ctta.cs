using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLTypeTrans
	{

		#region [ Consultas ]
		


		public ObservableCollection<TypeTrans> GetTypeTransCombo()
		{
			try
			{
				return this.Repository.GetTypeTransCombo();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<TypeTrans> GetTypeTrans_Informes()
		{
			try
			{
				return this.Repository.GetTypeTrans_Informes();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public TypeTrans GetOneTypeTrans_Informes(int IDTIPO)
		{
			try
			{
				return this.Repository.GetOneTypeTrans_Informes(IDTIPO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
