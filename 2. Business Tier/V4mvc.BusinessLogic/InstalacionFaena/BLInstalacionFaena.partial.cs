
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLInstalacionFaena
    {
        #region [ Consultas ]
        public InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST)
		{
			try
			{
				return this.Repository.GetOneInstFaena_ContratOSTCtta(NROOST);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL)
		{
			try
			{
				return this.Repository.GetOneInstFaena_ContratOSTCtta(NROOST, IDEMPRESA, MADRE, NIVEL);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
	