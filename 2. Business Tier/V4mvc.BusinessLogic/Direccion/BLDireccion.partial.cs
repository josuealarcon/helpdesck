using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLDireccion
    {

        #region [ Consultas ]

        public ObservableCollection<Direccion> GetAllPaises()
        {
            try
            {
                return this.Repository.GetAllPaises();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Direccion> GetAllRegionesByPais(String PAIS)
        {
            try
            {
                return this.Repository.GetAllRegionesByPais(PAIS);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Direccion> GetAllCiudadByRegion(String REGION)
        {
            try
            {
                return this.Repository.GetAllCiudadByRegion(REGION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Direccion> GetAllComunaByCiudad(String CIUDAD)
        {
            try
            {
                return this.Repository.GetAllComunaByCiudad(CIUDAD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Direccion> GetAllCiudad()
        {
            try
            {
                return this.Repository.GetAllCiudad();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveDireccionCtta(ref Direccion item) {
            try
            {
                return this.Repository.SaveDireccionCtta(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF00(ref Direccion item)
        {
            try
            {
                return this.Repository.SaveDireccionCovidF00(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF100(ref Direccion item)
        {
            try
            {
                return this.Repository.SaveDireccionCovidF100(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF300(ref Direccion item)
        {
            try
            {
                return this.Repository.SaveDireccionCovidF300(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCelularRut(String CELULAR, String RUT)
        {
            try
            {
                return this.Repository.SaveDireccionCelularRut(CELULAR, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
