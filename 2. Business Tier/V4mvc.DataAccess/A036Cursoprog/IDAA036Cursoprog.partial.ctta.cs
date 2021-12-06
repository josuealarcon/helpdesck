using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAA036Cursoprog
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
