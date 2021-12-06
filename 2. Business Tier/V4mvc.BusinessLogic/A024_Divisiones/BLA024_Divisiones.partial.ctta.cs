
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLA024_Divisiones
    {
        #region [ Consultas ]
        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllA024Divisiones_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Informes ]
        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                var response = Repository.GetAllA024Divisiones_InformeConsultaRapidaCtta(request);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.EMPRESA = item.EMPRESA_FORMATO + " " + IDAEnterprise_Repository.GetOne(item.EMPRESA).ACRONIMO;
                    }
                }
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<A024_Divisiones> GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                return Repository.GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<A024_Divisiones> GetA024Divisiones_HistoricoBloqueoVehiculos_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                return Repository.GetA024Divisiones_HistoricoBloqueoVehiculos_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        #endregion
        #region [ Metodos ]

        #endregion
    }
}
	