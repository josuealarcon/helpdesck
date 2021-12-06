using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLAprobacion_SubContratos
	{

        #region [ Consultas ]
        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosPendientes(string IDEMPRESA) {
            try
            {
                return this.Repository.GetAllAprobacion_SubContratosPendientes(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProceso(string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllAprobacion_SubContratosEnProceso(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

		public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProcesadas(string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetAllAprobacion_SubContratosEnProcesadas(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}


		#endregion

		#region [ Metodos ]
		public Boolean Save_Aprobacion_SubContratos( Aprobacion_SubContratos Item)
		{
			try
			{
				return this.Repository.Save_Aprobacion_SubContratos( Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		//public Boolean Save(ref Aprobacion_SubContratos Item)
		//{
		//	try
		//	{
		//		return this.Repository.Save(ref Item);
		//	}
		//	catch (Exception ex)
		//	{ throw ex; }
		//}

		//public Boolean Save(ref ObservableCollection<Ccostos> Items)
		//{
		//	try
		//	{
		//		using (TransactionScope tran = new TransactionScope())
		//		{
		//			for (int i = 0; i < Items.Count; i++)
		//			{
		//				var item = Items.ElementAt(i);
		//				this.Repository.Save(ref item);
		//			}
		//			tran.Complete();
		//		}
		//		return true;
		//	}
		//	catch (Exception ex)
		//	{ throw ex; }
		//}
		#endregion

	}
}
