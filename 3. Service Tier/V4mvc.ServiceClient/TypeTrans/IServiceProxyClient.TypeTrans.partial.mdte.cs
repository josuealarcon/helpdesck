using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<TypeTrans> GetAllTypeTrans_PasesMdte();

		ObservableCollection<TypeTrans> GetAllTypeTrans_CertificacionMdte();

        ObservableCollection<TypeTrans> GetListTypeTrans_Mdte();
        
		#endregion

        #region [ Metodos ]

        #endregion

    }
}
