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

        Colab_Usuario ValidarLogin(String IdEmpresa, String Rut, String Clave);
		ObservableCollection<Colab_Usuario> GetAllEnterprise(String IDEMPRESA);
		Colab_Usuario GetColab_UsuarioEmailsCtta(string IDEMPRESA);

		#endregion

		#region [ Metodos ]

		bool UpdateClaveColabUsuario(string IDEMPRESA, string RUT, string NEWPASSWORD);
		bool SaveColabUsuarioNewEnterpriseCTTA(ref Colab_Usuario Item);
		bool SaveColabUsuario_EmpUsuariosCtta(Colab_Usuario colab);
		bool DelColabUsuario_EmpUsuariosCtta(string RUT, string EMPRESA, string USUARIO);
		bool ChangePasswordCtta(string IDEMPRESA, string RUT, string CLAVEACTUAL, string NUEVACLAVE);
		bool ValidarClaveCtta(string ID, string IDEMPRESA, string CLAVE);
		bool ValidarClaveHistoricoCtta(string ID, string IDEMPRESA, string CLAVE);
		bool CambioClaveCtta(string ID, string IDEMPRESA, string NUEVACLAVE);
		bool CambioClaveHistoricoCtta(string ID, string IDEMPRESA, string NUEVACLAVE, string IP);

		#endregion

	}
}
