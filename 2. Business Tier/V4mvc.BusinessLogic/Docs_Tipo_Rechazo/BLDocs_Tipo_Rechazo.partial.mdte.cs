using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Tipo_Rechazo
	{

        #region [ Consultas ]
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionValidadaChecked_Mdte(Guid? ID, string RUT)
        {
            try
            {
                return this.Repository.GetListDocsTipoRechazoLiquidacionValidadaChecked_Mdte(ID,RUT);
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
                return this.Repository.GetListDocsTipoRechazoVehiculosChecked_Mdte(ID, ID_DOC, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }

        }

        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoChecked_Mdte(Guid ID, int ID_DOC, string RUT)
        {
            try
            {
                return this.Repository.GetListDocsTipoRechazoChecked_Mdte(ID,ID_DOC,RUT);
            }
            catch (Exception ex)
            { throw ex; }

        }

        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionChecked_Mdte(Guid? ID)
        {
            try
            {
                return this.Repository.GetListDocsTipoRechazoLiquidacionChecked_Mdte(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoControlAccesoChecked_Mdte(Guid ID, int ID_DOC)
        {
            try
            {
                return this.Repository.GetListDocsTipoRechazoControlAccesoChecked_Mdte(ID, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
