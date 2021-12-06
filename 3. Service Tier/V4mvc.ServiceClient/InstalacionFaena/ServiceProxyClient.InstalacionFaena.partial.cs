
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
		public InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST)
        {
            try
            {
                return this.BL_InstalacionFaena.GetOneInstFaena_ContratOSTCtta(NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL)
        {
            try
            {
                return this.BL_InstalacionFaena.GetOneInstFaena_ContratOSTCtta(NROOST, IDEMPRESA, MADRE, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	