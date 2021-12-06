using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using System.Data;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Transport> GetAllTransportEnterpriseCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Transport.GetAllTransportEnterpriseCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> BuscarVehiculos(Int32 iDisplayStart, Int32 iDisplayLength, String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB, String sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                return this.BL_Transport.BuscarVehiculos(iDisplayStart, iDisplayLength, searchPATENTE, searchMARCA, searchMODELO, searchTIPO, searchANOFAB, sortCOLUMN, sortDIRECTION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport BuscarVehiculos_NumRegistros(String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB)
        {
            try
            {
                return this.BL_Transport.BuscarVehiculos_NumRegistros(searchPATENTE, searchMARCA, searchMODELO, searchTIPO, searchANOFAB);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_PasesCtta(string PATENTE, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.BL_Transport.GetOneTransport_PasesCtta(PATENTE, IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> GetTransportsAcreditacionVehicularCtta(string IDEMPRESA, string DIVCOD)
        {
            try
            {
                return this.BL_Transport.GetTransportsAcreditacionVehicularCtta(IDEMPRESA, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> GetTransportsCtta(ref Transport model)
        {
            try
            {
                return this.BL_Transport.GetTransportsCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetAllTransportDatatablesCountCtta(ref JqueryDatatableParam model)
        {
            try
            {
                return this.BL_Transport.GetAllTransportDatatablesCountCtta(ref model);
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
                return this.BL_Transport.GetTransport_DatosFichaVehiculo_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport GetTransport_ValidaExistenciaPatente_InformeConsultaRapidaCtta(Transport Item)
        {
            try
            {
                return this.BL_Transport.GetTransport_ValidaExistenciaPatente_InformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllTransport_IAcreditacionVeh_Informes(ref Transport parametros)
        {
            try
            {
                return this.BL_Transport.GetAllTransport_IAcreditacionVeh_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool DeleteTransportCtta(string PATENTE, string TIPO, string IDEMPRESA, string USUARIO)
        {
            try
            {
                return this.BL_Transport.DeleteTransportCtta(PATENTE, TIPO, IDEMPRESA, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransport_VehiculosCtta(ref Transport vehiculo)
        {
            try
            {
                return this.BL_Transport.UpdateTransport_VehiculosCtta(ref vehiculo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransportEnterpriseCtta(string PATENTE, string EMPRESA)
        {
            try
            {
                return this.BL_Transport.UpdateTransportEnterpriseCtta(PATENTE, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
