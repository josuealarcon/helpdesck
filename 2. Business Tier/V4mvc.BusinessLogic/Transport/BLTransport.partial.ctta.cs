using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial class BLTransport
    {

        #region [ Consultas ]

        public ObservableCollection<Transport> GetAllTransportEnterpriseCtta(string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllTransportEnterpriseCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> BuscarVehiculos(Int32 iDisplayStart, Int32 iDisplayLength, String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB, String sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                return this.Repository.BuscarVehiculos(iDisplayStart, iDisplayLength, searchPATENTE, searchMARCA, searchMODELO, searchTIPO, searchANOFAB, sortCOLUMN, sortDIRECTION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport BuscarVehiculos_NumRegistros(String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB)
        {
            try
            {
                return this.Repository.BuscarVehiculos_NumRegistros(searchPATENTE, searchMARCA, searchMODELO, searchTIPO, searchANOFAB);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_PasesCtta(string PATENTE, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.Repository.GetOneTransport_PasesCtta(PATENTE, IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> GetTransportsAcreditacionVehicularCtta(string IDEMPRESA, string DIVCOD)
        {
            try
            {
                return this.Repository.GetTransportsAcreditacionVehicularCtta(IDEMPRESA, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> GetTransportsCtta(ref Transport model)
        {
            try
            {
                return this.Repository.GetTransportsCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetAllTransportDatatablesCountCtta(ref JqueryDatatableParam model)
        {
            try
            {
                return this.Repository.GetAllTransportDatatablesCountCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Informes ]
        public Transport GetTransport_DatosFichaVehiculo_InformeConsultaRapidaCtta(Transport request)
        {
            try
            {
                return this.Repository.GetTransport_DatosFichaVehiculo_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport GetTransport_ValidaExistenciaPatente_InformeConsultaRapidaCtta(Transport Item)
        {
            try
            {
                return this.Repository.GetTransport_ValidaExistenciaPatente_InformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllTransport_IAcreditacionVeh_Informes(ref Transport parametros)
        {
            try
            {
                return this.Repository.GetAllTransport_IAcreditacionVeh_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool DeleteTransportCtta(string PATENTE, string TIPO,string IDEMPRESA,string USUARIO)
        {
            try
            {
                return this.Repository.DeleteTransportCtta(PATENTE, TIPO, IDEMPRESA, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransport_VehiculosCtta(ref Transport vehiculo)
        {
            try
            {
                return this.Repository.UpdateTransport_VehiculosCtta(ref vehiculo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransportEnterpriseCtta(string PATENTE, string EMPRESA)
        {
            try
            {
                return this.Repository.UpdateTransportEnterpriseCtta(PATENTE, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
