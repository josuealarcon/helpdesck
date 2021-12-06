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
	public partial class BLCertDesautorizacionTransport : IBLCertDesautorizacionTransport
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDACertDesautorizacionTransport Repository { get; set; }

		public IDAArchivos RepositoryArchivos { get; set; }

		#endregion

		#region [ Constructores ]

		public BLCertDesautorizacionTransport(IDACertDesautorizacionTransport x_container, IDAArchivos y_container)
		{
			Repository = x_container;
			RepositoryArchivos = y_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CertDesautorizacionTransport> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CertDesautorizacionTransport GetOne(string PATENTE)
		{
			try
			{
				return this.Repository.GetOne(PATENTE);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref CertDesautorizacionTransport item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref CertDesautorizacionTransport item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<CertDesautorizacionTransport> items)
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
