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
		public string getFechaWLocal(string RUT, int ID_DOC_FEC, string EMPRESA)
        {
			try
			{
				return this.Repository.getFechaWLocal(RUT, ID_DOC_FEC, EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool setFechaWLocal(string RUT, int ID_DOC_FEC, string DIV, string EMPRESA, string FECHA, string USUARIO)
        {
			try
			{
				return this.Repository.setFechaWLocal(RUT, ID_DOC_FEC, DIV, EMPRESA, FECHA, USUARIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool setFechaEmpresa(int ID_DOC_FEC, string EMPRESA, string FECHA)
        {
			try
			{
				return this.Repository.setFechaEmpresa(ID_DOC_FEC, EMPRESA, FECHA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
