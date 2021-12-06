
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
		public ObservableCollection<A056_Form30> GetAllFormF30_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_A056_Form30.GetAllFormF30_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                return this.BL_A056_Form30.GetOneFormF30_ControlLaboralCtta(ID_DOC, EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_v2_ControlLaboralCtta(int ID_CERTIFICADO)
        {
            try
            {
                return this.BL_A056_Form30.GetOneFormF30_v2_ControlLaboralCtta(ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(Guid ID)
        {
            try
            {
                return this.BL_A056_Form30.GetOneFormF30_v3_ControlLaboralCtta(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int CERTIFICADO_ID)
        {
            try
            {
                return this.BL_A056_Form30.GetOneFormF30_v3_ControlLaboralCtta(ID_DOC, EMPRESA, CERTIFICADO_ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveFormF30_ControlLaboralCtta(ref Archivos archivo, A056_Form30 model, out int RET_CODE)
        {
            try
            {
                return this.BL_A056_Form30.SaveFormF30_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF30DispFile_ControlLaboralCtta(ref A056_Form30 modelo)
        {
            try
            {
                return this.BL_A056_Form30.DelFormF30DispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF30_ControlLaboralCtta(ref A056_Form30 modelo)
        {
            try
            {
                return this.BL_A056_Form30.DelFormF30_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	