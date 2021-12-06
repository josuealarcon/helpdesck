using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Colab_Usuario> GetAllColab_Usuario();
        Colab_Usuario GetOneColabUsuario_Ctta(String IdEmpresa,String Rut);

		Colab_Usuario GetOneColabUsuario_v2_Ctta(String IdEmpresa, String Rut);
		#endregion

		#region [ Metodos ]
		Boolean SaveColab_Usuario(ref Colab_Usuario Item);
		Boolean SaveColab_Usuario(ref ObservableCollection<Colab_Usuario> Items);
		#endregion
		
	}
}
