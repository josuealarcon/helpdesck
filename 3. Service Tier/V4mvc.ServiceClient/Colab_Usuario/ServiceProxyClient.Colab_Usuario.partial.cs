using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public Colab_Usuario ValidarLoginColab_Usuario(String IdEmpresa, String Rut, String Clave)
        {
            try
            {
                return this.BL_Colab_Usuario.ValidarLogin(IdEmpresa, Rut, Clave);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Colab_Usuario> GetAllEnterpriseColab_Usuario(String IDEMPRESA)
        {
            try
            {
                return this.BL_Colab_Usuario.GetAllEnterprise(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Colab_Usuario GetColab_UsuarioEmailsCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Colab_Usuario.GetColab_UsuarioEmailsCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }


        }

        #endregion

        #region [ Metodos ]

        public bool UpdateClaveColabUsuario(string IDEMPRESA, string RUT, string NEWPASSWORD)
        {
            try
            {
                return this.BL_Colab_Usuario.UpdateClaveColabUsuario(IDEMPRESA, RUT, NEWPASSWORD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveColabUsuarioNewEnterpriseCTTA(ref Colab_Usuario Item)
        {
            try
            {
                return this.BL_Colab_Usuario.SaveColabUsuarioNewEnterpriseCTTA(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveColabUsuario_EmpUsuariosCtta(Colab_Usuario colab)
        {
            try
            {
                return this.BL_Colab_Usuario.SaveColabUsuario_EmpUsuariosCtta(colab);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelColabUsuario_EmpUsuariosCtta(string RUT, string EMPRESA, string USUARIO)
        {
            try
            {
                return this.BL_Colab_Usuario.DelColabUsuario_EmpUsuariosCtta(RUT, EMPRESA, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ChangePasswordCtta(string IDEMPRESA, string RUT, string CLAVEACTUAL, string NUEVACLAVE)
        {
            try
            {
                return this.BL_Colab_Usuario.ChangePasswordCtta(IDEMPRESA, RUT, CLAVEACTUAL, NUEVACLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveCtta(string ID, string IDEMPRESA, string CLAVE)
        {
            try
            {
                return this.BL_Colab_Usuario.ValidarClaveCtta(ID, IDEMPRESA, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveHistoricoCtta(string ID, string IDEMPRESA, string CLAVE)
        {
            try
            {
                return this.BL_Colab_Usuario.ValidarClaveHistoricoCtta(ID, IDEMPRESA, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveCtta(string ID, string IDEMPRESA, string NUEVACLAVE)
        {
            try
            {
                return this.BL_Colab_Usuario.CambioClaveCtta(ID, IDEMPRESA, NUEVACLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveHistoricoCtta(string ID, string IDEMPRESA, string NUEVACLAVE, string IP)
        {
            try
            {
                return this.BL_Colab_Usuario.CambioClaveHistoricoCtta(ID, IDEMPRESA, NUEVACLAVE,IP);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
