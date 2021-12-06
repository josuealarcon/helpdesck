using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALiquidacion_Disputa
	{

		#region [ Consultas ]
		Liquidacion_Disputa GetLiquidacion_DisputaTop1(string RUT, string PERIODO, string EMPRESA);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
