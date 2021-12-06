using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Fec_Workers
	{

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		public bool SaveFechasWorkersLocal_Mdte(string RUT, int ID_DOC_FEC, string DIVISION, string EMPRESA, string FECHA, string USUARIO)
        {
			try
			{
				return this.Repository.SaveFechasWorkersLocal_Mdte(RUT, ID_DOC_FEC, DIVISION, EMPRESA, FECHA, USUARIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}


		#endregion

	}
}
