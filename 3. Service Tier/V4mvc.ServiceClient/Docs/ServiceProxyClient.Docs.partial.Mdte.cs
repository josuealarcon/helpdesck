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
		public ObservableCollection<Docs> GetExistencia_DOCS_Mdte()
		{
			try
			{
				return this.BL_Docs.GetExistencia_DOCS_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public ObservableCollection<Docs> GetAllDocsAcredFuncionario_Mdte(ref Docs modelo)
        {
            try
            {
                return this.BL_Docs.GetAllDocsAcredFuncionario_Mdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocsAcredFuncionarioConduccion_Mdte(ref Docs modelo)
        {
            try
            {
                return this.BL_Docs.GetAllDocsAcredFuncionarioConduccion_Mdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocsAcredVehiculo_Mdte(ref Docs modelo)
        {
            try
            {
                return this.BL_Docs.GetAllDocsAcredVehiculo_Mdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocs_CertificacionMdte(string PATENTE, string DIVCOD, string TIPO_VEHICULO)
        {
            try
            {
                return this.BL_Docs.GetAllDocs_CertificacionMdte(PATENTE, DIVCOD, TIPO_VEHICULO);
            }
            catch (Exception ex)
            { throw ex; }
        }


        public ObservableCollection<Docs> GetAllDocs_CertificacionDocsMdte(ref Docs modelo)
        {
            try
            {
                return this.BL_Docs.GetAllDocs_CertificacionDocsMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs GetListDocsDocumentos_Mdte(int ID_DOC, string PATENTE, string EMPRESA, string DIVCOD)
        {
            try
            {

                return this.BL_Docs.GetListDocsDocumentos_Mdte(ID_DOC, PATENTE, EMPRESA,DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveDocsVehiculos_Mdte(ref Docs Docs)
        {
            try
            {

                return this.BL_Docs.SaveDocsVehiculos_Mdte(ref Docs);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs> GetAllCertificadosPases_Mdte(string RUT,  string DIVCOD, int NRO, int OPCION)
        {
            try
            {
                return this.BL_Docs.GetAllCertificadosPases_Mdte(RUT, DIVCOD, NRO, OPCION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs> GetListDocumentos_Mdte()
        {
            try
            {
                return this.BL_Docs.GetListDocumentos_Mdte();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
