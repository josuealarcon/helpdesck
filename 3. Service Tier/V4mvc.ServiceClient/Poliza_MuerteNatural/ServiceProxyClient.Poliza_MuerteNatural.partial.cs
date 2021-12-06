
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
		public ObservableCollection<Poliza_MuerteNatural> GetAllPolizaMuerteNatural_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.GetAllPolizaMuerteNatural_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_MuerteNatural GetOnePolizaMuerteNat_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.GetOnePolizaMuerteNat_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_MuerteNatural GetOnePolizaMuerteNat_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.GetOnePolizaMuerteNat_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_MuerteNatural GetOnePolizaMuerteNat_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.GetOnePolizaMuerteNat_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SavePolizaMuerteNat_ControlLaboralCtta(ref Archivos archivo, Poliza_MuerteNatural model, out int RET_CODE)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.SavePolizaMuerteNat_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteNatDispFile_ControlLaboralCtta(ref Poliza_MuerteNatural modelo)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.DelPolizaMuerteNatDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteNat_ControlLaboralCtta(ref Poliza_MuerteNatural modelo)
        {
            try
            {
                return this.BL_Poliza_MuerteNatural.DelPolizaMuerteNat_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	