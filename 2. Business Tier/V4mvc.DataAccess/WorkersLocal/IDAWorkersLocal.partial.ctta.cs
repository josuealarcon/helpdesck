using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkersLocal
	{

        #region [ Consultas ]

        ObservableCollection<WorkersLocal> GetWorkersLocalLaborales(String RUT, String EMPRESA);
        ObservableCollection<WorkersLocal> GetWorkersLocalEnterprise(String EMPRESA);
        ObservableCollection<WorkersLocal> GetWorkersLocalDocPendientesSelect(String EMPRESA);
        ObservableCollection<WorkersLocal> GetWorkersLocalSelectB(String EMPRESA, String DIVCOD);
        WorkersLocal GetWorkersLocalSelectC(String EMPRESA,  String DIVCOD, String RUT);

        ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumen_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen);


        ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumenOST_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen);

        DataSet GetAllWorkersLocal_IFechaEmpDivision_Informes(ref WorkersLocal parametros);

        DataSet GetAllWorkersLocal_IFechaFuncDivision_Informes(ref WorkersLocal parametros);

        DataSet GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref WorkersLocal parametros);


        WorkersLocal GetWorkersLocalSelect_Ctta(String EMPRESA, String DIVCOD, String RUT);
        #endregion
        #region [ Informes ]
        ObservableCollection<WorkersLocal> GetWorkers_GridEmpresas_FichaRut_InformeConsultaRapidaCtta(WorkersLocal Item);
        #endregion
        #region [ Metodos ]

        bool SaveWorkersLocalLaboralesCtta(string RUT, string EMPRESA, string DIVISION);

        bool BloquearWorkersLocalLaboralesCtta(string RUT, string USUARIO, string DIVISION, int LOTE);
        bool SaveWorkersLocalPasesFuncionario_Ctta(WorkersLocal WorkersLocal);
        #endregion

        #region [ func_getdatos V3 ]

        WorkersLocal GetWorkersLocalSelectByRut(string RUT, string DIVISION);

        #endregion

    }
}
