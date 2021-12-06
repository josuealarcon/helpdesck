using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.Entities;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocumentosContratistas : IBLDocumentosContratistas
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDADocumentosContratistas Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLDocumentosContratistas(IDADocumentosContratistas x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<DocumentosContratistas> GetAll(ref DocumentosContratistas documentosContratistas)
		{
			try
			{
				return this.Repository.GetAll(ref documentosContratistas);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public DocumentosContratistas GetOne(Int32 IDCTTA_DOC)
		{
			try
			{
				return this.Repository.GetOne(IDCTTA_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref DocumentosContratistas item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref DocumentosContratistas item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<DocumentosContratistas> items)
		{
			try
			{
				for (int i = 0; i < items.Count; ++i)
				{
					var item = items.ElementAt(i);
					this.Repository.Save(ref item);
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
