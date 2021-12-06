using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACertDesautorizacionTransport
	{
		#region [ Consultas ]

		ObservableCollection<CertDesautorizacionTransport> GetAll();

		CertDesautorizacionTransport GetOne(string PATENTE);

		#endregion

		#region [ Metodos ]

		bool Save(ref CertDesautorizacionTransport item);

		bool Delete(ref CertDesautorizacionTransport item);

		#endregion
	}
}
