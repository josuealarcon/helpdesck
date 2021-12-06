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
        public ObservableCollection<WorkersLocal> GetWorkersLocal_PasesFuncionarios(String RUT, String DIVCOD)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocal_PasesFuncionarios(RUT, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<WorkersLocal> GetWorkersLocal_Archivos(String RUT, int ID_DOC)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocal_Archivos(RUT, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveCertificadoFuncionario(ref WorkersLocal modelo)
        {
            try
            {
                return this.BL_WorkersLocal.SaveCertificadoFuncionario(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
