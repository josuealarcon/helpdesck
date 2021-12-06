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
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		A036Cursoprog GetCourseCargarCursos(int code);
		bool GuardarCurso_CargarCuso(ref A036Cursoprog curso);
		bool ActualizarOrador_CargarCurso(A036Cursoprog curso);
		#endregion

	}
}
