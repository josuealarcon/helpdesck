using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLA036_CursoProg_Docs
	{

		#region [ Consultas ]

		public A036_CursoProg_Docs GetA036CursoProgDocsCodigoCtta(int CODIGO)
		{
			try
			{
				return this.Repository.GetA036CursoProgDocsCodigoCtta(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
