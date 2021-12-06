using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLWorkerscasino
	{
		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		public bool SaveWorkercasino_Ctta(ObservableCollection<Local> LOCALES, ObservableCollection<Servicio> SERVICIOS,string RUT)
		{
			try
			
			{
				bool result = false;
				using (TransactionScope transaccion = new TransactionScope())
				{
					this.Repository.DeleteWorkerCasino_Ctta(RUT);
					foreach (var item in LOCALES)
					{
						foreach (var subitem in item.listServiciosChecked)
						{
							if (subitem.CHECKED)
							{

								result = this.Repository.SaveWorkercasino_Ctta(RUT, subitem.LOCAL, subitem.SERVICIO);
							}
						}
					}
					transaccion.Complete();
				}

				return result;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteWorkerCasino_Ctta(string RUT)
		{
			try
			{
				return this.Repository.DeleteWorkerCasino_Ctta(RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
