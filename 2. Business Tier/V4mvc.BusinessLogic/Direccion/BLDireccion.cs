using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLDireccion : IBLDireccion
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADireccion Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLDireccion(IDADireccion x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Direccion> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Direccion GetOne(String RUT)
        {
            try
            {
                return this.Repository.GetOne(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Direccion Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Direccion> Items)
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
