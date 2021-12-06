
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]
		Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL, int NUM_SOLICITUD, out int SUBE_DOCUMENTO);

		Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD);

		#endregion

		#region [ Metodos ]
		bool SaveDocsOSTPrevencionista_ContratOSTCtta(Archivos archivo, Docs_OST_Prevencionista prev);

		bool DelDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD, string USUARIO);
		#endregion

	}
}
	