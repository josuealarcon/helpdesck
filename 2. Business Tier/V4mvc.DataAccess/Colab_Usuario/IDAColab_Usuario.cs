using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAColab_Usuario
	{
		
		#region [ Consultas ]
		ObservableCollection<Colab_Usuario> GetAll();
        Colab_Usuario GetOne(String IdEmpresa, String Rut);
		Colab_Usuario GetOneColabUsuario_v2_Ctta(String IdEmpresa, String Rut);
		
		#endregion

		#region [ Metodos ]
		bool Save(ref Colab_Usuario Item);
		#endregion
		
	}
}
