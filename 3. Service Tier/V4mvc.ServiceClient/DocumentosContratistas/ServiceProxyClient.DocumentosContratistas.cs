using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLDocumentosContratistas BL_DocumentosContratistas { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDocumentosContratistas BL_DocumentosContratistas)
		{
			this.BL_DocumentosContratistas = BL_DocumentosContratistas;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<DocumentosContratistas> GetAllDocumentosContratistas(ref DocumentosContratistas documentosContratistas)
		{
			try
			{
				return this.BL_DocumentosContratistas.GetAll(ref documentosContratistas);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public DocumentosContratistas GetOneDocumentoContratistas(Int32 IDCTTA_DOC)
		{
			try
			{
				return this.BL_DocumentosContratistas.GetOne(IDCTTA_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveDocumentoContratistas(ref DocumentosContratistas item)
		{
			try
			{
				return this.BL_DocumentosContratistas.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteDocumentoContratistas(ref DocumentosContratistas item)
		{
			try
			{
				return this.BL_DocumentosContratistas.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveDocumentosContratistas(ref ObservableCollection<DocumentosContratistas> items)
		{
			try
			{
				return this.BL_DocumentosContratistas.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
