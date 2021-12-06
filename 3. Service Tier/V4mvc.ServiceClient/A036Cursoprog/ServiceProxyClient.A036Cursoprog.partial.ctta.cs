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

		#endregion

		#region [ Metodos ]
		public A036Cursoprog GetCourseCargarCursos(int code)
		{
			try
			{
				return this.BL_A036Cursoprog.GetCourseCargarCursos(code);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool GuardarCurso_CargarCuso(ref A036Cursoprog curso)
		{
			try
			{
				return this.BL_A036Cursoprog.GuardarCurso_CargarCuso(ref curso);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarOrador_CargarCurso(A036Cursoprog curso)
		{
			try
			{
				return this.BL_A036Cursoprog.ActualizarOrador_CargarCurso(curso);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
