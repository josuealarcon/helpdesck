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

        public ObservableCollection<WorkersLocal> GetWorkersLocalLaborales(String RUT, String EMPRESA)
        {
            try
            {
                return this.Repository.GetWorkersLocalLaborales(RUT, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetWorkersLocalEnterprise(String EMPRESA)
        {
            try
            {
                return this.Repository.GetWorkersLocalEnterprise(EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetWorkersLocalDocPendientesSelect(String EMPRESA)
        {
            try
            {
                return this.Repository.GetWorkersLocalDocPendientesSelect(EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetWorkersLocalSelectB(String EMPRESA, String DIVCOD)
        {
            try
            {
                return this.Repository.GetWorkersLocalSelectB(EMPRESA,DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public WorkersLocal GetWorkersLocalSelectC(String EMPRESA, String DIVCOD,String RUT)
        {
            try
            {
                return this.Repository.GetWorkersLocalSelectC(EMPRESA, DIVCOD, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumen_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen)
        {
            try
            {
                return this.Repository.GetAllWorkersLocal_ICertResumen_Informes(EMPRESA, DIVISION, ref resumen);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumenOST_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen)
        {
            try
            {
                return this.Repository.GetAllWorkersLocal_ICertResumenOST_Informes(EMPRESA, DIVISION, ref resumen);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllWorkersLocal_IFechaEmpDivision_Informes(ref WorkersLocal parametros)
        {
            try
            {
                return this.Repository.GetAllWorkersLocal_IFechaEmpDivision_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref WorkersLocal parametros)
        {
            try
            {
                return this.Repository.GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
        #region [ Informes ]
        public ObservableCollection<WorkersLocal> GetWorkers_GridEmpresas_FichaRut_InformeConsultaRapidaCtta(WorkersLocal Item)
        {
            try
            {
                return this.Repository.GetWorkers_GridEmpresas_FichaRut_InformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_IFechaFuncDivision_Informes(ref WorkersLocal parametros)
        {
            try
            {
                return this.Repository.GetAllWorkersLocal_IFechaFuncDivision_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
        #region [ Metodos ]

        public bool SaveWorkersLocalLaboralesCtta(string RUT, String EMPRESA, ObservableCollection<Divisiones> divisiones)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    if(divisiones!=null)
                    for (int i = 0; i < divisiones.Count; i++)
                    {
                        var item = divisiones.ElementAt(i);
                        this.Repository.SaveWorkersLocalLaboralesCtta(RUT, EMPRESA, item.DIVCOD);
                    }
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool BloquearWorkersLocalLaboralesCtta(string RUT, string USUARIO, string DIVISION, int LOTE)
        {
            try
            {
                return this.Repository.BloquearWorkersLocalLaboralesCtta(RUT, USUARIO, DIVISION, LOTE);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersLocalPasesFuncionario_Ctta(WorkersLocal WorkersLocal)
        {
            try
            {
                return this.Repository.SaveWorkersLocalPasesFuncionario_Ctta(WorkersLocal);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
