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

        public ObservableCollection<Direccion> GetAllPaises()
        {
            try
            {
                return this.BL_Direccion.GetAllPaises();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Direccion> GetAllRegionesByPais(String PAIS)
        {
            try
            {
                return this.BL_Direccion.GetAllRegionesByPais(PAIS);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Direccion> GetAllCiudadByRegion(String REGION)
        {
            try
            {
                return this.BL_Direccion.GetAllCiudadByRegion(REGION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Direccion> GetAllComunaByCiudad(String CIUDAD)
        {
            try
            {
                return this.BL_Direccion.GetAllComunaByCiudad(CIUDAD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Direccion> GetAllCiudad()
        {
            try
            {
                return this.BL_Direccion.GetAllCiudad();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public Boolean SaveDireccionCtta(ref Direccion Item)
        {
            try
            {
                return this.BL_Direccion.SaveDireccionCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF00(ref Direccion Item)
        {
            try
            {
                return this.BL_Direccion.SaveDireccionCovidF00(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF100(ref Direccion Item)
        {
            try
            {
                return this.BL_Direccion.SaveDireccionCovidF100(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF300(ref Direccion Item)
        {
            try
            {
                return this.BL_Direccion.SaveDireccionCovidF300(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCelularRut(String CELULAR, String RUT)
        {
            try
            {
                return this.BL_Direccion.SaveDireccionCelularRut(CELULAR, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
