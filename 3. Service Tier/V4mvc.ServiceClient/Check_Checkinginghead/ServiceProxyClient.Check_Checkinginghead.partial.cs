using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklist_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeControlesChecklist_ChecklistCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklistDetalle_ChecklistCtta(Check_Checkinginghead request)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeControlesChecklistDetalle_ChecklistCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculo_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeChecklistTestVehiculo_ChecklistCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculoDetalle_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeChecklistTestVehiculoDetalle_ChecklistCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Check_Checkinginghead Get_Check_Checkinginghead_InformeChecklistTestVehiculoHead_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeChecklistTestVehiculoHead_ChecklistCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestFatigaSomnolencia_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeChecklistTestFatigaSomnolencia_ChecklistCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistPorPeriodo_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.Get_Check_Checkinginghead_InformeChecklistPorPeriodo_ChecklistCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> GetListadoEncuestasCovidCtta(ref Check_Checkinginghead Item)
        {
            try
            {
                return this.BL_Check_Checkinginghead.GetListadoEncuestasCovidCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Check_Checkinginghead GetOneListadoEncuestaCovid_Ctta(string RUT, int ID_CHECKINGHEAD, int ID_CHECK)
        {
            try
            {
                return this.BL_Check_Checkinginghead.GetOneListadoEncuestaCovid_Ctta( RUT, ID_CHECKINGHEAD, ID_CHECK);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        #endregion

    }
}
