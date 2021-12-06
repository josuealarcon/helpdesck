
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
		public ObservableCollection<Remuneraciones_Propio> GetAllRemuneracionesPropio_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Remuneraciones_Propio.GetAllRemuneracionesPropio_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Remuneraciones_Propio GetOneRemPropio_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return this.BL_Remuneraciones_Propio.GetOneRemPropio_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Remuneraciones_Propio GetOneRemPropio_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return this.BL_Remuneraciones_Propio.GetOneRemPropio_v2_ControlLaboralCtta(EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Remuneraciones_Propio GetOneRemPropio_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return this.BL_Remuneraciones_Propio.GetOneRemPropio_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SaveRemPropio_ControlLaboralCtta(ref Archivos archivo, Remuneraciones_Propio model, out int RET_CODE)
        {
            try
            {
                return this.BL_Remuneraciones_Propio.SaveRemPropio_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelRemPropio_ControlLaboralCtta(ref Remuneraciones_Propio modelo)
        {
            try
            {
                return this.BL_Remuneraciones_Propio.DelRemPropio_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelRemuneracionPropioDispFile_ControlLaboralCtta(ref Remuneraciones_Propio modelo) {
            try
            {
                return this.BL_Remuneraciones_Propio.DelRemuneracionPropioDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	