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
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		public bool SaveWorkercasino_Ctta(ObservableCollection<Local> LOCALES, ObservableCollection<Servicio> SERVICIOS ,string RUT)
		{
			try
			{
				return this.BL_Workerscasino.SaveWorkercasino_Ctta(LOCALES, SERVICIOS, RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteWorkerCasino_Ctta(string RUT)
		{
			try
			{
				return this.BL_Workerscasino.DeleteWorkerCasino_Ctta(RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
