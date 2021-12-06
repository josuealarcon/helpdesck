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
		public IBLRecorridos BL_Recorridos { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLRecorridos BL_Recorridos)
		{
			this.BL_Recorridos = BL_Recorridos;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Recorridos> GetAllRecorridos()
		{
			try
			{
				return this.BL_Recorridos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Recorridos GetOneRecorrido(Int32 IDRECORRIDO)
		{
			try
			{
				return this.BL_Recorridos.GetOne(IDRECORRIDO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveRecorrido(ref Recorridos item)
		{
			try
			{
				return this.BL_Recorridos.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteRecorrido(ref Recorridos item)
		{
			try
			{
				return this.BL_Recorridos.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveRecorridos(ref ObservableCollection<Recorridos> items)
		{
			try
			{
				return this.BL_Recorridos.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
