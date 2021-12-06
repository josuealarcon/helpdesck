using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Transport
	{

        #region [ Consultas ]

        public ObservableCollection<Docs_Transport> GetListDocsTransport_Mdte(string PATENTE, int ID_DOC, Guid ID, int ID_DISPUTA)
        {
            try
            {
                return this.Repository.GetListDocsTransport_Mdte(PATENTE, ID_DOC, ID, ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Transport> GetListDocTransportsArchivosAlmacenados_Mdte(string PATENTE, string DIVCOD, int ID_DOC, string EMPRESA)
        {
            try
            {
                return this.Repository.GetListDocTransportsArchivosAlmacenados_Mdte(PATENTE, DIVCOD, ID_DOC, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }

        }

        #endregion

        #region Metodos


        #endregion

    }
}
