using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLColab_Usuario
	{
		
		#region [ Consultas ]
		ObservableCollection<Colab_Usuario> GetAll();
        Colab_Usuario GetOne(String IdEmpresa, String Rut);

		Colab_Usuario GetOneColabUsuario_v2_Ctta(String IdEmpresa, String Rut);
		#endregion

		#region [ Metodos ]
		Boolean Save(ref Colab_Usuario Item);
		Boolean Save(ref ObservableCollection<Colab_Usuario> Items);
		#endregion
		
	}
}
