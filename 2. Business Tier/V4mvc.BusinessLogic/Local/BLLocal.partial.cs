using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLLocal
    {

        #region [ Consultas ]
        public ObservableCollection<Local> GetAllLocal_PasesCtta(string DIVCOD)
        {
            try
            {
                return this.Repository.GetAllLocal_PasesCtta(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        public ObservableCollection<Local> GetAllLocalAcceso_PasesCtta(string DIVCOD)
        {
            try
            {
                return this.Repository.GetAllLocalAcceso_PasesCtta(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Local> GetAllLocal_v2_PasesCtta(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA)
        {
            try
            {
                return this.Repository.GetAllLocal_v2_PasesCtta(RUT, DIVISION, IDPASE, ID_EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Local> GetAllLocalesPorDiv_Informe(string DIVCOD, string LOCALL)
        {
            try
            {
                return this.Repository.GetAllLocalesPorDiv_Informe(DIVCOD, LOCALL);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Local> GetLocalDivisionCtta(string DIVCOD)
        {
            try
            {
                return this.Repository.GetLocalDivisionCtta(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Local> GetLocalesCasinoCtta(string RUT)
        {
            try
            {
                return this.Repository.GetLocalesCasinoCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public ObservableCollection<Local> GetListLocalesCasinoPermitidos_Ctta(string RUT)
        {
            try
            {
                return this.Repository.GetListLocalesCasinoPermitidos_Ctta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Local> GetListLocalesCasinoPermitidosAutorizaciones_Ctta(string RUT)
        {
            try
            {
                var listLocalesCasino = this.Repository.GetListLocalesCasinoPermitidosAutorizaciones_Ctta();
                if (listLocalesCasino.Count != 0)
                {
                    foreach (var item in listLocalesCasino)
                    {
                        item.listServiciosChecked = this.Repository.GetListServiciosCheckedCasinoPermitidosAutorizaciones_Ctta(RUT, item.LOCAL);
                    }
                }    
                
                return listLocalesCasino;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
