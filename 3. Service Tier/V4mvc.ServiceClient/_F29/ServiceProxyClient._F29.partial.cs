
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
		public ObservableCollection<_F29> GetAllF29_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL__F29.GetAllF29_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public _F29 GetOneFormF29_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL__F29.GetOneFormF29_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public _F29 GetOneFormF29_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL__F29.GetOneFormF29_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public _F29 GetOneFormF29_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL__F29.GetOneFormF29_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveFormF29_ControlLaboralCtta(ref Archivos archivo, _F29 model, out int RET_CODE)
        {
            try
            {
                return this.BL__F29.SaveFormF29_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF29DispFile_ControlLaboralCtta(ref _F29 modelo)
        {
            try
            {
                return this.BL__F29.DelFormF29DispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF29_ControlLaboralCtta(ref _F29 modelo)
        {
            try
            {
                return this.BL__F29.DelFormF29_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	