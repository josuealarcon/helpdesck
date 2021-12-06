
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
		public ObservableCollection<Comprobante_Sueldo> GetAllComprobanteSueldo_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.GetAllComprobanteSueldo_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Comprobante_Sueldo GetOneComprobanteSueldo_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.GetOneComprobanteSueldo_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Comprobante_Sueldo GetOneComprobanteSueldo_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.GetOneComprobanteSueldo_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Comprobante_Sueldo GetOneComprobanteSueldo_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.GetOneComprobanteSueldo_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveComprobanteSueldo_ControlLaboralCtta(ref Archivos archivo, Comprobante_Sueldo model, out int RET_CODE)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.SaveComprobanteSueldo_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelComprobanteSueldoDispFile_ControlLaboralCtta(ref Comprobante_Sueldo modelo)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.DelComprobanteSueldoDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelComprobanteSueldo_ControlLaboralCtta(ref Comprobante_Sueldo modelo)
        {
            try
            {
                return this.BL_Comprobante_Sueldo.DelComprobanteSueldo_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	