using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLA036Cursoprog
	{
		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		public A036Cursoprog GetCourseCargarCursos(int code)
		{
			try
			{
				return this.Repository.GetCourseCargarCursos(code);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool GuardarCurso_CargarCuso(ref A036Cursoprog curso)
		{
			try
			{
				return this.Repository.GuardarCurso_CargarCuso(ref curso);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarOrador_CargarCurso(A036Cursoprog curso)
		{
			try
			{
				return this.Repository.ActualizarOrador_CargarCurso(curso);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
