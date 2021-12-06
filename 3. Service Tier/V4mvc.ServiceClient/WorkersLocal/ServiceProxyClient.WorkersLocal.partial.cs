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

        public ObservableCollection<WorkersLocal> GetWorkersLocalLaborales(String RUT, String EMPRESA)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocalLaborales(RUT, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetWorkersLocalEnterprise(String EMPRESA)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocalEnterprise(EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetWorkersLocalDocPendientesSelect(String EMPRESA)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocalDocPendientesSelect(EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetWorkersLocalSelectB(String EMPRESA, String DIVCOD)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocalSelectB(EMPRESA, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public WorkersLocal GetWorkersLocalSelectC(String EMPRESA, String DIVCOD, String RUT)
        {
            try
            {
                return this.BL_WorkersLocal.GetWorkersLocalSelectC(EMPRESA, DIVCOD, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumen_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen)
        {
            try
            {
                return this.BL_WorkersLocal.GetAllWorkersLocal_ICertResumen_Informes(EMPRESA, DIVISION, ref resumen);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumenOST_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen)
        {
            try
            {
                return this.BL_WorkersLocal.GetAllWorkersLocal_ICertResumenOST_Informes(EMPRESA, DIVISION, ref resumen);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllWorkersLocal_IFechaEmpDivision_Informes(ref WorkersLocal parametros)
        {
            try
            {
                return this.BL_WorkersLocal.GetAllWorkersLocal_IFechaEmpDivision_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_IFechaFuncDivision_Informes(ref WorkersLocal parametros)
        {
            try
            {
                return this.BL_WorkersLocal.GetAllWorkersLocal_IFechaFuncDivision_Informes(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref WorkersLocal parametros)
        {
            try
            {
                return this.BL_WorkersLocal.GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref parametros);
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
                return this.BL_WorkersLocal.GetWorkers_GridEmpresas_FichaRut_InformeConsultaRapidaCtta(Item);
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
                return this.BL_WorkersLocal.SaveWorkersLocalLaboralesCtta(RUT, EMPRESA, divisiones);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool BloquearWorkersLocalLaboralesCtta(string RUT, string USUARIO, string DIVISION, int LOTE)
        {
            try
            {
                return this.BL_WorkersLocal.BloquearWorkersLocalLaboralesCtta(RUT, USUARIO, DIVISION, LOTE);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersLocalPasesFuncionario_Ctta(WorkersLocal WorkersLocal)
        {
            try
            {
                return this.BL_WorkersLocal.SaveWorkersLocalPasesFuncionario_Ctta(WorkersLocal);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
