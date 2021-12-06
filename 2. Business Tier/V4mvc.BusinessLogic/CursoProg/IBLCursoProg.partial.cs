using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCursoProg
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
