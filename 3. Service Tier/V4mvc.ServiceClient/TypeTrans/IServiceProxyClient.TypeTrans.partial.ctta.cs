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

		ObservableCollection<TypeTrans> GetAllTypeTrans_PasesCtta();
		ObservableCollection<TypeTrans> GetTypeTransCombo();

		ObservableCollection<TypeTrans> GetTypeTrans_Informes();

		TypeTrans GetOneTypeTrans_Informes(int IDTIPO);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
