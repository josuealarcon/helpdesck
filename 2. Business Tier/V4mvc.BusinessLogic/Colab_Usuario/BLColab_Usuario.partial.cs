using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLColab_Usuario
    {

        #region [ Consultas ]

        public Colab_Usuario ValidarLogin(String IdEmpresa, String Rut, String Clave)
        {
            try
            {
                return this.Repository.ValidarLogin(IdEmpresa, Rut, Clave);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Colab_Usuario> GetAllEnterprise(String IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllEnterprise(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Colab_Usuario GetColab_UsuarioEmailsCtta(string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetColab_UsuarioEmailsCtta(IDEMPRESA);
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
                return this.Repository.UpdateClaveColabUsuario(IDEMPRESA, RUT, NEWPASSWORD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveColabUsuarioNewEnterpriseCTTA(ref Colab_Usuario Item)
        {
            try
            {
                return this.Repository.SaveColabUsuarioNewEnterpriseCTTA(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveColabUsuario_EmpUsuariosCtta(Colab_Usuario colab)
        {
            try
            {
                return this.Repository.SaveColabUsuario_EmpUsuariosCtta(colab);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelColabUsuario_EmpUsuariosCtta(string RUT, string EMPRESA, string USUARIO)
        {
            try
            {
                return this.Repository.DelColabUsuario_EmpUsuariosCtta(RUT, EMPRESA, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ChangePasswordCtta(string IDEMPRESA, string RUT, string CLAVEACTUAL, string NUEVACLAVE)
        {
            try
            {
                return this.Repository.ChangePasswordCtta(IDEMPRESA, RUT, CLAVEACTUAL, NUEVACLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveCtta(string ID, string IDEMPRESA, string CLAVE)
        {
            try
            {
                return this.Repository.ValidarClaveCtta(ID, IDEMPRESA, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveHistoricoCtta(string ID, string IDEMPRESA, string CLAVE)
        {
            try
            {
                return this.Repository.ValidarClaveHistoricoCtta(ID, IDEMPRESA, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveCtta(string ID, string IDEMPRESA, string NUEVACLAVE)
        {
            try
            {
                return this.Repository.CambioClaveCtta(ID, IDEMPRESA, NUEVACLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveHistoricoCtta(string ID, string IDEMPRESA, string NUEVACLAVE, string IP)
        {
            try
            {
                return this.Repository.CambioClaveHistoricoCtta(ID, IDEMPRESA, NUEVACLAVE, IP);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
