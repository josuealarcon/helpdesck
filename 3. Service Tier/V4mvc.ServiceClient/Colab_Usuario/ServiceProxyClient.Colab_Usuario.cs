using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{
		
		#region [ Propiedades ]
		[Dependency]
		public IBLColab_Usuario BL_Colab_Usuario { get; set; }
        #endregion

        #region [ Constructor]

        public ServiceProxyClient(IBLColab_Usuario BL_Colab_Usuario)
        {
            this.BL_Colab_Usuario = BL_Colab_Usuario;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Colab_Usuario> GetAllColab_Usuario()
		{
			try
			{
				return this.BL_Colab_Usuario.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Colab_Usuario GetOneColabUsuario_Ctta(String IdEmpresa, String Rut)
		{
			try
			{
				return this.BL_Colab_Usuario.GetOne(IdEmpresa,Rut);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Colab_Usuario GetOneColabUsuario_v2_Ctta(String IdEmpresa, String Rut)
		{
			try
			{
				return this.BL_Colab_Usuario.GetOneColabUsuario_v2_Ctta(IdEmpresa, Rut);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveColab_Usuario(ref Colab_Usuario Item)
		{
			try
			{
				return this.BL_Colab_Usuario.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveColab_Usuario(ref ObservableCollection<Colab_Usuario> Items)
		{
			try
			{
				return this.BL_Colab_Usuario.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
