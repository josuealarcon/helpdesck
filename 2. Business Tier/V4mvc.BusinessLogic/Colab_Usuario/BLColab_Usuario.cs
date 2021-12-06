using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLColab_Usuario : IBLColab_Usuario
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAColab_Usuario Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLColab_Usuario(IDAColab_Usuario x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Colab_Usuario> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Colab_Usuario GetOne(String IdEmpresa, String Rut)
        {
            try
            {
                return this.Repository.GetOne(IdEmpresa, Rut);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Colab_Usuario GetOneColabUsuario_v2_Ctta(String IdEmpresa, String Rut)
        {
            try
            {
                return this.Repository.GetOneColabUsuario_v2_Ctta(IdEmpresa, Rut);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Colab_Usuario Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Colab_Usuario> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.Save(ref item);
                }

                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
