using System;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkersLocal
    {

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal> GetWorkersLocal_PasesFuncionarios(String RUT, String DIVCOD)
        {
            try
            {
                return this.Repository.GetWorkersLocal_PasesFuncionarios(RUT, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<WorkersLocal> GetWorkersLocal_Archivos(String RUT, int ID_DOC)
        {
            try
            {
                return this.Repository.GetWorkersLocal_Archivos(RUT, ID_DOC);
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
                return this.Repository.SaveCertificadoFuncionario(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
