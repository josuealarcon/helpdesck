using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.DataAccess
{
    public partial interface IDACheck_Checkinginghead
    {

        #region [ Consultas ]
        ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklist_ChecklistCtta(Check_Checkinginghead Item);
        ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklistDetalle_ChecklistCtta(Check_Checkinginghead Item);
        ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculo_ChecklistCtta(Check_Checkinginghead Item);
        ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculoDetalle_ChecklistCtta(Check_Checkinginghead Item);
        Check_Checkinginghead Get_Check_Checkinginghead_InformeChecklistTestVehiculoHead_ChecklistCtta(Check_Checkinginghead Item);
        ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestFatigaSomnolencia_ChecklistCtta(Check_Checkinginghead Item);
        ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistPorPeriodo_ChecklistCtta(Check_Checkinginghead Item);
        ObservableCollection<Check_Checkinginghead> GetListadoEncuestasCovidCtta(ref Check_Checkinginghead Item);
        Check_Checkinginghead GetOneListadoEncuestaCovid_Ctta(string RUT, int ID_CHECKINGHEAD, int ID_CHECK);

        #endregion

        #region [ Metodos ]
        #endregion
    }
}
