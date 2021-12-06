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
		public IBLEmpresascertificadoras BL_Empresascertificadoras { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLEmpresascertificadoras BL_Empresascertificadoras)
		{
			this.BL_Empresascertificadoras = BL_Empresascertificadoras;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Empresascertificadoras> GetAllEmpresascertificadoras()
		{
			try
			{
				return this.BL_Empresascertificadoras.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Empresascertificadoras GetOneEmpresascertificadora(Int32 ID)
		{
			try
			{
				return this.BL_Empresascertificadoras.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveEmpresascertificadora(ref Empresascertificadoras item)
		{
			try
			{
				return this.BL_Empresascertificadoras.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteEmpresascertificadora(ref Empresascertificadoras item)
		{
			try
			{
				return this.BL_Empresascertificadoras.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveEmpresascertificadoras(ref ObservableCollection<Empresascertificadoras> items)
		{
			try
			{
				return this.BL_Empresascertificadoras.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
