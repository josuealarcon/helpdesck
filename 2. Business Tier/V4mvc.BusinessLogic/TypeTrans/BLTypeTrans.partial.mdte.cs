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
		
		public ObservableCollection<TypeTrans> GetAllTypeTrans_CertificacionMdte()
		{
			try
			{
				return Repository.GetAllTypeTrans_CertificacionMdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		public ObservableCollection<TypeTrans> GetListTypeTrans_Mdte()
        {
            try
            {
                return this.Repository.GetListTypeTrans_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
