
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
		public ObservableCollection<Poliza_Muerte> GetAllPolizaMuerteAcc_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Poliza_Muerte.GetAllPolizaMuerteAcc_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Muerte GetOnePolizaMuerteAcc_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_Muerte.GetOnePolizaMuerteAcc_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Muerte GetOnePolizaMuerteAcc_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_Muerte.GetOnePolizaMuerteAcc_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Muerte GetOnePolizaMuerteAcc_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_Muerte.GetOnePolizaMuerteAcc_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SavePolizaMuerteAcc_ControlLaboralCtta(ref Archivos archivo, Poliza_Muerte model, out int RET_CODE)
        {
            try
            {
                return this.BL_Poliza_Muerte.SavePolizaMuerteAcc_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteAccDispFile_ControlLaboralCtta(ref Poliza_Muerte modelo)
        {
            try
            {
                return this.BL_Poliza_Muerte.DelPolizaMuerteAccDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteAcc_ControlLaboralCtta(ref Poliza_Muerte modelo)
        {
            try
            {
                return this.BL_Poliza_Muerte.DelPolizaMuerteAcc_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	