
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
		public ObservableCollection<A056_Form30_1> GetAllF301_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_A056_Form30_1.GetAllF301_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                return this.BL_A056_Form30_1.GetOneFormF301_ControlLaboralCtta(ID_DOC, EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v2_ControlLaboralCtta(int ID_CERTIFICADO)
        {
            try
            {
                return this.BL_A056_Form30_1.GetOneFormF301_v2_ControlLaboralCtta(ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(Guid ID)
        {
            try
            {
                return this.BL_A056_Form30_1.GetOneFormF301_v3_ControlLaboralCtta(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                return this.BL_A056_Form30_1.GetOneFormF301_v3_ControlLaboralCtta(ID_DOC, EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v4_ControlLaboralCtta(string PERIODO, string EMPRESA)
        {
            try
            {
                return this.BL_A056_Form30_1.GetOneFormF301_v4_ControlLaboralCtta(PERIODO, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public A056_Form30_1 GetOneFormF301_v5_ControlLaboralCtta(string PERIODO, string EMPRESA)
        {
            try
            {
                return this.BL_A056_Form30_1.GetOneFormF301_v5_ControlLaboralCtta(PERIODO, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SaveFormF301_ControlLaboralCtta(ref Archivos archivo, A056_Form30_1 model, out int RET_CODE)
        {
            try
            {
                return this.BL_A056_Form30_1.SaveFormF301_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF301_ControlLaboralCtta(ref A056_Form30_1 modelo)
        {
            try
            {
                return this.BL_A056_Form30_1.DelFormF301_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF301DispFile_ControlLaboralCtta(ref A056_Form30_1 modelo)
        {
            try
            {
                return this.BL_A056_Form30_1.DelFormF301DispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	