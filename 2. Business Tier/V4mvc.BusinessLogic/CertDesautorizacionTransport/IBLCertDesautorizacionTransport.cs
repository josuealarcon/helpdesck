using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCertDesautorizacionTransport
	{
		#region [ Consultas ]

		ObservableCollection<CertDesautorizacionTransport> GetAll();

		CertDesautorizacionTransport GetOne(string PATENTE);

		#endregion

		#region [ Metodos ]

		bool Save(ref CertDesautorizacionTransport item);

		bool Delete(ref CertDesautorizacionTransport item);

		bool Save(ref ObservableCollection<CertDesautorizacionTransport> items);

		#endregion
	}
}
