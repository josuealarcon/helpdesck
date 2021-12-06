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
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionValidadaChecked_Mdte(Guid? ID, string RUT) {
            try
            {
                return this.BL_Docs_Tipo_Rechazo.GetListDocsTipoRechazoLiquidacionValidadaChecked_Mdte(ID,RUT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoVehiculosChecked_Mdte(Guid ID, int ID_DOC, string PATENTE)
        {

            try
            {
                return this.BL_Docs_Tipo_Rechazo.GetListDocsTipoRechazoVehiculosChecked_Mdte(ID, ID_DOC, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoChecked_Mdte(Guid ID, int ID_DOC, string RUT)
        {

            try
            {
                return this.BL_Docs_Tipo_Rechazo.GetListDocsTipoRechazoChecked_Mdte(ID,ID_DOC,RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionChecked_Mdte(Guid? ID)
        {
            try
            {
                return this.BL_Docs_Tipo_Rechazo.GetListDocsTipoRechazoLiquidacionChecked_Mdte(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoControlAccesoChecked_Mdte(Guid ID, int ID_DOC)
        {
            try
            {
                return this.BL_Docs_Tipo_Rechazo.GetListDocsTipoRechazoControlAccesoChecked_Mdte(ID,ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
