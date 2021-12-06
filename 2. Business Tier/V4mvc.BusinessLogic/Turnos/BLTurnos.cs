using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLTurnos : IBLTurnos
    {

        #region [ Propiedades ]

        [Dependency]
        public IDATurnos Repository { get; set; }
        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BLTurnos(IDATurnos x_container
                       , IDAArchivos x_container1)
        { Repository = x_container;
            RepositoryArchivos = x_container1;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Turnos> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Turnos GetOne(int IDTURNO)
        {
            try
            {
                return this.Repository.GetOne(IDTURNO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Turnos Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Turnos> Items)
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
