using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCheck_Checkinginghead
    {

        #region [ Consultas ]
        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklist_ChecklistCtta(Check_Checkinginghead request)
        {
            try
            {
                var items = Repository.Get_Check_Checkinginghead_InformeControlesChecklist_ChecklistCtta(request);
                foreach (var item in items)
                {
                    item.FECHA_LETRA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
                    item.EMPRESA = item.EMPRESA_FORMATO + " - " + request.ACRONIMO;
                }
                return items;

            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklistDetalle_ChecklistCtta(Check_Checkinginghead request)
        {
            try
            {
                return Repository.Get_Check_Checkinginghead_InformeControlesChecklistDetalle_ChecklistCtta(request);

            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculo_ChecklistCtta(Check_Checkinginghead request)
        {
            try
            {
                var items = Repository.Get_Check_Checkinginghead_InformeChecklistTestVehiculo_ChecklistCtta(request);
                foreach (var item in items)
                {
                    item.FECHA_LETRA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
                    item.EMPRESA = item.EMPRESA_FORMATO + " - " + request.ACRONIMO;
                }
                return items;

            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculoDetalle_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return Repository.Get_Check_Checkinginghead_InformeChecklistTestVehiculoDetalle_ChecklistCtta(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }

        public Check_Checkinginghead Get_Check_Checkinginghead_InformeChecklistTestVehiculoHead_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                return Repository.Get_Check_Checkinginghead_InformeChecklistTestVehiculoHead_ChecklistCtta(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestFatigaSomnolencia_ChecklistCtta(Check_Checkinginghead request)
        {
            try
            {
                var items = Repository.Get_Check_Checkinginghead_InformeChecklistTestFatigaSomnolencia_ChecklistCtta(request);
                foreach (var item in items)
                {
                    item.FECHA_LETRA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
                    item.EMPRESA = item.EMPRESA_FORMATO + " - " + request.ACRONIMO;
                }
                return items;

            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistPorPeriodo_ChecklistCtta(Check_Checkinginghead request)
        {
            try
            {
                var items = Repository.Get_Check_Checkinginghead_InformeChecklistPorPeriodo_ChecklistCtta(request);
                foreach (var item in items)
                {
                    var cumple = item.PERIODO.Substring(6, 2);
                    item.FECHA = item.PERIODO.Substring(0, 6);
                    item.ESTADO = item.PERIODO.Substring(6, 2);
                    item.PERIODO = Utils.Fec_User(item.PERIODO.Substring(0, 6), Utils.Formato_Fecha.GuionMesLetras);
                    if (cumple.ToString() == "SI")
                        item.PERIODO = item.PERIODO + "-Cumple";
                    else
                        item.PERIODO = item.PERIODO + "-NoCumple";
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> GetListadoEncuestasCovidCtta(ref Check_Checkinginghead Item)
        {
            try
            {
                var response = Repository.GetListadoEncuestasCovidCtta(ref Item);
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Check_Checkinginghead GetOneListadoEncuestaCovid_Ctta(string RUT, int ID_CHECKINGHEAD, int ID_CHECK)
        {
            try
            {
                return this.Repository.GetOneListadoEncuestaCovid_Ctta(RUT, ID_CHECKINGHEAD, ID_CHECK);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
