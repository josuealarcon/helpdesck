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
		public bool SaveDisputaVehiculo(ref Docs_Disputa_Trans Item)
		{
			try
			{
				return this.BL_Docs_Disputa_Trans.SaveDisputaVehiculo(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
        public Docs_Disputa_Trans GetOneDocsDisputaTrans_Ctta(string PATENTE, int ID_DOC, Guid? ID, string IDEMPRESA, string USUARIO)
        {
            try
            {
                return this.BL_Docs_Disputa_Trans.GetOneDocsDisputaTrans_Ctta(PATENTE,ID_DOC,ID, IDEMPRESA,USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
