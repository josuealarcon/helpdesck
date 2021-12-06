using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]

        public ObservableCollection<Docs_Workers> GetListDocsWorkerDocsApoyo_Mdte(string RUT, int ID_DISPUTA, int ID_DOC)
        {
            try
            {
                return this.BL_Docs_Workers.GetListDocsWorkerDocsApoyo_Mdte(RUT,ID_DISPUTA,ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Workers> GetListDocsWorkerDocsApoyoVehiculos_Mdte(string PATENTE, string ID_DISPUTA, string ID_DOC)
        {
            try
            {
                return this.BL_Docs_Workers.GetListDocsWorkerDocsApoyoVehiculos_Mdte(PATENTE, ID_DISPUTA, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs_Workers> GetListDocsWorkerFuncionarioDisputa_Mdte(string RUT, int ID_DOC, Guid ID, string DIVISION, int ID_DISPUTA)
        {
            try
            {
                return this.BL_Docs_Workers.GetListDocsWorkerFuncionarioDisputa_Mdte(RUT, ID_DOC, ID, DIVISION,ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
