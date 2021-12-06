using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCertDesautorizacionTransport
	{
		#region [ Consultas ]

		public CertDesautorizacionTransport GetOneCertDesautorizacion_CertificacionMdte(string PATENTE, string DIVCOD)
        {
            try
            {
                return Repository.GetOneCertDesautorizacion_CertificacionMdte(PATENTE, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SaveCertDesautorizacionTransport_CertificacionMdte(ref CertDesautorizacionTransport modelo)
        {
            try
            {
                bool exitoso = true;
                using (TransactionScope tran = new TransactionScope())
                {
                    if (modelo.archivo != null)
                    {
                        exitoso = this.RepositoryArchivos.Save(ref modelo.archivo);
                        modelo.ID_ARCHIVO = modelo.archivo.ID;
                    }

                    exitoso = exitoso && Repository.SaveCertDesautorizacionTransport_CertificacionMdte(ref modelo);

                    tran.Complete();
                }
                return exitoso;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
