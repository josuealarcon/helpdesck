using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]
        public ObservableCollection<OST> GetOSTsSearcherCtta(ref OST model)
        {
            try
            {
                return this.BL_OST.GetOSTsSearcherCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<OST> GetAllOST_PasesCtta(string IDEMPRESA, string DIVISION, out string OST, out int CUENTA_CONTRATOS, out string FEC_INICIO, out string FEC_TERM)
        {
            try
            {
                return this.BL_OST.GetAllOST_PasesCtta(IDEMPRESA, DIVISION, out OST, out CUENTA_CONTRATOS, out FEC_INICIO, out FEC_TERM);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<OST> GetAllOST_ControlLaboralCtta(string IDEMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_OST.GetAllOST_ControlLaboralCtta(IDEMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<OST> GetAllOST_v2_ControlLaboralCtta(string IDEMPRESA, string DIVISION)
        {
            try
            {
                return this.BL_OST.GetAllOST_v2_ControlLaboralCtta(IDEMPRESA, DIVISION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public OST GetOneOST_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL)
        {
            try
            {
                return this.BL_OST.GetOneOST_ContratOSTCtta(NROOST, IDEMPRESA, MADRE, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveOST_ContratOSTCtta(Archivos archivo, int index, string NROOST)
        {
            try
            {
                return this.BL_OST.SaveOST_ContratOSTCtta(archivo, index, NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
