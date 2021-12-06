
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
		public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_A024_Divisiones.GetAllA024Divisiones_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_Ctta()
        {
            try
            {
                return this.BL_A024_Divisiones.GetAllA024Divisiones_Ctta();
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
                return this.BL_A024_Divisiones.GetAllA024Divisiones_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<A024_Divisiones> GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                return this.BL_A024_Divisiones.GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<A024_Divisiones> GetA024Divisiones_HistoricoBloqueoVehiculos_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                return this.BL_A024_Divisiones.GetA024Divisiones_HistoricoBloqueoVehiculos_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
       
        #endregion
        #region [ Metodos ]

        #endregion
    }
}
	