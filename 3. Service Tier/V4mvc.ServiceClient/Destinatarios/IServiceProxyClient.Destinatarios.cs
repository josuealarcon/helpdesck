using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]
		ObservableCollection<Destinatarios> GetAllDestinatarios(String MODULO);
		Destinatarios GetOneDestinatarios(String MODULO);
		#endregion

		#region [ Metodos ]
		Boolean SaveDestinatarios(ref Destinatarios Item);
		Boolean SaveDestinatarios(ref ObservableCollection<Destinatarios> Items);
		#endregion
	}
}
