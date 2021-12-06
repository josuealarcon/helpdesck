using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

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

        public Transport GetOneTransport_PasesMdte(Docs modelo)
        {
            try
            {
                return this.Repository.GetOneTransport_PasesMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransportExtra_PasesMdte(Transport modelo)
        {
            try
            {
                return this.Repository.GetOneTransportExtra_PasesMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_CertificacionMdte(string PATENTE)
        {
            try
            {
                return this.Repository.GetOneTransport_CertificacionMdte(PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_v2_CertificacionMdte(string PATENTE)
        {
            try
            {
                return this.Repository.GetOneTransport_v2_CertificacionMdte(PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> GetListTransports_Mdte(ref Transport transports)
        {
            try
            {
                return this.Repository.GetListTransports_Mdte(ref transports);
            }
            catch (Exception ex)
            { throw ex; }
        }

		
        public Transport GetOneTransport_Acreditacion_CertificacionMdte(string DIVCOD, string PATENTE, string TIPO_VEHICULO, string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetOneTransport_Acreditacion_CertificacionMdte(DIVCOD, PATENTE, TIPO_VEHICULO, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_Mdte(string PATENTE, string DIVCOD)
        {
            try
            {
                return this.Repository.GetOneTransport_Mdte(PATENTE, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
		
        public bool ValidarTransportRFID_Mdte(string RFID, string PATENTE)
        {
            try
            {
                return this.Repository.ValidarTransportRFID_Mdte(RFID, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport GetOneTransportCertificacion_Mdte(string DIVCOD, string PATENTE, string TIPO_VEHICULO, string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetOneTransportCertificacion_Mdte(DIVCOD, PATENTE, TIPO_VEHICULO, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool DeleteTransport_Mdte(string PATENTE, int TIPO, string IDEMPRESA, string USUARIO)
        {
            try
            {
                return this.Repository.DeleteTransport_Mdte(PATENTE,TIPO,IDEMPRESA,USUARIO);
            }
            catch (Exception ex)
            { throw ex; } 
        }


        public bool SaveTransport_Mdte(ref Transport Transport)
        { 
            try
            { 
                return this.Repository.SaveTransport_Mdte(ref Transport);
            }
            

            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveTransport_CertificacionMdte(ref Transport modelo)
        {
            try
            {
                return this.Repository.SaveTransport_CertificacionMdte(ref modelo);
            }


            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}