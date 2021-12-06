
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
		public ObservableCollection<Poliza_Salud> GetAllPolizaSalud_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Poliza_Salud.GetAllPolizaSalud_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Salud GetOnePolizaSalud_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_Salud.GetOnePolizaSalud_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Salud GetOnePolizaSalud_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_Salud.GetOnePolizaSalud_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Salud GetOnePolizaSalud_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_Salud.GetOnePolizaSalud_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SavePolizaSalud_ControlLaboralCtta(ref Archivos archivo, Poliza_Salud model, out int RET_CODE)
        {
            try
            {
                return this.BL_Poliza_Salud.SavePolizaSalud_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaSaludDispFile_ControlLaboralCtta(ref Poliza_Salud modelo)
        {
            try
            {
                return this.BL_Poliza_Salud.DelPolizaSaludDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaSalud_ControlLaboralCtta(ref Poliza_Salud modelo)
        {
            try
            {
                return this.BL_Poliza_Salud.DelPolizaSalud_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	