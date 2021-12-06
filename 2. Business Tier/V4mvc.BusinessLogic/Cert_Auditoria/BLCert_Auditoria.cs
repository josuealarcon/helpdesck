using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLCert_Auditoria : IBLCert_Auditoria
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDACert_Auditoria Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLCert_Auditoria(IDACert_Auditoria x_container)
		{ Repository = x_container; }

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Cert_Auditoria> GetAll(string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetAll(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Cert_Auditoria GetOne(Int32 ID_CERT_AUDITORIA)
		{
			try
			{
				return this.Repository.GetOne(ID_CERT_AUDITORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean Save(ref Cert_Auditoria Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean Save(ref ObservableCollection<Cert_Auditoria> Items)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					for (int i = 0; i < Items.Count; i++)
					{
						var item = Items.ElementAt(i);
						this.Repository.Save(ref item);
					}
					tran.Complete();
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}