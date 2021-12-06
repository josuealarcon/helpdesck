using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLTransport
    {

        #region [ Consultas ]
        public ObservableCollection<Transport> GetTransportsSearcherMdte(ref Transport model)
        {
            try
            {
                return this.Repository.GetTransportsSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }
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

        public ObservableCollection<Transport> GetAllTransportDatatablesCtta(ref JqueryDatatableParam model, out int iTotalCount)
        {
            try
            {
                ObservableCollection<Transport> transports = Repository.GetAllTransportDatatablesCtta(ref model, out iTotalCount);
                return transports;
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

        public int GetTransportCumpleCertificacion_Ctta(string PATENTE, int? TIPO,string DIVCOD)
        {
            try
            {
                return this.Repository.GetTransportCumpleCertificacion_Ctta(PATENTE, TIPO, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport GetDataByPatente_VehiculosCtta(string patente)
        {
            try
            {
                return this.Repository.GetDataByPatente_VehiculosCtta(patente);
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

        public bool DeleteTransportCtta(string PATENTE, string IDEMPRESA)
        {
            try
            {
                return this.Repository.DeleteTransportCtta(PATENTE, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransport_VehiculosCtta(ref Transport vehiculo)
        {
            try
            {
                var options = new TransactionOptions();
                options.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
                using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Required, options))
                {
                    this.Repository.UpdateTransport_VehiculosCtta(ref vehiculo);
                    var areas = vehiculo.AREAS_ASIGNADAS.Split(',');
                    foreach(var area in areas)
                    {
                        this.Repository.UpdateAreasAsignadas_VehiculosCtta(area, vehiculo.PATENTE);
                    }
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveTransport_VehiculosCtta(Transport vehiculo)
        {
            try
            {
                var options = new TransactionOptions();
                options.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
                using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Required, options))
                {
                    this.Repository.SaveTransport_VehiculosCtta(vehiculo);
                    var areas = vehiculo.AREAS_ASIGNADAS.Split(',');
                    foreach (var area in areas)
                    {
                        this.Repository.UpdateAreasAsignadas_VehiculosCtta(area, vehiculo.PATENTE);
                    }
                    tran.Complete();
                }
                return true;
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
