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
		public IBLE200_Datos BL_E200_Datos { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLE200_Datos BL_E200_Datos)
		{
			this.BL_E200_Datos = BL_E200_Datos;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<E200_Datos> GetAllE200_Datos()
		{
			try
			{
				return this.BL_E200_Datos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public E200_Datos GetOneE200_Dato(Guid? ID)
		{
			try
			{
				return this.BL_E200_Datos.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveE200_Dato(ref E200_Datos item)
		{
			try
			{
				return this.BL_E200_Datos.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteE200_Dato(ref E200_Datos item)
		{
			try
			{
				return this.BL_E200_Datos.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveE200_Datos(ref ObservableCollection<E200_Datos> items)
		{
			try
			{
				return this.BL_E200_Datos.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
