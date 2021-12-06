using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]
        ObservableCollection<CursoProg> GetAllCursosProgCtta();
        ObservableCollection<CursoProg> GetListCargarCursosCtta(CursoProg model);
        #endregion

        #region [ Informes ]
        ObservableCollection<CursoProg> GetCursoProg_Grid_CharlasyReservas_InformeFuncionariosCtta(CursoProg request);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
