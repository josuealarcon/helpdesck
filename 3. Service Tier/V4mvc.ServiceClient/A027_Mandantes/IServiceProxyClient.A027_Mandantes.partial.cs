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

		A027_Mandantes GetA027_MandantesEmpresa(string EMPRESA);

		#endregion

		#region [ Métodos ]

		#endregion

	}
}