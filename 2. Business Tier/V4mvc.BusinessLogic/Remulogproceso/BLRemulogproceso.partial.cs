using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLRemulogproceso
	{

		#region [ Consultas ]
		public ObservableCollection<Remulogproceso> Get_Remulogproceso_InformeDocumentosCargadosDetalle_InformeControlLaboralCtta(Remulogproceso Item)
		{
			try
			{
				var response = Repository.Get_Remulogproceso_InformeDocumentosCargadosDetalle_InformeControlLaboralCtta(Item);

				if (response != null)
				{
					foreach (var item in response)
					{
						item.FPROCESO_LETRA = Utils.Fec_User(item.FPROCESO, Utils.Formato_Fecha.GuionMesLetras);
						item.RUT_COD = Utils.strRut(item.RUT);
						item.EMPRESA_COD = Utils.strRut(item.EMPRESA);
						if (item.IMPONIBLE_P != null)
							item.IMPONIBLE_P_COD= Utils.agregar_puntos_miles(item.IMPONIBLE_P.ToString());
					}
				}
				return response;

			}
			catch (Exception ex)
			{ throw ex; }
		}	
		
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
